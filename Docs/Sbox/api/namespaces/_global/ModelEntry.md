# Sandbox.ParticleModelRenderer.ModelEntry

Entry for a model, including its material group and body group settings.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.ParticleModelRenderer`

## Constructors

- `ModelEntry()`

## Properties

- `Sandbox.Model Model`
  - The model associated with this entry.
- `System.String MaterialGroup`
  - Material group for the model.
- `System.UInt64 BodyGroups`
  - Body group mask for the model.
- `System.Boolean HasMaterialGroups`
  - Indicates whether the model has material groups.
- `System.Boolean HasBodyGroups`
  - Indicates whether the model has body groups.
