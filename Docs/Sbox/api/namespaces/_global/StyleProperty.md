# Sandbox.UI.IStyleBlock.StyleProperty

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`
- **Declaring type:** `Sandbox.UI.IStyleBlock`

## Properties

- `System.String Name`
  - Name of the property, ie "color" or "width"
- `System.String Value`
  - Current value of the property (which is being rendered)
- `System.String OriginalValue`
  - The value that was loaded from the .scss file
- `System.Int32 Line`
  - The line in the file containing this value
- `System.Boolean IsValid`
  - If parsing this property was successful or failed
