# Editor.ShortcutContext

Scope of the shortcut. Requires focus at this level for the shortcut to be active.
Defaults to `Editor.ShortcutContext.WindowShortcut`.

- **Kind:** enum
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `System.Enum`

## Values

- `WidgetShortcut` - Shortcut is only active when the parent widget is focused.
- `WindowShortcut` - Shortcut is only active when the window of the parent widget is focused.
- `ApplicationShortcut` - Shortcut is only active when one of the application windows is focused.
- `WidgetWithChildrenShortcut` - Shortcut is only active when the parent widget, or a child of the parent widget, is focused.
