# Sandbox.UI.PanelRenderTreeBuilder

This is a tree renderer for panels. If we ever use razor on other ui we'll want to make a copy of
this class and do the specific things to that.

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder`

## Methods

### Instance methods

- `virtual System.Void AddLocation(System.String filename, System.Int32 line, System.Int32 column)`
  - Add the current source location. Used to record in which file the element was created.
- `virtual System.Void OpenElement(System.Int32 sequence, System.String elementName)`
- `virtual System.Void OpenElement(System.Int32 sequence, System.String elementName, System.Object key)`
  - Start working on this element
- `System.Void AddAttributeObject(System.Int32 sequence, System.String attrName, System.Object value)`
  - Handles "style" and "class" attributes..
- `System.Void AddAttributeString(System.Int32 sequence, System.String attrName, System.String value)`
  - Handles "style" and "class" attributes..
- `virtual System.Void AddStyleDefinitions(System.Int32 sequence, System.String styles)`
  - Styles from a style block
- `virtual System.Void AddAttribute(System.Int32 sequence, System.Action<T> value)`
- `virtual System.Void CloseElement()`
  - Finish working on this element
- `virtual System.Void AddContent(System.Int32 sequence, T content)`
  - Handles text content within an element
- `virtual System.Void AddReferenceCapture(System.Int32 sequence, T current, System.Action<T> value)`
- `virtual System.Void SetRenderFragment(System.Action<T,Microsoft.AspNetCore.Components.RenderFragment> setter, Microsoft.AspNetCore.Components.RenderFragment builder)`
- `virtual System.Void SetRenderFragmentWithContext(System.Func<T,Microsoft.AspNetCore.Components.RenderFragment<U>> getter, System.Action<T,Microsoft.AspNetCore.Components.RenderFragment<U>> setter, Microsoft.AspNetCore.Components.RenderFragment<U> builder)`
- `System.Void AddAttributeAction(System.Int32 sequence, System.String attrName, System.Action value)`
  - Handles @onclick=@( () =&gt; DoSomething( "boobies" ) )
- `System.Void AddAttributeAction(System.Int32 sequence, System.String attrName, System.Func<System.Threading.Tasks.Task> value)`
- `virtual System.Void AddMarkupContent(System.Int32 sequence, System.String markupContent)`
  - Add markup to the current element
- `virtual System.Void OpenElement(System.Int32 sequence)`
- `virtual System.Void OpenElement(System.Int32 sequence, System.Object key)`
  - Create a panel of type T
- `System.Void AddAttributeWithSetter(System.Int32 sequence, System.Object value, System.Action<T> setter)`
- `virtual System.Void AddBind(System.Int32 sequence, System.String propertyName, System.Func<T> get, System.Action<T> set)`
