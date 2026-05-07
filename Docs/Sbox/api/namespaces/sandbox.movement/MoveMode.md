# Sandbox.Movement.MoveMode

A move mode for this character

- **Kind:** abstract class
- **Namespace:** `Sandbox.Movement`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `MoveMode()`

## Properties

- `System.Boolean AllowGrounding`
- `System.Boolean AllowFalling`
- `Sandbox.PlayerController Controller`

## Methods

### Instance methods

- `virtual System.Void UpdateAnimator(Sandbox.SkinnedModelRenderer renderer)`
  - Update the animator which is available at Controller.Renderer.
- `virtual System.Void OnUpdateAnimatorVelocity(Sandbox.SkinnedModelRenderer renderer)`
  - Sets animation parameters on `renderer` based on the current
            `Sandbox.PlayerController.Velocity` and `Sandbox.PlayerController.WishVelocity`.
- `virtual System.Void OnUpdateAnimatorState(Sandbox.SkinnedModelRenderer renderer)`
  - Sets animation parameters on `renderer` describing the movement style, like
swimming, falling, or ducking.
- `virtual System.Void OnUpdateAnimatorLookDirection(Sandbox.SkinnedModelRenderer renderer)`
  - Set animation parameters on `renderer` to look towards `Sandbox.Movement.MoveMode.CalculateEyeTransform`.
- `virtual System.Void OnRotateRenderBody(Sandbox.SkinnedModelRenderer renderer)`
  - Updates the `Sandbox.Component.WorldRotation` of `renderer`.
- `virtual Transform CalculateEyeTransform()`
  - Get the position of the player's eye
- `System.Void UpdateCamera(Sandbox.CameraComponent cam)`
  - Called to update the camera each frame
- `virtual System.Int32 Score(Sandbox.PlayerController controller)`
  - Highest number becomes the new control mode
- `virtual System.Void PrePhysicsStep()`
  - Called before the physics step is run
- `virtual System.Void PostPhysicsStep()`
  - Called after the physics step is run
- `virtual System.Void UpdateRigidBody(Sandbox.Rigidbody body)`
- `virtual System.Void AddVelocity()`
- `virtual System.Void OnModeBegin()`
  - This mode has just started
- `virtual System.Void OnModeEnd(Sandbox.Movement.MoveMode next)`
  - This mode has stopped. We're swapping to another move mode.
- `System.Void TrySteppingUp(System.Single maxDistance)`
  - If we're approaching a step, step up if possible
- `System.Void StickToGround(System.Single maxDistance)`
  - If we're on the ground, make sure we stay there by falling to the ground
- `virtual System.Boolean IsStandableSurace(Sandbox.SceneTraceResult& modreq(System.Runtime.InteropServices.InAttribute) result)`
- `virtual System.Boolean IsStandableSurface(Sandbox.SceneTraceResult& modreq(System.Runtime.InteropServices.InAttribute) result)`
- `virtual Vector3 UpdateMove(Rotation eyes, Vector3 input)`
  - Read inputs, return WishVelocity
