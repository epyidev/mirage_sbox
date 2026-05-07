# Editor.MapEditor.IBlockTool

Interface for the addon layer to implement, this is called from native Hammer.

- **Kind:** interface
- **Namespace:** `Editor.MapEditor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `static Editor.MapEditor.IBlockTool Instance`
- `Editor.MeshEditor.PrimitiveBuilder Current`
- `System.Boolean InProgress`
- `System.String EntityOverride`
- `static System.Boolean OrientPrimitives`

## Methods

### Static methods

- `static System.Void UpdateTool()`
  - Tells the tool a parameter has changed and that we should redraw.

### Instance methods

- `virtual Editor.Widget BuildUI()`
