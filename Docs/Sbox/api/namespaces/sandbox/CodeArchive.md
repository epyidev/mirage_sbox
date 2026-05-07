# Sandbox.CodeArchive

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Compiling`

## Constructors

- `CodeArchive()`
- `CodeArchive(System.Byte[] data)`

## Properties

- `System.String CompilerName`
  - The name of the compiler
- `Sandbox.Compiler.Configuration Configuration`
  - The compiler's configuration settings
- `System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTree> SyntaxTrees`
  - The syntax trees that should be compiled
- `System.Collections.Concurrent.ConcurrentDictionary<System.String,System.UInt64> FileHashMap`
  - Hashes of source files, used for incremental compiles. Not serialized right now.
- `System.Collections.Generic.List<Sandbox.CodeArchive.AdditionalFile> AdditionalFiles`
  - Additional files that the compiler/generator needs. This is going to be .razor files.
- `System.Collections.Generic.Dictionary<System.String,System.String> FileMap`
  - Converts the syntax tree paths from physical paths to project local paths
- `System.Collections.Generic.HashSet<System.String> References`
  - References that this compiler/generator needs to compile the code
- `System.Int64 Version`
  - The version of the code archive
1005 - Inital version
1006 - Razor updates. Add razor namespaces on older versions.
1007 - Razor changed to our own Microsoft.AspNetCore.Components assembly

## Methods

### Instance methods

- `System.Byte[] Serialize()`
  - Serialize to a byte array
