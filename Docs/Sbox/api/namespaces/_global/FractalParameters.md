# Sandbox.Utility.Noise.FractalParameters

Parameters for constructing a <a href="https://en.wikipedia.org/wiki/Pink_noise">fractal</a>
noise field, which layers multiple octaves of a noise function with increasing frequency
and reducing amplitudes.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`
- **Base:** `Sandbox.Utility.Noise.Parameters`
- **Declaring type:** `Sandbox.Utility.Noise`

## Constructors

- `FractalParameters(System.Int32 Seed, System.Single Frequency, System.Int32 Octaves, System.Single Gain, System.Single Lacunarity)`
  - Parameters for constructing a <a href="https://en.wikipedia.org/wiki/Pink_noise">fractal</a>
noise field, which layers multiple octaves of a noise function with increasing frequency
and reducing amplitudes.
  - `Seed`: Seed state to initialize the field with.
  - `Frequency`: How quickly should samples change across space.
  - `Octaves`: How many layers of noise to use.
  - `Gain`: How much to multiply the amplitude of each successive octave by.
  - `Lacunarity`: How much to multiply the frequency of each successive octave by.
- `FractalParameters(Sandbox.Utility.Noise.FractalParameters original)`

## Properties

- `System.Type EqualityContract`
- `System.Int32 Octaves`
  - How many layers of noise to use.
- `System.Single Gain`
  - How much to multiply the amplitude of each successive octave by.
- `System.Single Lacunarity`
  - How much to multiply the frequency of each successive octave by.

## Methods

### Instance methods

- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Sandbox.Utility.Noise.FractalParameters <Clone>$()`
- `System.Void Deconstruct(System.Int32 Seed, System.Single Frequency, System.Int32 Octaves, System.Single Gain, System.Single Lacunarity)`
