# Facepunch.ActionGraphs.ActionGraphExtensions.WriteSubGraphDelegate

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `System.MulticastDelegate`
- **Declaring type:** `Facepunch.ActionGraphs.ActionGraphExtensions`

## Constructors

- `WriteSubGraphDelegate(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Threading.Tasks.Task<System.String> Invoke(Facepunch.ActionGraphs.ActionGraph subGraph)`
- `virtual System.IAsyncResult BeginInvoke(Facepunch.ActionGraphs.ActionGraph subGraph, System.AsyncCallback callback, System.Object object)`
- `virtual System.Threading.Tasks.Task<System.String> EndInvoke(System.IAsyncResult result)`
