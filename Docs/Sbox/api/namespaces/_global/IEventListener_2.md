# Sandbox.ResourceLibrary.IEventListener

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.ResourceLibrary`

## Methods

### Instance methods

- `virtual System.Void OnRegister(Sandbox.GameResource resource)`
  - Called when a new resource has been registered
- `virtual System.Void OnUnregister(Sandbox.GameResource resource)`
  - Called when a previously known resource has been unregistered
- `virtual System.Void OnSave(Sandbox.GameResource resource)`
  - Called when a resource has been saved
- `virtual System.Void OnExternalChanges(Sandbox.GameResource resource)`
  - Called when the source file of a known resource has been externally modified on disk
- `virtual System.Void OnExternalChangesPostLoad(Sandbox.GameResource resource)`
  - Called when the source file of a known resource has been externally modified on disk
and after it has been fully loaded (after post load is called)
