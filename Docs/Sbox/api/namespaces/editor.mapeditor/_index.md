# Namespace `Editor.MapEditor`

17 types.

## Classes

- [`EditorContext`](./EditorContext.md)
- [`HammerMainWindow`](./HammerMainWindow.md) - This is our CQHammerMainWnd
- [`HammerManagedInspector`](./HammerManagedInspector.md)
- [`HammerSceneEditorSession`](./HammerSceneEditorSession.md)
- [`HammerSession`](./HammerSession.md) - This is our CQHammerMainWnd
- [`HammerSourceLocation`](./HammerSourceLocation.md) - Source location for graphs created in a Hammer editor session.
- [`MapView`](./MapView.md) - MapViews are owned by the MapViewMgr. They display the MapViewMgr's mapdoc.
- [`SelectMode`](./SelectMode.md)

## Static classes

- [`Hammer`](./Hammer.md)
- [`History`](./History.md) - Undo/redo history for the current active mapdoc
- [`Selection`](./Selection.md) - Current selection set for the active map

## Attributes

- [`CanDropAttribute`](./CanDropAttribute.md)

## Interfaces

- [`IBlockTool`](./IBlockTool.md) - Interface for the addon layer to implement, this is called from native Hammer.
- [`IEntityTool`](./IEntityTool.md) - Interface for the addon layer to implement, this is called from native Hammer.
- [`IMapViewDropTarget`](./IMapViewDropTarget.md) - Provides an interface for dragging and dropping `Editor.Asset` or `Sandbox.Package` on a map view.
- [`IPathTool`](./IPathTool.md) - Interface for the addon layer to implement, this is called from native Hammer.
- [`IToolFactory`](./IToolFactory.md)

## Enums

- [`SelectMode`](./SelectMode.md)
