/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Mirage data-driven inventory. Lives as a Component on the player and is
/// host-authoritative: every mutation goes through the host, then the host
/// pushes the new snapshot to the owning client through a filtered RPC.
/// Other clients never see another player's inventory contents.
///
/// 25 slots, 5 columns x 5 rows. The first row (slots 0..4) is also the
/// always-visible hotbar.
/// </summary>
public sealed class MirageInventory : Component
{
	public const int SlotCount = 25;
	public const int HotbarColumns = 5;

	/// <summary>Carry capacity in grams. 24 kg total.</summary>
	public const int MaxWeightGrams = 24_000;

	private MirageInventorySlot[] _slots;

	/// <summary>
	/// Currently selected hotbar slot, in range
	/// [0, <see cref="HotbarColumns"/>). The first slot is selected by
	/// default and the operator can never end up with no slot in hand
	/// through the UI: pressing the same hotbar key twice keeps the slot
	/// selected, only switching to a different slot (or scrolling) moves
	/// the selection.
	/// </summary>
	[Sync( SyncFlags.FromHost ), Change] public int SelectedSlot { get; set; } = 0;

	/// <summary>
	/// Sync change callback. Bumps <see cref="Version"/> so the local UI
	/// re-renders the hotbar highlight without subscribing to engine events.
	/// </summary>
	public void OnSelectedSlotChanged( int oldValue, int newValue )
	{
		Version++;
	}

	private void EnsureSlots()
	{
		if ( _slots is not null ) return;
		_slots = new MirageInventorySlot[SlotCount];
		for ( int i = 0; i < SlotCount; i++ )
			_slots[i] = new MirageInventorySlot();
	}

	public IReadOnlyList<MirageInventorySlot> Slots
	{
		get { EnsureSlots(); return _slots; }
	}

	public MirageInventorySlot Slot( int index )
	{
		EnsureSlots();
		if ( index < 0 || index >= SlotCount ) return null;
		return _slots[index];
	}

	// ------------------------------------------------------------------
	// Host-side mutations
	// ------------------------------------------------------------------

	/// <summary>
	/// Host-only. Add <paramref name="count"/> of <paramref name="itemId"/>
	/// to the inventory, stacking onto existing slots if the item is
	/// stackable, otherwise filling empty slots.
	///
	/// Returns the number of units that could not fit.
	/// </summary>
	public int Add( string itemId, int count, IReadOnlyDictionary<string, string> metadata = null )
	{
		Assert.True( Networking.IsHost, "MirageInventory.Add must run on the host" );
		EnsureSlots();
		if ( count <= 0 ) return 0;
		var def = MirageItems.Find( itemId );
		if ( def is null ) return count;

		// Cap the request by the remaining carry capacity. Anything past it
		// stays as leftover and the caller decides what to do (drop on the
		// floor, refuse the give, leave the world pickup behind, ...).
		var requested = count;
		var allowed = count;
		if ( def.Weight > 0 )
		{
			var free = Math.Max( 0, MaxWeightGrams - CurrentWeightGrams );
			var maxByWeight = free / def.Weight;
			if ( maxByWeight < allowed ) allowed = maxByWeight;
		}
		if ( allowed <= 0 ) return requested;

		var added = 0;

		// Stack first onto existing slots that already hold this item, when
		// the metadata matches. Stacks with different metadata cannot merge,
		// since their per-instance state (durability, ammo, ...) differs.
		if ( def.Stackable )
		{
			for ( int i = 0; i < SlotCount && added < allowed; i++ )
			{
				var slot = _slots[i];
				if ( slot.IsEmpty ) continue;
				if ( !string.Equals( slot.ItemId, itemId, StringComparison.OrdinalIgnoreCase ) ) continue;
				if ( !MetadataEquals( slot.Metadata, metadata ) ) continue;
				var room = def.MaxStack - slot.Count;
				if ( room <= 0 ) continue;
				var move = Math.Min( room, allowed - added );
				slot.Count += move;
				added += move;
			}
		}

		// Then drop the rest into the first empty slot(s).
		while ( added < allowed )
		{
			var idx = FindFirstEmpty();
			if ( idx < 0 ) break;
			var batch = def.Stackable ? Math.Min( allowed - added, def.MaxStack ) : 1;
			_slots[idx].ItemId = def.Id;
			_slots[idx].Count = batch;
			_slots[idx].Metadata = SeedMetadata( def, metadata );
			added += batch;
		}

		if ( added > 0 ) BroadcastSnapshot();
		return requested - added;
	}

