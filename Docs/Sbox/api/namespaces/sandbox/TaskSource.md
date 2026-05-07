# Sandbox.TaskSource

Provides a way for us to cancel tasks after common async shit is executed.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Boolean IsValid`
- `System.Threading.Tasks.Task CompletedTask`

## Methods

### Static methods

- `static Sandbox.TaskSource Create(System.Threading.CancellationToken token)`
- `static System.Threading.CancellationTokenSource CreateLinkedTokenSource()`
  - Create a token source, which will also be cancelled when sessions end

### Instance methods

- `System.Threading.Tasks.Task Delay(System.Int32 ms)`
  - A task that does nothing for given amount of time in milliseconds.
  - `ms`: Time to wait in milliseconds.
- `System.Threading.Tasks.Task Delay(System.Int32 ms, System.Threading.CancellationToken ct)`
  - A task that does nothing for given amount of time in milliseconds.
  - `ms`: Time to wait in milliseconds.
  - `ct`: Token to cancel the delay early.
- `System.Threading.Tasks.Task DelaySeconds(System.Single seconds)`
  - A task that does nothing for given amount of time in seconds.
  - `seconds`: &gt;Time to wait in seconds.
- `System.Threading.Tasks.Task DelaySeconds(System.Single seconds, System.Threading.CancellationToken ct)`
  - A task that does nothing for given amount of time in seconds.
  - `seconds`: &gt;Time to wait in seconds.
  - `ct`: Token to cancel the delay early.
- `System.Threading.Tasks.Task RunInThreadAsync(System.Action action)`
- `System.Threading.Tasks.Task<T> RunInThreadAsync(System.Func<T> func)`
- `System.Threading.Tasks.Task RunInThreadAsync(System.Func<System.Threading.Tasks.Task> task)`
- `System.Threading.Tasks.Task<T> RunInThreadAsync(System.Func<System.Threading.Tasks.Task<T>> task)`
- `System.Threading.Tasks.Task DelayRealtime(System.Int32 ms)`
- `System.Threading.Tasks.Task DelayRealtime(System.Int32 ms, System.Threading.CancellationToken ct)`
- `System.Threading.Tasks.Task DelayRealtimeSeconds(System.Single seconds)`
- `System.Threading.Tasks.Task DelayRealtimeSeconds(System.Single seconds, System.Threading.CancellationToken ct)`
- `Sandbox.Tasks.SyncTask MainThread()`
  - Continues on the main thread.
- `Sandbox.Tasks.SyncTask WorkerThread()`
  - Continues on a worker thread.
- `System.Threading.Tasks.Task<T> FromResult(T t)`
- `System.Threading.Tasks.Task FromCanceled(System.Threading.CancellationToken token)`
- `System.Threading.Tasks.Task FromException(System.Exception e)`
- `System.Threading.Tasks.Task WhenAll(System.Threading.Tasks.Task[] tasks)`
- `System.Threading.Tasks.Task WhenAll(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task> tasks)`
- `System.Threading.Tasks.Task<T[]> WhenAll(System.Threading.Tasks.Task<T>[] tasks)`
- `System.Threading.Tasks.Task<T[]> WhenAll(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<T>> tasks)`
- `System.Threading.Tasks.Task WhenAny(System.Threading.Tasks.Task[] tasks)`
- `System.Threading.Tasks.Task WhenAny(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task> tasks)`
- `System.Void WaitAny(System.Threading.Tasks.Task[] tasks)`
- `System.Void WaitAll(System.Threading.Tasks.Task[] tasks)`
- `System.Threading.Tasks.Task<System.Threading.Tasks.Task<T>> WhenAny(System.Threading.Tasks.Task<T>[] tasks)`
- `System.Threading.Tasks.Task<System.Threading.Tasks.Task<T>> WhenAny(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<T>> tasks)`
- `System.Threading.Tasks.Task Yield()`
- `System.Threading.Tasks.Task Frame()`
  - Wait until the start of the next frame
- `System.Threading.Tasks.Task FrameEnd()`
  - Wait until the end of the frame
- `System.Threading.Tasks.Task FixedUpdate()`
  - Wait until the next fixed update
