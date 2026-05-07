# Editor.Widget

A generic widget.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.QObject`

## Constructors

- `Widget()`
- `Widget(Editor.Widget parent, System.Boolean isDarkWindow)`
  - The default widget constructor
  - `parent`: The parent to attach this to. This can be null while you're sorting stuff out, before you add it to a layout or something - but generally a null parent is something a window has.
  - `isDarkWindow`: If true we'll run a function on startup to force this to be a darkmode window. Basically pass true if this is going to be a window and we'll all be friends.

## Properties

- `System.Boolean Enabled`
  - Makes the widget not interactable. This is also usually be reflected visually by the widget.
The widget will not process any keyboard or mouse inputs. Applies retroactively to all children.
- `System.Boolean ReadOnly`
  - Makes the widget read only. I.e. You can copy text of a text entry, but can't edit it.
Applies retroactively to all children.
- `Editor.Widget Parent`
  - Parent widget. If non null, position of this widget will be relative to the parent widget. Certain events will also propagate to the parent widget if unhandled.
- `Sandbox.UI.Margin ContentMargins`
- `Sandbox.Rect ContentRect`
- `Vector2 Size`
  - Size of this widget.
- `Sandbox.Rect LocalRect`
  - This panel's rect at 0,0
- `Sandbox.Rect ScreenRect`
  - This panel's rect in screen coordinates
- `System.Single Width`
  - Utility to interact with a widget's width - use Size where possible
- `System.Single Height`
  - Utility to interact with a widget's width - use Size where possible
- `Vector2 MinimumSize`
  - Sets `Editor.Widget.MinimumWidth` and `Editor.Widget.MinimumHeight` simultaneously.
- `System.Single MinimumWidth`
  - This widgets width should never be smaller than the given value.
- `System.Single MinimumHeight`
  - This widgets height should never be smaller than the given value.
- `System.Single FixedHeight`
  - Sets the fixed height for this widget
- `System.Single FixedWidth`
  - Sets the fixed width for this widget
- `Vector2 FixedSize`
- `System.Single MaximumWidth`
  - This widgets width should never be larger than the given value.
- `System.Single MaximumHeight`
  - This widgets height should never be larger than the given value.
- `Vector2 MaximumSize`
  - Sets `Editor.Widget.MaximumWidth` and `Editor.Widget.MaximumHeight` simultaneously.
- `Vector2 Position`
  - Position of this widget, relative to its parent if it has one.
- `System.Boolean Visible`
  - Whether this widget is visible or not, in the tree. This will return false if a parent is hidden. You 
might want to set Hidden if you're looking to check local visible status on a widget.
- `System.Boolean Hidden`
  - Whether this widget is hidden. This differs from Visible because this will return the state for
this particular widget, where as Visible returns false if a parent is hidden etc.
- `System.String Name`
  - Name of the widget, usually for debugging purposes.
- `System.Boolean TranslucentBackground`
- `System.Boolean NoSystemBackground`
- `System.Boolean TransparentForMouseEvents`
- `System.Boolean ShowWithoutActivating`
- `System.Boolean MouseTracking`
- `System.Boolean AcceptDrops`
  - Accept drag and dropping shit on us
- `System.Boolean IsFramelessWindow`
- `System.Boolean IsTooltip`
- `System.Boolean IsPopup`
- `System.Boolean IsWindow`
- `System.Boolean HasMaximizeButton`
- `System.Boolean DeleteOnClose`
  - Delete this widget when close is pressed
- `System.Single DpiScale`
  - The scale this widget is using (multiplying Size by this value gives the actual native size)
- `System.Boolean IsFocused`
  - Whether this widget has keyboard focus.
- `System.Boolean IsActiveWindow`
- `Editor.FocusMode FocusMode`
  - Sets the focus mode for this widget. This determines both how it will get focus and whether it will receive keyboard input.
- `System.Boolean ContextMenuEnabled`
  - Enables or disables the context menu on this widget.
- `Editor.WindowFlags WindowFlags`
- `System.Collections.Generic.IEnumerable<Editor.Widget> Children`
  - Child widgets of this widget.
- `Editor.CursorShape Cursor`
  - Cursor override for this widget.
- `Editor.Pixmap PixmapCursor`
  - Custom cursor override for this widget.
Will override `Editor.Widget.Cursor` with `Editor.CursorShape.CustomCursor`.
- `Vector2 ScreenPosition`
  - Position of the widget relative to the monitor's top left corner.
- `Editor.Widget FocusProxy`
- `System.Boolean IsUnderMouse`
- `Editor.SizeMode HorizontalSizeMode`
- `Editor.SizeMode VerticalSizeMode`
- `System.String ToolTip`
  - If set, this text will be displayed after a certain delay of hovering this widget with the mouse cursor.
- `System.String StatusTip`
  - If set, hovering over this widget will set the text of a `Editor.StatusBar` of the window the widget belongs to.
- `Sandbox.Rect ScreenGeometry`
  - Returns the geometry of the screen this widget is currently on.
- `System.String WindowTitle`
- `System.Boolean IsMinimized`
- `System.Boolean IsMaximized`
- `System.Single WindowOpacity`
- `System.Boolean UpdatesEnabled`
  - If true, Update will call
- `System.Boolean DebugModeEnabled`
  - Enable debug mode on this widget.
- `System.Boolean ProvidesDebugMode`
  - If true then this widget has a debug mode that can be activated
- `System.Boolean IsPressed`
  - Whether this widget is currently being pressed down or not.
- `System.Boolean IsDraggable`
  - Whether this widget can be drag and dropped onto other widgets.
- `System.Boolean IsBeingDroppedOn`
  - Whether something is being dragged over this widget.
- `Editor.Layout Layout`
  - The widget's internal layout, if any

## Fields

- `System.Action MouseRelease`
- `System.Action MouseClick`
- `System.Action MouseRightClick`
- `System.Action MouseLeftPress`
  - Called when this widget is left clicked (on mouse press).
- `System.Action MouseRightPress`
  - Called when this widget is right clicked (on mouse press).
- `System.Action MouseMiddlePress`
  - Called when this widget is clicked with the mouse wheel (on mouse press).
- `System.Action<Vector2> MouseMove`
- `System.Func<System.Boolean> OnPaintOverride`
  - Override the widget's paint process.
            
Return `true` to prevent the default paint action, which is to call `Editor.Widget.OnPaint`.

## Methods

### Instance methods

- `System.Void SetContext(System.String key, System.Object value)`
  - Set a context value on this widget. This context will be available to its children via FindContext.
- `System.Void ClearContext(System.String key)`
  - Remove a context on this widget. This will NOT remove contexts set from parent objects.
- `T GetContext(System.String key, T defaultIfMissing)`
  - Find a context on this widget. If not found, look at the parent. If not found, look at the parent.
This is useful for passing information down to child widgets without any effort.
- `T GetAncestor()`
  - Find the closest ancestor widget of type
- `System.Collections.Generic.IEnumerable<T> GetDescendants()`
  - Get all descendants of type T
- `System.Boolean IsDescendantOf(Editor.Widget parent)`
  - Returns whether or not the specified Widget is a descendent of this Widget.
- `System.Boolean IsAncestorOf(Editor.Widget child)`
  - Returns whether or not the specified Widget is an ancestor of this Widget.
- `System.Void Focus(System.Boolean activateWindow)`
- `System.Void Blur()`
  - Clear keyboard focus from this widget.
- `System.Void SetStyles(System.String sheet)`
  - Directly set CSS style sheet(s) for this widget. Same format as a .css file.
- `System.Void SetStylesheetFile(System.String filename)`
  - Set a file to load CSS for this widget from.
- `System.Void DestroyChildren()`
  - Destroys all child widgets of this widget.
- `virtual System.Void Update()`
  - Tell this widget that shit changed and it needs to redraw
- `Vector2 ToScreen(Vector2 p)`
  - Transform coordinates relative to the panel's top left corner, to coordinates relative to monitors's top left corner.
  - `p`: Position on the panel, relative it its top left corner.
  - returns: The same position relative to the monitors top left corner.
- `Vector2 FromScreen(Vector2 p)`
  - Transform coordinates relative to the monitors's top left corner, to coordinates relative to panel's top left corner.
  - `p`: Position relative to the monitors top left corner.
  - returns: The same position on the panel, relative it its top left corner.
- `System.Void PostKeyEvent(Editor.KeyCode key)`
- `System.Void SetSizeMode(Editor.SizeMode horizontal, Editor.SizeMode vertical)`
- `System.String SaveGeometry()`
  - Serialize position and size of this widget to a string, which can then be passed to `Editor.Widget.RestoreGeometry(System.String)`.
- `System.Void RestoreGeometry(System.String state)`
  - Restore position and size previously stored via `Editor.Widget.SaveGeometry`.
- `virtual System.Void Signal(Editor.WidgetSignal signal)`
- `virtual System.Void ChildValuesChanged(Editor.Widget source)`
- `System.Void MakeSignal(System.String name)`
- `System.Void SignalValuesChanged()`
  - When a value on this widget changed due to user input (ie, checking a box, editing a form)
this is called, which sends a signal up the parent widgets.
- `System.Void AdjustSize()`
  - Adjusts the size of the widget to fit its contents.
- `System.Void ConstrainToScreen()`
  - Constrain this widget to the screen it's currently on.
- `System.Void ConstrainTo(Sandbox.Rect parentRect)`
  - Reposition this widget to ensure it is within the given rectangle.
  - `parentRect`: Rectangle to constraint to, relative to the parent widget.
- `virtual System.Void SetWindowIcon(System.String name)`
- `virtual System.Void SetWindowIcon(Editor.Pixmap icon)`
- `virtual System.Void Show()`
  - Make this widget visible.
- `virtual System.Void Hide()`
  - Make this widget not visible.
- `virtual System.Void Close()`
  - If a window - will close
- `System.Void MakeMinimized()`
- `System.Void MakeMaximized()`
- `System.Void MakeWindowed()`
- `System.Void SetModal(System.Boolean on, System.Boolean application)`
  - Set this window to be modal. This means it will appear on top of everything and block input to everything else.
- `System.Boolean IsModal()`
  - Returns true if this is a modal window. This means it will appear on top of everything and block input to everything else.
- `System.Void DisableWindowActivation()`
  - Calling this will set the WS_EX_NOACTIVATE flag on the window internally, which will stop
it taking focus away from other windows.
- `System.Void SetEffectOpacity(System.Single f)`
- `System.Boolean SetContentHash(System.Int32 hash, System.Single secondsDebounce)`
  - Call every frame/tick to redraw this Widget on content change
- `System.Boolean SetContentHash(System.Func<System.Int32> getHash, System.Single secondsDebounce)`
- `virtual System.Void AlignToParent(Sandbox.TextFlag alignment, Vector2 offset)`
  - Align this widget to its parents edge, with an offset.
- `System.Void UpdateGeometry()`
  - Tell everything that the geometry of this has changed
- `Editor.Widget GetWindow()`
  - Get the top level window widget
- `virtual System.Void OnMouseWheel(Editor.WheelEvent e)`
  - Mouse wheel was scrolled while the mouse cursor was over this widget.
- `virtual System.Void OnWheel(Editor.WheelEvent e)`
  - Mouse wheel was scrolled while the mouse cursor was over this widget.
- `virtual System.Void OnMouseReleased(Editor.MouseEvent e)`
  - Called when mouse is released over this widget.
- `virtual System.Void OnMouseClick(Editor.MouseEvent e)`
  - Called when this widget is left clicked (on mouse release).
- `virtual System.Void OnMouseRightClick(Editor.MouseEvent e)`
  - Called when this widget is right clicked (on mouse release).
- `virtual System.Void OnMousePress(Editor.MouseEvent e)`
  - Called when mouse is pressed over this widget.
- `virtual System.Void OnMouseMove(Editor.MouseEvent e)`
  - Called when the mouse cursor is moved while being over this widget.
- `virtual System.Void OnMouseEnter()`
  - Mouse cursor entered the bounds of this widget.
- `virtual System.Void OnMouseLeave()`
  - Mouse cursor exited the bounds of this widget.
- `virtual System.Void OnContextMenu(Editor.ContextMenuEvent e)`
  - Called after `Editor.Widget.OnMouseRightClick(Editor.MouseEvent)`, for the purposes of opening a context menu.
- `virtual System.Void OnDoubleClick(Editor.MouseEvent e)`
  - Called when the widget was double clicked with any mouse button.
- `virtual System.Void OnKeyPress(Editor.KeyEvent e)`
  - A key has been pressed. Your widget needs keyboard focus for this to be called - see FocusMode.
- `virtual System.Void OnKeyRelease(Editor.KeyEvent e)`
  - A key has been released.
- `virtual System.Void OnShortcutPressed(Editor.KeyEvent e)`
  - A shortcut has been activated. This is called on the focused control so they can override it.
- `virtual System.Void OnFocus(Editor.FocusChangeReason reason)`
  - Called when the widget gains keyboard focus.
- `virtual System.Void OnBlur(Editor.FocusChangeReason reason)`
  - Called when the widget loses keyboard focus.
- `virtual System.Void OnResize()`
  - Called when the widgets' size was changed.
- `virtual System.Void OnMoved()`
  - Called when the widget was moved to a new position relative to it's parent.
- `virtual System.Void OnPaint()`
  - Override to custom paint your widget, for example using `Editor.Paint`. Can be overwritten by `Editor.Widget.OnPaintOverride`.
- `virtual System.Boolean OnClose()`
  - Called when a window is about to be closed.
- `virtual System.Void OnClosed()`
  - Called when a window is closed.
- `virtual System.Void OnVisibilityChanged(System.Boolean visible)`
  - Called when the visibility of this widget changes.
- `virtual System.Boolean FocusNext()`
  - Called when Tab is pressed to find the next widget to focus.
Return true to prevent focusing.
- `virtual System.Boolean FocusPrevious()`
  - Called when Shift + Tab is pressed to find the next widget to focus.
Return true to prevent focusing.
- `virtual System.Void DoLayout()`
  - Called to make sure all child panels are in correct positions and have correct sizes.
This is typically called when the size of this widget changes, but there are other cases as well.
- `virtual Vector2 MinimumSizeHint()`
  - Return the minimum size this widget wants to be
- `virtual Vector2 SizeHint()`
  - Should return the size this widget really wants to be if it can its way. The default
is that you don't care - and just to return whatever the base value is.
- `virtual System.Void OnDragStart()`
  - Called when dragging. `Editor.Widget.IsDraggable` should be true.
- `virtual System.Void OnDragLeave()`
  - Cursor with drag and drop data left the bounds of this widget.


Requires `Editor.Widget.AcceptDrops` to function.
- `virtual System.Void OnDragHover(Editor.Widget.DragEvent ev)`
  - Cursor with drag and drop data moved on this widget.


Requires `Editor.Widget.AcceptDrops` to function.
  - `ev`: The drag event info.
- `virtual System.Void OnDragDrop(Editor.Widget.DragEvent ev)`
  - Something was dragged and dropped on this widget. Apply the data here, if its valid.


Requires `Editor.Widget.AcceptDrops` to function.
  - `ev`: The drag event info.
- `System.Void Raise()`
  - Raises this widget to the top of the parent widget's stack.
After this call the widget will be visually in front of any overlapping sibling widgets.
- `System.Void Lower()`
  - Lowers the widget to the bottom of the parent widget's stack.
After this call the widget will be visually behind (and therefore obscured by) any overlapping sibling widgets.