	/// <summary>
	/// Total weight currently held in this inventory, in grams. Recomputed on
	/// every read; the slot count is small so the cost is negligible.
	/// </summary>
	public int CurrentWeightGrams
	{
		get
		{
			EnsureSlots();
			var total = 0;
			for ( int i = 0; i < SlotCount; i++ )
			{
				var slot = _slots[i];
				if ( slot.IsEmpty ) continue;
				var def = slot.Item;
				if ( def is null ) continue;
				total += slot.Count * def.Weight;
			}
			return total;
		}
	}

	/// <summary>How much capacity (in grams) is still free.</summary>
	public int FreeWeightGrams => Math.Max( 0, MaxWeightGrams - CurrentWeightGrams );

	/// <summary>
	/// Total number of units of <paramref name="itemId"/> across every slot.
	/// Used by the weapon system to compute reserve ammo from inventory items
	/// (e.g. how many <c>ammo_9</c> the operator carries).
	/// </summary>
	public int CountById( string itemId )
	{
		if ( string.IsNullOrEmpty( itemId ) ) return 0;
		EnsureSlots();
		var total = 0;
		for ( int i = 0; i < SlotCount; i++ )
		{
			var slot = _slots[i];
			if ( slot.IsEmpty ) continue;
			if ( !string.Equals( slot.ItemId, itemId, StringComparison.OrdinalIgnoreCase ) ) continue;
			total += slot.Count;
		}
		return total;
	}

	/// <summary>
	/// Host-only. Remove up to <paramref name="count"/> units of
	/// <paramref name="itemId"/> by walking slots in order, draining each
	/// matching stack until the request is satisfied or no stack is left.
	/// Returns the number of units actually consumed.
	/// </summary>
	public int ConsumeById( string itemId, int count )
	{
		Assert.True( Networking.IsHost, "MirageInventory.ConsumeById must run on the host" );
		if ( string.IsNullOrEmpty( itemId ) || count <= 0 ) return 0;
		EnsureSlots();
		var consumed = 0;
		var changed = false;
		for ( int i = 0; i < SlotCount && consumed < count; i++ )
		{
			var slot = _slots[i];
			if ( slot.IsEmpty ) continue;
			if ( !string.Equals( slot.ItemId, itemId, StringComparison.OrdinalIgnoreCase ) ) continue;
			var take = Math.Min( slot.Count, count - consumed );
			slot.Count -= take;
			if ( slot.Count <= 0 ) slot.Clear();
			consumed += take;
			changed = true;
		}
		if ( changed ) BroadcastSnapshot();
		return consumed;
	}

	/// <summary>
	/// Host-only. Remove up to <paramref name="count"/> units from
	/// <paramref name="slotIndex"/>. Returns how many were actually removed.
	/// Empties the slot when count drops to 0.
	/// </summary>
	public int RemoveAt( int slotIndex, int count = int.MaxValue )
	{
		Assert.True( Networking.IsHost, "MirageInventory.RemoveAt must run on the host" );
		EnsureSlots();
		if ( slotIndex < 0 || slotIndex >= SlotCount ) return 0;

		var slot = _slots[slotIndex];
		if ( slot.IsEmpty ) return 0;

		var taken = Math.Min( count, slot.Count );
		slot.Count -= taken;
		if ( slot.Count <= 0 ) slot.Clear();

		BroadcastSnapshot();
		return taken;
	}

	/// <summary>
	/// Host-only. Move or merge a slot into another. If the destination is
	/// empty, the source moves there; if both hold the same item with
	/// matching metadata, the stacks merge as far as possible; otherwise
	/// the two stacks swap.
	/// </summary>
	public void Move( int from, int to )
	{
		Assert.True( Networking.IsHost, "MirageInventory.Move must run on the host" );
		EnsureSlots();
		if ( from == to ) return;
		if ( from < 0 || from >= SlotCount ) return;
		if ( to < 0 || to >= SlotCount ) return;

		var src = _slots[from];
		var dst = _slots[to];
		if ( src.IsEmpty ) return;

		if ( dst.IsEmpty )
		{
			(src.ItemId, dst.ItemId) = (dst.ItemId, src.ItemId);
			(src.Count, dst.Count) = (dst.Count, src.Count);
			(src.Metadata, dst.Metadata) = (dst.Metadata, src.Metadata);
		}
		else if ( string.Equals( src.ItemId, dst.ItemId, StringComparison.OrdinalIgnoreCase )
			&& MetadataEquals( src.Metadata, dst.Metadata ) )
		{
			var def = MirageItems.Find( src.ItemId );
			var max = def?.MaxStack ?? 1;
			var room = max - dst.Count;
			if ( room > 0 )
			{
				var move = Math.Min( room, src.Count );
				dst.Count += move;
				src.Count -= move;
				if ( src.Count <= 0 ) src.Clear();
			}
		}
		else
		{
			(src.ItemId, dst.ItemId) = (dst.ItemId, src.ItemId);
			(src.Count, dst.Count) = (dst.Count, src.Count);
			(src.Metadata, dst.Metadata) = (dst.Metadata, src.Metadata);
		}

		BroadcastSnapshot();
	}

