# Sandbox.ResourceLibrary

Keeps a library of all available `Sandbox.Resource`.

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static T Get(System.Int32 identifier)`
  - Get a cached resource by its hash.
  - `identifier`: Resource hash to look up.
- `static T Get(System.String filepath)`
  - Get a cached resource by its file path.
  - `filepath`: File path to the resource.
- `static System.Boolean TryGet(System.String filepath, T resource)`
  - Try to get a cached resource by its file path.
  - `filepath`: File path to the resource.
  - `resource`: The retrieved resource, if any.
  - returns: True if resource was retrieved successfully.
- `static System.Collections.Generic.IEnumerable<T> GetAll()`
  - Get all cached resources of given type.
- `static System.Collections.Generic.IEnumerable<T> GetAll(System.String filepath, System.Boolean recursive)`
  - Get all cached resources of given type in a specific folder.
  - `filepath`: The path of the folder to check.
  - `recursive`: Whether or not to check folders within the specified folder.
- `static System.Threading.Tasks.Task<T> LoadAsync(System.String path)`
  - Load a resource by its file path.
- `static System.Threading.Tasks.Task<Sandbox.Bitmap> GetThumbnail(System.String path, System.Int32 width, System.Int32 height)`
  - Render a thumbnail for this resource
