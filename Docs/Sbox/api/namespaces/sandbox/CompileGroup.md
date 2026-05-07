# Sandbox.CompileGroup

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Compiling`

## Constructors

- `CompileGroup(System.String name)`

## Properties

- `static System.Boolean SuppressBuildNotifications`
  - Build notifications start of suppressed until after startup proper. That way
we don't get 4 build notification windows popping up on startup.
- `System.Collections.Generic.IEnumerable<Sandbox.Compiler> Compilers`
  - The compilers within the group
- `System.String Name`
  - The name of this compile group, for debugging/display purposes
- `System.Boolean NeedsBuild`
  - Returns true if we have compiles pending
- `System.Boolean IsBuilding`
  - Returns true if we are currently in the process of building
- `System.Boolean PrintErrorsInConsole`
  - True if we want to print errors in the console when compiling
- `System.Boolean AllowFastHotload`
  - True if we want to use fast hotloading with this compile group
- `Sandbox.CompileGroup.Results BuildResult`
  - Returns true if build was successful
- `System.Action OnCompileStarted`
  - Called when a compiling starts
- `System.Action OnCompileFinished`
  - Called when a compiling ends
- `System.Action OnCompileSuccess`
  - Called when a compile completes successfully. Can access the result from BuildResult.
- `Sandbox.ICompileReferenceProvider ReferenceProvider`
  - Allows providing an external way to find references
- `Sandbox.AccessControl AccessControl`
  - AccessControl instance to use when verifying whitelist. Must be set to enable compile-time access control.

## Methods

### Instance methods

- `virtual System.Void Dispose()`
  - Shut everything down
- `Sandbox.Compiler CreateCompiler(System.String name, System.String path, Sandbox.Compiler.Configuration settings)`
  - Create a new compiler in this group.
- `Sandbox.Compiler GetOrCreateCompiler(System.String name)`
- `System.Threading.Tasks.Task<System.Boolean> BuildAsync()`
  - Build the compilers
- `System.Void Reset()`
  - Reset the compile group. Clear errors and outputs.
- `System.Threading.Tasks.Task WaitForCompile(System.Threading.CancellationToken token)`