	/// <summary>
	/// Host-only. Hydrate the inventory from the API's character detail
	/// payload, honouring the saved slot positions. Wipes any previous
	/// in-memory content first so a /relog or character switch starts from
	/// a clean board.
	/// </summary>
	public void LoadFromApi( IReadOnlyList<MirageInventoryEntry> entries )
	{
		Assert.True( Networking.IsHost, "MirageInventory.LoadFromApi must run on the host" );
		EnsureSlots();
		for ( int i = 0; i < SlotCount; i++ ) _slots[i].Clear();
		if ( entries is not null )
		{
			foreach ( var e in entries )
			{
				if ( e is null || string.IsNullOrEmpty( e.ItemId ) ) continue;
				if ( e.Slot < 0 || e.Slot >= SlotCount ) continue;
				if ( e.Quantity <= 0 ) continue;
				if ( !MirageItems.IsKnown( e.ItemId ) ) continue;
				var slot = _slots[e.Slot];
				slot.ItemId = e.ItemId;
				slot.Count = e.Quantity;
				slot.Metadata = e.Metadata is null ? new() : new Dictionary<string, string>( e.Metadata );
			}
		}
		BroadcastSnapshot();
	}

	/// <summary>Host-only. Wipe every slot. Used on character switch / relog.</summary>
	public void ClearAll()
	{
		Assert.True( Networking.IsHost, "MirageInventory.ClearAll must run on the host" );
		EnsureSlots();
		for ( int i = 0; i < SlotCount; i++ ) _slots[i].Clear();
		BroadcastSnapshot();
	}

	/// <summary>
	/// Host-only. Move <paramref name="amount"/> units from <paramref name="from"/>
	/// to <paramref name="to"/>. Backs the right-click split drag in the
	/// inventory UI. Skips when the destination is occupied with a
	/// different item or with the same item but mismatched metadata
	/// (those would lose data on the merge).
	/// </summary>
	public void SplitMove( int from, int to, int amount )
	{
		Assert.True( Networking.IsHost, "MirageInventory.SplitMove must run on the host" );
		EnsureSlots();
		if ( amount <= 0 ) return;
		if ( from == to ) return;
		if ( from < 0 || from >= SlotCount ) return;
		if ( to < 0 || to >= SlotCount ) return;

		var src = _slots[from];
		if ( src.IsEmpty ) return;
		if ( amount >= src.Count )
		{
			// Asking to move the whole stack: defer to the regular move
			// path which handles swap / merge cleanly.
			Move( from, to );
			return;
		}

		var def = src.Item;
		var dst = _slots[to];

		if ( dst.IsEmpty )
		{
			dst.ItemId = src.ItemId;
			dst.Count = amount;
			dst.Metadata = src.Metadata is null ? new() : new Dictionary<string, string>( src.Metadata );
			src.Count -= amount;
			BroadcastSnapshot();
			return;
		}

		if ( !string.Equals( dst.ItemId, src.ItemId, StringComparison.OrdinalIgnoreCase ) )
			return;
		if ( !MetadataEquals( src.Metadata, dst.Metadata ) )
			return;

		var max = def?.MaxStack ?? 1;
		var room = max - dst.Count;
		if ( room <= 0 ) return;

		var move = Math.Min( amount, room );
		dst.Count += move;
		src.Count -= move;
		if ( src.Count <= 0 ) src.Clear();
		BroadcastSnapshot();
	}

	/// <summary>Host-only. Replace the whole inventory state in one go.</summary>
	public void Replace( IEnumerable<MirageInventorySlot> snapshot )
	{
		Assert.True( Networking.IsHost, "MirageInventory.Replace must run on the host" );
		EnsureSlots();
		for ( int i = 0; i < SlotCount; i++ ) _slots[i].Clear();
		if ( snapshot is null ) { BroadcastSnapshot(); return; }
		foreach ( var s in snapshot )
		{
			if ( s is null ) continue;
			if ( string.IsNullOrEmpty( s.ItemId ) ) continue;
			// Honour the slot index encoded by the snapshot when valid; the
			// Api's character_inventory rows already carry one.
			// The snapshot iterates linearly so we just append into the next
			// free slot, callers that need positional placement should call
			// SetSlot directly.
			var idx = FindFirstEmpty();
			if ( idx < 0 ) break;
			_slots[idx].ItemId = s.ItemId;
			_slots[idx].Count = s.Count;
			_slots[idx].Metadata = s.Metadata is null ? new() : new Dictionary<string, string>( s.Metadata );
		}
		BroadcastSnapshot();
	}

