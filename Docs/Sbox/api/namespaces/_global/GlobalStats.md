# Sandbox.Services.Stats.GlobalStats

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Services.Stats`

## Properties

- `System.Boolean IsRefreshing`
  - True if we're currently fetching new stats
- `System.DateTime LastRefresh`
  - The UTC datetime when we last fetched new stats
- `Sandbox.Services.Stats.GlobalStat Item`

## Methods

### Instance methods

- `Sandbox.Services.Stats.GlobalStats Copy()`
  - Make a copy of this class. Allows you to store the stats from a point in time.
- `Sandbox.Services.Stats.GlobalStat Get(System.String name)`
  - Get a stat by name. Will return an empty stat if not found
- `System.Boolean TryGet(System.String name, Sandbox.Services.Stats.GlobalStat stat)`
  - Get a stat by name, returns true if found
- `System.Threading.Tasks.Task Refresh()`
  - Refresh these global stats - grab the latest values
- `virtual System.Collections.Generic.IEnumerator<Sandbox.Services.Stats.GlobalStat> GetEnumerator()`
