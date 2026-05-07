# Sandbox.GameObjectSystem

Allows creation of a system that always exists in every scene, is hooked into the scene's lifecycle, 
and is disposed when the scene is disposed.

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `GameObjectSystem(Sandbox.Scene scene)`

## Properties

- `Sandbox.Scene Scene`
- `System.Guid Id`

## Methods

### Instance methods

- `virtual System.Void Dispose()`
- `System.Void Listen(Sandbox.GameObjectSystem.Stage stage, System.Int32 order, System.Action function, System.String debugName)`
  - Listen to a frame stage. Order is used to determine the order in which listeners are called, the default action always happens at 0, so if you
want it to happen before you should go to -1, if you want it to happen after go to 1 etc.
- `System.Void __rpc_Wrapper(Sandbox.WrappedMethod m, T[] argument)`
- `System.Void __rpc_Wrapper(Sandbox.WrappedMethod m, System.Object[] argumentList)`
- `System.Void __sync_SetValue(Sandbox.WrappedPropertySet<T> p)`
- `T __sync_GetValue(Sandbox.WrappedPropertyGet<T> p)`
