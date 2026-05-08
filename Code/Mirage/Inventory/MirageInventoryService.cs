/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Static host-side service that backs the inventory UI: every client click
/// in the hotbar or the inventory panel ends up here through an
/// <see cref="Rpc.Host"/> entry, so the host stays the single source of
/// truth for slot state.
///
/// Every entry point validates the caller, finds their <see cref="Player"/>
/// and <see cref="MirageInventory"/>, and delegates the actual mutation.
/// </summary>
public static class MirageInventoryService
{
	[Rpc.Host]
	public static void RpcSelectSlot( int slotIndex )
	{
		var (player, inv) = ResolveCallerInventory();
		if ( inv is null ) return;
		if ( slotIndex < 0 || slotIndex >= MirageInventory.HotbarColumns ) return;

		// No toggle: pressing the same hotbar key twice keeps the slot
		// selected. The operator always has exactly one hotbar slot in
		// hand, the only way to switch is to point at another one.
		inv.SetSelectedSlot( slotIndex );
		MirageInventoryEquip.ApplyEquip( player, inv );
	}

	[Rpc.Host]
	public static void RpcMoveSlot( int from, int to )
	{
		var (player, inv) = ResolveCallerInventory();
		if ( inv is null ) return;
		inv.Move( from, to );
		MirageInventoryEquip.ApplyEquip( player, inv );
	}

	[Rpc.Host]
	public static void RpcDropSlot( int slotIndex, int count )
	{
		var (player, inv) = ResolveCallerInventory();
		if ( inv is null || player is null ) return;
		if ( slotIndex < 0 || slotIndex >= MirageInventory.SlotCount ) return;

		var slot = inv.Slot( slotIndex );
		if ( slot is null || slot.IsEmpty ) return;

		// Capture every field BEFORE the slot gets cleared by RemoveAt,
		// otherwise the spawn path below would see null id / metadata.
		var item = slot.Item;
		var itemId = slot.ItemId;
		var dropCount = count <= 0 ? slot.Count : Math.Min( count, slot.Count );
		var metadataCopy = slot.Metadata is null ? new Dictionary<string, string>() : new Dictionary<string, string>( slot.Metadata );

		// Remove from inventory before spawning the world drop, so a
		// failure to spawn the drop does not also lose the item.
		inv.RemoveAt( slotIndex, dropCount );

		MirageInventoryEquip.ApplyEquip( player, inv );

		MirageDroppedItem.SpawnFromPlayer( player, item, itemId, dropCount, metadataCopy );
	}

	[Rpc.Host]
	public static void RpcRequestRefresh()
	{
		var (_, inv) = ResolveCallerInventory();
		inv?.BroadcastSnapshot();
	}

	/// <summary>
	/// Host-only entry the items browser uses for its inline "Donner" button.
	/// Re-checks the same permission as the chat <c>/give</c> command so the
	/// browser cannot bypass it.
	/// </summary>
	[Rpc.Host]
	public static void RpcGiveSelf( string itemId, int count )
	{
		var caller = Rpc.Caller;
		if ( caller is null ) return;
		if ( !PermissionsSystem.Current.Has( caller, "command.give" ) ) return;
		if ( count <= 0 ) count = 1;

		var (player, inv) = ResolveCallerInventory();
		if ( inv is null || player is null ) return;
		if ( !MirageItems.IsKnown( itemId ) ) return;

		inv.Add( itemId, count );
		MirageInventoryEquip.ApplyEquip( player, inv );
	}

	private static (Player, MirageInventory) ResolveCallerInventory()
	{
		var caller = Rpc.Caller;
		if ( caller is null ) return (null, null);
		var player = Game.ActiveScene.GetAll<Player>().FirstOrDefault( x => x.Network.Owner?.Id == caller.Id );
		if ( !player.IsValid() ) return (null, null);
		var inv = player.GetComponent<MirageInventory>();
		return (player, inv);
	}
}
