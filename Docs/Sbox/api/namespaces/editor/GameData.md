# Editor.GameData

Lets all native and managed tools know about any engine / game entities.

- **Kind:** static class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `static System.Collections.Generic.IReadOnlyList<Editor.MapClass> EntityClasses`
  - A list of all entity classes exposed to tools.
- `static Sandbox.Package[] LoadedPackages`
  - All loaded sbox.game packages for this session to load entities for tools from.

## Methods

### Static methods

- `static System.Threading.Tasks.Task LoadEntitiesFromPackage(Sandbox.Package package)`
  - Loads the entity classes from a remote sbox.game game or addon into Hammer.
