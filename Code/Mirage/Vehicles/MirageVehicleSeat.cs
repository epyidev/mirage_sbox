/** @author Epyi */

namespace Sandbox.Mirage.Vehicles;

/// <summary>
/// Driver seat for a Mirage vehicle. Lives as a Component on the
/// vehicle root and exposes a press-to-interact handle: pressing E on
/// an empty seat puts the operator in the driver's seat, pressing E
/// again (or any time while seated) ejects them next to the vehicle.
///
/// Seating state is held entirely on the host:
/// <list type="bullet">
///   <item><see cref="DriverPlayerId"/> tracks the seated PlayerData by
///   its connection guid so every client knows who's driving.</item>
///   <item>The seated player's <see cref="Player.GameObject"/> is
///   parented to the vehicle so they translate with the chassis, and
///   <see cref="PlayerData.InVehicleId"/> is set so
///   <see cref="Player"/>'s OnControl knows to suspend the player
///   controller (gameplay WASD reaches <see cref="MirageCar"/> only).</item>
///   <item>On exit the player is teleported one body-length to the
///   left of the chassis at the vehicle's current yaw, the parent is
///   cleared and the controller flag is released.</item>
/// </list>
/// </summary>
[Category( "Mirage Vehicles" )]
[Title( "Mirage Vehicle Seat" )]
[Icon( "event_seat" )]
public sealed class MirageVehicleSeat : Component, Component.IPressable
{
	/// <summary>
	/// Connection-id of the seated player's <see cref="PlayerData"/>.
	/// Empty string when the seat is free.
	/// </summary>
	[Sync( SyncFlags.FromHost )] public string DriverPlayerId { get; set; } = "";

	/// <summary>How far above the chassis origin to lift the driver while seated.</summary>
	[Property] public Vector3 SeatOffset { get; set; } = new Vector3( 0f, 0f, 24f );

	/// <summary>How far away from the vehicle to teleport the driver on exit.</summary>
	[Property] public float ExitOffset { get; set; } = 90f;

	public bool IsOccupied => !string.IsNullOrEmpty( DriverPlayerId );

	IPressable.Tooltip? IPressable.GetTooltip( IPressable.Event e )
	{
		var label = IsOccupied ? "Sortir" : "Conduire";
		return new IPressable.Tooltip( label, "directions_car", "Véhicule" );
	}

	bool IPressable.CanPress( IPressable.Event e ) => true;

	bool IPressable.Press( IPressable.Event e )
	{
		var presser = e.Source.GameObject;
		HostHandlePress( presser );
		return true;
	}

	[Rpc.Host]
	private void HostHandlePress( GameObject presserObject )
	{
		if ( !presserObject.IsValid() ) return;
		var player = presserObject.Root.GetComponent<Player>();
		if ( !player.IsValid() ) return;
		var pd = player.PlayerData;
		if ( pd is null ) return;

		var presserId = pd.PlayerId.ToString();

		if ( IsOccupied )
		{
			// Only the seated player can vacate the seat through a
			// press; another player pressing E while it is occupied
			// is silently ignored (use exit points or ramming if you
			// want them out).
			if ( DriverPlayerId == presserId )
			{
				ExitDriver( player );
			}
			return;
		}

		// Refuse seating a player who is already in another vehicle
		// (e.g. they pressed E mid-ride on a passing seat).
		if ( !string.IsNullOrEmpty( pd.InVehicleId ) ) return;

		EnterDriver( player );
	}

	private void EnterDriver( Player player )
	{
		Assert.True( Networking.IsHost, "MirageVehicleSeat.EnterDriver must run on the host" );
		if ( !player.IsValid() ) return;
		var pd = player.PlayerData;
		if ( pd is null ) return;

		DriverPlayerId = pd.PlayerId.ToString();
		pd.InVehicleId = GameObject.Id.ToString();

		// Park the player at the seat point so they ride along with
		// the chassis. Body stays visible by default; if you want a
		// cleaner cockpit later, gate Body.Enabled here.
		player.GameObject.SetParent( GameObject, false );
		player.GameObject.LocalPosition = SeatOffset;
		player.GameObject.LocalRotation = Rotation.Identity;
	}

	private void ExitDriver( Player player )
	{
		Assert.True( Networking.IsHost, "MirageVehicleSeat.ExitDriver must run on the host" );
		if ( !player.IsValid() ) return;
		var pd = player.PlayerData;
		if ( pd is not null )
		{
			pd.InVehicleId = "";
		}

		// Unparent and drop the player one body-length to the side of
		// the vehicle, on the ground if we can find one.
		player.GameObject.SetParent( null, true );

		var sideDir = WorldRotation.Right;
		var exitTarget = WorldPosition + sideDir * ExitOffset + Vector3.Up * 32f;
		var trace = Game.ActiveScene.Trace
			.Ray( exitTarget, exitTarget + Vector3.Down * 256f )
			.WithoutTags( "player", "vehicle", "mirage_vehicle" )
			.Run();
		var floor = trace.Hit ? trace.EndPosition + Vector3.Up * 4f : exitTarget;

		player.MirageTeleport( floor, new Angles( 0f, WorldRotation.Yaw() + 90f, 0f ) );

		DriverPlayerId = "";
	}

	/// <summary>
	/// Force-eject the current driver. Used when the vehicle is
	/// destroyed so the player is not left dangling under a deleted
	/// parent GameObject.
	/// </summary>
	public void ForceExit()
	{
		Assert.True( Networking.IsHost, "MirageVehicleSeat.ForceExit must run on the host" );
		if ( !IsOccupied ) return;

		var pd = PlayerData.All.FirstOrDefault( p => p.PlayerId.ToString() == DriverPlayerId );
		var player = pd is null ? null : Game.ActiveScene.GetAll<Player>().FirstOrDefault( x => x.PlayerData == pd );
		if ( player.IsValid() )
		{
			ExitDriver( player );
		}
		else
		{
			DriverPlayerId = "";
		}
	}

	protected override void OnDestroy()
	{
		// Make sure a despawned vehicle releases its driver: otherwise
		// PlayerData.InVehicleId stays set and the player controller
		// remains frozen.
		if ( Networking.IsHost && IsOccupied )
		{
			ForceExit();
		}
	}
}
