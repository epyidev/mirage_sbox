/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Central catalogue of every item recognised by the Mirage inventory.
///
/// To add a new item: append an entry to <see cref="Build"/>. The id is the
/// lowercase slug stored on disk and over RPCs. All other fields are pure
/// configuration. The catalogue is built once on first access and cached.
///
/// This is the C# equivalent of an ox_inventory <c>items.lua</c> table: the
/// gameplay layer never hard-codes item ids, it always looks them up here so
/// adding a burger or a new pistol is a one-block edit.
/// </summary>
public static class MirageItems
{
	private static Dictionary<string, MirageItem> _byId;
	private static List<MirageItem> _ordered;

	/// <summary>
	/// Bumped manually whenever the build code below changes, so the static
	/// cache that survives s&amp;box hot reloads gets discarded and rebuilt
	/// from the new code instead of silently serving stale entries (e.g. an
	/// old WeaponPrefab path renamed since the last reload).
	/// </summary>
	private const int CatalogueVersion = 4;
	private static int _builtVersion = -1;

	private static void EnsureBuilt()
	{
		if ( _byId is not null && _builtVersion == CatalogueVersion ) return;
		_byId = new Dictionary<string, MirageItem>( StringComparer.OrdinalIgnoreCase );
		_ordered = new List<MirageItem>();
		Build();
		_builtVersion = CatalogueVersion;
	}

	private static void Add( MirageItem item )
	{
		_byId[item.Id] = item;
		_ordered.Add( item );
	}

	/// <summary>Lookup an item config by id. Returns null if unknown.</summary>
	public static MirageItem Find( string id )
	{
		EnsureBuilt();
		if ( string.IsNullOrEmpty( id ) ) return null;
		_byId.TryGetValue( id, out var item );
		return item;
	}

	/// <summary>
	/// True if <paramref name="id"/> exists in the catalogue. Useful when
	/// validating untrusted input from the network or chat commands.
	/// </summary>
	public static bool IsKnown( string id )
	{
		EnsureBuilt();
		return !string.IsNullOrEmpty( id ) && _byId.ContainsKey( id );
	}

	/// <summary>Every registered item, in catalogue order.</summary>
	public static IReadOnlyList<MirageItem> All
	{
		get { EnsureBuilt(); return _ordered; }
	}

