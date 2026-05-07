# Sandbox.ModelEditor.Nodes.ModelPropData

Generic prop settings. Support for this depends on the entity.

- **Kind:** class
- **Namespace:** `Sandbox.ModelEditor.Nodes`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ModelPropData()`

## Properties

- `System.Boolean BakeLighting`
  - When this model is used as prop_static, it will bake lighting by default depending on this value.
- `System.Single Health`
  - When this model is used as prop_physics, it's health will be set to this value.
- `System.Boolean Flammable`
  - If true well treat this prop as flammable, meaning it can catch fire and burn.
- `System.Boolean Explosive`
  - If true we'll explode this prop when it's destroyed
- `System.Single ExplosionDamage`
  - Amount of damage to do at the center on the explosion. It will falloff over distance.
- `System.Single ExplosionRadius`
  - Range of explosion's damage.
- `System.Single ExplosionForce`
  - Scale of the force applied to entities damaged by the explosion and the models break pieces.
- `System.Single MinImpactDamageSpeed`
  - Minimum impact damage speed to break this object.
- `System.Single ImpactDamage`
  - The amount of damage this deals to other objects when it collides at high speed.
If set to -1, this will be calculated from the mass of the rigidbody.
