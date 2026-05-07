# Sandbox.Material

A material. Uses several `Sandbox.Texture`s and a `Sandbox.Material.Shader` with specific settings for more interesting visual effects.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Resource`

## Properties

- `System.Boolean IsValid`
- `System.String Name`
  - Name (or path) of the material.
- `Sandbox.RenderAttributes Attributes`
  - Access to all of the attributes of this material.
- `Sandbox.Material.FlagsAccessor Flags`
  - Access flags on this material, which usually hint about the contents. These are generally added by 
the shader procedurally - but developers can add these in material editor too.
- `System.String ShaderName`
  - Gets the underlying shader name for this material.
- `Sandbox.Texture FirstTexture`
  - Get thje first texture assigned to this material, if any.
- `Sandbox.Shader Shader`
  - Gets the material's shader

## Methods

### Static methods

- `static Sandbox.Material Load(System.String filename)`
  - Load a material from disk. Has internal cache.
  - `filename`: The filepath to load the material from.
  - returns: The loaded material, or null
- `static System.Threading.Tasks.Task<Sandbox.Material> LoadAsync(System.String filename)`
  - Load a material from disk. Has internal cache.
  - `filename`: The filepath to load the material from.
  - returns: The loaded material, or null
- `static Sandbox.Material Create(System.String materialName, System.String shader, System.Boolean anonymous)`
  - Create a new empty material at runtime.
  - `materialName`: Name of the new material.
  - `shader`: Shader that the new material will use.
  - `anonymous`: If false, material can be found by name.
  - returns: The new material.
- `static Sandbox.Material FromShader(Sandbox.Shader shader)`
  - Get an empty material based on the specified shader. This will cache the material so that subsequent calls
will return the same material.
- `static Sandbox.Material FromShader(System.String path)`
  - Get an empty material based on the specified shader. This will cache the material so that subsequent calls
will return the same material.

### Instance methods

- `Sandbox.Material CreateCopy(System.String name)`
  - Create a copy of this material
- `System.Void SetFeature(System.String name, System.Int32 value)`
  - Set a feature flag on the material. This is usually used to enable/disable shader permutations.
This is kind of a define, also known as a combo.
- `System.Int32 GetFeature(System.String name)`
  - Get a feature flag on the material. This is usually used to enable/disable shader permutations.
- `Sandbox.Texture GetTexture(System.String name)`
  - Get texture parameter, by name
- `Vector4 GetVector4(System.String name)`
  - Get Vector4 parameter, by name
- `Color GetColor(System.String name)`
  - Get Color parameter, by name
- `System.Boolean Set(System.String param, Vector4 value)`
  - Overrides/Sets an Vector4 within the material
- `System.Boolean Set(System.String param, Sandbox.Texture texture)`
  - Override/Sets texture parameter (Color, Normal, etc)
- `System.Boolean Set(System.String param, Color value)`
  - Overrides/Sets an color within the material as a color value within the material
- `System.Boolean Set(System.String param, Vector3 value)`
  - Overrides/Sets an Vector3 within the material
- `System.Boolean Set(System.String param, Vector2 value)`
  - Overrides/Sets an Vector2 within the material
- `System.Boolean Set(System.String param, System.Single value)`
  - Overrides/Sets an float within the material
- `System.Boolean Set(System.String param, System.Int32 value)`
  - Overrides/Sets an int within the material
- `System.Boolean Set(System.String param, System.Boolean value)`
  - Overrides/Sets an bool within the material
