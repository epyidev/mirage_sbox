# Sandbox.RadiusDamage

Applies damage in a radius, with physics force, and optional occlusion

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `RadiusDamage()`

## Properties

- `System.Single Radius`
  - The radius of the damage area.
- `System.Single PhysicsForceScale`
  - How much physics force should be applied on explosion?
- `System.Boolean DamageOnEnabled`
  - If enabled we'll apply damage once as soon as enabled
- `System.Boolean Occlusion`
  - Should the world shield victims from damage?
- `System.Single DamageAmount`
  - The amount of damage inflicted
- `Sandbox.TagSet DamageTags`
  - Tags to apply to the damage
- `Sandbox.GameObject Attacker`
  - Who should we credit with this attack?

## Methods

### Static methods

- `static System.Void ApplyDamage(Sandbox.Sphere sphere, Sandbox.DamageInfo damage, System.Single physicsForce, Sandbox.GameObject ignore, System.Boolean occlusion)`

### Instance methods

- `System.Void Apply()`
  - Apply the damage now
