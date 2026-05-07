# Facepunch.ActionGraphs.CreateSubGraphNodeDelegate

- **Kind:** sealed class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `System.MulticastDelegate`

## Constructors

- `CreateSubGraphNodeDelegate(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Threading.Tasks.Task<Facepunch.ActionGraphs.Node> Invoke(Facepunch.ActionGraphs.ActionGraph subGraph)`
- `virtual System.IAsyncResult BeginInvoke(Facepunch.ActionGraphs.ActionGraph subGraph, System.AsyncCallback callback, System.Object object)`
- `virtual System.Threading.Tasks.Task<Facepunch.ActionGraphs.Node> EndInvoke(System.IAsyncResult result)`
