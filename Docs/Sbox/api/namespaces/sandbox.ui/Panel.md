# Sandbox.UI.Panel

A simple User Interface panel. Can be styled with <a href="https://en.wikipedia.org/wiki/CSS">CSS</a>.

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Panel()`
- `Panel(Sandbox.UI.Panel parent)`
- `Panel(Sandbox.UI.Panel parent, System.String classnames)`

## Properties

- `Sandbox.UI.Construct.PanelCreator Add`
  - Quickly add common panels with certain values as children.
- `System.Collections.Generic.IEnumerable<Sandbox.UI.Panel> Children`
  - List of panels that are attached/<see cref="P:Sandbox.UI.Panel.Parent">parented</see> directly to this one.
- `System.Boolean HasChildren`
  - Whether this panel has any <see cref="P:Sandbox.UI.Panel.Children">child panels</see> at all.
- `Sandbox.UI.Panel Parent`
  - The panel we are directly attached to. This panel will be positioned relative to the given parent, and therefore move with it, typically also be hidden by the parents bounds.
- `System.Int32 SiblingIndex`
  - The index of this panel in its parent's child list.
- `System.Collections.Generic.IEnumerable<Sandbox.UI.Panel> AncestorsAndSelf`
  - Returns this panel and all its <see cref="P:Sandbox.UI.Panel.Ancestors">ancestors</see>, i.e. the <see cref="P:Sandbox.UI.Panel.Parent">Parent</see>, parent of its parent, etc.
- `System.Collections.Generic.IEnumerable<Sandbox.UI.Panel> Ancestors`
  - Returns all ancestors, i.e. the parent, parent of our parent, etc.
- `System.Collections.Generic.IEnumerable<Sandbox.UI.Panel> Descendants`
  - List of all panels that are attached to this panel, recursively, i.e. all <see cref="P:Sandbox.UI.Panel.Children">children</see> of this panel, children of those children, etc.
- `Sandbox.Scene Scene`
  - Returns the scene that this panel belongs to
- `Sandbox.GameObject GameObject`
  - Returns the GameObject that this panel belongs to
- `System.Int32 ChildrenCount`
  - Amount of panels directly <see cref="P:Sandbox.UI.Panel.Parent">parented</see> to this panel.
- `System.Collections.Generic.IEnumerable<System.String> Class`
  - A list of CSS classes applied to this panel.
- `System.String Classes`
  - All CSS classes applied to this panel, separated with spaces.
- `System.String ElementName`
  - The element name. If you've created this Panel via a template this will be whatever the element
name is on there. If not then it'll be the name of the class (ie Panel, Button)
- `System.String Id`
  - Works the same as the html id="" attribute. If you set Id to "poop", it'll match any styles
that define #poop in their selector.
- `System.String SourceFile`
  - If this was created by razor, this is the file in which it was created
- `System.Int32 SourceLine`
  - If this was created by razor, this is the line number in the file
- `Sandbox.UI.PseudoClass PseudoClass`
  - Special flags used by the styling system for hover, active etc..
- `System.Boolean HasFocus`
  - Whether this panel has the `:focus` pseudo class active.
- `System.Boolean HasActive`
  - Whether this panel has the `:active` pseudo class active.
- `System.Boolean HasHovered`
  - Whether this panel has the `:hover` pseudo class active.
- `System.Boolean HasIntro`
  - Whether this panel has the `:intro` pseudo class active.
- `System.Boolean HasOutro`
  - Whether this panel has the `:outro` pseudo class active.
- `System.Collections.Generic.IEnumerable<Sandbox.UI.StyleSheet> AllStyleSheets`
  - List of all `Sandbox.UI.StyleSheet`s applied to this panel and all its <see cref="P:Sandbox.UI.Panel.AncestorsAndSelf">ancestors</see>.
- `System.Boolean IsVisible`
  - Return true if this panel isn't hidden by opacity or displaymode.
- `System.Boolean IsVisibleSelf`
  - Return true if this panel isn't hidden by opacity or displaymode.
- `System.Boolean AllowChildSelection`
  - Allow selecting child text
- `System.Boolean IsValid`
- `System.String StringValue`
  - Set via `"value"` property from HTML.
- `System.Boolean IsDeleting`
  - Whether `Sandbox.UI.Panel.Delete(System.Boolean)` was called on this panel.
- `System.Boolean WantsDrag`
  - Return true if this panel wants to be dragged
- `System.Boolean CanDragScroll`
  - Set this to false if you want to opt out of drag scrolling
- `System.Boolean WantsDragScrolling`
- `System.Boolean HasScrollX`
  - Return true if this panel is scrollable on the X axis
- `System.Boolean HasScrollY`
  - Return true if this panel is scrollable on the Y axis
- `Vector2 MousePosition`
  - Current mouse position local to this panels top left corner.
- `System.Boolean AcceptsFocus`
  - False by default, can this element accept keyboard focus. If an element accepts
focus it'll be able to receive keyboard input.
- `Sandbox.UI.PanelInputType ButtonInput`
  - Describe what to do with keyboard input. The default is InputMode.UI which means that when
focused, this panel will receive Keys Typed and Button Events.
If you set this to InputMode.Game, this panel will redirect its inputs to the game, which means
for example that if you're focused on this panel and press space, it'll send the jump button to the game.
- `System.Boolean AcceptsImeInput`
  - False by default. Anything that is capable of accepting IME input should return true. Which is probably just a TextEntry.
- `System.Boolean HasMouseCapture`
  - Whether this panel is capturing the mouse cursor. See `Sandbox.UI.Panel.SetMouseCapture(System.Boolean)`.
- `Sandbox.UI.Box Box`
  - Access to various bounding boxes of this panel.
- `System.Boolean HasContent`
  - If true, calls `Sandbox.UI.Panel.DrawContent(Sandbox.UI.PanelRenderer,Sandbox.UI.RenderState@)`.
- `Vector2 ScrollOffset`
  - Offset of the panel's children position for scrolling purposes.
- `System.Single ScaleToScreen`
  - Scale of the panel on the screen.
- `System.Single ScaleFromScreen`
  - Inverse scale of `Sandbox.UI.Panel.ScaleToScreen`.
- `System.Nullable<Matrix> LocalMatrix`
  - If this panel has transforms, they'll be reflected here
- `System.Nullable<Matrix> GlobalMatrix`
  - If this panel or its parents have transforms, they'll be compounded here.
- `System.Single Opacity`
  - The currently calculated opacity.
This is set by multiplying our current style opacity with our parent's opacity.
- `System.Boolean PreferScrollToBottom`
  - If true, we'll try to stay scrolled to the bottom when the panel changes size
- `System.Boolean IsScrollAtBottom`
  - Whether the scrolling is currently pinned to the bottom of the panel as dictated by `Sandbox.UI.Panel.PreferScrollToBottom`.
- `Vector2 ScrollSize`
  - The size of the scrollable area within this panel.
- `System.Boolean IsDragScrolling`
  - Is this panel currently being scrolled by dragging?
- `Microsoft.AspNetCore.Components.RenderFragment ChildContent`
- `Sandbox.UI.Styles ComputedStyle`
  - This is the style that we computed last. If you're looking to see which
styles are set on this panel then this is what you're looking for.
- `System.Collections.Generic.IEnumerable<Sandbox.UI.IStyleBlock> ActiveStyleBlocks`
  - A importance sorted list of style blocks that are active on this panel
- `Sandbox.UI.PanelStyle Style`
  - Allows you to set styles specifically on this panel. Setting the style will
only affect this panel and no others and will override any other styles.
- `System.String Tooltip`
  - A string to show when hovering over this panel.
- `System.String TooltipClass`
  - The created tooltip element will have this class, if set.
- `System.Boolean HasTooltip`
  - You should override and return true if you're overriding `Sandbox.UI.Panel.CreateTooltipPanel`.
Otherwise this will return true if `Sandbox.UI.Panel.Tooltip` is not empty.
- `Sandbox.UI.Transitions Transitions`
  - Handles the storage, progression and application of CSS transitions.
- `System.Boolean HasActiveTransitions`
  - Returns true if this panel has any active CSS transitions.
- `System.Object UserData`
  - Can be used to store random data without sub-classing the panel.
- `System.Threading.CancellationToken DeletionToken`
  - Get a token that is cancelled when the panel is deleted

## Fields

- `Sandbox.TaskSource Task`
  - Quick access to timing events, for async/await.
- `Sandbox.UI.StyleSheetCollection StyleSheet`
  - A collection of stylesheets applied to this panel directly.
- `Vector2 ScrollVelocity`
  - The velocity of the current scroll

## Methods

### Instance methods

- `virtual System.Void OnChildRemoved(Sandbox.UI.Panel child)`
  - A child panel has been removed from this panel.
- `System.Void DeleteChildren(System.Boolean immediate)`
  - Deletes all child panels via `Sandbox.UI.Panel.Delete(System.Boolean)`.
- `T AddChild(T p)`
  - Add given panel as a child to this panel.
- `virtual System.Void OnChildAdded(Sandbox.UI.Panel child)`
  - A child panel has been added to this panel.
- `System.Void SortChildren(System.Comparison<Sandbox.UI.Panel> sorter)`
- `System.Void SortChildren(System.Func<TargetType,System.Int32> sorter)`
- `System.Void SortChildren(System.Func<Sandbox.UI.Panel,System.Int32> sorter)`
- `virtual System.Boolean IsPanelEmpty()`
  - Can be overridden by children to determine whether the panel is empty, and the :empty pseudo-class should be applied.
- `System.Void EmptyStateChanged()`
  - Should be called if overriding IsEmpty to notify the panel that its empty state has changed.
- `T AddChild(System.String classnames)`
  - Creates a panel of given type and makes it our child.
  - `classnames`: Optional CSS class names to apply to the newly created panel.
  - returns: The created panel.
- `System.Boolean AddChild(T outPanel, System.String classnames)`
  - Creates a panel of given type and makes it our child, returning it as an out argument.
  - `outPanel`: The created panel.
  - `classnames`: Optional CSS class names to apply to the newly created panel.
  - returns: Always returns `true`.
- `System.Boolean IsAncestor(Sandbox.UI.Panel panel)`
  - Is the given panel a parent, grandparent, etc.
- `Sandbox.UI.RootPanel FindRootPanel()`
  - Returns the `Sandbox.UI.RootPanel` we are ultimately attached to, if any.
- `virtual Sandbox.UI.Panel FindPopupPanel()`
  - Returns the first <see cref="P:Sandbox.UI.Panel.Ancestors">ancestor</see> panel that has no parent.
- `System.Int32 GetChildIndex(Sandbox.UI.Panel panel)`
  - Returns the index at which the given panel is <see cref="P:Sandbox.UI.Panel.Parent">parented</see> to this panel, or -1 if it is not.
- `Sandbox.UI.Panel GetChild(System.Int32 index, System.Boolean loop)`
  - Return a child at given index.
  - `index`: Index at which to look.
  - `loop`: Whether to loop indices when out of bounds, i.e. -1 becomes last child, 11 becomes second child in a list of 10, etc.
  - returns: Returns the requested child, or `null` if it was not found.
- `System.Collections.Generic.IEnumerable<T> ChildrenOfType()`
  - Returns a list of <see cref="P:Sandbox.UI.Panel.Children">child panels</see> of given type.
- `System.Void AddClass(System.String classname)`
  - Adds CSS class(es) separated by spaces to this panel.
- `System.Void SetClass(System.String classname, System.Boolean active)`
  - Sets a specific CSS class active or not.
- `System.Void FlashClass(System.String classname, System.Single seconds)`
  - Add a class for a set amount of seconds. If called multiple times, we will stomp the earlier call.
- `System.Void ToggleClass(System.String classname)`
  - Add a class if we don't have it, remove a class if we do have it
- `System.Void RemoveClass(System.String classname)`
  - Removes given CSS class from this panel.
- `System.Boolean HasClass(System.String classname)`
  - Whether we have the given CSS class or not.
- `System.Void BindClass(System.String className, System.Func<System.Boolean> func)`
- `virtual System.Void OnHotloaded()`
  - Called when a hotload happened. (Not necessarily on this panel)
- `System.Boolean Switch(Sandbox.UI.PseudoClass c, System.Boolean state)`
  - Switch a pseudo class on or off.
- `virtual System.Void Tick()`
  - Called every frame. This is your "Think" function.
- `virtual System.Void OnParentChanged()`
  - Called after the parent of this panel has changed.
- `virtual System.Boolean WantsMouseInput()`
  - Returns true if this panel would like the mouse cursor to be visible.
- `Vector2 ScreenPositionToPanelDelta(Vector2 pos)`
  - Convert a point from the screen to a point representing a delta on this panel where
the top left is [0,0] and the bottom right is [1,1]
- `Vector2 ScreenPositionToPanelPosition(Vector2 pos)`
  - Convert a point from the screen to a position relative to the top left of this panel
- `Vector2 PanelPositionToScreenPosition(Vector2 pos)`
  - Convert a point from local space to screen space
- `System.Collections.Generic.IEnumerable<Sandbox.UI.Panel> FindInRect(Sandbox.Rect box, System.Boolean fullyInside)`
  - Find and return any children of this panel (including self) within the given rect.
  - `box`: The area to look for panels in, in screen-space coordinates.
  - `fullyInside`: Whether we want only the panels that are completely within the given bounds.
- `virtual System.Void OnDragSelect(Sandbox.UI.SelectionEvent e)`
  - Called when the player moves the mouse after "press and holding" (or dragging) the panel.
- `System.Void SelectAllInChildren()`
  - If AllowChildSelection is enabled, we'll try to select all children text
- `System.Void UnselectAllInChildren()`
  - Clear any selection in children
- `virtual System.Void LanguageChanged()`
  - Called when the current language has changed. This allows you to rebuild
anything that might need rebuilding. Tokenized text labels should automatically update.
- `System.Void Invoke(System.Single seconds, System.Action action)`
  - Invoke a method after a delay. If the panel is deleted before this delay the method will not be called.
- `System.Void InvokeOnce(System.String name, System.Single seconds, System.Action action)`
  - Invoke a method after a delay. If the panel is deleted before this delay the method will not be called. If the invoke is called
while the old one is waiting, the old one will be cancelled.
- `System.Void CancelInvoke(System.String name)`
  - Cancel a named invocation
- `System.Void CreateValueEvent(System.String name, System.Object value)`
  - Call this when the value has changed due to user input etc. This updates any
bindings, backwards. Also triggers $"{name}.changed" event, with value being the Value on the event.
- `virtual System.Void Delete(System.Boolean immediate)`
  - Deletes the panel.
  - `immediate`: If `true`, will skip any outros. (`:outro` CSS pseudo class)
- `virtual System.Void OnDeleted()`
  - Called when the panel is about to be deleted.
- `virtual System.Void OnDragStart(Sandbox.UI.DragEvent e)`
- `virtual System.Void OnDragEnd(Sandbox.UI.DragEvent e)`
- `virtual System.Void OnDrag(Sandbox.UI.DragEvent e)`
- `virtual System.Void OnDragEnter(Sandbox.UI.PanelEvent e)`
  - Called when a panel is being dragged over this panel. Fires continuously as the cursor moves.
- `virtual System.Void OnDragLeave(Sandbox.UI.PanelEvent e)`
  - Called when a panel being dragged leaves this panel's bounds.
- `virtual System.Void OnDrop(Sandbox.UI.PanelEvent e)`
  - Called when a dragged panel is released over this panel.
- `System.Void DrawBackgroundTexture(Sandbox.Texture texture, Sandbox.UI.Length defaultSize)`
  - Draws a texture using this panel's CSS box styling (border radius, border image, background position/size,
tint, blend mode, filter mode, etc.) and adds the resulting descriptor to `Sandbox.UI.Panel.CachedDescriptors`.


This is intended for controls like `Sandbox.UI.Image`, `Sandbox.UI.ScenePanel`, and `Sandbox.UI.SvgPanel`
that render a texture as their primary content while respecting the panel's CSS properties.
For simple texture drawing without CSS styling, use `Sandbox.UI.Panel.Draw.Texture(Sandbox.Texture,Sandbox.Rect,System.Nullable{Color})` instead.
  - `texture`: The texture to draw. If null or invalid, draws the styled box without a texture.
  - `defaultSize`: Controls how the texture is sized within the panel (e.g. `Sandbox.UI.Length.Cover`, `Sandbox.UI.Length.Contain`, `Sandbox.UI.Length.Auto`).
- `virtual System.Void InitializeEvents()`
  - Called on creation and hotload to delete and re-initialize event listeners.
- `System.Void AddEventListener(System.String eventName, System.Action<Sandbox.UI.PanelEvent> e)`
- `System.Void AddEventListener(System.String eventName, System.Action action)`
  - Runs given callback when the given event is triggered, without access to the `Sandbox.UI.PanelEvent`.
- `virtual System.Void CreateEvent(System.String name, System.Object value, System.Nullable<System.Single> debounce)`
- `virtual System.Void CreateEvent(Sandbox.UI.PanelEvent evnt)`
  - Pass given event to the event queue.
- `virtual System.Void OnEvent(Sandbox.UI.PanelEvent e)`
  - Called when various `Sandbox.UI.PanelEvent`s happen. Handles event listeners and many standard events by default.
- `virtual System.Void OnClick(Sandbox.UI.MousePanelEvent e)`
  - Called when the player releases their left mouse button (Mouse 1) while hovering this panel.
- `virtual System.Void OnMiddleClick(Sandbox.UI.MousePanelEvent e)`
  - Called when the player releases their middle mouse button (Mouse 3) while hovering this panel.
- `virtual System.Void OnRightClick(Sandbox.UI.MousePanelEvent e)`
  - Called when the player releases their right mouse button (Mouse 2) while hovering this panel.
- `virtual System.Void OnMouseDown(Sandbox.UI.MousePanelEvent e)`
  - Called when the player presses down the left or right mouse buttons while hovering this panel.
- `virtual System.Void OnMouseUp(Sandbox.UI.MousePanelEvent e)`
  - Called when the player releases left or right mouse button.
- `virtual System.Void OnDoubleClick(Sandbox.UI.MousePanelEvent e)`
  - Called when the player double clicks the panel with the left mouse button.
- `virtual System.Void OnMouseMove(Sandbox.UI.MousePanelEvent e)`
  - Called when the cursor moves while hovering this panel.
- `virtual System.Void OnMouseOver(Sandbox.UI.MousePanelEvent e)`
  - Called when the cursor enters this panel.
- `virtual System.Void OnMouseOut(Sandbox.UI.MousePanelEvent e)`
  - Called when the cursor leaves this panel.
- `virtual System.Void OnBack(Sandbox.UI.PanelEvent e)`
  - Called when the player presses the "Back" button while hovering this panel, which is typically "mouse 5", aka one of the mouse buttons on its side.
- `virtual System.Void OnForward(Sandbox.UI.PanelEvent e)`
  - Called when the player presses the "Forward" button while hovering this panel, which is typically "mouse 4", aka one of the mouse buttons on its side.
- `virtual System.Void OnEscape(Sandbox.UI.PanelEvent e)`
  - Called when the escape key is pressed
- `virtual System.Void OnFocus(Sandbox.UI.PanelEvent e)`
  - Called when this panel receives input focus.
- `virtual System.Void OnBlur(Sandbox.UI.PanelEvent e)`
  - Called when this panel loses input focus.
- `virtual Vector2 GetTransformPosition(Vector2 pos)`
  - Called by `Sandbox.UI.PanelInput.CheckHover(Sandbox.UI.Panel,Vector2,Sandbox.UI.Panel@)` to transform
the current mouse position using the panel's LocalMatrix (by default). This can be overriden for special cases.
- `System.Boolean IsInside(Vector2 pos)`
  - Whether given screen position is within this panel. This will accurately handle border radius as well.
  - `pos`: The position to test, in screen coordinates.
- `System.Boolean IsInside(Sandbox.Rect rect, System.Boolean fullyInside)`
  - Whether the given rect is inside this panels bounds. (`Sandbox.UI.Box.Rect`)
  - `rect`: The rect to test, which should have screen-space coordinates.
  - `fullyInside`: `true` to test if the given rect is completely inside the panel. `false` to test for an intersection.
- `System.Boolean Focus()`
  - Give input focus to this panel.
- `System.Boolean Blur()`
  - Remove input focus from this panel.
- `virtual System.Void OnButtonEvent(Sandbox.UI.ButtonEvent e)`
  - Called when any button, mouse (except for mouse4/5) and keyboard, are pressed or depressed while hovering this panel.
- `virtual System.Void OnKeyTyped(System.Char k)`
  - Called when a printable character has been typed (pressed) while this panel has input focus. (`Sandbox.UI.Panel.Focus`)
- `virtual System.Void OnButtonTyped(Sandbox.UI.ButtonEvent e)`
  - Called when any keyboard button has been typed (pressed) while this panel has input focus. (`Sandbox.UI.Panel.Focus`)
- `virtual System.Void OnPaste(System.String text)`
  - Called when the user presses CTRL+V while this panel has input focus.
- `virtual System.String GetClipboardValue(System.Boolean cut)`
  - If we have a value that can be copied to the clipboard, return it here.
- `virtual System.Void OnMouseWheel(Vector2 value)`
  - Called when the player scrolls their mouse wheel while hovering this panel.
  - `value`: The scroll wheel delta. Positive values are scrolling down, negative - up.
- `System.Boolean TryScroll(Vector2 value)`
  - Called from `Sandbox.UI.Panel.OnMouseWheel(Vector2)` to try to scroll.
  - `value`: The scroll wheel delta. Positive values are scrolling down, negative - up.
  - returns: Return true to NOT propagate the event to the `Sandbox.UI.Panel.Parent`.
- `System.Boolean TryScrollToBottom()`
  - Scroll to the bottom, if the panel has scrolling enabled.
  - returns: Whether we scrolled to the bottom or not.
- `System.Void SetMouseCapture(System.Boolean b)`
  - Captures the mouse cursor while active. The cursor will be hidden and will be stuck in place.


You will want to use `Sandbox.Mouse.Delta` in
`Sandbox.UI.Panel.Tick` while `Sandbox.UI.Panel.HasMouseCapture` to read mouse movements.



You can call this from `Sandbox.UI.Panel.OnButtonEvent(Sandbox.UI.ButtonEvent)` for mouse clicks.
  - `b`: Whether to enable or disable the capture.
- `virtual System.Boolean RayToLocalPosition(Ray ray, Vector2 position, System.Single distance)`
  - Transform a ray in 3D space to a position on the panel. This is used for world panel input.
  - `ray`: The ray in 3D world space to test against this panel.
  - `position`: Position on the panel where the intersection happened, local to the panel's top left corner.
  - `distance`: Distance from the ray's origin to the intersection in 3D space.
  - returns: Return true if a hit/intersection was detected.
- `virtual System.Void OnVisibilityChanged()`
  - Called when the visibility of the current panel changes. This could be because our own style changed, or a parent style.
You can check visibility using `Sandbox.UI.Panel.IsVisible` and `Sandbox.UI.Panel.IsVisibleSelf`.
- `virtual System.Void OnLayout(Sandbox.Rect layoutRect)`
  - This panel has just been laid out. You can modify its position now and it will affect its children.
This is a useful place to restrict shit to the screen etc.
- `virtual System.Void FinalLayout(Vector2 offset)`
  - Takes a `Sandbox.UI.LayoutCascade` and returns an outer rect
- `virtual System.Void FinalLayoutChildren(Vector2 offset)`
  - Layout the children of this panel.
  - `offset`: The parent's position.
- `virtual System.Void AddScrollVelocity()`
- `virtual System.Void ConstrainScrolling(Vector2 size)`
  - Constrain <see cref="P:Sandbox.UI.Panel.ScrollOffset">scrolling</see> to the given size.
- `System.Void PlaySound(System.String sound)`
  - Play a sound from this panel.
- `System.Void MoveAfterSibling(Sandbox.UI.Panel previousSibling)`
  - Move this panel to be after the given sibling.
- `System.Void SetChildIndex(Sandbox.UI.Panel child, System.Int32 newIndex)`
  - Move given child panel to be given index, where 0 is the first child.
- `virtual System.Void SetPropertyObject(System.String name, System.Object value)`
  - Same as `Sandbox.UI.Panel.SetProperty(System.String,System.String)`, but first tries to set the property on the panel object, then process any special properties such as `class`.
- `virtual System.Void SetProperty(System.String name, System.String value)`
  - Set a property on the panel, such as special properties (`class`, `id`, `style` and `value`, etc.) and properties of the panel's C# class.
  - `name`: name of the property to modify.
  - `value`: Value to assign to the property.
- `System.Void SetAttribute(System.String k, System.String v)`
  - Used in templates, gets an attribute that was set in the template.
- `System.String GetAttribute(System.String k, System.String defaultIfNotFound)`
  - Used in templates, try to get the attribute that was set in creation.
- `virtual System.Void OnParametersSet()`
  - Called after all templated panel binds have been set.
- `virtual System.Threading.Tasks.Task OnParametersSetAsync()`
  - Called after all templated panel binds have been set.
- `virtual System.Void SetContent(System.String value)`
  - Called by the templating system when an element has content between its tags.
- `System.Void StateHasChanged()`
  - For razor panels, call when the state of the render tree has changed such that
it would be a good idea to re-render the tree. You would usually not need to call
this manually.
- `virtual System.String GetRenderTreeChecksum()`
  - Overridden/implemented by Razor templating, contains render tree checksum to determine when the render tree content has changed.
- `virtual System.Void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder tree)`
  - Overridden/implemented by Razor templating to build a render tree.
- `virtual System.Int32 BuildHash()`
  - By overriding this you can return a hash of variables used by the Razor layout, which
will cause a rebuild when changed. This is useful when your layout uses a global variable
because by adding it to a HashCode.Combine here you can easily trigger a build when it changes.
- `System.Void OnRenderFragmentChanged(Sandbox.UI.Panel upTo)`
  - A RenderFragment has been set on us, so our tree has potential changes now.
Lets update and see.
- `virtual System.Void OnAfterTreeRender(System.Boolean firstTime)`
  - Called after the razor tree has been created/rendered.
- `System.Void MarkRenderDirty()`
- `virtual System.Void OnDraw()`
  - Override this to draw custom graphics for this panel using the `Sandbox.UI.Panel.Draw` API.
<example>

```

