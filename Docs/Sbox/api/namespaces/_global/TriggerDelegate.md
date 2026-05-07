# Sandbox.ActionGraphs.TriggerActionComponent.TriggerDelegate

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.MulticastDelegate`
- **Declaring type:** `Sandbox.ActionGraphs.TriggerActionComponent`

## Constructors

- `TriggerDelegate(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Void Invoke(Sandbox.Collider other)`
- `virtual System.IAsyncResult BeginInvoke(Sandbox.Collider other, System.AsyncCallback callback, System.Object object)`
- `virtual System.Void EndInvoke(System.IAsyncResult result)`
