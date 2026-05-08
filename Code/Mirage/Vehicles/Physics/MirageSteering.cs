/** @author Epyi */

namespace Sandbox.Mirage.Vehicles;

/// <summary>
/// Turns a list of wheels left/right based on the analog steering value
/// fed by <see cref="MirageCar"/>. Ported from the VehicleSystemExemple
/// "Steering" component.
/// </summary>
[Category( "Mirage Vehicles" )]
[Title( "Mirage Steering" )]
public sealed class MirageSteering : Component
{
	[Property] public List<GameObject> Wheels { get; set; }
	[Property] public float MaxSteeringAngle { get; set; } = 20f;
	[Property] public float SteeringSmoothness { get; set; } = 10f;
	[Property] public Angles Offset { get; set; }

	protected override void OnFixedUpdate()
	{
		if ( Scene.IsEditor ) return;
		if ( IsProxy ) return;
		if ( Wheels is null ) return;

		var car = GameObject.GetComponentInParent<MirageCar>();
		if ( car is null || !car.CanMove ) return;

		var steer = car.SteerInput;

		foreach ( var wheel in Wheels )
		{
			if ( wheel is null ) continue;
			var targetRotation = Rotation.FromYaw( MaxSteeringAngle * steer ) * Rotation.From( Offset );
			wheel.Transform.LocalRotation = Rotation.Lerp( wheel.Transform.LocalRotation, targetRotation, Time.Delta * SteeringSmoothness );
		}
	}
}
