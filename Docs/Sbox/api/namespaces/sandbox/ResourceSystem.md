# Sandbox.ResourceSystem

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ResourceSystem()`

## Methods

### Instance methods

- `T Get(System.Int32 identifier)`
  - Get a cached resource by its hash.
  - `identifier`: Resource hash to look up.
- `T Get(System.String filepath)`
  - Get a cached resource by its file path.
  - `filepath`: File path to the resource.
- `System.Boolean TryGet(System.String filepath, T resource)`
  - Try to get a cached resource by its file path.
  - `filepath`: File path to the resource.
  - `resource`: The retrieved resource, if any.
  - returns: True if resource was retrieved successfully.
- `System.Collections.Generic.IEnumerable<T> GetAll()`
  - Get all cached resources of given type.
- `System.Collections.Generic.IEnumerable<T> GetAll(System.String filepath, System.Boolean recursive)`
  - Get all cached resources of given type in a specific folder.
  - `filepath`: The path of the folder to check.
  - `recursive`: Whether or not to check folders within the specified folder.
