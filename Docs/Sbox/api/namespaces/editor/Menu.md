# Editor.Menu

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `Menu(Editor.Widget parent)`
- `Menu(System.String title, Editor.Widget parent)`

## Properties

- `System.String Title`
- `System.String Icon`
- `System.Boolean ToolTipsVisible`
  - This property holds whether tooltips of menu actions should be visible.



This property specifies whether action menu entries show their tooltip.



By default, this property is `false`.
- `System.String ToolTip`
- `Editor.Menu ParentMenu`
- `Editor.Menu RootMenu`
- `System.Boolean HasOptions`
- `System.Boolean HasMenus`
- `System.Int32 OptionCount`
- `System.Int32 MenuCount`
- `System.Collections.Generic.IReadOnlyList<Editor.Widget> Widgets`
- `Editor.Option SelectedOption`

## Fields

- `System.Collections.Generic.List<Editor.Menu> Menus`
- `System.Collections.Generic.List<Editor.Option> Options`

## Methods

### Static methods

- `static Editor.Menu.PathElement[] GetSplitPath(System.String path)`
  - Splits a path as a list of `/`-delimited elements, each with the form `"[#]name[:icon][@order]"`.
  - `path`: Path to split.
- `static Editor.Menu.PathElement[] GetSplitPath(Sandbox.Internal.ITitleProvider item)`
  - Combines the `Sandbox.Internal.ICategoryProvider.Value` (if exists) and `Sandbox.Internal.ITitleProvider.Value`, then splits it with `Editor.Menu.GetSplitPath(System.String)`.

### Instance methods

- `System.Void AddOptions(System.Collections.Generic.IEnumerable<T> items, System.Func<T,System.String> getPath, System.Action<T> action, System.Boolean flat, System.Boolean reduce, System.String defaultSubMenuIcon)`
- `System.Void AddOptions(System.Collections.Generic.IEnumerable<T> items, System.Action<T> action, System.Boolean flat, System.Boolean reduce, System.String defaultSubMenuIcon)`
- `System.Void AddOptions(System.Collections.Generic.IEnumerable<T> items, System.Func<T,Editor.Menu.PathElement[]> getPath, System.Action<T> action, System.Boolean flat, System.Boolean reduce, System.String defaultSubMenuIcon)`
- `virtual System.Void OnAboutToShow()`
- `virtual System.Void OnAboutToHide()`
- `virtual Editor.Option AddOption(System.String name, System.String icon, System.Action action, System.String shortcut)`
- `virtual Editor.Option AddOptionWithImage(System.String name, Editor.Pixmap icon, System.Action action, System.String shortcut)`
- `Editor.Option AddOption(System.String[] path, System.String icon, System.Action action, System.String shortcut)`
  - Like AddOption, except will automatically create the menu path from the array of names
- `Editor.Option AddOption(System.ReadOnlySpan<Editor.Menu.PathElement> path, System.Action action, System.String shortcut)`
- `virtual Editor.Option AddOption(Editor.Option option)`
- `T AddWidget(T widget)`
  - Add a widget as an action to the menu.<br />
Some widgets such as `Editor.Widget` and `Editor.LineEdit` require `Editor.Widget.OnMouseReleased(Editor.MouseEvent)`
to set `Editor.MouseEvent.Accepted` to `true` to prevent the menu from closing.
- `Editor.Label AddHeading(System.String title)`
- `System.Void GetPathTo(System.String path, System.Collections.Generic.List<Editor.Menu> list)`
- `System.Void GetPathTo(System.ReadOnlySpan<Editor.Menu.PathElement> path, System.Collections.Generic.List<Editor.Menu> list)`
- `Editor.Menu FindOrCreateMenu(System.String name)`
- `Editor.Menu AddMenu(System.String name, System.String icon)`
- `Editor.Menu AddMenu(Editor.Menu menu)`
- `Editor.Option GetOption(System.String name)`
- `System.Void RemoveOption(System.String name)`
- `System.Void RemoveOption(Editor.Option option)`
- `System.Void RemoveWidget(Editor.Widget widget)`
- `System.Void RemoveOptions()`
  - Remove all options
- `System.Void RemoveMenus()`
  - Remove all menus
- `System.Void RemoveWidgets()`
  - Remove all widgets
- `Editor.Option AddSeparator()`
- `System.Void OpenAt(Vector2 position, System.Boolean modal)`
- `System.Void OpenAtCursor(System.Boolean modal)`
  - Open this menu at the mouse cursor position
- `System.Void Clear()`
