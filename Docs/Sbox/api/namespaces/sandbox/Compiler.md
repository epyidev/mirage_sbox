# Sandbox.Compiler

Given a folder of .cs files, this will produce (and load) an assembly

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Compiling`

## Properties

- `Sandbox.CompileGroup Group`
  - Each compiler must belong to a compile group
- `Sandbox.CompilerOutput Output`
  - The output from the previous build
- `System.Boolean IsBuilding`
  - Is this compiler currently building?
- `System.Boolean NeedsBuild`
  - Returns true if this compiler is pending a build, or currently building.
- `System.String Name`
  - Name of the project this compiler was created for. This could be something like "base" or "org.ident".
- `System.Boolean UseAbsoluteSourcePaths`
  - During development we use absolute source paths so that debugging works better. In a packed/release build it's
good to use relative paths instead, just to avoid exposing the builder's file system.
- `Microsoft.CodeAnalysis.Diagnostic[] Diagnostics`
  - A list of warnings and errors created by the last build
- `System.String AssemblyName`
  - Generated assembly name, without an extension. This will be "package.{Name}".
- `System.Text.StringBuilder GeneratedCode`
  - Global namespaces
- `Sandbox.BaseFileSystem FileSystem`
  - An aggregate of all the filesystem this compiler has
- `Microsoft.CodeAnalysis.Emit.EmitResult BuildResult`
  - Results for the assembly build. This can contain warnings or errors.
- `System.Boolean BuildSuccess`
  - Accesses Output.Successful

## Methods

### Static methods

- `static Microsoft.CodeAnalysis.SyntaxTree StripDisabledTextTrivia(Microsoft.CodeAnalysis.SyntaxTree tree)`
  - Strips out disabled text trivia from the syntax tree. This is stuff like `#if false` blocks that are not compiled.

### Instance methods

- `System.Void UpdateFromArchive(Sandbox.CodeArchive a)`
  - Fill this compiler from a code archive
- `System.Void AddSourcePath(System.String fullPath)`
  - Add an extra source path. Useful for situations where you want to combine multiple addons into one.
- `System.Void SetConfiguration(Sandbox.Compiler.Configuration newConfig)`
- `Sandbox.Compiler.Configuration GetConfiguration()`
- `System.Void NotifyFastHotload(System.Version fastHotloadedVersion)`
- `virtual System.Void Dispose()`
- `System.Int32 DependencyIndex(System.Int32 depth)`
- `System.Void MarkForRecompile()`
  - Recompile this as soon as is appropriate
- `System.Void AddReference(System.String referenceName)`
  - Add a reference to this compiler. This might be a system dll, or an assembly name from a fellow compiler.
- `System.Boolean HasReference(System.String referenceName, System.Boolean deep)`
  - Returns true if `Sandbox.Compiler._references` contains the given reference assembly name.
If `deep` is true, referenced compilers are searched too.
- `System.Void WatchForChanges()`
  - Watch the filesystem for changes to our c# files, and trigger a recompile if they change.
