# Sandbox.Movement.MoveModeWalk

The character is walking

- **Kind:** class
- **Namespace:** `Sandbox.Movement`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Movement.MoveMode`

## Constructors

- `MoveModeWalk()`

## Properties

- `System.Int32 Priority`
- `System.Single GroundAngle`
- `System.Single StepUpHeight`
- `System.Single StepDownHeight`
- `System.Boolean AllowGrounding`
- `System.Boolean AllowFalling`

## Methods

### Instance methods

- `virtual System.Int32 Score(Sandbox.PlayerController controller)`
- `virtual System.Void AddVelocity()`
- `virtual System.Void PrePhysicsStep()`
- `virtual System.Void PostPhysicsStep()`
- `virtual System.Boolean IsStandableSurface(Sandbox.SceneTraceResult& modreq(System.Runtime.InteropServices.InAttribute) result)`
- `virtual Vector3 UpdateMove(Rotation eyes, Vector3 input)`
