/** @author Epyi */

namespace Sandbox.Mirage.Vehicles;

/// <summary>
/// Adds a small upwards impulse to other rigid bodies on collision so
/// hitting a prop sends it tumbling instead of grinding against it.
/// Ported from the VehicleSystemExemple "KnockOnContact" component.
/// </summary>
[Category( "Mirage Vehicles" )]
[Title( "Mirage Knock On Contact" )]
public sealed class MirageKnockOnContact : Component, Component.ICollisionListener
{
	[Property] public float Strength { get; set; } = 10f;
	[Property] public Rigidbody Rigidbody { get; set; }

	public void OnCollisionStart( Collision collision )
	{
		if ( !collision.Other.Collider.IsValid() ) return;
		if ( collision.Other.Collider.Static ) return;

		var direction = -collision.Contact.Normal;
		direction = direction.LerpTo( Vector3.Up, 0.8f ).Normal;

		var force = direction * Strength;
		Rigidbody?.ApplyImpulse( force );
	}

	public void OnCollisionStop( CollisionStop collision ) { }
	public void OnCollisionUpdate( Collision collision ) { }
}
