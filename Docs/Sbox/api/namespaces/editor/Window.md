# Editor.Window

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `Window(Editor.Widget parent)`

## Properties

- `System.String StateCookie`
  - A unique identifier for this window, to store the window state across sessions using the <see cref="P:Sandbox.Internal.GlobalGameNamespace.Cookie">Cookie</see> library.
- `System.String Title`
- `Editor.Widget Canvas`
- `Editor.MenuBar MenuBar`
- `Editor.Widget MenuWidget`
- `Editor.StatusBar StatusBar`
- `System.Boolean StartCentered`
  - Initialises the window at the centre of the screen (or main editor window if one is present) by default.
- `System.Boolean IsDialog`
- `System.Boolean CloseButtonVisible`

## Fields

- `static System.Collections.Generic.List<Editor.Window> All`

## Methods

### Instance methods

- `virtual System.Void RestoreFromStateCookie()`
  - Called whenever the window should restore its state via the <see cref="P:Sandbox.Internal.GlobalToolsNamespace.EditorCookie">EditorCookie</see> library,
that was previously saved in `Editor.Window.SaveToStateCookie`.<br />
You should use `Editor.Window.StateCookie` in the cookie name.
- `virtual System.Void SaveToStateCookie()`
  - Called whenever the window should save its state via the <see cref="P:Sandbox.Internal.GlobalToolsNamespace.EditorCookie">EditorCookie</see> library,
to be later restored in `Editor.Window.RestoreFromStateCookie`. This is useful to carry data across game sessions.<br />
You should use `Editor.Window.StateCookie` in the cookie name.
- `virtual System.Void OnResize()`
- `virtual System.Void SetWindowIcon(System.String name)`
- `virtual System.Void SetWindowIcon(Editor.Pixmap icon)`
- `virtual System.Void Show()`
- `virtual System.Void Close()`
- `System.Void Clear()`
  - TODO this was a test, get rid of it
- `virtual System.Void OnClosed()`
- `System.Void AddToolBar(Editor.ToolBar bar, Editor.ToolbarPosition position)`
- `System.Void RemoveToolBar(Editor.ToolBar bar)`
- `System.String SaveState(System.Int32 version)`
- `System.Void RestoreState(System.String state)`
- `virtual System.Void OnBlur(Editor.FocusChangeReason reason)`
- `System.Void Center()`
  - Position the window at the centre of the screen, or main editor window if one is present.
