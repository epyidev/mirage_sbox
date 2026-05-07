# Editor.CanEditAttribute

- **Kind:** attribute
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `System.Attribute`

## Constructors

- `CanEditAttribute(System.Type type, System.String typeName)`
- `CanEditAttribute(System.String typeName)`

## Properties

- `System.Type TargetType`
- `System.Type Type`
- `System.String TypeName`

## Methods

### Static methods

- `static Editor.Widget CreateEditorFor(System.Reflection.PropertyInfo property)`
- `static Editor.Widget CreateEditorFor(System.Type t, System.Collections.Generic.IEnumerable<System.Attribute> attributes, System.Type[] generics)`
- `static Editor.Widget CreateEditorFor(System.String name)`
- `static Editor.Widget CreateEditorFor(System.Array array)`
- `static Editor.Widget CreateEditorForObject(System.Object obj)`
