# Sandbox.Resources.ResourceGenerator

Creates a resource from a json definition

- **Kind:** abstract class
- **Namespace:** `Sandbox.Resources`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ResourceGenerator()`

## Properties

- `System.Boolean CacheToDisk`
  - If true then the generation will create a real resource and store it on disk.
Use this if creating the resource takes a while, or you won't be shipping the generator
with the game, or if it relies on data that won't be available in the shipped game.

## Methods

### Static methods

- `static Sandbox.Resources.ResourceGenerator<T> Create(System.String generatorName)`
  - Create a ResourceGenerator by name
- `static Sandbox.Resources.ResourceGenerator<T> Create(Sandbox.Resources.EmbeddedResource serialized)`
  - Create a ResourceGenerator by name and deserialize it
- `static T CreateResource(Sandbox.Resources.EmbeddedResource obj, Sandbox.Resources.ResourceGenerator.Options options)`
- `static Sandbox.Resource CreateResource(Sandbox.Resources.EmbeddedResource obj, Sandbox.Resources.ResourceGenerator.Options options, System.Type type)`
  - Create a resource from an embedded resource with a given `System.Type`

### Instance methods

- `virtual System.Void Deserialize(System.Text.Json.Nodes.JsonObject obj)`
  - Copy properties from obj to us
- `virtual System.UInt64 GetHash()`
  - Returns a hash to be used when loading/saving. We use this to determine if the resource has changed.
By default we serialize the generator to a json string and return the CRC64 of that value. You can
override this in your generator if you need to make it faster, or ignore some stuff.
- `virtual System.Threading.Tasks.ValueTask<Sandbox.Resource> FindOrCreateObjectAsync(Sandbox.Resources.ResourceGenerator.Options options, System.Threading.CancellationToken token)`
  - If we generated this before, then find the current cache'd value.
If not, then generate a new one.
- `virtual Sandbox.Resource FindOrCreateObject(Sandbox.Resources.ResourceGenerator.Options options)`
  - Find or create the resource (blocking)
