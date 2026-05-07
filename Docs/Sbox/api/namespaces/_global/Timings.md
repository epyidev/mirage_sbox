# Sandbox.Diagnostics.PerformanceStats.Timings

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Diagnostics.PerformanceStats`

## Properties

- `static Sandbox.Diagnostics.PerformanceStats.Timings Async`
- `static Sandbox.Diagnostics.PerformanceStats.Timings Animation`
- `static Sandbox.Diagnostics.PerformanceStats.Timings Audio`
- `static Sandbox.Diagnostics.PerformanceStats.Timings Editor`
- `static Sandbox.Diagnostics.PerformanceStats.Timings Input`
- `static Sandbox.Diagnostics.PerformanceStats.Timings NavMesh`
- `static Sandbox.Diagnostics.PerformanceStats.Timings Network`
- `static Sandbox.Diagnostics.PerformanceStats.Timings Particles`
- `static Sandbox.Diagnostics.PerformanceStats.Timings Physics`
- `static Sandbox.Diagnostics.PerformanceStats.Timings Render`
- `static Sandbox.Diagnostics.PerformanceStats.Timings Update`
- `static Sandbox.Diagnostics.PerformanceStats.Timings Ui`
- `static Sandbox.Diagnostics.PerformanceStats.Timings Video`
- `static Sandbox.Diagnostics.PerformanceStats.Timings GcPause`
- `System.String Name`
- `Color Color`
- `Sandbox.Utility.CircularBuffer<Sandbox.Diagnostics.PerformanceStats.Timings.Frame> History`
- `System.Boolean IsManualFlip`

## Methods

### Static methods

- `static System.Collections.Generic.IEnumerable<Sandbox.Diagnostics.PerformanceStats.Timings> GetMain()`
  - Return a list of the main top tier timings we're interested in
- `static Sandbox.Diagnostics.PerformanceStats.Timings Get(System.String stage, System.Nullable<Color> color)`

### Instance methods

- `System.Single AverageMs(System.Int32 frames)`
- `Sandbox.Diagnostics.PerformanceStats.PeriodMetric GetMetric(System.Int32 frames)`
