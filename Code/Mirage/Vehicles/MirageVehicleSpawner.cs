/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Host-only helpers for spawning and despawning vehicles. Mirage tags
/// every spawned vehicle with <see cref="VehicleTag"/> so radius queries
/// (<c>/dv &lt;radius&gt;</c>) and "vehicle I'm currently on" lookups
/// stay cheap and self-contained.
/// </summary>
public static class MirageVehicleSpawner
{
	/// <summary>
	/// Tag stamped on every spawned vehicle GameObject. Used by the
	/// despawn / radius commands and by physics tracers (see
	/// <see cref="Sandbox.Mirage.Vehicles.MirageWheel"/> which ignores
	/// tags <c>vehicle</c> in its ground trace).
	/// </summary>
	public const string VehicleTag = "vehicle";

	/// <summary>
	/// Tag stamped on a tracked vehicle so the despawn helper can tell
	/// Mirage spawned cars apart from any other GameObject that might
	/// also carry the generic <c>vehicle</c> tag.
	/// </summary>
	public const string MirageVehicleTag = "mirage_vehicle";

	/// <summary>
	/// Host-only. Spawn the prefab referenced by <paramref name="model"/>
	/// at a sensible position in front of <paramref name="player"/>,
	/// give the spawning player ownership and return the new GameObject.
	/// Returns null when the prefab cannot be loaded.
	/// </summary>
	public static GameObject Spawn( Player player, MirageVehicle model )
	{
		Assert.True( Networking.IsHost, "MirageVehicleSpawner.Spawn must run on the host" );
		if ( !player.IsValid() || model is null )
		{
			Log.Warning( "[Mirage] Vehicle spawn aborted: invalid player or model." );
			return null;
		}
		if ( string.IsNullOrEmpty( model.PrefabPath ) )
		{
			Log.Warning( $"[Mirage] Vehicle '{model.Id}' has empty PrefabPath." );
			return null;
		}

		Log.Info( $"[Mirage] Spawning vehicle '{model.Id}' from prefab '{model.PrefabPath}'..." );

		var prefab = GameObject.GetPrefab( model.PrefabPath );
		if ( !prefab.IsValid() )
		{
			Log.Warning( $"[Mirage] Vehicle prefab '{model.PrefabPath}' could not be loaded (GameObject.GetPrefab returned null/invalid)." );
			return null;
		}

		var spawn = ResolveSpawnTransform( player );
		Log.Info( $"[Mirage] Vehicle spawn position: {spawn.Position} yaw={spawn.Rotation.Yaw()}" );

		GameObject go;
		try
		{
			go = prefab.Clone( new CloneConfig
			{
				Transform = spawn,
				StartEnabled = true
			} );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] prefab.Clone failed: {ex.Message}" );
			return null;
		}

		if ( !go.IsValid() )
		{
			Log.Warning( "[Mirage] prefab.Clone returned an invalid GameObject." );
			return null;
		}

		// Tag stamping so /dv and trace filters can find the vehicle
		// without walking every component on the GameObject.
		go.Tags.Add( VehicleTag );
		go.Tags.Add( MirageVehicleTag );
		go.Name = $"Mirage Vehicle ({model.Id})";

		Ownable.Set( go, player.Network.Owner );
		go.NetworkSpawn( false, player.Network.Owner );

		Log.Info( $"[Mirage] Vehicle '{model.Id}' spawned successfully (guid={go.Id})." );
		return go;
	}

	/// <summary>
	/// Host-only. Destroy the vehicle the player is sitting on, if any.
	/// Returns true when something was despawned.
	/// </summary>
	public static bool DespawnCurrent( Player player )
	{
		Assert.True( Networking.IsHost, "MirageVehicleSpawner.DespawnCurrent must run on the host" );
		if ( !player.IsValid() ) return false;

		var vehicle = ResolveCurrentVehicle( player );
		if ( vehicle is null ) return false;

		vehicle.Destroy();
		return true;
	}

	/// <summary>
	/// Host-only. Destroy every Mirage-spawned vehicle within
	/// <paramref name="radius"/> world units of <paramref name="player"/>.
	/// Returns the count of vehicles removed.
	/// </summary>
	public static int DespawnInRadius( Player player, float radius )
	{
		Assert.True( Networking.IsHost, "MirageVehicleSpawner.DespawnInRadius must run on the host" );
		if ( !player.IsValid() || radius <= 0f ) return 0;

		var origin = player.WorldPosition;
		var radiusSq = radius * radius;
		var hits = AllSpawned()
			.Where( go => go.IsValid() && (go.WorldPosition - origin).LengthSquared <= radiusSq )
			.ToList();

		foreach ( var go in hits )
		{
			go.Destroy();
		}
		return hits.Count;
	}

	/// <summary>
	/// Every Mirage-spawned vehicle in the active scene. Cheap because
	/// the engine indexes objects by tag.
	/// </summary>
	public static IEnumerable<GameObject> AllSpawned()
	{
		return Game.ActiveScene.GetAllObjects( true )
			.Where( go => go.IsValid() && go.Tags.Has( MirageVehicleTag ) );
	}

	/// <summary>
	/// Find the vehicle <paramref name="player"/> is currently in. We
	/// look for an ancestor with the vehicle tag of the player's
	/// occupied seat (BaseChair on the prefab), and fall back to the
	/// closest tagged vehicle within a couple of meters when no chair
	/// is occupied so an admin can despawn a car they fell out of.
	/// </summary>
	public static GameObject ResolveCurrentVehicle( Player player )
	{
		if ( !player.IsValid() ) return null;

		// Seated path: BaseChair parents the controller's hierarchy
		// while occupied, so walking up from the player's GameObject
		// lands on the vehicle root.
		var ancestor = player.GameObject?.Parent;
		while ( ancestor.IsValid() )
		{
			if ( ancestor.Tags.Has( MirageVehicleTag ) ) return ancestor;
			ancestor = ancestor.Parent;
		}

		// Fallback: nearest spawned vehicle within 256 units.
		const float NearbyRadius = 256f;
		const float NearbyRadiusSq = NearbyRadius * NearbyRadius;
		var origin = player.WorldPosition;
		GameObject closest = null;
		float closestSq = NearbyRadiusSq;
		foreach ( var go in AllSpawned() )
		{
			var d = (go.WorldPosition - origin).LengthSquared;
			if ( d < closestSq )
			{
				closestSq = d;
				closest = go;
			}
		}
		return closest;
	}

	/// <summary>
	/// World transform for a fresh spawn: 3 metres in front of the
	/// player at eye yaw, lifted slightly so the vehicle does not clip
	/// the floor as the wheel suspension settles.
	/// </summary>
	private static Transform ResolveSpawnTransform( Player player )
	{
		var ang = player.Controller.IsValid() ? player.Controller.EyeAngles : Angles.Zero;
		var yaw = ang.yaw;
		var forward = Rotation.From( 0, yaw, 0 ).Forward;
		var pos = player.WorldPosition + forward * 220f + Vector3.Up * 24f;
		return new Transform( pos, Rotation.FromYaw( yaw ) );
	}
}
