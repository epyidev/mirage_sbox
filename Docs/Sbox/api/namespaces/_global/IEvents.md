# Sandbox.PlayerController.IEvents

Events from the PlayerController

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.PlayerController`

## Methods

### Instance methods

- `virtual System.Void OnEyeAngles(Angles angles)`
  - Our eye angles are changing. Allows you to change the sensitivity, or stomp all together.
- `virtual System.Void PostCameraSetup(Sandbox.CameraComponent cam)`
  - Called after we've set the camera up
- `virtual System.Void OnJumped()`
  - The player has just jumped
- `virtual System.Void OnLanded(System.Single distance, Vector3 impactVelocity)`
  - The player has landed on the ground, after falling this distance.
- `virtual Sandbox.Component GetUsableComponent(Sandbox.GameObject go)`
  - Used by the Using system to find components we can interact with.
By default we can only interact with IPressable components.
Return a component if we can use it, or else return null.
- `virtual System.Void StartPressing(Sandbox.Component target)`
  - We have started using something (use was pressed)
- `virtual System.Void StopPressing(Sandbox.Component target)`
  - We have stopped using something
- `virtual System.Void FailPressing()`
  - We pressed USE but it did nothing
- `virtual System.Void PreInput()`
  - We have a chance to do something before input is processed
