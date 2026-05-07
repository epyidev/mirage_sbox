# Sandbox.ModelHitboxes

Hitboxes from a model

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `ModelHitboxes()`

## Properties

- `Sandbox.SkinnedModelRenderer Renderer`
  - The target SkinnedModelRenderer that holds the model/skeleton you want to 
take the hitboxes from.
- `Sandbox.GameObject Target`
  - The target GameObject to report in trace hits. If this is unset we'll defaault to the gameobject on which this component is.

## Methods

### Instance methods

- `System.Void Rebuild()`
- `System.Void UpdatePositions()`
- `System.Void AddHitbox(Sandbox.Hitbox hitbox)`
