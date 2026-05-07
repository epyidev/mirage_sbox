# Editor.MapEditor.EditorContext

- **Kind:** abstract class
- **Namespace:** `Editor.MapEditor`
- **Assembly:** `Sandbox.Tools`

## Constructors

- `EditorContext()`

## Properties

- `Editor.MapEditor.EditorContext.EntityObject Target`
  - The current entity we're rendering gizmos for
- `System.Boolean IsSelected`
  - If the current entity we're drawing selected
- `System.Collections.Generic.HashSet<Editor.MapEditor.EditorContext.EntityObject> Selection`
  - All selected entities

## Methods

### Instance methods

- `virtual Editor.MapEditor.EditorContext.EntityObject FindTarget(System.String name)`
  - Given a string name return the first found target
- `virtual Editor.MapEditor.EditorContext.EntityObject[] FindTargets(System.String name)`
  - Given a string name return all found targets
