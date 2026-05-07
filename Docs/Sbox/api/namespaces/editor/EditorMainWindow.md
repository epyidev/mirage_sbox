# Editor.EditorMainWindow

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.DockWindow`

## Properties

- `Editor.Menu AppsMenu`
- `Editor.Menu ViewsMenu`
- `Editor.Menu GameMenu`

## Methods

### Instance methods

- `virtual System.Boolean OnClose()`
- `System.Void ShowCloseDialog()`
- `virtual System.Void OnPaint()`
- `virtual System.Void RestoreDefaultDockLayout()`
- `virtual System.Void OnDestroyed()`
- `System.Boolean IsFullscreen(Editor.Widget widget)`
  - Is a widget currently the fullscreen widget
- `System.Boolean SetFullscreen(Editor.Widget widget)`
  - Sets a widget as the fullscreen widget
  - returns: whether or not the widget is now fullscreen
- `System.Void OnAssetSelected(Editor.Asset asset)`
- `System.Void SetVisible(System.Boolean visible)`
- `System.Void UpdateEditorTitle(System.String title)`
