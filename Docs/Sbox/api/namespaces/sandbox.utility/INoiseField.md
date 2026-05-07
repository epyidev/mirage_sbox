# Sandbox.Utility.INoiseField

A noise function that can be sampled at a 1-, 2-, or 3D position.
Samples will be between `0` and `1`. Thread-safe.

- **Kind:** interface
- **Namespace:** `Sandbox.Utility`
- **Assembly:** `Sandbox.System`

## Methods

### Instance methods

- `virtual System.Single Sample(System.Single x)`
  - Sample at a 1D position.
  - returns: A noise value between `0` and `1`.
- `virtual System.Single Sample(System.Single x, System.Single y)`
  - Sample at a 2D position.
  - returns: A noise value between `0` and `1`.
- `virtual System.Single Sample(System.Single x, System.Single y, System.Single z)`
  - Sample at a 3D position.
  - returns: A noise value between `0` and `1`.
- `virtual System.Single Sample(Vector2 vec)`
  - Sample at a 2D position.
  - returns: A noise value between `0` and `1`.
- `virtual System.Single Sample(Vector3 vec)`
  - Sample at a 3D position.
  - returns: A noise value between `0` and `1`.
