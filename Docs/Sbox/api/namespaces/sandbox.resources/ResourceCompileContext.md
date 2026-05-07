# Sandbox.Resources.ResourceCompileContext

- **Kind:** abstract class
- **Namespace:** `Sandbox.Resources`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ResourceCompileContext()`

## Properties

- `System.String AbsolutePath`
  - The absolute path to the resource on disk
- `System.String RelativePath`
  - The path relative to the assets folder
- `System.Int32 ResourceVersion`
  - The resource version can be important
- `Sandbox.Resources.ResourceCompileContext.DataStream StreamingData`
  - Get the streaming data to write to
- `Sandbox.Resources.ResourceCompileContext.DataStream Data`
  - Get the data to write to

## Methods

### Instance methods

- `virtual System.Void AddRuntimeReference(System.String path)`
  - Add a reference. This means that the resource we're compiling depends on this resource.
- `virtual System.Void AddCompileReference(System.String path)`
  - Add a reference that is needed to compile this resource, but isn't actually needed once compiled.
- `virtual System.Void AddGameFileReference(System.String path)`
  - Add a game file reference. This file will be included in packages but is not a native resource.
Use this for arbitrary data files that are loaded by managed code (e.g. navdata files).
- `virtual Sandbox.Resources.ResourceCompileContext.Child CreateChild(System.String absolutePath)`
  - Create a child resource
- `virtual System.String ScanJson(System.String json)`
  - Load the json and scan it for paths or any embedded resources
- `virtual System.Byte[] ReadSource()`
  - Read the source, either from in memory, or from disk
- `System.String ReadSourceAsString()`
  - Read the source, either from in memory, or from disk
- `System.Text.Json.Nodes.JsonObject ReadSourceAsJson()`
  - Read the source, either from in memory, or from disk
