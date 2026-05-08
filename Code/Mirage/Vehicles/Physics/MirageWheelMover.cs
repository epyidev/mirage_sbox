/** @author Epyi */

namespace Sandbox.Mirage.Vehicles;

/// <summary>
/// Cosmetic wheel renderer: rotates the visual wheel mesh based on the
/// rigidbody's current speed. Ported from the VehicleSystemExemple
/// "WheelMover" component.
/// </summary>
[Category( "Mirage Vehicles" )]
[Title( "Mirage Wheel Mover" )]
public sealed class MirageWheelMover : Component
{
	[Property] public MirageWheel Target { get; set; }
	[Property] public bool ReverseRotation { get; set; }
	[Property] public float Speed { get; set; } = MathF.PI;

	private Rigidbody _rigidbody;

	protected override void OnEnabled()
	{
		_rigidbody = Components.GetInAncestors<Rigidbody>();
	}

	protected override void OnFixedUpdate()
	{
		if ( IsProxy ) return;
		if ( !_rigidbody.IsValid() || Target is null ) return;

		var groundVel = _rigidbody.Velocity;
		Transform.Position = Target.GetCenter();
		Transform.LocalRotation *= Rotation.From( groundVel.Length * Time.Delta * (ReverseRotation ? -1f : 1f) * Speed, 0, 0 );
	}
}
