# Sandbox.VerletRope

Verlet integration-based rope physics simulation component.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `VerletRope()`

## Properties

- `Sandbox.GameObject Attachment`
  - The GameObject the end of the rope attaches to.
- `Sandbox.LineRenderer LinkedRenderer`
  - The LineRenderer used to visualize the rope.
- `System.Single Slack`
  - Additional slack, added to the rope length.
- `System.Int32 SegmentCount`
  - Number of segments in the rope. Higher values increase visual fidelity and collision accuracy but quickly reduce performance.
- `System.Single Radius`
  - Radius of the rope for collision detection.
- `System.Single LengthOverride`
  - Controls the rope's length directly, will override the initial length and slack will not be applied.
When set to 0, the rope's initial length between attachment points is used.
- `System.Single Stiffness`
  - Rope stiffness factor. Higher values make the rope more rigid.
- `System.Single DampingFactor`
  - Dampens rope movement. Higher values make the rope settle faster.
- `System.Single SoftBendFactor`
  - Controls how easily the rope bends. Lower values allow more bending, higher values make it stiffer.

## Methods

### Instance methods

- `virtual System.Void OnEnabled()`
- `virtual System.Void OnUpdate()`
- `virtual System.Void OnDestroy()`
