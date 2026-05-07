# Facepunch.ActionGraphs.LinkTriggeredHandler

Handler for `Facepunch.ActionGraphs.ActionGraph.LinkTriggered` events.

- **Kind:** sealed class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `System.MulticastDelegate`

## Constructors

- `LinkTriggeredHandler(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Void Invoke(Facepunch.ActionGraphs.Link link, System.Object value)`
- `virtual System.IAsyncResult BeginInvoke(Facepunch.ActionGraphs.Link link, System.Object value, System.AsyncCallback callback, System.Object object)`
- `virtual System.Void EndInvoke(System.IAsyncResult result)`