	/// <summary>Host-only. Set a slot's content directly. Pass null itemId to clear.</summary>
	public void SetSlot( int index, string itemId, int count, IReadOnlyDictionary<string, string> metadata = null )
	{
		Assert.True( Networking.IsHost, "MirageInventory.SetSlot must run on the host" );
		EnsureSlots();
		if ( index < 0 || index >= SlotCount ) return;
		var slot = _slots[index];
		if ( string.IsNullOrEmpty( itemId ) || count <= 0 )
		{
			slot.Clear();
		}
		else
		{
			var def = MirageItems.Find( itemId );
			if ( def is null ) return;
			slot.ItemId = def.Id;
			slot.Count = count;
			slot.Metadata = SeedMetadata( def, metadata );
		}
		BroadcastSnapshot();
	}

	/// <summary>Host-only. Tell every client what hotbar slot is selected.</summary>
	public void SetSelectedSlot( int slotIndex )
	{
		Assert.True( Networking.IsHost, "MirageInventory.SetSelectedSlot must run on the host" );
		if ( slotIndex < 0 || slotIndex >= HotbarColumns ) return;
		if ( SelectedSlot == slotIndex ) return;
		SelectedSlot = slotIndex;
		Version++;
	}

	// ------------------------------------------------------------------
	// Snapshot delivery
	// ------------------------------------------------------------------

	/// <summary>
	/// Host-only. Send the current state to the owning client only. Other
	/// clients have no business knowing what is in this player's pockets.
	/// </summary>
	public void BroadcastSnapshot()
	{
		if ( !Networking.IsHost ) return;
		EnsureSlots();
		var owner = Network.Owner;
		if ( owner is null ) return;
		var json = Sandbox.Json.Serialize( _slots );
		using ( Rpc.FilterInclude( owner ) )
			RpcDeliverSnapshot( json );
	}

	[Rpc.Broadcast( NetFlags.HostOnly | NetFlags.Reliable )]
	private void RpcDeliverSnapshot( string json )
	{
		EnsureSlots();
		// Apply locally on the receiving (owner) client.
		MirageInventorySlot[] arr;
		try { arr = Sandbox.Json.Deserialize<MirageInventorySlot[]>( json ); }
		catch { return; }
		if ( arr is null ) return;
		for ( int i = 0; i < SlotCount; i++ )
		{
			if ( i >= arr.Length || arr[i] is null )
			{
				_slots[i].Clear();
				continue;
			}
			_slots[i].ItemId = arr[i].ItemId;
			_slots[i].Count = arr[i].Count;
			_slots[i].Metadata = arr[i].Metadata ?? new();
		}
		Version++;
	}

	/// <summary>Bumped on every snapshot delivery. UIs poll this to rebuild.</summary>
	public int Version { get; private set; }

	// ------------------------------------------------------------------
	// Helpers
	// ------------------------------------------------------------------

	private int FindFirstEmpty()
	{
		EnsureSlots();
		for ( int i = 0; i < SlotCount; i++ )
			if ( _slots[i].IsEmpty ) return i;
		return -1;
	}

	private static Dictionary<string, string> SeedMetadata( MirageItem def, IReadOnlyDictionary<string, string> overrides )
	{
		var meta = new Dictionary<string, string>();
		if ( def?.DefaultMetadata is not null )
			foreach ( var kv in def.DefaultMetadata ) meta[kv.Key] = kv.Value;
		if ( overrides is not null )
			foreach ( var kv in overrides ) meta[kv.Key] = kv.Value;
		return meta;
	}

	private static bool MetadataEquals( IReadOnlyDictionary<string, string> a, IReadOnlyDictionary<string, string> b )
	{
		var ac = a is null ? 0 : a.Count;
		var bc = b is null ? 0 : b.Count;
		if ( ac != bc ) return false;
		if ( ac == 0 ) return true;
		foreach ( var kv in a )
		{
			if ( !b.TryGetValue( kv.Key, out var other ) ) return false;
			if ( !string.Equals( kv.Value, other, StringComparison.Ordinal ) ) return false;
		}
		return true;
	}

	// ------------------------------------------------------------------
	// Convenient access for the local player
	// ------------------------------------------------------------------

	public static MirageInventory ForLocalPlayer()
	{
		var local = Player.FindLocalPlayer();
		return local?.GetComponent<MirageInventory>();
	}

	public static MirageInventory For( Player player )
	{
		return player?.GetComponent<MirageInventory>();
	}
}
