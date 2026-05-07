# Sandbox.HitboxSet.Box

A single hitbox on the model. This can be a box, sphere or capsule.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.HitboxSet`

## Properties

- `System.String Name`
- `System.String SurfaceName`
- `Sandbox.BoneCollection.Bone Bone`
- `Sandbox.ITagSet Tags`
- `System.Object Shape`
  - Either a Sphere, Capsule or BBox
- `Vector3 RandomPointInside`
  - Get a random point inside this hitbox
- `Vector3 RandomPointOnEdge`
  - Get a random point on the edge this hitbox
