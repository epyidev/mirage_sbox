# Sandbox.Mounting.Directory

- **Kind:** static class
- **Namespace:** `Sandbox.Mounting`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static Sandbox.Mounting.MountInfo[] GetAll()`
  - Get information about all the current mounts
- `static Sandbox.Mounting.BaseGameMount Get(System.String name)`
  - Get a specific mount by name
- `static System.Threading.Tasks.Task<Sandbox.Mounting.BaseGameMount> Mount(System.String name)`
  - Mount this game if we can. Returns null if it can't be mounted, or the mount object if it can.
If we're already mounted, will just return the mount straight away.
