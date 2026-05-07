# Sandbox.Engine.Shaders.ShaderCompile.Results.Program

The results of an individual shader program compile (PS, VS etc)

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Engine.Shaders.ShaderCompile/Results`

## Constructors

- `Program()`

## Properties

- `System.String Name`
  - The identifier for this program
- `System.Int32 ComboCount`
  - How many combos had to be compiled for this program. This is Static * Dynamic.
- `System.String Source`
  - The full pre-processed source for this shader
- `System.Boolean Success`
  - True if this was compiled successfully
- `System.Collections.Generic.List<System.String> Output`
  - Shader compile output, warnings and errors
