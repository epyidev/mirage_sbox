# Sandbox.HapticEffect

Contains a haptic effect, which consists of patterns for the controller and triggers.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `HapticEffect(Sandbox.HapticPattern controllerPattern, Sandbox.HapticPattern leftTriggerPattern, Sandbox.HapticPattern rightTriggerPattern)`
- `HapticEffect(Sandbox.HapticEffect original)`

## Properties

- `System.Type EqualityContract`
- `System.Single AmplitudeScale`
- `System.Single FrequencyScale`
- `System.Single LengthScale`
- `static Sandbox.HapticEffect SoftImpact`
  - A haptic pattern that represents a light, soft impact.
- `static Sandbox.HapticEffect HardImpact`
  - A haptic pattern that represents a hard, sudden impact.
- `static Sandbox.HapticEffect Rumble`
  - Applies a simple rumble to the controller.
- `static Sandbox.HapticEffect RumbleLeftTrigger`
  - Applies a simple rumble to the left trigger.
- `static Sandbox.HapticEffect RumbleRightTrigger`
  - Applies a simple rumble to the right trigger.
- `static Sandbox.HapticEffect Heartbeat`
  - A haptic effect that feels like a heartbeat.

## Fields

- `Sandbox.HapticPattern ControllerPattern`
- `Sandbox.HapticPattern LeftTriggerPattern`
- `Sandbox.HapticPattern RightTriggerPattern`

## Methods

### Instance methods

- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Sandbox.HapticEffect <Clone>$()`
