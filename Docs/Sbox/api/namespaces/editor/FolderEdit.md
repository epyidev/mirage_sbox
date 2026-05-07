# Editor.FolderEdit

An editable text box with a button to browse for an arbitrary folder using OS file browser dialog.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.LineEdit`

## Constructors

- `FolderEdit(Editor.Widget parent)`

## Properties

- `System.String DialogTitle`
  - Title override for the "browse folder" dialog.

## Fields

- `System.Action<System.String> FolderSelected`
  - Path to the user selected folder.

## Methods

### Instance methods

- `System.Void Browse()`
  - Open a "browse folder" dialog.
- `virtual System.Void OnMouseEnter()`
- `virtual System.Void OnMouseLeave()`
- `virtual System.Void OnPaint()`
- `virtual System.Void OnDragHover(Editor.Widget.DragEvent ev)`
- `virtual System.Void OnDragDrop(Editor.Widget.DragEvent ev)`
