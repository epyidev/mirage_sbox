# Sandbox.VR.VRInput

- **Kind:** class
- **Namespace:** `Sandbox.VR`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static Sandbox.VR.VRInput Current`
  - The current relevant `Sandbox.VR.VRInput` instance.
- `System.Single Scale`
  - Get or set the player's scale in the world. If you set it to 2 the player will be twice as big.
- `Transform Anchor`
  - Gets or sets where the center of the VR play area is in world space.
- `System.Boolean ControllersAreDrawing`
  - Returns true if SteamVR is drawing the controllers
- `System.Boolean IsLeftHandDominant`
  - Returns true if the left hand is dominant
- `Transform Head`
  - Position and rotation of the Head Mounted Display in local space coordinates.
- `Sandbox.VR.VRController LeftHand`
  - Information about the left hand input.
- `Sandbox.VR.VRController RightHand`
  - Information about the right hand input.
- `System.Collections.Generic.IReadOnlyList<Sandbox.VR.TrackedObject> TrackedObjects`
  - A list of available trackers.
