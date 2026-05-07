# Editor.PopupWidget

A popup widget that automatically deletes itself once it stops being visible

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `PopupWidget(Editor.Widget widget)`

## Properties

- `System.Action OnLostFocus`

## Fields

- `System.Boolean PreventDestruction`

## Methods

### Instance methods

- `virtual System.Void OnVisibilityChanged(System.Boolean visible)`
- `virtual System.Void OnPaint()`
- `System.Void OpenAtCursor(System.Boolean animate, System.Nullable<Vector2> offset)`
- `System.Void OpenAt(Vector2 position, System.Boolean animate, System.Nullable<Vector2> animateOffset)`
- `System.Void OpenBelowCursor(System.Single distance, System.Single centering)`
  - Open the window this many pixels below the cursor.
