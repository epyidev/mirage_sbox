# Sandbox.Utility.DataProgress.Callback

Callback delegate for receiving progress updates.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`
- **Base:** `System.MulticastDelegate`
- **Declaring type:** `Sandbox.Utility.DataProgress`

## Constructors

- `Callback(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Void Invoke(Sandbox.Utility.DataProgress progress)`
- `virtual System.IAsyncResult BeginInvoke(Sandbox.Utility.DataProgress progress, System.AsyncCallback callback, System.Object object)`
- `virtual System.Void EndInvoke(System.IAsyncResult result)`
