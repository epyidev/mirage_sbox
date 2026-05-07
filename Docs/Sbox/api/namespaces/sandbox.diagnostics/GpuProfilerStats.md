# Sandbox.Diagnostics.GpuProfilerStats

GPU profiler stats collected from the scene system timestamp manager

- **Kind:** static class
- **Namespace:** `Sandbox.Diagnostics`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static System.Boolean Enabled`
  - Whether GPU profiling is enabled
- `static System.Single TotalGpuTimeMs`
  - Total GPU time for all tracked passes
- `static System.Collections.Generic.IReadOnlyList<Sandbox.Diagnostics.GpuTimingEntry> Entries`
  - Get the current GPU timing entries

## Methods

### Static methods

- `static System.Single GetSmoothedDuration(System.String name)`
  - Get a smoothed duration for a given name (for display purposes)
- `static System.Single GetMaxDuration(System.String name)`
  - Get a decayed max duration for a given name (for display purposes)
