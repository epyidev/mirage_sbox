# Sandbox.Resources.ResourceCompiler

Takes the "source" of a resource and creates a compiled version. The compiled version
can create a number of child resources and store binary data.

- **Kind:** abstract class
- **Namespace:** `Sandbox.Resources`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ResourceCompiler()`

## Properties

- `Sandbox.Resources.ResourceCompileContext Context`

## Methods

### Instance methods

- `virtual System.Boolean CompileEmbedded(Sandbox.Resources.EmbeddedResource json)`
- `virtual System.Threading.Tasks.Task<System.Boolean> Compile()`
- `System.Threading.Tasks.Task<System.Boolean> WriteToJson()`
  - Writes resource to a JSON file, using the ResourceGenerator to create the resource.
- `System.Boolean TryParseEmbeddedResource(System.Nullable<Sandbox.Resources.EmbeddedResource> resource)`
- `System.String CreateGeneratedResourcePath(Sandbox.Resources.EmbeddedResource embed, System.String subfolder, System.String extension)`
  - Create a deterministic path for a generated resource based on the embedded resource data.
- `System.Boolean CompileEmbeddedResource(Sandbox.Resources.EmbeddedResource embed, System.String subfolder, System.String extension, Sandbox.BaseFileSystem fs)`
  - Generic method to compile an embedded resource by creating a child context.
This handles the common pattern of creating a generator, generating a path,
creating a child context, and setting the compiled path.
