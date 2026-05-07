# Sandbox.Surface.SurfacePrefabCollection

Holds a dictionary of common prefabs associated with a surface

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Surface`

## Properties

- `Sandbox.GameObject BulletImpact`
  - A prefab to spawn when this surface is hit by a bullet. The prefab should be spawned facing the same direction as the hit normal. It could include decals and particle effects. It should be parented to the surface that it hit.
- `Sandbox.GameObject BluntImpact`
  - A prefab to spawn when this surface is hit by something blunt. The prefab should be spawned facing the same direction as the hit normal. It could include decals and particle effects. It should be parented to the surface that it hit.
