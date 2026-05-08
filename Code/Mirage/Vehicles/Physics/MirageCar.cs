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

		// Hybrid input source: the chair-based ControlSystem path fills
		// ThrottleInput/SteerInput via OnControl when a player is
		// seated, refreshing _timeSinceChairInput on every fixed tick.
		// If that silence stretches past ChairInputTimeout we assume
		// no seat is in play and fall back to direct input polling so
		// the owning client can drive without a BaseChair attached.
		if ( _timeSinceChairInput > ChairInputTimeout )
		{
			var move = Input.AnalogMove;
			ThrottleInput = move.x;
			SteerInput = move.y;
		}

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
