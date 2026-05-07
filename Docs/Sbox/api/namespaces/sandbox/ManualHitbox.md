# Sandbox.ManualHitbox

A hitbox that can be placed manually on a GameObject, instead of coming from a model

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `ManualHitbox()`

## Properties

- `Sandbox.GameObject Target`
  - The target GameObject to report in trace hits. If this is unset we'll default to the gameobject on which this component is.
- `Sandbox.ManualHitbox.HitboxShape Shape`
- `System.Single Radius`
- `Vector3 CenterA`
- `Vector3 CenterB`
- `Sandbox.TagSet HitboxTags`

## Methods

### Instance methods

- `System.Void Rebuild()`
- `System.Void UpdatePositions()`
