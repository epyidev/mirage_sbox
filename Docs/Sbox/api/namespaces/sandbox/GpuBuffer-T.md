# Sandbox.GpuBuffer<T>

A typed GpuBuffer

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GpuBuffer`

## Constructors

- `GpuBuffer<T>(System.Int32 elementCount, Sandbox.GpuBuffer.UsageFlags flags, System.String debugName)`

## Methods

### Instance methods

- `System.Void GetData(System.Span<T> data)`
- `System.Void GetData(System.Span<T> data, System.Int32 start, System.Int32 count)`
- `System.Void SetData(System.Span<T> data, System.Int32 elementOffset)`
- `System.Void GetDataAsync(System.Action<System.ReadOnlySpan<T>> callback)`
- `System.Void GetDataAsync(System.Action<System.ReadOnlySpan<T>> callback, System.Int32 start, System.Int32 count)`
