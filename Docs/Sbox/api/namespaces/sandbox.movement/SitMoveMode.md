# Sandbox.Movement.SitMoveMode

The character is sitting

- **Kind:** sealed class
- **Namespace:** `Sandbox.Movement`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Movement.MoveMode`

## Constructors

- `SitMoveMode()`

## Methods

### Instance methods

- `virtual System.Int32 Score(Sandbox.PlayerController controller)`
  - Score this move mode highly if we're parented to a chair
- `virtual System.Void UpdateAnimator(Sandbox.SkinnedModelRenderer renderer)`
  - Update the animator while sitting in a chair
- `virtual System.Void OnModeBegin()`
  - Entering the chair, disable body and collider
- `virtual System.Void OnModeEnd(Sandbox.Movement.MoveMode next)`
  - Leaving the chair, re-enable body and collider
- `virtual Vector3 UpdateMove(Rotation eyes, Vector3 input)`
  - Move is always zero while sitting
- `virtual Transform CalculateEyeTransform()`
  - Get the eye transform from the chair we're sitting in
