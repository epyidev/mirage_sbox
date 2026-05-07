# Facepunch.ActionGraphs.Nodes.ControlFlow.ForEachBody<T>

Output signal for a `Facepunch.ActionGraphs.Nodes.ControlFlow.ForEach``1(System.Collections.Generic.IEnumerable{``0},Facepunch.ActionGraphs.Nodes.ControlFlow.ForEachBody{``0})` node, fired for each element of an enumerable.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `System.MulticastDelegate`
- **Declaring type:** `Facepunch.ActionGraphs.Nodes.ControlFlow`

## Constructors

- `ForEachBody<T>(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Threading.Tasks.Task Invoke(T value, System.Int32 index)`
- `virtual System.IAsyncResult BeginInvoke(T value, System.Int32 index, System.AsyncCallback callback, System.Object object)`
- `virtual System.Threading.Tasks.Task EndInvoke(System.IAsyncResult result)`
