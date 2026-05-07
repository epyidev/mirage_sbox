# Sandbox.Helpers.UndoSystem

A system that aims to wrap the main reusable functionality of an undo system

- **Kind:** class
- **Namespace:** `Sandbox.Helpers`
- **Assembly:** `Sandbox.Tools`

## Constructors

- `UndoSystem()`

## Properties

- `System.Collections.Generic.Stack<Sandbox.Helpers.UndoSystem.Entry> Back`
  - Backwards stack
- `System.Collections.Generic.Stack<Sandbox.Helpers.UndoSystem.Entry> Forward`
  - Forwards stack, gets cleared when a new undo is added

## Fields

- `System.Action<Sandbox.Helpers.UndoSystem.Entry> OnUndo`
  - Called when an undo is run
- `System.Action<Sandbox.Helpers.UndoSystem.Entry> OnRedo`
  - Called when a redo is run

## Methods

### Instance methods

- `System.Boolean Undo()`
  - Instigate an undo. Return true if we found a successful undo
- `System.Boolean Redo()`
  - Instigate a redo, returns true if we found a successful undo
- `Sandbox.Helpers.UndoSystem.Entry Insert(System.String title, System.Action undo, System.Action redo)`
  - Insert a new undo entry
- `System.Void SetSnapshotFunction(System.Func<System.Action> snapshot)`
- `System.Void Snapshot(System.String changeTitle)`
  - Should be called after you make a change to your project. The snapshot system
is good for self contained projects that can be serialized and deserialized quickly.
- `System.Void Initialize()`
  - Clear the history and take an initial snapshot.
You should call this right after a load, or a new project.
