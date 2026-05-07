# RangedFloat

A float between two values, which can be randomized or fixed.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `RangedFloat(System.Single fixedValue)`
  - Initialize the float as a fixed value.
- `RangedFloat(System.Single min, System.Single max)`
  - Initialize the float as a random value between given min and max.
  - `min`: The minimum possible value for this float.
  - `max`: The maximum possible value for this float.

## Properties

- `System.Single Min`
  - The minimum value of the float range.
- `System.Single Max`
  - The maximum value of the float range. For `RangedFloat.RangeType.Fixed`,
this will be the same as `RangedFloat.Min`.
- `System.Single FixedValue`
  - The fixed value. Setting this will convert us to a fixed value
- `Vector2 RangeValue`
  - The range value. Setting this will convert us to a range value
- `RangedFloat.RangeType Range`
  - Range type of this float.

## Fields

- `System.Single x`
- `System.Single y`

## Methods

### Static methods

- `static RangedFloat Parse(System.String str)`
  - Parse a ranged float from a string. Format is `"min[ max]"`.

### Instance methods

- `System.Single GetValue()`
  - Returns the final value of this ranged float, randomizing between min and max values.
- `System.Void Deconstruct(System.Single min, System.Single max)`
