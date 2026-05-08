/** @author Epyi */

namespace Sandbox.Mirage.Vehicles;

/// <summary>
/// Physics wheel: ground trace + suspension + friction force. Ported
/// from the VehicleSystemExemple "Wheel" component, kept under the
/// Mirage namespace so prefabs that reference it never depend on a
/// third-party assembly.
/// </summary>
[Category( "Mirage Vehicles" )]
[Title( "Mirage Wheel" )]
[Icon( "sync" )]
public sealed class MirageWheel : Component
{
	[Property] public float MinSuspensionLength { get; set; } = 0f;
	[Property] public float MaxSuspensionLength { get; set; } = 8f;
	[Property] public float SuspensionStiffness { get; set; } = 3000.0f;
	[Property] public float SuspensionDamping { get; set; } = 140.0f;
	[Property] public float WheelRadius { get; set; } = 14.0f;

	[Property] public MirageWheelFrictionInfo ForwardFriction { get; set; }
	[Property] public MirageWheelFrictionInfo SideFriction { get; set; }

	public bool IsGrounded => _groundTrace.Hit;

	private const float LowSpeedThreshold = 32.0f;

	private SceneTraceResult _groundTrace;
	private Rigidbody _rigidbody;
	private float _motorTorque;
	private float _suspensionTotalLength;

	protected override void OnEnabled()
	{
		_rigidbody = Components.GetInAncestorsOrSelf<Rigidbody>();
		_suspensionTotalLength = (MaxSuspensionLength + WheelRadius) - MinSuspensionLength;
	}

	protected override void OnFixedUpdate()
	{
		if ( !_rigidbody.IsValid() ) return;

		DoTrace();

		if ( IsProxy ) return;

		UpdateSuspension();
		UpdateWheelForces();
	}

	public void ApplyMotorTorque( float value )
	{
		_motorTorque = value;
	}

	private void UpdateWheelForces()
	{
		if ( !IsGrounded ) return;

		var forwardDir = Transform.Rotation.Forward;
		var sideDir = Transform.Rotation.Right;
		var wheelVelocity = _rigidbody.GetVelocityAtPoint( Transform.Position );
		var wheelSpeed = wheelVelocity.Length;

		float sideSlip = CalculateSlip( wheelVelocity, sideDir, wheelSpeed );
		float forwardSlip = CalculateSlip( wheelVelocity, forwardDir, wheelSpeed );

		var sideForce = CalculateFrictionForce( SideFriction, sideSlip, sideDir );
		var forwardForce = CalculateFrictionForce( ForwardFriction, forwardSlip, forwardDir );

		float factor = wheelSpeed.LerpInverse( 0f, LowSpeedThreshold );
		float groundFriction = _groundTrace.Surface.Friction;

		var targetAcceleration = (sideForce + forwardForce) * factor * groundFriction;
		targetAcceleration += _motorTorque * Transform.Rotation.Forward;

		var force = targetAcceleration / Time.Delta;
		_rigidbody.ApplyForceAt( GameObject.Transform.Position, force );
	}

	private static float CalculateSlip( Vector3 velocity, Vector3 direction, float speed )
	{
		const float epsilon = 0.01f;
		return Vector3.Dot( velocity, direction ) / (speed + epsilon);
	}

	private static Vector3 CalculateFrictionForce( MirageWheelFrictionInfo friction, float slip, Vector3 direction )
	{
		return -friction.Evaluate( MathF.Abs( slip ) ) * MathF.Sign( slip ) * direction;
	}

	public Vector3 GetCenter()
	{
		var up = _rigidbody.Transform.Rotation.Up;
		return _groundTrace.EndPosition + up * WheelRadius;
	}

	private void UpdateSuspension()
	{
		if ( !IsGrounded ) return;

		var worldVelocity = _rigidbody.GetVelocityAtPoint( Transform.Position );
		var suspensionCompression = _groundTrace.Distance - _suspensionTotalLength;

		var dampingForce = -SuspensionDamping * worldVelocity.z;
		var springForce = -SuspensionStiffness * suspensionCompression;
		var totalForce = (dampingForce + springForce) / Time.Delta;

		var suspensionForce = new Vector3( 0, 0, totalForce );
		_rigidbody.ApplyForceAt( Transform.Position, suspensionForce );
	}

	private void DoTrace()
	{
		var down = _rigidbody.Transform.Rotation.Down;
		var startPos = Transform.Position + down * MinSuspensionLength;
		var endPos = startPos + down * (MaxSuspensionLength + WheelRadius);

		_groundTrace = Scene.Trace
				.Radius( 1f )
				.IgnoreGameObjectHierarchy( GameObject )
				.WithoutTags( "vehicle" )
				.FromTo( startPos, endPos )
				.Run();
	}

	protected override void DrawGizmos()
	{
		if ( !Gizmo.IsSelected ) return;
		Gizmo.Draw.IgnoreDepth = true;

		var suspensionStart = Vector3.Zero - Vector3.Down * MinSuspensionLength;
		var suspensionEnd = Vector3.Zero + Vector3.Down * MaxSuspensionLength;
		Gizmo.Draw.Color = Color.Cyan;
		Gizmo.Draw.LineThickness = 0.25f;
		Gizmo.Draw.Line( suspensionStart, suspensionEnd );

		Gizmo.Draw.LineThickness = 1.0f;
		Gizmo.Draw.Color = Color.White;
		Gizmo.Draw.LineCircle( Vector3.Zero, Vector3.Right, WheelRadius );

		var arrowStart = Vector3.Forward * WheelRadius;
		var arrowEnd = arrowStart + Vector3.Forward * 8f;
		Gizmo.Draw.Color = Color.Red;
		Gizmo.Draw.Arrow( arrowStart, arrowEnd, 4, 1 );
	}
}
