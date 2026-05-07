# Sandbox.DamageInfo

Describes the damage that should be done to something. This is purposefully a class
so it can be derived from, allowing games to create their own special types of damage, while
not having to create a whole new system.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `DamageInfo()`
- `DamageInfo(System.Single damage, Sandbox.GameObject attacker, Sandbox.GameObject weapon)`
- `DamageInfo(System.Single damage, Sandbox.GameObject attacker, Sandbox.GameObject weapon, Sandbox.Hitbox hitbox)`

## Properties

- `Sandbox.GameObject Attacker`
  - Usually a player or Npc
- `Sandbox.GameObject Weapon`
  - The weapon that did the damage, or a vehicle etc
- `Sandbox.Hitbox Hitbox`
  - The hitbox that we hit (if any)
- `System.Single Damage`
  - Amount of damage this should do
- `Vector3 Origin`
  - The origin of the damage. For bullets this would be the shooter's eye position. For explosions, this would be the center of the exposion.
- `Vector3 Position`
  - The location of the damage on the hit object.
- `Sandbox.PhysicsShape Shape`
  - The physics shape that we hit (if any)
- `Sandbox.TagSet Tags`
  - Tags for this damage, allows you to enter and read different damage types etc
- `System.Boolean IsExplosion`
  - True if this is explosive damage
