# Sandbox.ActionGraphs.CollisionActionComponent.CollisionDelegate

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.MulticastDelegate`
- **Declaring type:** `Sandbox.ActionGraphs.CollisionActionComponent`

## Constructors

- `CollisionDelegate(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Void Invoke(Sandbox.Collision other)`
- `virtual System.IAsyncResult BeginInvoke(Sandbox.Collision other, System.AsyncCallback callback, System.Object object)`
- `virtual System.Void EndInvoke(System.IAsyncResult result)`
