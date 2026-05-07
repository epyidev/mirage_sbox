# Sandbox.Rpc

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static Sandbox.Connection Caller`
  - The `Sandbox.Connection` that is calling this method.
- `static System.Guid CallerId`
  - The id of the `Sandbox.Connection` that is calling this method.
- `static System.Boolean Calling`
  - Whether we're currently being called from a remote `Sandbox.Connection`.

## Methods

### Static methods

- `static System.Void PreCall()`
  - Called right before calling an RPC function.
- `static System.IDisposable FilterInclude(System.Collections.Generic.IEnumerable<Sandbox.Connection> connections)`
- `static System.IDisposable FilterInclude(System.Predicate<Sandbox.Connection> predicate)`
- `static System.IDisposable FilterInclude(Sandbox.Connection connection)`
  - Filter the recipients of any Rpc called in this scope to only include the specified `Sandbox.Connection`.
  - `connection`: Only send the RPC to this connection.
- `static System.IDisposable FilterExclude(System.Predicate<Sandbox.Connection> predicate)`
- `static System.IDisposable FilterExclude(System.Collections.Generic.IEnumerable<Sandbox.Connection> connections)`
- `static System.IDisposable FilterExclude(Sandbox.Connection connection)`
  - Filter the recipients of any Rpc called in this scope to exclude the specified `Sandbox.Connection`.
  - `connection`: Exclude this connection from receiving the RPC.
- `static System.Void OnCallInstanceRpc(Sandbox.GameObjectSystem system, Sandbox.WrappedMethod m, System.Object[] argumentList)`
  - Called when an instance RPC is called for a `Sandbox.Scene` and `Sandbox.GameObjectSystem`.
- `static System.Void OnCallInstanceRpc(Sandbox.GameObject go, Sandbox.Component component, Sandbox.WrappedMethod m, System.Object[] argumentList)`
  - Called when an instance RPC is called for a `Sandbox.GameObject` and `Sandbox.Component`.
- `static System.Void OnCallRpc(Sandbox.WrappedMethod m, T[] argument)`
  - Called when a static RPC is called with a single argument of an array type.
- `static System.Void OnCallRpc(Sandbox.WrappedMethod m, System.Object[] argumentList)`
  - Called when a static RPC is called with object parameters.
