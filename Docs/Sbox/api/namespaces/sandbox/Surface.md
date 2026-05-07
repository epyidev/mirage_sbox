# Sandbox.Surface

A physics surface. This is applied to each <see cref="T:Sandbox.PhysicsShape">PhysicsShape</see> and controls its physical properties and physics related sounds.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameResource`

## Constructors

- `Surface()`

## Properties

- `System.UInt32 NameHash`
- `System.Int32 Index`
- `System.String BaseSurface`
  - Filepath of the base surface. Use <see cref="M:Sandbox.Surface.SetBaseSurface(System.String)">SetBaseSurface</see> and <see cref="M:Sandbox.Surface.GetBaseSurface">GetBaseSurface</see>.
- `Sandbox.AudioSurface AudioSurface`
  - Defines the audio properties of this surface for Steam Audio
- `System.String Description`
  - A concise description explaining what this surface property should be used for.
- `System.Single Friction`
  - Friction of this surface material.
- `System.Single Elasticity`
  - Controls bounciness.
- `System.Single Density`
  - Density of this surface material. This affects things like automatic mass calculation.
Density is in kg/m^3.
- `System.Single RollingResistance`
  - Controls how easily rolling shapes (sphere, capsule) roll on surfaces.
- `System.Single BounceThreshold`
  - Velocity threshold, below which objects will not bounce due to their elasticity.
- `System.Single FluidLinearDrag`
  - Linear drag applied when submerged.
- `System.Single FluidAngularDrag`
  - Angular drag applied when submerged.
- `System.Single Dampening`
- `Sandbox.Surface.ImpactEffectData ImpactEffects`
  - Impact effects of this surface material.
- `Sandbox.Surface.ScrapeEffectData ScrapeEffects`
  - Scrape effects of this surface material.
- `Sandbox.Surface.OldSoundData Sounds`
  - Sounds associated with this surface material.
- `Sandbox.Surface.SurfacePrefabCollection PrefabCollection`
  - Common prefabs for this surface material
- `Sandbox.Surface.SurfaceSoundCollection SoundCollection`
  - Sounds for this surface material
- `System.String Tags`
  - A list of tags as one string.

## Methods

### Static methods

- `static Sandbox.Surface FindByName(System.String name)`
  - Returns a Surface from its name, or null
  - `name`: The name of a surface property to look up
  - returns: The surface with given name, or null if such surface property doesn't exist

### Instance methods

- `Sandbox.Surface GetBaseSurface()`
  - Returns the base surface of this surface, or null if we are the default surface.
- `System.Void SetBaseSurface(System.String name)`
  - Sets the base surface by name.
- `virtual System.Void PostLoad()`
- `virtual System.Void PostReload()`
- `virtual System.Void OnDestroy()`
- `virtual Sandbox.Bitmap CreateAssetTypeIcon(System.Int32 width, System.Int32 height)`
- `Sandbox.SoundHandle PlayCollisionSound(Vector3 position, System.Single speed)`
  - Play a collision sound based on this shape's surface. Can return null if sound is invalid, or too quiet to play.
- `System.Boolean HasTag(System.String tag)`
  - Do we have a tag?
- `System.Boolean HasAllTags(System.String[] tags)`
  - Do we have all the tags on this hitbox?
  - returns: True if all tags match, false if any tag does not match.
- `System.Boolean HasAnyTags(System.String[] tags)`
  - Do we have all the tags on this hitbox?
  - returns: True if any tag matches, false if all tags do not match.
