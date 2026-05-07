# Sandbox.SceneExtensions

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Tools`

## Methods

### Static methods

- `static System.Boolean IsDeletable(Sandbox.GameObject target)`
- `static System.Collections.Generic.IEnumerable<Sandbox.GameObject> GetAll(Sandbox.GameObjectDirectory target)`
- `static Editor.Menu CreateContextMenu(Sandbox.Scene scene, Editor.Widget parent)`
  - We should make this globally reachanle at some point. Should be able to draw icons using bitmaps etc too.
- `static System.Void CopyToClipboard(Sandbox.Component component)`
  - Copy the target `Sandbox.Component` to the clipboard.
- `static System.Void PasteValues(Sandbox.Component target)`
  - Paste component values from clipboard to the target `Sandbox.Component`.
- `static System.Boolean ShouldShowInHierarchy(Sandbox.GameObject target)`
  - Return true if this object should be shown in the GameObject list
- `static System.Void PasteComponent(Sandbox.GameObject target)`
  - Paste a `Sandbox.Component` as a new component on the target `Sandbox.GameObject`.
- `static System.Void PaintComponentIcon(Sandbox.TypeDescription td, Sandbox.Rect rect, System.Single opacity)`
- `static System.Void EnableEditorRigidBody(Sandbox.Scene scene, Sandbox.Rigidbody body, System.Boolean enabled)`
- `static System.Void DisableEditorRigidBodies(Sandbox.Scene scene)`
- `static System.Void EnableEditorPhysics(Sandbox.Scene scene, System.Boolean enabled)`
- `static System.Void SetTargetTransform(Sandbox.Rigidbody body, System.Nullable<Transform> tx)`
