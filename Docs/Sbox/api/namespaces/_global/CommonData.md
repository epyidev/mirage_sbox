# Sandbox.Model.CommonData

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Model`

## Properties

- `System.Single Health`
  - If the prop is destructable this is its start health
- `System.Boolean Flammable`
  - Should this prop explode when destroyed? If so, this is the radius of the damage from it.
- `System.Boolean Explosive`
  - Should this prop explode when destroyed? If so, this is the radius of the damage from it.
- `System.Single ExplosionRadius`
  - Should this prop explode when destroyed? If so, this is the radius of the damage from it.
- `System.Single ExplosionDamage`
  - Should this prop explode when destroyed? If so, this is the radius of the damage from it.
- `System.Single ExplosionForce`
  - Should this prop explode when destroyed? If so, this is the physics push force from it.
- `System.Single MinImpactDamageSpeed`
  - Minimum impact damage speed to break this object.
- `System.Single ImpactDamage`
  - The amount of damage this deals to other objects when it collides at high speed.
If set to -1, this will be calculated from the mass of the rigidbody.
