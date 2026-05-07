# Sandbox.Utility.Parallel

Wrappers of the parallel class.

- **Kind:** static class
- **Namespace:** `Sandbox.Utility`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static System.Boolean ForEach(System.Collections.Generic.IEnumerable<T> source, System.Action<T> body)`
- `static System.Boolean ForEach(System.Collections.Generic.IEnumerable<T> source, System.Threading.CancellationToken token, System.Action<T> body)`
- `static System.Boolean For(System.Int32 fromInclusive, System.Int32 toExclusive, System.Action<System.Int32> body)`
- `static System.Threading.Tasks.Task ForAsync(System.Int32 fromInclusive, System.Int32 toExclusive, System.Threading.CancellationToken token, System.Func<System.Int32,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask> body)`
