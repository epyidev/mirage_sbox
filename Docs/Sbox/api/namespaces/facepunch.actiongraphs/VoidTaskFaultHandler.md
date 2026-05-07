# Facepunch.ActionGraphs.VoidTaskFaultHandler

- **Kind:** sealed class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `System.MulticastDelegate`

## Constructors

- `VoidTaskFaultHandler(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Void Invoke(Facepunch.ActionGraphs.ActionGraph graph, System.Exception e)`
- `virtual System.IAsyncResult BeginInvoke(Facepunch.ActionGraphs.ActionGraph graph, System.Exception e, System.AsyncCallback callback, System.Object object)`
- `virtual System.Void EndInvoke(System.IAsyncResult result)`
