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

	private static void EnsureBuilt()
	{
		if ( _byId is not null ) return;
		_byId = new Dictionary<string, MirageItem>( StringComparer.OrdinalIgnoreCase );
		_ordered = new List<MirageItem>();
		Build();
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
		// ---- Generic / RP fluff items ----
		Add( new MirageItem
		{
			Id = "bandage",
			Label = "Bandage",
			Weight = 115,
			MaxStack = 20,
			Category = "consumable",
			Description = "Soigne légèrement les blessures."
		} );

		Add( new MirageItem
		{
			Id = "burger",
			Label = "Burger",
			Weight = 220,
			MaxStack = 5,
			Category = "consumable",
			Description = "Un bon vieux burger graisseux."
		} );

		Add( new MirageItem
		{
			Id = "water",
			Label = "Bouteille d'eau",
			Weight = 500,
			MaxStack = 5,
			Category = "consumable"
		} );

		Add( new MirageItem
		{
			Id = "phone",
			Label = "Téléphone",
			Weight = 190,
			MaxStack = 1,
			Category = "tool"
		} );

		Add( new MirageItem
		{
			Id = "lockpick",
			Label = "Crochet",
			Weight = 160,
			MaxStack = 5,
			Category = "tool"
		} );

		Add( new MirageItem
		{
			Id = "money",
			Label = "Argent",
			Weight = 0,
			MaxStack = 999_999,
			Category = "currency"
		} );

		Add( new MirageItem
		{
			Id = "scrapmetal",
			Label = "Ferraille",
			Weight = 80,
			MaxStack = 100,
			Category = "material"
		} );

		Add( new MirageItem
		{
			Id = "identification",
			Label = "Carte d'identité",
			Weight = 5,
			MaxStack = 1,
			Category = "document"
		} );

		// ---- Weapons bound to the existing Sandbox carryables ----
		// The WeaponPrefab path is what PlayerInventory.Pickup expects, so
		// equipping these from the hotbar still gives the operator a fully
		// usable Sandbox weapon with the original behaviour, animation, etc.
		Add( new MirageItem
		{
			Id = "pistol",
			Label = "Pistolet",
			Weight = 1100,
			MaxStack = 1,
			Category = "weapon",
			WeaponPrefab = "weapons/pistol/pistol.prefab",
			DefaultMetadata = new Dictionary<string, string>
			{
				["ammo"] = "12",
				["durability"] = "100"
			}
		} );

		Add( new MirageItem
		{
			Id = "smg",
			Label = "SMG",
			Weight = 2400,
			MaxStack = 1,
			Category = "weapon",
			WeaponPrefab = "weapons/smg/smg.prefab",
			DefaultMetadata = new Dictionary<string, string>
			{
				["ammo"] = "30",
				["durability"] = "100"
			}
		} );

		Add( new MirageItem
		{
			Id = "shotgun",
			Label = "Fusil à pompe",
			Weight = 3200,
			MaxStack = 1,
			Category = "weapon",
			WeaponPrefab = "weapons/shotgun/shotgun.prefab",
			DefaultMetadata = new Dictionary<string, string>
			{
				["ammo"] = "8",
				["durability"] = "100"
			}
		} );

		Add( new MirageItem
		{
			Id = "rifle",
			Label = "Fusil d'assaut",
			Weight = 3800,
			MaxStack = 1,
			Category = "weapon",
			WeaponPrefab = "weapons/rifle/rifle.prefab",
			DefaultMetadata = new Dictionary<string, string>
			{
				["ammo"] = "30",
				["durability"] = "100"
			}
		} );

		Add( new MirageItem
		{
			Id = "physgun",
			Label = "Physgun",
			Weight = 1500,
			MaxStack = 1,
			Category = "tool",
			WeaponPrefab = "weapons/physgun/physgun.prefab"
		} );

		Add( new MirageItem
		{
			Id = "toolgun",
			Label = "Toolgun",
			Weight = 1000,
			MaxStack = 1,
			Category = "tool",
			WeaponPrefab = "weapons/toolgun/toolgun.prefab"
		} );

		Add( new MirageItem
		{
			Id = "camera",
			Label = "Caméra",
			Weight = 800,
			MaxStack = 1,
			Category = "tool",
			WeaponPrefab = "weapons/camera/camera.prefab"
		} );
	}
}
