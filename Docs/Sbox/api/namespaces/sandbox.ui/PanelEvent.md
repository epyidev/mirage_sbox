# Sandbox.UI.PanelEvent

Base `Sandbox.UI.Panel` event.<br />
See `Sandbox.UI.Panel.CreateEvent(Sandbox.UI.PanelEvent)`.

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `PanelEvent(System.String eventName, Sandbox.UI.Panel active)`

## Properties

- `System.String Name`
- `System.Object Value`
- `System.Single Time`
- `System.String Button`
- `Sandbox.UI.Panel This`
  - The panel on which the event is being called. For example, if you have a button with a label.. when the
button gets clicked the actual click event might come from the label. When the event is called on the
label, This will be the label. When the event propagates up to the button This will be the button - but
Target will be the label. This is mainly of use with Razor callbacks, where you want to get the actual
panel that created the event.
- `Sandbox.UI.Panel Target`

## Methods

### Instance methods

- `System.Boolean Is(System.String name)`
- `System.Void StopPropagation()`
