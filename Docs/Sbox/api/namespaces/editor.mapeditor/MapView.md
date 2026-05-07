# Editor.MapEditor.MapView

MapViews are owned by the MapViewMgr. They display the MapViewMgr's mapdoc.
            
The MapView provides either a 2d or 3d view of the provided map doc. The rendering mode
may be swapped between various 2d and 3d modes dynamically. In addition to basic display 
functionality the view also provides movement implementation for moving a camera within a 3d view
or panning a 2d view.

- **Kind:** class
- **Namespace:** `Editor.MapEditor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `Sandbox.SceneCamera SceneCamera`
  - Read-only SceneCamera set automatically during rendering
- `Sandbox.Gizmo.Instance GizmoInstance`
- `Editor.MapDoc.MapDocument MapDoc`
- `Vector2 MousePosition`

## Methods

### Instance methods

- `System.Void BuildRay(Vector3 startRay, Vector3 endRay)`
  - Builds a ray from the mouse cursor
