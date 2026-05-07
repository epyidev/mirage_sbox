# Sandbox.GameObjectSystem.ITraceProvider

When implementing an ITraceProvider, the most important thing to keep in mind
is that the call to DoTrace should be thread safe. This might be called from
multiple threads at once, so you better watch out.

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.GameObjectSystem`

## Methods

### Instance methods

- `virtual System.Void DoTrace(Sandbox.SceneTrace& modreq(System.Runtime.InteropServices.InAttribute) trace, System.Collections.Generic.List<Sandbox.SceneTraceResult> results)`
- `virtual System.Nullable<Sandbox.SceneTraceResult> DoTrace(Sandbox.SceneTrace& modreq(System.Runtime.InteropServices.InAttribute) trace)`
