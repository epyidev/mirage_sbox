# Sandbox.Utility.DisposeAction

A simple IDisposable that invokes an action when disposed.
Useful for creating using-blocks with cleanup logic.

- **Kind:** struct
- **Namespace:** `Sandbox.Utility`
- **Assembly:** `Sandbox.System`

## Constructors

- `DisposeAction(System.Action action)`
  - Creates a new DisposeAction that will invoke the specified action on disposal.
  - `action`: The action to invoke when disposed

## Methods

### Static methods

- `static System.IDisposable Create(System.Action action)`
  - Factory method to create a DisposeAction as an IDisposable.
  - `action`: The action to invoke when disposed
  - returns: A disposable object that will invoke the action

### Instance methods

- `virtual System.Void Dispose()`
  - Invokes the action specified in the constructor.
