# Sandbox.Engine.Shaders.ShaderCompile.Results

The results of a shader compile

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Engine.Shaders.ShaderCompile`

## Constructors

- `Results()`

## Properties

- `System.Boolean Success`
  - True if the shader was compiled successfully. False indicates an error
occurred. You can dig deeper into why in Programs.
- `System.Boolean Skipped`
  - If true then this compile was skipped because nothing changed
- `System.Byte[] CompiledShader`
  - If successful, this contains the actual resource-encoded bytes of the
shader compile.
- `System.Collections.Generic.List<Sandbox.Engine.Shaders.ShaderCompile.Results.Program> Programs`
