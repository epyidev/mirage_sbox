# Editor.EditorEvent.ISceneEdited

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.EditorEvent`

## Methods

### Instance methods

- `virtual System.Void GameObjectPreEdited(Sandbox.GameObject go, System.String propertyName)`
  - Called when a property on a `Sandbox.GameObject` is about to be edited, so the old value can be inspected.
- `virtual System.Void GameObjectEdited(Sandbox.GameObject go, System.String propertyName)`
  - Called when a `Sandbox.GameObject` has been edited, so the new value can be inspected.
- `virtual System.Void ComponentPreEdited(Sandbox.Component cmp, System.String propertyName)`
  - Called when a property on a `Sandbox.Component` is about to be edited, so the old value can be inspected.
- `virtual System.Void ComponentEdited(Sandbox.Component cmp, System.String propertyName)`
  - Called when a `Sandbox.Component` has been edited, so the new value can be inspected.
