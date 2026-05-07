# Sandbox.Compiler.Configuration

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Compiling`
- **Declaring type:** `Sandbox.Compiler`

## Constructors

- `Configuration()`

## Properties

- `System.String RootNamespace`
- `System.String DefineConstants`
- `System.String NoWarn`
- `System.String WarningsAsErrors`
- `System.Boolean TreatWarningsAsErrors`
- `System.Boolean Nullables`
- `System.Boolean Whitelist`
  - If true, we will be using the whitelist system. If false then this package won't
be "sandboxed", so won't be able to be published on the platform.
- `System.Boolean Unsafe`
  - If true, we'll compile with /unsafe. This means that the package won't be able to
be published on the platform.
- `Sandbox.Compiler.ReleaseMode ReleaseMode`
  - The current release mode. This only matters during local development. 
Published games are always built in release mode, where optimizations are enabled and debugging is limited (breakpoints, sequence points, and locals may be unavailable).
- `System.Collections.Generic.List<System.String> AssemblyReferences`
  - References to non-package assemblies, by assembly name.
- `System.Collections.Generic.Dictionary<System.String,System.String> ReplacementDirectives`
  - Maps file patterns to preprocessor directives they should be wrapped in
- `System.Collections.Generic.HashSet<System.String> IgnoreFolders`
  - Folders to ignore when walking the tree
- `System.Collections.Generic.IReadOnlySet<System.String> DistinctAssemblyReferences`
  - Each unique element of `Sandbox.Compiler.Configuration.AssemblyReferences`

## Methods

### Instance methods

- `System.Void Clean()`
- `System.Collections.Generic.HashSet<System.String> GetPreprocessorSymbols()`
  - Fetches the preprocessor symbols, which might've changed based on criteria
- `Microsoft.CodeAnalysis.CSharp.CSharpParseOptions GetParseOptions()`
  - Returns the CSharpParseOptions for this configuration, which includes the preprocessor symbols defined in `Sandbox.Compiler.Configuration.DefineConstants`.
