/** @author Epyi */

namespace Sandbox.Mirage.Vehicles;

/// <summary>
/// Main vehicle controller: forwards seated-driver input to the wheels'
/// motor torque and feeds the steering. Ported and Mirage-ified from
/// the VehicleSystemExemple "Car" component:
///
/// <list type="bullet">
///   <item>Implements <see cref="IPlayerControllable"/> so the seated
///   player drives via the existing <see cref="ControlSystem"/> path.
///   The vehicle prefab carries a <see cref="BaseChair"/> on a child
///   GameObject; the chair takes the player, and the ControlSystem
///   pushes that player's input scope before invoking
///   <see cref="OnControl"/> on every connected component.</item>
///   <item>Drive input is captured in <see cref="OnControl"/> and
///   applied physically in <see cref="OnFixedUpdate"/>, so the
///   physics keeps running on a fixed step regardless of how often the
///   chair refreshes the input scope.</item>
///   <item>When the chair is empty the input falls to zero, which
///   smoothly decelerates the car instead of leaving the throttle
///   stuck.</item>
/// </list>
/// </summary>
[Category( "Mirage Vehicles" )]
[Title( "Mirage Car" )]
[Icon( "directions_car" )]
public sealed class MirageCar : Component, IPlayerControllable
{
	[RequireComponent] public Rigidbody Rigidbody { get; set; }

	[Property, Group( "Vehicle" )] public float Torque { get; set; } = 15000f;
	[Property, Group( "Vehicle" )] public float AccelerationRate { get; set; } = 1.0f;
	[Property, Group( "Vehicle" )] public float DecelerationRate { get; set; } = 0.5f;
	[Property, Group( "Vehicle" )] public float BrakingRate { get; set; } = 2.0f;
	[Property, Group( "Vehicle" )] public float TerminalVelocity { get; set; } = 1000f;

	/// <summary>When false the wheels and steering ignore input, used
	/// to lock a parked vehicle without unparenting the chair.</summary>
	[Property, Group( "Controls" )] public bool CanMove { get; set; } = true;

	/// <summary>
	/// Steering value in [-1, 1] captured from the seated driver. Read
	/// by <see cref="MirageSteering"/> on the same fixed tick.
	/// </summary>
	public float SteerInput { get; private set; }

	/// <summary>Throttle value in [-1, 1] captured from the seated driver.</summary>
	public float ThrottleInput { get; private set; }

	private List<MirageWheel> _wheels;
	private float _currentTorque;

	// Track how long since the chair-driven OnControl path fed us
	// input. After ~one tick of silence we assume the seat is empty and
	// fall back to direct input polling so the owning client can drive
	// without a chair attached.
	private RealTimeSince _timeSinceChairInput = 1f;
	private const float ChairInputTimeout = 0.1f;

	// "Input arming" state: we only start reading the analog stick
	// once it has crossed back to neutral after the operator entered
	// the seat. Without this, holding W to run into the car would keep
	// the throttle pinned at full as soon as the seat is taken, so the
	// car would shoot forward "by itself" the instant we enter.
	private bool _inputArmed;
	private bool _wasOccupied;
	private int _diagFrames;
	private const float InputArmThreshold = 0.05f;

	protected override void OnEnabled()
	{
		_wheels = Components.GetAll<MirageWheel>( FindMode.EverythingInSelfAndDescendants ).ToList();
	}

	void IPlayerControllable.OnControl()
	{
		// Sandbox.AnalogMove maps to WASD/arrow keys; .x is forward axis,
		// .y is sideways. Same convention as the example car.
		var move = Input.AnalogMove;
		ThrottleInput = move.x;
		SteerInput = move.y;
		_timeSinceChairInput = 0f;
	}

	void IPlayerControllable.OnStartControl() { }
	void IPlayerControllable.OnEndControl()
	{
		ThrottleInput = 0f;
		SteerInput = 0f;
	}

