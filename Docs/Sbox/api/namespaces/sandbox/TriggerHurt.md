# Sandbox.TriggerHurt

Deals damage to objects inside

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `TriggerHurt()`

## Properties

- `Sandbox.TagSet DamageTags`
  - These tags will be applied to the emitted `Sandbox.DamageInfo`
- `System.Single Damage`
  - How much damage to apply
- `System.Single Rate`
  - The delay between applying the damage
- `Sandbox.TagSet Include`
  - If not empty, the target must have one of these tags
- `Sandbox.TagSet Exclude`
  - If not empty, the target must not have one of these tags
