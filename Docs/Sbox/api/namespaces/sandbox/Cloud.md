# Sandbox.Cloud

For accessing assets from the cloud - from code

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static System.String Asset(System.String ident)`
  - Returns the path of the asset referenced by this package
- `static Sandbox.Model Model(System.String ident)`
  - Loads a model from the cloud by its identifier. The asset is downloaded during code compilation, so it's treated like a local model since it's shipped along with your package.
<br></br>
If you wish to load a model at runtime, use `Sandbox.Cloud.Load``1(System.String,System.Boolean)` instead.
  - `ident`: The cloud ident/url of the model
- `static Sandbox.Material Material(System.String ident)`
  - Loads a material from the cloud by its identifier. The asset is downloaded during code compilation, so it's treated like a local material since it's shipped along with your package.
<br></br>
If you wish to load a material at runtime, use `Sandbox.Cloud.Load``1(System.String,System.Boolean)` instead.
  - `ident`: The cloud ident/url of the material
- `static Sandbox.ParticleSystem ParticleSystem(System.String ident)`
- `static Sandbox.SoundEvent SoundEvent(System.String ident)`
  - Loads a sound event from the cloud by its identifier. The asset is downloaded during code compilation, so it's treated like a local particle system since it's shipped along with your package.
<br></br>
If you wish to load a sound event at runtime, use `Sandbox.Cloud.Load``1(System.String,System.Boolean)` instead.
  - `ident`: The cloud ident/url of the particle system
- `static Sandbox.Shader Shader(System.String ident)`
  - Loads a shader from the cloud by its identifier. The asset is downloaded during code compilation, so it's treated like a local shader since it's shipped along with your package.
<br></br>
If you wish to load a shader at runtime, use `Sandbox.Cloud.Load``1(System.String,System.Boolean)` instead.
  - `ident`: The cloud ident/url of the shader
- `static System.Threading.Tasks.Task<T> Load(System.String ident, System.Boolean withCode)`
  - Loads a resource asynchronously from the cloud by its identifier, downloading the package if the client doesn't have it locally.
- `static System.Boolean IsInstalled(System.String ident)`
  - Checks if a cloud package is installed.
- `static System.Threading.Tasks.Task Load(System.String ident)`
  - Loads a cloud package asynchronously from the cloud by its identifier
- `static Sandbox.Package ResolvePrimaryAsset(System.String assetPath)`
  - Resolve a primary asset to a loaded package
- `static Sandbox.Package[] ResolvePrimaryAssetsFromJson(System.Text.Json.Nodes.JsonNode jso)`
  - Given a json value, walk it and find paths, resolve them to packages
- `static Sandbox.Package[] ResolvePrimaryAssetsFromJson(System.String json)`
  - Given a json string, walk it and find paths, resolve them to packages
