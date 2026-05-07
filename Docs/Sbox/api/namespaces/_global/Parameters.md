# Sandbox.Utility.Noise.Parameters

Parameters for constructing a noise field. Use `Sandbox.Utility.Noise.FractalParameters` if you
want a noise field made from multiple octaves.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`
- **Declaring type:** `Sandbox.Utility.Noise`

## Constructors

- `Parameters(System.Int32 Seed, System.Single Frequency)`
  - Parameters for constructing a noise field. Use `Sandbox.Utility.Noise.FractalParameters` if you
want a noise field made from multiple octaves.
  - `Seed`: Seed state to initialize the field with.
  - `Frequency`: How quickly should samples change across space.
- `Parameters(Sandbox.Utility.Noise.Parameters original)`

## Properties

- `System.Type EqualityContract`
- `System.Int32 Seed`
  - Seed state to initialize the field with.
- `System.Single Frequency`
  - How quickly should samples change across space.

## Methods

### Instance methods

- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Sandbox.Utility.Noise.Parameters <Clone>$()`
- `System.Void Deconstruct(System.Int32 Seed, System.Single Frequency)`
