# Editor.MapEditor.IMapViewDropTarget

Provides an interface for dragging and dropping `Editor.Asset` or `Sandbox.Package` on a map view.
Use with `Editor.MapEditor.CanDropAttribute` to register your drop target for a `Sandbox.Package.Type` or `Sandbox.GameResource` type.

- **Kind:** interface
- **Namespace:** `Editor.MapEditor`
- **Assembly:** `Sandbox.Tools`

## Methods

### Instance methods

- `virtual System.Void DragEnter(Editor.Asset asset, Editor.MapEditor.MapView view)`
  - An asset started being dragged over a Hammer view..
- `virtual System.Void DragEnter(Sandbox.Package package, Editor.MapEditor.MapView view)`
  - An sbox.game package started being dragged over a Hammer view..
- `virtual System.Void DragMove(Editor.MapEditor.MapView view)`
  - Called when the mouse cursor moves over a Hammer view while dragging an asset or a package.
- `virtual System.Void DragDropped(Editor.MapEditor.MapView view)`
  - Called when a dragged an asset or a package gets finally dropped on a Hammer view.
- `virtual System.Void DragLeave(Editor.MapEditor.MapView view)`
  - Called when a dragged an asset or a package gets dragged outside of a Hammer view.
This is a good spot to clean up any created nodes.
- `virtual System.Void DrawGizmos(Editor.MapEditor.MapView view)`
