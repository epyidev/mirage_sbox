# Sandbox.IHotloadManaged

During hotloads, instances of types implementing this interface will be notified when
they get replaced.

- **Kind:** interface
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Methods

### Instance methods

- `virtual System.Void Destroyed(System.Collections.Generic.Dictionary<System.String,System.Object> state)`
- `virtual System.Void Created(System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> state)`
- `virtual System.Void Persisted()`
  - Called when this instance is about to be processed, but not replaced.
- `virtual System.Void Failed()`
  - Called when this instance could not be upgraded during a hotload, and any references
to it have been replaced with null. This is a good time to clean up any unmanaged resources
related to this instance.
