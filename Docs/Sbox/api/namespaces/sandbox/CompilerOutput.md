# Sandbox.CompilerOutput

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Compiling`

## Constructors

- `CompilerOutput(Sandbox.Compiler compiler)`

## Properties

- `System.Boolean Successful`
  - True if the build succeeded
- `Sandbox.Compiler Compiler`
  - The compiler that has produced this build
- `System.Version Version`
  - The version of the assembly
- `System.Byte[] AssemblyData`
  - The [assembly].dll contents for this build
- `Sandbox.CodeArchive Archive`
  - A code archive created during the compile
- `System.String XmlDocumentation`
  - The [assembly].xml contents for this build
- `System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic> Diagnostics`
  - A list of diagnostics caused by the previous build
- `System.Exception Exception`
  - If an exception happened during the build, it'll be available here
