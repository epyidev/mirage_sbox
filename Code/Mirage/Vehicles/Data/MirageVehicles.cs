/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Central catalogue of every vehicle model recognised by the Mirage
/// vehicle system. Mirrors the <see cref="MirageItems"/> pattern: append
/// an entry to <see cref="Build"/> to register a new car, the rest of
/// the gameplay code only ever asks the catalogue for the prefab path.
///
/// The catalogue is built once on first access and cached. Bump
/// <see cref="CatalogueVersion"/> any time you change <see cref="Build"/>
/// so the static cache that survives s&amp;box hot reloads gets
/// discarded and rebuilt.
/// </summary>
public static class MirageVehicles
{
	private static Dictionary<string, MirageVehicle> _byId;
	private static List<MirageVehicle> _ordered;

	private const int CatalogueVersion = 1;
	private static int _builtVersion = -1;

	private static void EnsureBuilt()
	{
		if ( _byId is not null && _builtVersion == CatalogueVersion ) return;
		_byId = new Dictionary<string, MirageVehicle>( StringComparer.OrdinalIgnoreCase );
		_ordered = new List<MirageVehicle>();
		Build();
		_builtVersion = CatalogueVersion;
		Log.Info( $"[Mirage] Vehicle catalogue v{CatalogueVersion} built with {_ordered.Count} model(s)." );
	}

	private static void Add( MirageVehicle vehicle )
	{
		_byId[vehicle.Id] = vehicle;
		_ordered.Add( vehicle );
	}

	/// <summary>Lookup a vehicle config by id. Returns null if unknown.</summary>
	public static MirageVehicle Find( string id )
	{
		EnsureBuilt();
		if ( string.IsNullOrEmpty( id ) ) return null;
		_byId.TryGetValue( id, out var v );
		return v;
	}

	/// <summary>True if <paramref name="id"/> exists in the catalogue.</summary>
	public static bool IsKnown( string id )
	{
		EnsureBuilt();
		return !string.IsNullOrEmpty( id ) && _byId.ContainsKey( id );
	}

	/// <summary>Every registered vehicle, in catalogue order.</summary>
	public static IReadOnlyList<MirageVehicle> All
	{
		get { EnsureBuilt(); return _ordered; }
	}

	private static void Build()
	{
		// Default Mirage car. Built around the example physics components
		// shipped under Code/Mirage/Vehicles/Physics/ and the prefab at
		// Assets/vehicles/default_car.prefab. Add other models below.
		Add( new MirageVehicle
		{
			Id = "car_default",
			Label = "Voiture par défaut",
			PrefabPath = "vehicles/default_car.prefab",
			Description = "Modèle de base, idéal pour tester le système de véhicules.",
			Category = "car"
		} );
	}
}
