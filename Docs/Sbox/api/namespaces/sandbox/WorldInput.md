# Sandbox.WorldInput

A router for world input, the best place to put this is on your player's camera.
Uses cursor ray when mouse is active, otherwise the direction of this gameobject.
You could also put this on a VR controller to interact with world panels.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `WorldInput()`

## Properties

- `System.String LeftMouseAction`
  - Which action is our left clicking button?
- `System.String RightMouseAction`
  - Which action is our right clicking button?
- `Sandbox.VR.VRHand.HandSources VRHandSource`
  - If using VR this will be the hand source for input.
- `Sandbox.UI.Panel Hovered`
  - The `Sandbox.UI.Panel` that is currently hovered by this input.