	protected override void OnFixedUpdate()
	{
		if ( IsProxy ) return;

		// Drive only when a player is actually seated in this vehicle.
		// Without this gate the car would respond to the spawning
		// player's WASD even before they pressed E to enter, because
		// they own the GameObject and the OnFixedUpdate runs on the
		// owner. The seat hands ownership over to the driver on enter
		// (and back to the host on exit) so IsProxy + IsOccupied
		// together guarantee the local update runs only on the driver
		// who is currently in the seat.
		var seat = GetComponent<MirageVehicleSeat>();
		var occupied = seat is not null && seat.IsOccupied;

		// Reset the input arming the first frame we become occupied
		// so we ignore any keys still held from before the operator
		// pressed E to enter the seat.
		if ( occupied && !_wasOccupied )
		{
			_inputArmed = false;
			_currentTorque = 0f;
			Log.Info( $"[Mirage] MirageCar: now occupied. Resetting input arm + torque. IsProxy={IsProxy}, Network.Owner={Network.Owner?.DisplayName ?? "<none>"}" );
		}
		_wasOccupied = occupied;

		// Throttled diagnostic so we can see whether the runaway
		// throttle comes from input or from stale torque.
		if ( occupied )
		{
			_diagFrames++;
			if ( _diagFrames >= 30 )
			{
				_diagFrames = 0;
				Log.Info( $"[Mirage] MirageCar tick: armed={_inputArmed} input={Input.AnalogMove} throttle={ThrottleInput:F2} steer={SteerInput:F2} torque={_currentTorque:F0} vel={Rigidbody?.Velocity}" );
			}
		}
		else
		{
			_diagFrames = 0;
		}

		if ( !occupied )
		{
			ThrottleInput = 0f;
			SteerInput = 0f;
			ApplyDriveTick();
			return;
		}

		// Read input from the seated driver. While the analog stick is
		// still pushed from a key held during entry, keep both axes
		// muted; once it returns to neutral we arm the controls and
		// the next non-zero input drives normally.
		var move = _timeSinceChairInput > ChairInputTimeout ? Input.AnalogMove : new Vector3( ThrottleInput, SteerInput, 0f );

		if ( !_inputArmed )
		{
			if ( MathF.Abs( move.x ) < InputArmThreshold && MathF.Abs( move.y ) < InputArmThreshold )
			{
				_inputArmed = true;
			}
			else
			{
				ThrottleInput = 0f;
				SteerInput = 0f;
				ApplyDriveTick();
				return;
			}
		}

		if ( _timeSinceChairInput > ChairInputTimeout )
		{
			ThrottleInput = move.x;
			SteerInput = move.y;
		}

		ApplyDriveTick();
	}

	private void ApplyDriveTick()
	{

		float verticalInput = ThrottleInput;
		float targetTorque = verticalInput * Torque;

		if ( !CanMove )
		{
			verticalInput = 0f;
			targetTorque = 0f;
		}

		bool isBraking = MathF.Sign( verticalInput * _currentTorque ) == -1;
		bool isDecelerating = verticalInput == 0;

		float lerpRate = AccelerationRate;
		if ( isBraking )
			lerpRate = BrakingRate;
		else if ( isDecelerating )
			lerpRate = DecelerationRate;

		_currentTorque = _currentTorque.LerpTo( targetTorque, lerpRate * Time.Delta );

		if ( _wheels is not null )
		{
			foreach ( var wheel in _wheels )
			{
				wheel?.ApplyMotorTorque( _currentTorque );
			}
		}

		var groundVel = Rigidbody.Velocity.WithZ( 0f );
		if ( verticalInput == 0f && groundVel.Length < 32f )
		{
			var z = Rigidbody.Velocity.z;
			Rigidbody.Velocity = Vector3.Zero.WithZ( z );
		}

		if ( Rigidbody.Velocity.Length > TerminalVelocity )
		{
			Rigidbody.Velocity = Rigidbody.Velocity.Normal * TerminalVelocity;
		}
	}
}
