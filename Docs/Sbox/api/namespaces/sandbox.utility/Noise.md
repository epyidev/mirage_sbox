# Sandbox.Utility.Noise

Provides access to coherent noise utilities.
            
All of these functions should return between 0 and 1.

- **Kind:** static class
- **Namespace:** `Sandbox.Utility`
- **Assembly:** `Sandbox.System`

## Methods

### Static methods

- `static System.Single Perlin(System.Single x, System.Single y)`
  - 2D <a href="https://en.wikipedia.org/wiki/Perlin_noise">Perlin noise</a> function.
For a thread-safe alternative with more options, use `Sandbox.Utility.Noise.PerlinField(Sandbox.Utility.Noise.Parameters)`.
  - `x`: Input on the X axis.
  - `y`: Input on the Y axis.
  - returns: Resulting noise at given coordinates, in range of 0 to 1.
- `static System.Single Perlin(System.Single x, System.Single y, System.Single z)`
  - 3D <a href="https://en.wikipedia.org/wiki/Perlin_noise">Perlin noise</a> function.
For a thread-safe alternative with more options, use `Sandbox.Utility.Noise.PerlinField(Sandbox.Utility.Noise.Parameters)`.
  - `x`: Input on the X axis.
  - `y`: Input on the Y axis.
  - `z`: Input on the Z axis.
  - returns: Resulting noise at given coordinates, in range of 0 to 1.
- `static System.Single Simplex(System.Single x, System.Single y)`
  - 2D <a href="https://en.wikipedia.org/wiki/Simplex_noise">Simplex noise</a> function.
For a thread-safe alternative with more options, use `Sandbox.Utility.Noise.SimplexField(Sandbox.Utility.Noise.Parameters)`.
  - `x`: Input on the X axis.
  - `y`: Input on the Y axis.
  - returns: Resulting noise at given coordinates, in range of 0 to 1.
- `static System.Single Simplex(System.Single x, System.Single y, System.Single z)`
  - 3D <a href="https://en.wikipedia.org/wiki/Simplex_noise">Simplex noise</a> function.
For a thread-safe alternative with more options, use `Sandbox.Utility.Noise.SimplexField(Sandbox.Utility.Noise.Parameters)`.
  - `x`: Input on the X axis.
  - `y`: Input on the Y axis.
  - `z`: Input on the Z axis.
  - returns: Resulting noise at given coordinates, in range of 0 to 1.
- `static System.Single Fbm(System.Int32 octaves, System.Single x, System.Single y, System.Single z)`
  - <a href="https://en.wikipedia.org/wiki/Fractional_Brownian_motion">Fractional Brownian Motion</a> noise, a.k.a. Fractal Perlin noise.
            For a thread-safe alternative with more options, use `Sandbox.Utility.Noise.PerlinField(Sandbox.Utility.Noise.Parameters)` with `Sandbox.Utility.Noise.FractalParameters`.
  - `octaves`: Number of octaves for the noise. Higher values are slower but produce more detailed results. 3 is a good starting point.
  - `x`: Input on the X axis.
  - `y`: Input on the Y axis.
  - `z`: Input on the Z axis.
  - returns: Resulting noise at given coordinates, in range of 0 to 1.
- `static Vector3 FbmVector(System.Int32 octaves, System.Single x, System.Single y)`
  - <a href="https://en.wikipedia.org/wiki/Fractional_Brownian_motion">Fractional Brownian Motion</a> noise, a.k.a. Fractal Perlin noise.
  - `octaves`: Number of octaves for the noise. Higher values are slower but produce more detailed results. 3 is a good starting point.
  - `x`: Input on the X axis.
  - `y`: Input on the Y axis.
- `static Sandbox.Utility.INoiseField ValueField(Sandbox.Utility.Noise.Parameters parameters)`
  - Creates a <a href="https://en.wikipedia.org/wiki/Value_noise">Value noise</a> field,
effectively smoothly sampled white noise. Use a `Sandbox.Utility.Noise.FractalParameters` for the
field to have multiple octaves.
- `static Sandbox.Utility.INoiseField PerlinField(Sandbox.Utility.Noise.Parameters parameters)`
  - Creates a <a href="https://en.wikipedia.org/wiki/Perlin_noise">Perlin noise</a> field,
which smoothly samples a grid of random gradients. Use a `Sandbox.Utility.Noise.FractalParameters`
for the field to have multiple octaves.
- `static Sandbox.Utility.INoiseField SimplexField(Sandbox.Utility.Noise.Parameters parameters)`
  - Creates a <a href="https://en.wikipedia.org/wiki/Simplex_noise">Simplex noise</a> field,
a cheaper gradient noise function similar to `Sandbox.Utility.Noise.PerlinField(Sandbox.Utility.Noise.Parameters)`. Use a
`Sandbox.Utility.Noise.FractalParameters` for the field to have multiple octaves.
