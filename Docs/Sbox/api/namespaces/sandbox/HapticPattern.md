# Sandbox.HapticPattern

Contains a haptic pattern, which consists of frequency and amplitude values that can change over time.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `HapticPattern(System.Single Length, Sandbox.Curve FrequencyCurve, Sandbox.Curve AmplitudeCurve)`
  - Contains a haptic pattern, which consists of frequency and amplitude values that can change over time.
- `HapticPattern(Sandbox.HapticPattern original)`

## Properties

- `System.Type EqualityContract`
- `System.Single Length`
- `Sandbox.Curve FrequencyCurve`
- `Sandbox.Curve AmplitudeCurve`
- `System.Int32 Position`
- `static Sandbox.HapticPattern SoftImpact`
  - A haptic pattern that represents a light, soft impact.
- `static Sandbox.HapticPattern HardImpact`
  - A haptic pattern that represents a hard, sudden impact.
- `static Sandbox.HapticPattern Rumble`
  - A haptic pattern that represents a constant low-frequency rumble.
- `static Sandbox.HapticPattern Heartbeat`
  - A haptic pattern that feels like a heartbeat.

## Fields

- `System.Single LengthScale`
- `System.Single FrequencyScale`
- `System.Single AmplitudeScale`

## Methods

### Instance methods

- `System.Void GetValue(System.Single t, System.Single frequency, System.Single amplitude)`
- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Sandbox.HapticPattern <Clone>$()`
- `System.Void Deconstruct(System.Single Length, Sandbox.Curve FrequencyCurve, Sandbox.Curve AmplitudeCurve)`
