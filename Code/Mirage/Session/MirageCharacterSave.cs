/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Host-only helpers for persisting a player's active character to the
/// Mirage API. Builds the atomic snapshot (position + vitals + wallets +
/// inventory) and ships it through <see cref="MirageApiClient.SaveCharacterSnapshotAsync"/>.
/// Stateless: callers (the periodic loop, the disconnect hook, the relog
/// flow, the admin command) decide when a flush should happen.
/// </summary>
public static class MirageCharacterSave
{
	/// <summary>
	/// Snapshot every persistent piece of <paramref name="player"/>'s active
	/// character. Returns null when the player has no active character (e.g.
	/// still in limbo) - the caller should skip the flush in that case.
	/// </summary>
	public static MirageCharacterSnapshot BuildSnapshot( Player player )
	{
		Assert.True( Networking.IsHost, "MirageCharacterSave.BuildSnapshot must run on the host" );
		if ( !player.IsValid() ) return null;
		var pd = player.PlayerData;
		if ( pd is null || !pd.HasActiveCharacter ) return null;

		var snapshot = new MirageCharacterSnapshot
		{
			Vitals = new MirageVitals
			{
				Health = player.Health,
				MaxHealth = player.MaxHealth,
				Armour = player.Armour
			}
		};

		// Position only when the body is "real" (not in limbo). For a player
		// who is still in character select the last known position is
		// untouched on disk, no need to overwrite with the limbo spawn.
		if ( player.Body.IsValid() && player.Body.Enabled )
		{
			var pos = player.WorldPosition;
			float yaw = player.Controller.IsValid() ? player.Controller.EyeAngles.yaw : 0f;
			snapshot.LastPosition = new MiragePosition { X = pos.x, Y = pos.y, Z = pos.z, Yaw = yaw };
		}

		var wallet = player.GetComponent<MirageWallet>();
		if ( wallet is not null )
		{
			snapshot.Wallets = wallet.Snapshot();
		}

		var inv = player.GetComponent<MirageInventory>();
		if ( inv is not null )
		{
			snapshot.Inventory = SnapshotInventory( inv );
		}

		return snapshot;
	}

	private static List<MirageInventoryEntry> SnapshotInventory( MirageInventory inv )
	{
		var list = new List<MirageInventoryEntry>();
		for ( int i = 0; i < MirageInventory.SlotCount; i++ )
		{
			var slot = inv.Slot( i );
			if ( slot is null || slot.IsEmpty ) continue;
			list.Add( new MirageInventoryEntry
			{
				Slot = i,
				ItemId = slot.ItemId,
				Quantity = slot.Count,
				Metadata = slot.Metadata is null || slot.Metadata.Count == 0
					? null
					: new Dictionary<string, string>( slot.Metadata )
			} );
		}
		return list;
	}

	/// <summary>
	/// Flush <paramref name="player"/>'s active character to the API. Catches
	/// every exception and logs them: the gameplay loop must never throw
	/// because the backend is momentarily unavailable.
	/// </summary>
	public static async Task FlushPlayerAsync( Player player )
	{
		Assert.True( Networking.IsHost, "MirageCharacterSave.FlushPlayerAsync must run on the host" );
		if ( !player.IsValid() ) return;
		var pd = player.PlayerData;
		if ( pd is null || !pd.HasActiveCharacter ) return;

		var snapshot = BuildSnapshot( player );
		if ( snapshot is null ) return;

		try
		{
			await MirageApiClient.SaveCharacterSnapshotAsync( pd.SteamId, pd.ActiveCharacterId, snapshot );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] Failed to save character {pd.ActiveCharacterId}: {ex.Message}" );
		}
	}

	/// <summary>
	/// Flush every connected player whose character is active. Returns the
	/// number of save attempts launched so admin commands can echo a count
	/// back to the operator.
	/// </summary>
	public static async Task<int> FlushAllAsync()
	{
		Assert.True( Networking.IsHost, "MirageCharacterSave.FlushAllAsync must run on the host" );

		var targets = Game.ActiveScene.GetAll<Player>()
			.Where( p => p.IsValid() && p.PlayerData is not null && p.PlayerData.HasActiveCharacter )
			.ToList();

		if ( targets.Count == 0 ) return 0;

		var tasks = new List<Task>( targets.Count );
		foreach ( var p in targets )
		{
			tasks.Add( FlushPlayerAsync( p ) );
		}
		foreach ( var t in tasks ) await t;
		return targets.Count;
	}
}
