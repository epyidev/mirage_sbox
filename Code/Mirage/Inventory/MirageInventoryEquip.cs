/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Bridge between the data-driven Mirage inventory and the existing Sandbox
/// weapon system. The legacy <see cref="PlayerInventory"/> still owns the
/// runtime <see cref="BaseCarryable"/> components (animations, view models,
/// ammo state), but the data of "what is in my pockets" lives in
/// <see cref="MirageInventory"/>.
///
/// On every selection or slot change the host calls
/// <see cref="ApplyEquip(Player, MirageInventory)"/>: the carryable that
/// matches the currently selected weapon item is spawned (if absent) and
/// switched to active; non-weapon items unequip the active weapon. Items
/// whose <see cref="MirageItem.WeaponPrefab"/> is null are simply held
/// "in hand" with no Sandbox carryable backing them.
/// </summary>
public static class MirageInventoryEquip
{
	/// <summary>
	/// Host-only. Reconcile the Sandbox <see cref="PlayerInventory"/> with the
	/// Mirage inventory's currently selected slot. Call this any time a slot
	/// changes (selection, move, drop, give).
	/// </summary>
	public static void ApplyEquip( Player player, MirageInventory inv )
	{
		if ( !Networking.IsHost ) return;
		if ( !player.IsValid() || inv is null ) return;

		var legacy = player.GetComponent<PlayerInventory>();
		if ( legacy is null ) return;

		var slotIndex = inv.SelectedSlot;
		var slot = slotIndex >= 0 ? inv.Slot( slotIndex ) : null;
		var item = slot?.Item;
		var prefabPath = item?.WeaponPrefab;

		// Wipe carryables that no longer match the selection. We keep at
		// most one carryable in the legacy inventory at a time, so old
		// entries from the previous selection (or from the upstream default
		// loadout) are removed cleanly.
		foreach ( var carryable in legacy.Weapons.ToArray() )
		{
			if ( !carryable.IsValid() ) continue;
			var path = carryable.GameObject?.PrefabInstanceSource;
			if ( !string.Equals( path, prefabPath, StringComparison.OrdinalIgnoreCase ) )
			{
				carryable.GameObject.Destroy();
			}
		}

		if ( string.IsNullOrEmpty( prefabPath ) )
		{
			SwitchActive( legacy, null );
			return;
		}

		// Find or spawn the carryable for this weapon item.
		BaseCarryable target = null;
		foreach ( var carryable in legacy.Weapons )
		{
			if ( !carryable.IsValid() ) continue;
			var path = carryable.GameObject?.PrefabInstanceSource;
			if ( string.Equals( path, prefabPath, StringComparison.OrdinalIgnoreCase ) )
			{
				target = carryable;
				break;
			}
		}

		if ( target is null )
		{
			try
			{
				legacy.Pickup( prefabPath, false );
			}
			catch ( Exception ex )
			{
				Log.Warning( $"[Mirage] Failed to spawn carryable {prefabPath}: {ex.Message}" );
				return;
			}

			foreach ( var carryable in legacy.Weapons )
			{
				if ( !carryable.IsValid() ) continue;
				var path = carryable.GameObject?.PrefabInstanceSource;
				if ( string.Equals( path, prefabPath, StringComparison.OrdinalIgnoreCase ) )
				{
					target = carryable;
					break;
				}
			}
		}

		SwitchActive( legacy, target );
	}

	private static void SwitchActive( PlayerInventory legacy, BaseCarryable target )
	{
		if ( legacy is null ) return;
		if ( legacy.ActiveWeapon == target ) return;
		legacy.SwitchWeapon( target, allowHolster: true );
	}
}
