# Editor.InspectorWidget

When using `Editor.InspectorAttribute` with a type that inherits from InspectorWidget, when you inspect an object of that class, it will create an instance of the widget and display it in the inspector.

- **Kind:** abstract class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `InspectorWidget(Sandbox.SerializedObject so)`

## Properties

- `Sandbox.SerializedObject SerializedObject`

## Methods

### Static methods

- `static Editor.InspectorWidget Create(Sandbox.SerializedObject obj, System.Type ignore)`
  - Creates an inspector widget for the given serialized object.

### Instance methods

- `System.Boolean CloseInspector(System.Object newObj)`
  - Closes the inspector
- `virtual System.Boolean OnInspectorClose(System.Object newObj)`
  - Called when the inspector is about to be closed.
Can return false to prevent closing.
