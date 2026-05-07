# Editor.TextureResourceCompiler

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Sandbox.Resources.ResourceCompiler`

## Constructors

- `TextureResourceCompiler()`

## Methods

### Instance methods

- `virtual System.Boolean CompileEmbedded(Sandbox.Resources.EmbeddedResource embed)`
  - We found an embedded resource definition.
1. Find the TextureGenerator
2. Create a child texture resource with a deterministic name
3. Put the provided compile data in that and let it compile
4. Store a reference to the compiled version in the json
- `virtual System.Threading.Tasks.Task<System.Boolean> Compile()`