public override void OnDraw()
{
    var r = Box.RectInner;
    Draw.Rect( r, Color.Blue.WithAlpha( 0.2f ), cornerRadius: 4 );
    Draw.Text( "Score: 100", r, 16, Color.White, TextFlag.Center );
}

```

</example>
- `virtual System.Void BuildContentCommandList(Sandbox.Rendering.CommandList commandList, Sandbox.UI.RenderState state)`
- `virtual System.Void BuildCommandList(Sandbox.Rendering.CommandList commandList)`
- `virtual System.Void DrawContent(Sandbox.UI.RenderState state)`
- `virtual System.Void DrawBackground(Sandbox.UI.RenderState state)`
- `System.Boolean TryFindKeyframe(System.String name, Sandbox.UI.KeyFrames keyframes)`
  - Try to find `@keyframes` CSS rule with given name in `Sandbox.UI.Panel.AllStyleSheets`.
  - `name`: The name to search for.
  - `keyframes`: The keyframes, if any are found, or `null`.
  - returns: `true` if `@keyframes` with given name were found.
- `System.Void StyleSelectorsChanged(System.Boolean ancestors, System.Boolean descendants, Sandbox.UI.RootPanel root)`
  - Should be called when something happens that means that this panel's stylesheets need to be
re-evaluated. Like becoming hovered or classes changed. You don't call this when changing styles
directly on the panel, just on anything that will change which stylesheets should get selected.
  - `ancestors`: Also re-evaluate all ancestor panels. (for `:has()`)
  - `descendants`: Also re-evaluate all child panels. (for parent selectors)
  - `root`: Root panel cache so we don't need to keep looking it up.
- `virtual System.Void OnTemplateSlot(Sandbox.Html.INode element, System.String slotName, Sandbox.UI.Panel panel)`
  - TODO: Obsolete this and instead maybe we have something like [PanelSlot( "slotname" )] that 
is applied on properties. Then when we find a slot="slotname" we chase up the heirachy and set the property.
- `virtual Sandbox.UI.Panel CreateTooltipPanel()`
  - Create a tooltip panel. You can override this to create a custom tooltip panel.<br />
If you're overriding this and not setting `Sandbox.UI.Panel.Tooltip`, then you must override and return true in `Sandbox.UI.Panel.HasTooltip`.
- `System.Void SkipTransitions()`
  - Any transitions running, or about to run, will jump straight to the end.
