# Sandbox.ModelArchetype

Default model archetypes.
These types are defined in "tools/model_archetypes.txt".

- **Kind:** enum
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`

## Values

- `static_prop_model` - A static model. It can still have collisions, but they do not have physics.
- `animated_model` - Animated model. Typically no physics.
- `physics_prop_model` - A generic physics enabled model.
- `jointed_physics_model` - A ragdoll type model.
- `breakable_prop_model` - A physics model that can be broken into other physics models.
- `generic_actor_model` - A generic actor/NPC model.
