# Editor.MapEditor.Hammer

- **Kind:** static class
- **Namespace:** `Editor.MapEditor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `static Editor.Asset MapAsset`
- `static Editor.MapDoc.MapDocument ActiveMap`
  - The active editor session's map document.
- `static System.Boolean Open`
  - If the Hammer app has been opened.
- `static Editor.Window Window`
  - The Hammer app's window.
- `static Sandbox.Material CurrentMaterial`
  - Current Material - you can set this programmatically with `Editor.MapEditor.Hammer.SetCurrentMaterial(Editor.Asset)`

## Methods

### Static methods

- `static System.Void ReloadFromFile()`
  - Reloads the active editor session from file with user prompt
- `static System.Void SetCurrentMaterial(Editor.Asset asset)`
  - Sets the currently used material to the specified asset.
- `static System.Void SelectObjectsUsingAsset(Editor.Asset asset)`
  - Selects all map nodes using the asset, appending them to the current selection.
- `static System.Void SelectFacesUsingMaterial(Editor.Asset asset)`
  - Selects all faces using the asset, forces `Editor.MapEditor.Selection.SelectMode` to `Editor.MapEditor.SelectMode.Faces`
- `static System.Void AssignAssetToSelection(Editor.Asset asset)`
  - Assigns the asset to the current selection.
- `static System.Void ShowEntityReportForAsset(Editor.Asset asset)`
  - Opens a Entity Report dialog showing all entities using this asset.
