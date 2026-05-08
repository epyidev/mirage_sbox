/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Bridge between the upstream Sandbox <see cref="BaseWeapon"/> ammo system
/// and the Mirage data-driven inventory.
///
/// The clip count stays where the upstream code expects it (<see cref="BaseWeapon.ClipContents"/>),
/// but the "reserve ammo" no longer lives on the weapon or on the legacy
/// <c>AmmoInventory</c> shared pool: it is the count of the matching ammo
/// item carried in the Mirage inventory. Reloading drains those item stacks
/// instead of incrementing/decrementing a separate counter.
///
/// Resolution rule: the active hotbar slot must hold a <see cref="MirageItem"/>
/// whose <see cref="MirageItem.WeaponPrefab"/> matches the weapon's prefab
/// path AND whose <see cref="MirageItem.WeaponAmmoType"/> is set to a known
/// ammo item id. Anything else falls back to the upstream behaviour, which
/// keeps non-Mirage weapons (admin physgun/toolgun, future modded items)
/// working unchanged.
/// </summary>
public static class MirageWeaponBridge
{
	/// <summary>
	/// Resolve the ammo item id (e.g. <c>ammo_9</c>) for the weapon currently
	/// held by <paramref name="weapon"/>'s owner. Returns null when the
	/// active slot does not match this weapon prefab, or when the matching
	/// item has no ammo type, or when the weapon has no owner at all.
	/// </summary>
	public static string ResolveAmmoTypeId( BaseWeapon weapon )
	{
		if ( !weapon.IsValid() ) return null;
		var player = weapon.Owner;
		if ( !player.IsValid() ) return null;
		var inv = player.GetComponent<MirageInventory>();
		if ( inv is null ) return null;
		var slot = inv.Slot( inv.SelectedSlot );
		if ( slot is null || slot.IsEmpty ) return null;
		var item = slot.Item;
		if ( item is null || string.IsNullOrEmpty( item.WeaponAmmoType ) ) return null;

		// Make sure the active slot actually points at THIS weapon prefab,
		// not at some other equipped weapon. Without this check a Glock
		// equipped via PlayerInventory would happily pull from any ammo
		// item the operator carries, which would defeat the per-caliber
		// reserve we just defined.
		var prefab = weapon.GameObject?.PrefabInstanceSource;
		if ( !string.IsNullOrEmpty( prefab ) && !string.IsNullOrEmpty( item.WeaponPrefab )
			&& !string.Equals( prefab, item.WeaponPrefab, StringComparison.OrdinalIgnoreCase ) )
			return null;

		return item.WeaponAmmoType;
	}

	/// <summary>
	/// Read the reserve ammo for <paramref name="weapon"/> from the operator's
	/// Mirage inventory. Returns true and writes the count to <paramref name="reserve"/>
	/// when the bridge applies; returns false to fall back to upstream.
	/// </summary>
	public static bool TryGetReserve( BaseWeapon weapon, out int reserve )
	{
		reserve = 0;
		var ammoId = ResolveAmmoTypeId( weapon );
		if ( ammoId is null ) return false;
		var inv = weapon.Owner?.GetComponent<MirageInventory>();
		if ( inv is null ) return false;
		reserve = inv.CountById( ammoId );
		return true;
	}

	/// <summary>
	/// Owner-side entry point used by <see cref="BaseWeapon.ReloadAsync"/>.
	/// Dispatches a host RPC that consumes <paramref name="amount"/> units of
	/// the matching ammo item. Returns true when the bridge owns the
	/// consumption (regardless of how many units were actually drained, the
	/// caller is told to consider it handled). Returns false to let upstream
	/// run (no Mirage inventory or no ammo type wired).
	/// </summary>
	public static bool TryConsumeReserve( BaseWeapon weapon, int amount )
	{
		if ( amount <= 0 ) return true;
		var ammoId = ResolveAmmoTypeId( weapon );
		if ( ammoId is null ) return false;
		var inv = weapon.Owner?.GetComponent<MirageInventory>();
		if ( inv is null ) return false;

		// Run on the host directly when we already are; otherwise route
		// through MirageInventoryService so the host stays the single
		// source of truth for slot mutations.
		if ( Networking.IsHost )
		{
			inv.ConsumeById( ammoId, amount );
		}
		else
		{
			MirageInventoryService.RpcConsumeAmmo( ammoId, amount );
		}
		return true;
	}
}
