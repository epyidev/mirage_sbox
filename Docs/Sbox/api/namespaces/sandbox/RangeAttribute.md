# Sandbox.RangeAttribute

Mark this property as a ranged float/int. In inspector we'll be able to create a slider
instead of a text entry.

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `RangeAttribute(System.Single min, System.Single max)`
- `RangeAttribute(System.Single min, System.Single max, System.Boolean clamped, System.Boolean slider)`
- `RangeAttribute(System.Single min, System.Single max, System.Single step, System.Boolean clamped, System.Boolean slider)`

## Properties

- `System.Single Min`
  - The minimum value of the range.
- `System.Single Max`
  - The maximum value of the range.
- `System.Boolean Slider`
  - Whether or not a slider should be shown for this range.
- `System.Boolean Clamped`
  - Whether or not the value should be clamped to the range.
If false, the user can manually enter values outside the range if they wish.
- `System.Single Step`
