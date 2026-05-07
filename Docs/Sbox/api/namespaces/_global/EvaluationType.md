# Sandbox.ParticleFloat.EvaluationType

- **Kind:** enum
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`
- **Declaring type:** `Sandbox.ParticleFloat`

## Values

- `Life` - Evaluates the value based on the lifetime using its normalized age.
- `Frame` - Evaluates the value based on the current frame, introducing randomness for dynamic effects.
- `Seed` - Evaluates the value based on a random seed. This means that in most situations, it's random per context.
Like if this is on a particle, the value will be random per particle.
- `Particle`
