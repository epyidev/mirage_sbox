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
	/// Host-side registry of every Mirage-spawned vehicle still alive.
	/// We do not rely on a scene-wide tag scan because freshly spawned
	/// objects can land under a parent (e.g. the s&amp;box system root)
	/// that <see cref="Scene.GetAllObjects(bool)"/> does not always
	/// recurse into. Keeping the registry next to the spawn / destroy
	/// path keeps lookups O(1) and self-consistent.
	/// </summary>
	private static readonly List<GameObject> _registered = new();

	/// <summary>
	/// Host-only. Spawn the prefab referenced by <paramref name="model"/>
	/// at a sensible position in front of <paramref name="player"/>,
	/// give the spawning player ownership and return the new GameObject.
	/// Returns null when the prefab cannot be loaded.
	/// </summary>
	public static GameObject Spawn( Player player, MirageVehicle model )
	{
		Assert.True( Networking.IsHost, "MirageVehicleSpawner.Spawn must run on the host" );
		if ( !player.IsValid() || model is null ) return null;
		if ( string.IsNullOrEmpty( model.PrefabPath ) ) return null;

		var prefab = GameObject.GetPrefab( model.PrefabPath );
		if ( !prefab.IsValid() )
		{
			Log.Warning( $"[Mirage] Vehicle prefab '{model.PrefabPath}' could not be loaded." );
			return null;
		}

		var spawn = ResolveSpawnTransform( player );

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

		if ( !go.IsValid() ) return null;

		go.Tags.Add( VehicleTag );
		go.Tags.Add( MirageVehicleTag );
		go.Name = $"Mirage Vehicle ({model.Id})";

		Ownable.Set( go, player.Network.Owner );
		// NetworkSpawn(true, owner) spawns enabled on every client and
		// hands ownership to the caller. The Pickup-style false-first
		// variant used by PlayerInventory is for items that start
		// disabled and get enabled later when held.
		go.NetworkSpawn( true, player.Network.Owner );

		_registered.Add( go );
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

		foreach ( var go in hits ) go.Destroy();
		_registered.RemoveAll( go => !go.IsValid() );
		return hits.Count;
	}

	/// <summary>
	/// Every Mirage-spawned vehicle currently alive on the host. Pulled
	/// from the in-process registry; stale entries (destroyed elsewhere)
	/// are pruned on the fly.
	/// </summary>
	public static IEnumerable<GameObject> AllSpawned()
	{
		_registered.RemoveAll( go => !go.IsValid() );
		foreach ( var go in _registered )
		{
			if ( go.IsValid() ) yield return go;
		}
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
	/// World transform for a fresh spawn: project a point ~3.5 metres
	/// in front of the player at their heading, then ground-trace
	/// straight down so the vehicle lands flat on the floor instead of
	/// dropping from the sky and clipping the operator's head. A small
	/// lift gives the wheel suspension room to settle without the
	/// chassis spawning intersecting the geometry.
	/// </summary>
	private static Transform ResolveSpawnTransform( Player player )
	{
		var ang = player.Controller.IsValid() ? player.Controller.EyeAngles : Angles.Zero;
		var yaw = ang.yaw;
		var forward = Rotation.From( 0, yaw, 0 ).Forward;

		// Front offset large enough that a ~140-unit-long car body does
		// not overlap the operator on spawn, and small enough that they
		// stay in the same room.
		const float ForwardOffset = 160f;
		const float GroundLift = 16f;
		const float TraceUp = 96f;
		const float TraceDown = 1024f;

		var origin = player.WorldPosition + forward * ForwardOffset + Vector3.Up * TraceUp;
		var endPos = origin + Vector3.Down * TraceDown;
		var trace = Game.ActiveScene.Trace
			.Ray( origin, endPos )
			.WithoutTags( "player", "vehicle", "mirage_vehicle" )
			.Run();

		Vector3 floor;
		if ( trace.Hit )
		{
			floor = trace.EndPosition;
		}
		else
		{
			// No floor under the spawn point. Fall back to the player's
			// own elevation so we at least put the car on a sensible Z.
			floor = (player.WorldPosition + forward * ForwardOffset).WithZ( player.WorldPosition.z );
		}

		var pos = floor + Vector3.Up * GroundLift;
		return new Transform( pos, Rotation.FromYaw( yaw ) );
	}
}
