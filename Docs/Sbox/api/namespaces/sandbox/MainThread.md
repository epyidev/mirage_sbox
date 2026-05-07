# Sandbox.MainThread

Utility functions that revolve around the main thread

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static Sandbox.Tasks.SyncTask Wait()`
  - Wait to execute on the main thread
- `static System.Void Queue(System.Action method)`
  - When running in another thread you can queue a method to run in the main thread.
If you are on the main thread we will execute the method immediately and return.
