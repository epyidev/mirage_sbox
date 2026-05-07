# Editor.EditorUtility.Projects

- **Kind:** static class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.EditorUtility`

## Methods

### Static methods

- `static System.Threading.Tasks.Task<Sandbox.CompilerOutput[]> Compile(Sandbox.Project project, System.Action<System.String> logOutput)`
- `static Sandbox.Compiler ResolveCompiler(System.Reflection.Assembly assembly)`
  - Resolve a compiler from an assembly, using the assembly name
- `static System.Collections.Generic.IReadOnlyList<Sandbox.Project> GetAll()`
- `static System.Threading.Tasks.Task<System.Boolean> Updated(Sandbox.Project addon)`
- `static System.Threading.Tasks.Task WaitForCompiles()`
  - Wait for the local compiles to be finished
- `static System.Threading.Tasks.Task GenerateSolution()`
  - Regenerates the project's solution
