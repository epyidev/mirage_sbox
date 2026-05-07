# Editor.EditorEvent

- **Kind:** static class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Methods

### Static methods

- `static System.Void Register(System.Object obj)`
  - Register an object, start receiving events
- `static System.Void Unregister(System.Object obj)`
  - Unregister an object, stop receiving events
- `static System.Void Run(System.String name)`
  - Run an event.
- `static System.Void Run(System.String name, T arg0)`
  - Run an event with an argument of arbitrary type.
  - `name`: Name of the event to run.
  - `arg0`: Argument to pass down to event handlers.
- `static System.Void Run(System.String name, T arg0, U arg1)`
  - Run an event with 2 arguments of arbitrary type.
  - `name`: Name of the event to run.
  - `arg0`: First argument to pass down to event handlers.
  - `arg1`: Second argument to pass down to event handlers.
- `static System.Void RunInterface(System.Action<T> action)`
- `static System.Void Run(System.String name, T arg0, U arg1, V arg2)`
  - Run an event with 3 arguments of arbitrary type.
  - `name`: Name of the event to run.
  - `arg0`: First argument to pass down to event handlers.
  - `arg1`: Second argument to pass down to event handlers.
  - `arg2`: Third argument to pass down to event handlers.
