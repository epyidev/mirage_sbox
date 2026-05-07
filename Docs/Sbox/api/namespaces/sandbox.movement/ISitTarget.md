# Sandbox.Movement.ISitTarget

A component that can be sat in by a player. If the player is parented to an object with this component, they will be sitting in it.

- **Kind:** interface
- **Namespace:** `Sandbox.Movement`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `virtual System.Void UpdatePlayerAnimator(Sandbox.PlayerController controller, Sandbox.SkinnedModelRenderer renderer)`
  - Here you can set any animator parameters needed for sitting in this chair
- `virtual Transform CalculateEyeTransform(Sandbox.PlayerController controller)`
  - Get the transform representing the eye position when seated. This is the first person
eye position, not the third person camera position.
- `virtual System.Void AskToLeave(Sandbox.PlayerController controller)`
  - Player wants to leave the chair
