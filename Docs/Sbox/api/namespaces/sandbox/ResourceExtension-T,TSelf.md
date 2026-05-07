# Sandbox.ResourceExtension<T,TSelf>

An extension of ResourceExtension[t], this gives special helper methods for retrieving resources targetting
specific assets.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ResourceExtension<T>`

## Constructors

- `ResourceExtension<T,TSelf>()`

## Methods

### Static methods

- `static TSelf FindForResource(Sandbox.Resource r)`
- `static TSelf FindForResourceOrDefault(Sandbox.Resource r)`
- `static System.Collections.Generic.IEnumerable<TSelf> FindAllForResource(Sandbox.Resource r)`
- `static TSelf FindDefault()`
