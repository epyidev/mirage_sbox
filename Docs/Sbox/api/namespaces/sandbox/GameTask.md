# Sandbox.GameTask

A generic `Sandbox.TaskSource`.

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static System.Threading.Tasks.Task CompletedTask`

## Methods

### Static methods

- `static System.Threading.Tasks.Task Yield()`
- `static System.Threading.Tasks.Task Delay(System.Int32 ms)`
- `static System.Threading.Tasks.Task Delay(System.Int32 ms, System.Threading.CancellationToken ct)`
- `static System.Threading.Tasks.Task DelaySeconds(System.Single seconds)`
- `static System.Threading.Tasks.Task DelaySeconds(System.Single seconds, System.Threading.CancellationToken ct)`
- `static System.Threading.Tasks.Task DelayRealtime(System.Int32 ms)`
- `static System.Threading.Tasks.Task DelayRealtime(System.Int32 ms, System.Threading.CancellationToken ct)`
- `static System.Threading.Tasks.Task DelayRealtimeSeconds(System.Single seconds)`
- `static System.Threading.Tasks.Task DelayRealtimeSeconds(System.Single seconds, System.Threading.CancellationToken ct)`
- `static System.Threading.Tasks.Task RunInThreadAsync(System.Action action)`
- `static System.Threading.Tasks.Task<T> RunInThreadAsync(System.Func<T> func)`
- `static System.Threading.Tasks.Task RunInThreadAsync(System.Func<System.Threading.Tasks.Task> task)`
- `static System.Threading.Tasks.Task<T> RunInThreadAsync(System.Func<System.Threading.Tasks.Task<T>> task)`
- `static System.Threading.Tasks.Task<T> FromResult(T t)`
- `static System.Threading.Tasks.Task WhenAll(System.Threading.Tasks.Task[] tasks)`
- `static System.Threading.Tasks.Task WhenAll(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task> tasks)`
- `static System.Threading.Tasks.Task<T[]> WhenAll(System.Threading.Tasks.Task<T>[] tasks)`
- `static System.Threading.Tasks.Task<T[]> WhenAll(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<T>> tasks)`
- `static System.Threading.Tasks.Task WhenAny(System.Threading.Tasks.Task[] tasks)`
- `static System.Threading.Tasks.Task WhenAny(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task> tasks)`
- `static System.Threading.Tasks.Task<System.Threading.Tasks.Task<T>> WhenAny(System.Threading.Tasks.Task<T>[] tasks)`
- `static System.Threading.Tasks.Task<System.Threading.Tasks.Task<T>> WhenAny(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<T>> tasks)`
- `static System.Void WaitAll(System.Threading.Tasks.Task[] tasks)`
- `static System.Void WaitAny(System.Threading.Tasks.Task[] tasks)`
- `static Sandbox.Tasks.SyncTask MainThread()`
- `static Sandbox.Tasks.SyncTask MainThread(System.Threading.CancellationToken cancellation)`
- `static Sandbox.Tasks.SyncTask WorkerThread()`
- `static Sandbox.Tasks.SyncTask WorkerThread(System.Threading.CancellationToken cancellation)`
