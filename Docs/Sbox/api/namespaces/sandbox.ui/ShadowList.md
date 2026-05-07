# Sandbox.UI.ShadowList

A list of shadows

- **Kind:** sealed class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Collections.Generic.List<Sandbox.UI.Shadow>`

## Constructors

- `ShadowList()`

## Fields

- `System.Boolean IsNone`
  - Whether there are no shadows at all.

## Methods

### Instance methods

- `System.Void AddFrom(Sandbox.UI.ShadowList other)`
  - Copy shadows from another list of shadows.
- `System.Void SetFromLerp(Sandbox.UI.ShadowList a, Sandbox.UI.ShadowList b, System.Single frac)`
  - Given 2 lists of shadows, perform linear interpolation on both lists and store the result in this list.
Will work with mismatched shadow counts.
  - `a`: The first list of shadows.
  - `b`: The second list of shadows.
  - `frac`: Fraction for the linear interpolation, in range of [0,1]
