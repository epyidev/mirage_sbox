# Sandbox.Internal.PublicArrayPool<T>

Calls to ArrayPool.Shared{T} will map to this class.
You can use it directly but you probably shouldn't

- **Kind:** sealed class
- **Namespace:** `Sandbox.Internal`
- **Assembly:** `Sandbox.System`

## Constructors

- `PublicArrayPool<T>()`

## Properties

- `static System.Buffers.ArrayPool<T> Shared`
  - Retrieves a shared `System.Buffers.ArrayPool`1` instance.
