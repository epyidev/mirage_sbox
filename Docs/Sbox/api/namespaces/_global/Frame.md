# Sandbox.Curve.Frame

Keyframes times and values should range between 0 and 1

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`
- **Declaring type:** `Sandbox.Curve`

## Constructors

- `Frame(System.Single timedelta, System.Single valuedelta)`
- `Frame(System.Single timedelta, System.Single valuedelta, System.Single inTangent, System.Single outTangent)`

## Properties

- `System.Single Time`
  - The delta position on the time line (0-1)
- `System.Single Value`
  - The delta position on the value line (0-1)
- `System.Single In`
  - This is the slope of entry, formula is something like tan( angle )
- `System.Single Out`
  - This is the slope of exit, formula is something like tan( angle )
- `Sandbox.Curve.HandleMode Mode`
  - How the line should behave when entering/leaving this frame

## Methods

### Instance methods

- `Sandbox.Curve.Frame WithTime(System.Single time)`
- `Sandbox.Curve.Frame WithValue(System.Single value)`
- `virtual System.Int32 CompareTo(Sandbox.Curve.Frame other)`
