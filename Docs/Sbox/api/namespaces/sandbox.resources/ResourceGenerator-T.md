# Sandbox.Resources.ResourceGenerator<T>

A resource generator targetting a specific type

- **Kind:** abstract class
- **Namespace:** `Sandbox.Resources`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Resources.ResourceGenerator`

## Constructors

- `ResourceGenerator<T>()`

## Properties

- `System.Boolean UseMemoryCache`
  - If true then the generation will avoid creating duplicate resources by checking
hash codes of previously generated resources and re-using them if possible.

## Methods

### Instance methods

- `virtual T FindCached()`
  - Find a previously created of this resource
- `System.Void AddToCache(T val)`
- `virtual T FindOrCreate(Sandbox.Resources.ResourceGenerator.Options options)`
  - If we generated this before, then find the current cache'd value.
If not, then generate a new one.
- `virtual System.Threading.Tasks.ValueTask<Sandbox.Resource> FindOrCreateObjectAsync(Sandbox.Resources.ResourceGenerator.Options options, System.Threading.CancellationToken token)`
- `virtual Sandbox.Resource FindOrCreateObject(Sandbox.Resources.ResourceGenerator.Options options)`
- `virtual System.Threading.Tasks.ValueTask<T> FindOrCreateAsync(Sandbox.Resources.ResourceGenerator.Options options, System.Threading.CancellationToken token)`
  - If we generated this before, then find the current cache'd value.
If not, then generate a new one.
- `virtual T Create(Sandbox.Resources.ResourceGenerator.Options options)`
  - Create the resource blocking
- `virtual System.Threading.Tasks.ValueTask<T> CreateAsync(Sandbox.Resources.ResourceGenerator.Options options, System.Threading.CancellationToken token)`
  - Create the resource asyncronously
