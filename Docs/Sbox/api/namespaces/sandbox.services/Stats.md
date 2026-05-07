# Sandbox.Services.Stats

Allows access to stats for the current game. Stats are defined by the game's author
and can be used to track anything from player actions to performance metrics. They are
how you submit data to leaderboards.

- **Kind:** static class
- **Namespace:** `Sandbox.Services`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static Sandbox.Services.Stats.GlobalStats Global`
  - Get the global stats for the calling package
- `static Sandbox.Services.Stats.PlayerStats LocalPlayer`
  - Get the global stats for the calling package

## Methods

### Static methods

- `static System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken token)`
  - Send any pending stats to the backend. Don't wait for confirmation of ingestiom, fire and forget.
- `static System.Void Flush()`
  - Send any pending stats to the backend. Don't wait for confirmation of ingestiom, fire and forget.
- `static System.Threading.Tasks.Task FlushAndWaitAsync(System.Threading.CancellationToken token)`
  - Send any pending stats to the backend, will wait until they're available for query before finishing.
- `static System.Void Increment(System.String name, System.Double amount)`
- `static System.Void Increment(System.String name, System.Double amount, System.String context, System.Object data)`
- `static System.Void Increment(System.String name, System.Double amount, System.Collections.Generic.Dictionary<System.String,System.Object> data)`
- `static System.Void SetValue(System.String name, System.Double amount, System.String context, System.Object data)`
- `static System.Void SetValue(System.String name, System.Double amount, System.Collections.Generic.Dictionary<System.String,System.Object> data)`
- `static Sandbox.Services.Stats.GlobalStats GetGlobalStats(System.String packageIdent)`
  - Get the global stats for this package
- `static Sandbox.Services.Stats.PlayerStats GetLocalPlayerStats(System.String packageIdent)`
  - Get the global stats for this package
- `static Sandbox.Services.Stats.PlayerStats GetPlayerStats(System.String packageIdent, System.Int64 steamid)`
  - Get the stats for this package
