# Editor.Menu.PathElement

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.Menu`

## Constructors

- `PathElement(System.String Name, System.String Icon, System.String Description, System.Nullable<System.Int32> Order, System.Boolean IsHeading)`

## Properties

- `System.String Name`
- `System.String Icon`
- `System.String Description`
- `System.Nullable<System.Int32> Order`
- `System.Boolean IsHeading`

## Methods

### Static methods

- `static System.Int32 Compare(System.Collections.Generic.IReadOnlyList<Editor.Menu.PathElement> aPath, System.Collections.Generic.IReadOnlyList<Editor.Menu.PathElement> bPath)`

### Instance methods

- `virtual System.Int32 CompareTo(Editor.Menu.PathElement other)`
- `System.Boolean Matches(Editor.Menu.PathElement other)`
- `Editor.Menu.PathElement Merge(Editor.Menu.PathElement other)`
- `System.Void Deconstruct(System.String Name, System.String Icon, System.String Description, System.Nullable<System.Int32> Order, System.Boolean IsHeading)`
