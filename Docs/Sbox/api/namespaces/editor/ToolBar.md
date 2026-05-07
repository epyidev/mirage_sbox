# Editor.ToolBar

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `ToolBar(Editor.Widget parent, System.String name)`

## Properties

- `System.String Title`
- `System.Boolean Movable`
- `System.Boolean Floatable`
- `Editor.ToolButtonStyle ButtonStyle`

## Methods

### Instance methods

- `Editor.Option AddOption(System.String text, System.String icon, System.Action action)`
- `Editor.Option AddOption(Editor.Option option)`
- `System.Void Clear()`
- `Editor.Option AddSeparator()`
- `T AddWidget(T widget)`
- `System.Void SetIconSize(Vector2 size)`
