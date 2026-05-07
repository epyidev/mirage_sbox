# Sandbox.Diagnostics.PerformanceStats

- **Kind:** static class
- **Namespace:** `Sandbox.Diagnostics`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static System.Double FrameTime`
  - Get the time taken, in seconds, that were required to process the previous frame.
- `static System.Single GpuFrametime`
  - Latest available GPU frametime, in ms.
- `static System.UInt32 GpuFrameNumber`
  - Frame number of the last reported `Sandbox.Diagnostics.PerformanceStats.GpuFrametime`.
- `static System.Int64 BytesAllocated`
  - The number of bytes that were allocated on the managed heap in the last frame.
<remarks>This may not include allocations from threads other than the game thread.</remarks>
- `static System.Int32 Gen0Collections`
  - Number of generation 0 (fastest) garbage collections were done in the last frame.
- `static System.Int32 Gen1Collections`
  - Number of generation 1 (fast) garbage collections were done in the last frame.
- `static System.Int32 Gen2Collections`
  - Number of generation 2 (slow) garbage collections were done in the last frame.
- `static System.Int64 GcPause`
  - How many ticks we paused in the last frame
- `static System.Int32 Exceptions`
  - Number of exceptions in the last frame.
- `static System.UInt64 ApproximateProcessMemoryUsage`
  - Approximate working set of this process.
- `static Sandbox.Diagnostics.PerformanceStats.Block LastSecond`
  - Performance statistics over the last period, which is dictated by "perf_time" console command.
