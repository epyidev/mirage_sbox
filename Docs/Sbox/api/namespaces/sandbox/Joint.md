# Sandbox.Joint

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `Joint()`

## Properties

- `Sandbox.Joint.AttachmentMode Attachment`
  - Are local frames calculated automatically or set manually. See `Sandbox.Joint.LocalFrame1`, `Sandbox.Joint.LocalFrame2`
- `Transform LocalFrame1`
  - Only used on joint creation. See `Sandbox.Joint.AttachmentMode.LocalFrames`
- `Transform LocalFrame2`
  - Only used on joint creation. See `Sandbox.Joint.AttachmentMode.LocalFrames`
- `Sandbox.GameObject AnchorBody`
  - The body this joint is anchored to. If this is null then it will use the current GameObject as the anchor.
- `Sandbox.GameObject Body`
  - Game object to find the body to attach this joint to.
- `System.Boolean EnableCollision`
  - Enable or disable collision between the two bodies.
- `System.Boolean StartBroken`
  - Is the joint broken on start.
- `System.Single BreakForce`
  - Strength of the linear constraint. If it takes any more energy than this, it'll break.
- `System.Single BreakTorque`
  - Strength of the angular constraint. If it takes any more energy than this, it'll break.
- `System.Action OnBreak`
  - Called when the joint breaks.
- `System.Single LinearStress`
  - Current linear stress applied to the joint.
- `System.Single AngularStress`
  - Current angular stress applied to the joint.
- `System.Boolean IsBroken`
  - Is the joint currently broken and inactive.
- `Sandbox.PhysicsBody Body1`
  - The source physics body this joint is attached to.
- `Sandbox.GameObject Object1`
  - The source GameObject we're connected to
- `Sandbox.PhysicsBody Body2`
  - The target physics body this joint is constraining.
- `Sandbox.GameObject Object2`
  - The target GameObject we're connected to
- `Sandbox.Physics.PhysicsPoint Point1`
  - A specific point this joint is attached at on `Sandbox.Joint.Body1`
- `Sandbox.Physics.PhysicsPoint Point2`
  - A specific point this joint is attached at on `Sandbox.Joint.Body2`

## Methods

### Instance methods

- `virtual System.Void OnStart()`
- `virtual System.Void OnDestroy()`
- `virtual System.Void OnEnabled()`
- `virtual System.Void OnDisabled()`
- `virtual Sandbox.Physics.PhysicsJoint CreateJoint(Sandbox.Physics.PhysicsPoint point1, Sandbox.Physics.PhysicsPoint point2)`
  - Joint type implementation.
- `virtual System.Void DestroyJoint()`
- `System.Void Break()`
- `System.Void Unbreak()`
- `virtual System.Void DrawGizmos()`
