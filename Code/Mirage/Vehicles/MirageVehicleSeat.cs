/** @author Epyi */

namespace Sandbox.Mirage.Vehicles;

/// <summary>
/// Driver seat for a Mirage vehicle. Lives as a Component on the
/// vehicle root and exposes a press-to-interact handle: pressing E on
/// an empty seat puts the operator in the driver's seat, pressing E
/// again ejects them next to the vehicle.
///
/// Seating mechanics:
/// <list type="bullet">
///   <item><see cref="DriverPlayerId"/> tracks the seated PlayerData by
///   its connection guid so every client knows who is driving (used by
///   <see cref="MirageCar"/> to refuse input from anyone else).</item>
///   <item>The seated player is NOT parented to the vehicle; instead
///   the host pins their WorldPosition to the seat anchor every fixed
///   tick and zeroes the controller rigidbody velocity. Keeps the
///   PlayerController fully alive (mouse-look, camera setup) while
///   guaranteeing they never slide off as the car accelerates.</item>
///   <item><see cref="PlayerData.InVehicleId"/> is set so the
///   <see cref="Player"/> controller's input gating can suspend
///   walking input while the operator is driving.</item>
///   <item>The car's network ownership is transferred to the seated
///   player on enter and dropped on exit, so <see cref="MirageCar"/>'s
///   IsProxy gate matches the actual driver.</item>
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

	/// <summary>
	/// Local-space anchor point for the driver. The player's eye
	/// height is added on top so a value of <c>(0, 0, 0)</c> usually
	/// puts the camera around cabin level for a standard car.
	/// </summary>
	[Property] public Vector3 SeatOffset { get; set; } = new Vector3( 0f, 0f, 0f );

	/// <summary>How far away from the vehicle to teleport the driver on exit.</summary>
	[Property] public float ExitOffset { get; set; } = 90f;

	public bool IsOccupied => !string.IsNullOrEmpty( DriverPlayerId );

	// Host-only cache so OnFixedUpdate does not have to walk every
	// PlayerData every tick to find the seated player.
	private Player _driverHost;

	IPressable.Tooltip? IPressable.GetTooltip( IPressable.Event e )
	{
		var label = IsOccupied ? "Sortir" : "Conduire";
		return new IPressable.Tooltip( label, "directions_car", "Véhicule" );
	}

	bool IPressable.CanPress( IPressable.Event e ) => true;

	bool IPressable.Press( IPressable.Event e )
	{
		HostHandlePress( e.Source.GameObject );
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
			if ( DriverPlayerId == presserId )
			{
				ExitDriver( player );
			}
			return;
		}

		// Refuse seating a player who is already in another vehicle.
		if ( !string.IsNullOrEmpty( pd.InVehicleId ) ) return;

		EnterDriver( player );
	}

	private void EnterDriver( Player player )
	{
		Assert.True( Networking.IsHost, "MirageVehicleSeat.EnterDriver must run on the host" );
		if ( !player.IsValid() ) return;
		var pd = player.PlayerData;
		if ( pd is null ) return;

		_driverHost = player;
		DriverPlayerId = pd.PlayerId.ToString();
		pd.InVehicleId = GameObject.Id.ToString();

		// Hide the body so we do not see the operator awkwardly
		// floating inside the cabin. The PlayerController stays alive
		// so mouse-look and PostCameraSetup keep firing on the local
		// client; we just suspend its WASD input via PlayerData.IsInVehicle
		// (read in Player.OnControl).
		if ( player.Body.IsValid() ) player.Body.Enabled = false;

		// Hand over network ownership so MirageCar's IsProxy gate fires
		// only on the driver's client. Without this, a passenger
		// pressing E would drive the car owned by the original spawner.
		var driverConn = pd.Connection;
		if ( driverConn is not null )
		{
			Network.AssignOwnership( driverConn );
		}

		// Seed an initial pin so the body does not flash through the
		// world before the first OnFixedUpdate kicks in.
		PinDriverToSeat( player );
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

		if ( player.Body.IsValid() ) player.Body.Enabled = true;

		// Drop the player one body-length to the right of the vehicle,
		// on the ground if we can find one.
		var sideDir = WorldRotation.Right;
		var exitTarget = WorldPosition + sideDir * ExitOffset + Vector3.Up * 32f;
		var trace = Game.ActiveScene.Trace
			.Ray( exitTarget, exitTarget + Vector3.Down * 256f )
			.WithoutTags( "player", "vehicle", "mirage_vehicle" )
			.Run();
		var floor = trace.Hit ? trace.EndPosition + Vector3.Up * 4f : exitTarget;

		player.MirageTeleport( floor, new Angles( 0f, WorldRotation.Yaw() + 90f, 0f ) );

		// Drop network ownership of the car. The host becomes the
		// authority again, MirageCar.OnFixedUpdate stops driving.
		Network.DropOwnership();

		_driverHost = null;
		DriverPlayerId = "";
	}

	/// <summary>
	/// Force-eject the current driver. Called when the vehicle is
	/// destroyed, so the operator does not stay frozen and invisible.
	/// </summary>
	public void ForceExit()
	{
		Assert.True( Networking.IsHost, "MirageVehicleSeat.ForceExit must run on the host" );
		if ( !IsOccupied ) return;
		if ( _driverHost.IsValid() )
		{
			ExitDriver( _driverHost );
		}
		else
		{
			DriverPlayerId = "";
		}
	}

	/// <summary>
	/// Host-only. Snap the driver to the seat anchor and zero their
	/// rigidbody velocity. Runs every fixed tick so the operator
	/// rides along with the chassis even if the controller tries to
	/// add gravity or any other passive force.
	/// </summary>
	protected override void OnFixedUpdate()
	{
		if ( !Networking.IsHost ) return;
		if ( !IsOccupied ) return;
		PinDriverToSeat( _driverHost );
	}

	private void PinDriverToSeat( Player player )
	{
		if ( !player.IsValid() ) return;
		var anchor = WorldTransform.PointToWorld( SeatOffset );
		player.WorldPosition = anchor;
		if ( player.Controller.IsValid() && player.Controller.Body.IsValid() )
		{
			player.Controller.Body.Velocity = Vector3.Zero;
			player.Controller.Body.AngularVelocity = Vector3.Zero;
		}
	}

	protected override void OnDestroy()
	{
		if ( Networking.IsHost && IsOccupied )
		{
			ForceExit();
		}
	}
}
