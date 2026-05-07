# Sandbox.ISceneEvent<T>

A wrapper for scene event interfaces. Allows syntax sugar of something like
`IPlayerEvents.Post( x =&gt; x.OnPlayerHurt( this, amount ) )` instead of using
Scene.Run to call them manually.

- **Kind:** interface
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static System.Void Post(System.Action<T> action)`
- `static System.Void PostToGameObject(Sandbox.GameObject go, System.Action<T> action, Sandbox.FindMode find)`
