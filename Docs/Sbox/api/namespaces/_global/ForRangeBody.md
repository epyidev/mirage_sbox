# Facepunch.ActionGraphs.Nodes.ControlFlow.ForRangeBody

Output signal for a `Facepunch.ActionGraphs.Nodes.ControlFlow.ForRange(Facepunch.ActionGraphs.Nodes.ControlFlow.ForRangeBody,System.Int32,System.Int32,System.Int32)` node, fired for each value in the range.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `System.MulticastDelegate`
- **Declaring type:** `Facepunch.ActionGraphs.Nodes.ControlFlow`

## Constructors

- `ForRangeBody(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Threading.Tasks.Task Invoke(System.Int32 value)`
- `virtual System.IAsyncResult BeginInvoke(System.Int32 value, System.AsyncCallback callback, System.Object object)`
- `virtual System.Threading.Tasks.Task EndInvoke(System.IAsyncResult result)`
