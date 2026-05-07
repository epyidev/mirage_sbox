# Sandbox.Gizmo.SceneSettings

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Gizmo`

## Constructors

- `SceneSettings()`

## Properties

- `System.String EditMode`
  - How do we want to edit this? Usually something like "position", "rotation", "scale" etc
- `System.Boolean Selection`
  - Do we want to let the user select things in the current mode?
- `System.String ViewMode`
  - What is the current view mode? 3d, 2d, ui?
- `System.Boolean GizmosEnabled`
  - Are gizmos enabled?
- `System.Single GizmoScale`
  - How big to show the gizmos
- `System.Single GridSpacing`
  - Grid spacing
- `System.Boolean SnapToGrid`
  - Snap positions to the grid
- `System.Boolean SnapToAngles`
  - Snap angles
- `System.Single AngleSpacing`
  - Grid spacing
- `System.Boolean GlobalSpace`
  - Editing in local space
- `System.Boolean DebugActionGraphs`
  - Should we show lines representing GameObject references in action graphs?

## Methods

### Instance methods

- `System.Boolean IsGizmoEnabled(System.Type type)`
  - Check if a gizmo type is enabled
- `System.Void SetGizmoEnabled(System.Type type, System.Boolean enabled)`
  - Set the enabled state of a gizmo type
- `System.Void ClearEnabledGizmos()`
  - Clear all enabled gizmos
