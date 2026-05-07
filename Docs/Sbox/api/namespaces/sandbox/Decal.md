# Sandbox.Decal

The Decal component projects textures onto model's opaque or transparent surfaces.
They inherit and modify the PBR properties of the surface they're projected on.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `Decal()`

## Properties

- `System.Collections.Generic.List<Sandbox.DecalDefinition> Decals`
- `Sandbox.Texture ColorTexture`
- `Sandbox.Texture NormalTexture`
- `Sandbox.Texture RMOTexture`
- `Sandbox.ParticleFloat LifeTime`
  - How long should this decal live for?
- `System.Boolean Looped`
  - If true then the decal will repeat itself forever
- `System.Boolean Transient`
  - If true then this decal will automatically get removed when maxdecals are exceeded. This is good for
things like bullect impacts, where you want to keep them around for as long as possible but also
don't want to have an unlimited amount of them hanging around.

Note that while the component will be destroyed, you probably want a TemporaryEffect component on the 
GameObject to make sure it all gets fully deleted.
- `Vector2 Size`
  - A 2D size of the decal in world units.
- `Sandbox.ParticleFloat Scale`
  - Scale the width and height by this value
- `Sandbox.ParticleFloat Rotation`
  - Rotation angle of the decal in degrees
- `System.Single Depth`
  - The depth of the decal in world units. This is how far the decal extends into the surface it is projected onto.
- `Sandbox.ParticleFloat Parallax`
  - Parallax depth strength of the decal
- `Sandbox.ParticleGradient ColorTint`
  - Tints the color of the decal's albedo and can be used to adjust the overall opacity of the decal.
- `Sandbox.ParticleFloat ColorMix`
  - Controls the opacity of the decal's color texture without reducing the impact of the normal or rmo texture.
Set to 0 to create a normal/rmo only decal masked by the color textures alpha.
- `System.Single AttenuationAngle`
  - Attenuation angle controls how much the decal fades at an angle.
At 0 it does not fade at all. Up to 1 it fades the most.
- `System.UInt32 SortLayer`
  - Determines the order the decal gets rendered in, the higher the layer the more priority it has.
Decals on the same layer get automatically sorted by their GameObject ID.
- `System.Boolean SheetSequence`
- `System.UInt32 SequenceId`
  - Which sequence to use
- `BBox WorldBounds`
  - Get the world bounds of this decal
- `System.Int32 ComponentVersion`

## Methods

### Static methods

- `static System.Void Upgrader_v2(System.Text.Json.Nodes.JsonObject json)`
- `static System.Void Upgrader_v3(System.Text.Json.Nodes.JsonObject json)`
