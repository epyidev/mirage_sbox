# Sandbox.Resources.ResourceGenerator.Options

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Resources.ResourceGenerator`

## Properties

- `System.Boolean ForDisk`
  - True if we're compiling this resource to write to disk
- `Sandbox.Resources.ResourceCompiler Compiler`
  - Will be set to the compiler that is currently compiling this resource. Or null, if we're generating in another method.
- `static Sandbox.Resources.ResourceGenerator.Options Default`
