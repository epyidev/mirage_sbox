# Sandbox.Resources.EmbeddedResource

A JSON definition of an embedded resource. This is a resource that can be either standalone (in a .vtex file) or 
embedded in a GameResource's Json data. 

When it's detected in a GameResource we will create the named compiler and create the resource. When compiling the
GameResource this can optionally create a compiled version of the resource on disk.

When we compile a regular resource that contains this $compiler structure, it operates like any other compile, except
it's totally managed by c# instead of resourcecompiler.

- **Kind:** struct
- **Namespace:** `Sandbox.Resources`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.String ResourceCompiler`
  - The name of the ResourceCompiler to use
- `System.String ResourceGenerator`
  - The name of the ResourceGenerator that created this resource. This is basically a sub-compiler.
- `System.String TypeName`
  - Sometimes we'll want to embed a child class of a resource
- `System.Text.Json.Nodes.JsonObject Data`
  - Data that is serialized/deserialized from the ResourceGenerator
- `System.String CompiledPath`
  - If this resource has been compiled to disk then this is the path to that resource.
This avoids the need to generate this resource again.
