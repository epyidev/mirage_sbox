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
	private const string AmmoMetaKey = "ammo";

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

		// Snapshot the live magazine count of any held carryable into the
		// slot metadata BEFORE we touch the inventory. This is what makes
		// the clip survive a hotbar swap: the carryable is about to be
		// destroyed (or simply switched away from) and once it is gone we
		// have no way to read its ClipContents back.
		PersistActiveAmmo( player, inv, legacy );

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

		// Restore the magazine count from the slot's saved ammo metadata
		// so the operator picks up exactly where they left off, no matter
		// how many slots they cycled through in between.
		if ( target.IsValid() && slot is not null )
		{
			ApplyAmmoFromMetadata( target, slot );
		}

		SwitchActive( legacy, target );
	}

	/// <summary>
	/// Host-only. Sweep every active carryable in <paramref name="legacy"/>
	/// and write its current <see cref="BaseWeapon.ClipContents"/> back to
	/// the matching Mirage slot metadata. Call this before any inventory
	/// mutation that could move, swap or remove a weapon slot, and before
	/// any drop reads the slot metadata to spawn a world pickup.
	/// </summary>
	public static void PersistActiveAmmo( Player player, MirageInventory inv )
	{
		if ( !Networking.IsHost ) return;
		if ( !player.IsValid() || inv is null ) return;
		var legacy = player.GetComponent<PlayerInventory>();
		if ( legacy is null ) return;
		PersistActiveAmmo( player, inv, legacy );
	}

	private static void PersistActiveAmmo( Player player, MirageInventory inv, PlayerInventory legacy )
	{
		foreach ( var carryable in legacy.Weapons )
		{
			if ( !carryable.IsValid() ) continue;
			if ( carryable is not BaseWeapon weapon ) continue;
			if ( !weapon.UsesClips ) continue;

			var prefabPath = carryable.GameObject?.PrefabInstanceSource;
			if ( string.IsNullOrEmpty( prefabPath ) ) continue;

			// Find the slot whose item points at this weapon prefab. There
			// is at most one (weapons are MaxStack = 1), so a linear scan
			// is fine.
			for ( int i = 0; i < MirageInventory.SlotCount; i++ )
			{
				var s = inv.Slot( i );
				if ( s is null || s.IsEmpty ) continue;
				var def = s.Item;
				if ( def is null || string.IsNullOrEmpty( def.WeaponPrefab ) ) continue;
				if ( !string.Equals( def.WeaponPrefab, prefabPath, StringComparison.OrdinalIgnoreCase ) ) continue;

				s.Metadata ??= new Dictionary<string, string>();
				s.Metadata[AmmoMetaKey] = weapon.ClipContents.ToString();
				break;
			}
		}
	}

	private static void ApplyAmmoFromMetadata( BaseCarryable carryable, MirageInventorySlot slot )
	{
		if ( carryable is not BaseWeapon weapon ) return;
		if ( !weapon.UsesClips ) return;
		if ( slot.Metadata is null ) return;
		if ( !slot.Metadata.TryGetValue( AmmoMetaKey, out var raw ) ) return;
		if ( !int.TryParse( raw, out var stored ) ) return;

		// Clamp to the weapon's clip max so a stale row from before a
		// balance change cannot exceed the new size. The carryable is
		// player-owned, so we cannot write ClipContents directly from
		// the host: route the new value through a host-to-owner RPC and
		// let the owning client apply it. The synced value then echoes
		// back to the host on the next tick.
		var clamped = Math.Clamp( stored, 0, weapon.ClipMaxSize );
		weapon.RpcMirageSetClipContents( clamped );
	}

	private static void SwitchActive( PlayerInventory legacy, BaseCarryable target )
	{
		if ( legacy is null ) return;
		if ( legacy.ActiveWeapon == target ) return;
		legacy.SwitchWeapon( target, allowHolster: true );
	}
}
