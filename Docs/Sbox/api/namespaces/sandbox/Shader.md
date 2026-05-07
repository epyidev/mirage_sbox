# Sandbox.Shader

A <a href="https://en.wikipedia.org/wiki/Shader">shader</a> is a specialized and complex computer program that use
world geometry, materials and textures to render graphics.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Resource`

## Properties

- `System.Boolean IsValid`
- `Sandbox.Shader.ShaderSchema Schema`
  - Returns a schema representing the variables and combos in this shader.
This is used by the material editor to show UI for editing shader parameters.

## Methods

### Static methods

- `static Sandbox.Shader Load(System.String filename)`
  - Load a shader by file path.
  - `filename`: The file path to load as a shader.
  - returns: The loaded shader, or null
