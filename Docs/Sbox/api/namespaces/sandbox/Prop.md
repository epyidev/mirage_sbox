# Sandbox.Prop

A prop is defined by its model. The model can define its health and what happens when it breaks.
This component is designed to be easy to use - since you only need to define the model. Although you can 
access the procedural (hidden) components, they aren't saved, so it's a waste of time.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `Prop()`

## Properties

- `Sandbox.Model Model`
- `System.UInt64 BodyGroups`
- `System.String MaterialGroup`
- `Color Tint`
- `System.Boolean HasMaterialGroups`
- `System.Boolean HasBodyGroups`
- `System.Single Health`
- `System.Boolean IsStatic`
  - If the prop is static - it won't have dynamic physics. This is usually used for things that
you want to be breakable but don't move. Like fences and stuff.
- `System.Boolean StartAsleep`
  - Physics will be asleep until it's woken up.
- `System.Action OnPropBreak`
- `System.Action<Sandbox.DamageInfo> OnPropTakeDamage`
- `System.Boolean IsFlammable`
  - True if this prop can be set on fire.
- `System.Boolean IsOnFire`
- `Sandbox.GameObject LastAttacker`

## Methods

### Instance methods

- `System.Void OnDamage(Sandbox.DamageInfo damage)`
- `System.Void Ignite()`
- `System.Void Kill()`
- `System.Void CreateExplosion()`
- `System.Void NetworkCreateGibs()`
  - Create the gibs for this prop breaking, over the network. This causes clients to spawn the gibs too.
- `System.Collections.Generic.List<Sandbox.Gib> CreateGibs()`
  - Create the gibs and return them.
- `System.Void Break()`
  - Delete this component and split into the procedural components that this prop created.