	private static void Build()
	{
		// All icon paths point to PNG files under Assets/UI/items/. Items
		// without a matching image fall back to the first letter of their
		// label in the inventory cell.

		// ---- Generic / RP fluff items ----
		Add( new MirageItem
		{
			Id = "bandage",
			Label = "Bandage",
			Weight = 115,
			MaxStack = 20,
			Category = "consumable",
			Image = "ui/items/bandage.png",
			Description = "Soigne légèrement les blessures."
		} );

		Add( new MirageItem
		{
			Id = "burger",
			Label = "Burger",
			Weight = 220,
			MaxStack = 5,
			Category = "consumable",
			Image = "ui/items/burger.png",
			Description = "Un bon vieux burger graisseux."
		} );

		Add( new MirageItem
		{
			Id = "water",
			Label = "Bouteille d'eau",
			Weight = 500,
			MaxStack = 5,
			Category = "consumable",
			Image = "ui/items/water.png"
		} );

		Add( new MirageItem
		{
			Id = "phone",
			Label = "Téléphone",
			Weight = 190,
			MaxStack = 1,
			Category = "tool",
			Image = "ui/items/phone.png"
		} );

		Add( new MirageItem
		{
			Id = "lockpick",
			Label = "Crochet",
			Weight = 160,
			MaxStack = 5,
			Category = "tool",
			Image = "ui/items/lockpick.png"
		} );

		Add( new MirageItem
		{
			Id = "money",
			Label = "Argent",
			Weight = 0,
			MaxStack = 999_999,
			Category = "currency",
			Image = "ui/items/money.png"
		} );

		Add( new MirageItem
		{
			Id = "scrapmetal",
			Label = "Ferraille",
			Weight = 80,
			MaxStack = 100,
			Category = "material",
			Image = "ui/items/scrapmetal.png"
		} );

		Add( new MirageItem
		{
			Id = "identification",
			Label = "Carte d'identité",
			Weight = 5,
			MaxStack = 1,
			Category = "document",
			Image = "ui/items/identification.png"
		} );

		// ---- Ammunition ----
		// One stackable item per cartridge family. Carrying these in the
		// inventory acts as the reserve magazine: reloading a weapon
		// pulls cartridges out of the matching ammo stack until the clip
		// is full or the stack is empty. The ids must match the
		// WeaponAmmoType wired on the weapon entries below.
		Add( new MirageItem
		{
			Id = "ammo_9",
			Label = "Munitions 9mm",
			Weight = 12,
			MaxStack = 200,
			Category = "ammo",
			Image = "ui/items/ammo_9.png"
		} );

		Add( new MirageItem
		{
			Id = "ammo_45",
			Label = "Munitions .45 ACP",
			Weight = 15,
			MaxStack = 200,
			Category = "ammo",
			Image = "ui/items/ammo_45.png"
		} );

		Add( new MirageItem
		{
			Id = "ammo_shotgun",
			Label = "Cartouches calibre 12",
			Weight = 45,
			MaxStack = 100,
			Category = "ammo",
			Image = "ui/items/ammo_shotgun.png"
		} );

		Add( new MirageItem
		{
			Id = "ammo_5-56",
			Label = "Munitions 5.56",
			Weight = 14,
			MaxStack = 200,
			Category = "ammo",
			Image = "ui/items/ammo_5-56.png"
		} );

		Add( new MirageItem
		{
			Id = "ammo_7-62",
			Label = "Munitions 7.62",
			Weight = 22,
			MaxStack = 100,
			Category = "ammo",
			Image = "ui/items/ammo_7-62.png"
		} );

		Add( new MirageItem
		{
			Id = "ammo_rpg",
			Label = "Roquette",
			Weight = 2500,
			MaxStack = 5,
			Category = "ammo",
			Image = "ui/items/ammo_rpg.png"
		} );

		// ---- Weapons bound to the existing Sandbox carryables ----
		// Weapon item ids are prefixed with "weapon_" so any reader can
		// tell at a glance that the slot holds an armed item. WeaponPrefab
		// paths must still match the actual prefab files under
		// Assets/weapons/, including the capital folder names. Equipping
		// these from the hotbar still gives the operator a fully usable
		// Sandbox weapon with the original behaviour, animation, etc.
		Add( new MirageItem
		{
			Id = "weapon_colt1911",
			Label = "Colt 1911",
			Weight = 1100,
			MaxStack = 1,
			Category = "weapon",
			Image = "ui/items/weapon_colt1911.png",
			WeaponPrefab = "weapons/Colt1911/colt1911.prefab",
			WeaponAmmoType = "ammo_45",
			DefaultMetadata = new Dictionary<string, string>
			{
				["ammo"] = "7",
				["durability"] = "100"
			}
		} );

		Add( new MirageItem
		{
			Id = "weapon_glock",
			Label = "Glock",
			Weight = 900,
			MaxStack = 1,
			Category = "weapon",
			Image = "ui/items/weapon_glock.png",
			WeaponPrefab = "weapons/Glock/glock.prefab",
			WeaponAmmoType = "ammo_9",
			DefaultMetadata = new Dictionary<string, string>
			{
				["ammo"] = "17",
				["durability"] = "100"
			}
		} );

		Add( new MirageItem
		{
			Id = "weapon_mp5",
			Label = "MP5",
			Weight = 2400,
			MaxStack = 1,
			Category = "weapon",
			Image = "ui/items/weapon_mp5.png",
			WeaponPrefab = "weapons/Mp5/mp5.prefab",
			WeaponAmmoType = "ammo_9",
			DefaultMetadata = new Dictionary<string, string>
			{
				["ammo"] = "30",
				["durability"] = "100"
			}
		} );

		Add( new MirageItem
		{
			Id = "weapon_shotgun",
			Label = "Fusil à pompe",
			Weight = 3200,
			MaxStack = 1,
			Category = "weapon",
			Image = "ui/items/weapon_shotgun.png",
			WeaponPrefab = "weapons/Shotgun/shotgun.prefab",
			WeaponAmmoType = "ammo_shotgun",
			DefaultMetadata = new Dictionary<string, string>
			{
				["ammo"] = "8",
				["durability"] = "100"
			}
		} );

		Add( new MirageItem
		{
			Id = "weapon_m4a1",
			Label = "M4A1",
			Weight = 3800,
			MaxStack = 1,
			Category = "weapon",
			Image = "ui/items/weapon_m4a1.png",
			WeaponPrefab = "weapons/M4a1/m4a1.prefab",
			WeaponAmmoType = "ammo_5-56",
			DefaultMetadata = new Dictionary<string, string>
			{
				["ammo"] = "30",
				["durability"] = "100"
			}
		} );

		Add( new MirageItem
		{
			Id = "weapon_sniper",
			Label = "Fusil de précision",
			Weight = 4500,
			MaxStack = 1,
			Category = "weapon",
			Image = "ui/items/weapon_sniper.png",
			WeaponPrefab = "weapons/Sniper/sniper.prefab",
			WeaponAmmoType = "ammo_7-62",
			DefaultMetadata = new Dictionary<string, string>
			{
				["ammo"] = "5",
				["durability"] = "100"
			}
		} );

		Add( new MirageItem
		{
			Id = "weapon_rpg",
			Label = "Lance-roquettes",
			Weight = 6000,
			MaxStack = 1,
			Category = "weapon",
			Image = "ui/items/weapon_rpg.png",
			WeaponPrefab = "weapons/Rpg/rpg.prefab",
			WeaponAmmoType = "ammo_rpg",
			DefaultMetadata = new Dictionary<string, string>
			{
				["ammo"] = "1",
				["durability"] = "100"
			}
		} );

		Add( new MirageItem
		{
			Id = "weapon_crowbar",
			Label = "Pied-de-biche",
			Weight = 1200,
			MaxStack = 1,
			Category = "weapon",
			Image = "ui/items/weapon_crowbar.png",
			WeaponPrefab = "weapons/Crowbar/crowbar.prefab"
		} );

		Add( new MirageItem
		{
			Id = "weapon_grenade",
			Label = "Grenade",
			Weight = 400,
			MaxStack = 5,
			Category = "weapon",
			Image = "ui/items/weapon_grenade.png",
			WeaponPrefab = "weapons/Grenade/grenade.prefab"
		} );

		Add( new MirageItem
		{
			Id = "physgun",
			Label = "Physgun",
			Weight = 1500,
			MaxStack = 1,
			Category = "tool",
			WeaponPrefab = "weapons/Physgun/physgun.prefab"
		} );

		Add( new MirageItem
		{
			Id = "toolgun",
			Label = "Toolgun",
			Weight = 1000,
			MaxStack = 1,
			Category = "tool",
			WeaponPrefab = "weapons/Toolgun/toolgun.prefab"
		} );

		Add( new MirageItem
		{
			Id = "camera",
			Label = "Caméra",
			Weight = 800,
			MaxStack = 1,
			Category = "tool",
			Image = "ui/items/camera.png",
			WeaponPrefab = "weapons/Camera/camera.prefab"
		} );
	}
}
