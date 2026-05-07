# Sandbox.Services.BenchmarkSystem

Allows access to stats for the current game. Stats are defined by the game's author
and can be used to track anything from player actions to performance metrics. They are
how you submit data to leaderboards.

- **Kind:** class
- **Namespace:** `Sandbox.Services`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `BenchmarkSystem()`

## Methods

### Instance methods

- `System.Void Start(System.String name)`
  - Called to start a benchmark
- `System.Void SetMetric(System.String name, System.Double metric)`
  - Set a custom metric, like load time, shutdown time etc
- `System.Void Finish()`
  - Called to close a benchmark off
- `System.Void Sample()`
  - Should be called in update every frame
- `System.Threading.Tasks.Task<System.Guid> SendAsync(System.Threading.CancellationToken token)`
  - Finish this benchmark session and send it off to the backend
