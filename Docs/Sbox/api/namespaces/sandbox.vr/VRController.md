# Sandbox.VR.VRController

Represents a VR controller, along with its transform, velocity, and inputs.

- **Kind:** sealed class
- **Namespace:** `Sandbox.VR`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.VR.TrackedObject`

## Properties

- `Transform Transform`
  - The grip pose transform in world space (centered on palm/grip).
- `Transform AimTransform`
  - The aim pose transform in world space (pointing forward).
- `System.Boolean IsHandTracked`
  - Is this controller currently being represented using full hand tracking?
- `Sandbox.VR.AnalogInput Trigger`
  - The trigger input on this controller
- `Sandbox.VR.AnalogInput Grip`
  - The grip input on this controller
- `Sandbox.VR.AnalogInput2D Joystick`
  - The primary joystick input on this controller
- `Sandbox.VR.DigitalInput JoystickPress`
  - The primary joystick press on this controller
- `Sandbox.VR.DigitalInput ButtonA`
  - The primary button on this controller (Usually A, can be X for Oculus Touch)
- `Sandbox.VR.DigitalInput ButtonB`
  - The secondary button on this controller (Usually B, can be Y for Oculus Touch)

## Methods

### Instance methods

- `Sandbox.Model GetModel()`
  - Retrieves or creates a cached model that can be used to render this controller.
- `System.Void TriggerHapticVibration(System.Single duration, System.Single frequency, System.Single amplitude)`
  - Triggers a haptic vibration event on the controller for this hand.
  - `duration`: How long the haptic action should last (in seconds - can be 0 to "pulse" it)
  - `frequency`: How often the haptic motor should bounce (0 - 320 in hz. The lower end being more useful)
  - `amplitude`: How intense the haptic should be (0 - 1)
- `System.Void StopAllVibrations()`
  - Stop all vibration events on this controller.
- `System.Void TriggerHaptics(Sandbox.HapticEffect effect, System.Single lengthScale, System.Single frequencyScale, System.Single amplitudeScale)`
  - Trigger a vibration based on a predefined `Sandbox.HapticPattern`.
All `Sandbox.HapticPattern`s are normalized (start at 0, peak at 1).
  - `effect`: The pattern to use
  - `lengthScale`: The amount to scale the pattern's length by.
  - `frequencyScale`: The amount to scale the pattern's frequency by.
  - `amplitudeScale`: The amount to scale the pattern's amplitude by.
- `System.Void StopAllHaptics()`
  - Stops all rumble and haptic events on this controller.
- `Sandbox.VR.VRHandJointData[] GetJoints(Sandbox.VR.MotionRange motionRange)`
  - Returns joint data for a specific motion range.
  - `motionRange`: Whether the joints returned represent a raw hand pose, or one that represents the hand wrapping around the controller.
- `System.Single GetFingerValue(Sandbox.VR.FingerValue value)`
  - Get the skeletal value (from 0 to 1) of a specified `Sandbox.VR.FingerValue` - includes curl and splay.
- `System.Single GetFingerCurl(System.Int32 index)`
  - Get the skeletal value (from 0 to 1) of a specified finger curl index.
- `System.Single GetFingerSplay(System.Int32 index)`
  - Get the skeletal value (from 0 to 1) of a specified finger splay index.
- `System.Collections.Generic.List<Sandbox.VR.VRHandJointData> GetJointData()`
- `virtual Sandbox.VR.VRController <Clone>$()`
