# Sandbox.UI.Transitions.TransitionFunction

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.MulticastDelegate`
- **Declaring type:** `Sandbox.UI.Transitions`

## Constructors

- `TransitionFunction(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Void Invoke(Sandbox.UI.Styles style, System.Single delta)`
- `virtual System.IAsyncResult BeginInvoke(Sandbox.UI.Styles style, System.Single delta, System.AsyncCallback callback, System.Object object)`
- `virtual System.Void EndInvoke(System.IAsyncResult result)`
