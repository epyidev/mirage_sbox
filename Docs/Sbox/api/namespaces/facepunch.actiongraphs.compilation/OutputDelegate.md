# Facepunch.ActionGraphs.Compilation.OutputDelegate

- **Kind:** sealed class
- **Namespace:** `Facepunch.ActionGraphs.Compilation`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `System.MulticastDelegate`

## Constructors

- `OutputDelegate(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Threading.Tasks.Task Invoke(System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> values)`
- `virtual System.IAsyncResult BeginInvoke(System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> values, System.AsyncCallback callback, System.Object object)`
- `virtual System.Threading.Tasks.Task EndInvoke(System.IAsyncResult result)`
