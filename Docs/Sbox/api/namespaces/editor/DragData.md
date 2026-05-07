# Editor.DragData

Contains drag and drop data for tool widgets. See `Editor.Widget.DragEvent`.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.QObject`

## Constructors

- `DragData()`

## Properties

- `System.Collections.Generic.IReadOnlyList<Editor.DragAssetData> Assets`
  - Interprets `Editor.DragData.Text` as a list of asset paths or cloud asset URLs,
getting a list of helper objects to access each asset. Generated and cached
internally on first access after `Editor.DragData.Text` changes.
- `System.Object Object`
  - An object that can be used to pass drag and drop data
- `System.String Text`
  - Text data of the drag and drop event.
- `System.String Html`
  - HTML data of the drag and drop event, if any.
- `System.Uri Url`
  - URL data of the drag and drop event, if any.
- `System.Boolean HasFileOrFolder`
  - Whether the drag data has at least 1 file or folder.
- `System.String FileOrFolder`
  - The first file or folder in the drag data.
- `System.String[] Files`
  - All files and folders in the drag data.

## Methods

### Instance methods

- `System.Collections.Generic.IEnumerable<T> OfType()`
  - Helper for finding instances of type `T` in `Editor.DragData.Object`.
Will find matches if `Editor.DragData.Object` is of type `T`, is
an `System.Collections.IEnumerable` with `T` items, or a `Sandbox.SerializedObject`
with `T` targets.
- `System.Collections.Generic.IEnumerable<System.Object> OfType(System.Type type)`
  - Helper for finding instances of type `type` in `Editor.DragData.Object`.
Will find matches if `Editor.DragData.Object` is of type `type`, is
an `System.Collections.IEnumerable` with `type` items, or a `Sandbox.SerializedObject`
with `type` targets.
