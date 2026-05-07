# Sandbox.GpuBuffer

A GPU data buffer intended for use with a `Sandbox.ComputeShader`.

You can read and write arbitrary data to and from the CPU and GPU.
This allows for efficient parallel data processing on the GPU.

Different GPU buffer types can be used depending on the provided `Sandbox.GpuBuffer.UsageFlags`.
Using the default `Sandbox.GpuBuffer.UsageFlags.Structured` type buffers map to StructuredBuffer&lt;T&gt; and RWStructuredBuffer&lt;T&gt; in HLSL.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `GpuBuffer(System.Int32 elementCount, System.Int32 elementSize, Sandbox.GpuBuffer.UsageFlags flags, System.String debugName)`
  - Creates a new GPU buffer with a specified number of elements and a specific buffer type.
  - `elementCount`: The total number of elements that the GpuBuffer can hold. This represents the buffer's size in terms of elements, not bytes.
  - `elementSize`: The total number of elements that the GpuBuffer can hold. This represents the buffer's size in terms of elements, not bytes.
  - `flags`: Defines the usage pattern of the GPU buffer. This can affect performance depending on how the buffer is utilized.
  - `debugName`: Test
- `GpuBuffer()`

## Properties

- `System.Int32 ElementCount`
  - Number of elements in the buffer.
- `System.Int32 ElementSize`
  - Size of a single element in the buffer.
- `Sandbox.GpuBuffer.UsageFlags Usage`
  - What sort of buffer this is
- `System.Boolean IsValid`

## Methods

### Instance methods

- `virtual System.Void Finalize()`
- `System.Void Initialize(System.Int32 elementCount, System.Int32 elementSize, Sandbox.GpuBuffer.UsageFlags usageFlags, System.String debugName)`
- `virtual System.Void Dispose()`
  - Destroys the GPU buffer, don't use it no more
- `System.Void GetData(System.Span<T> data)`
- `System.Void GetData(System.Span<T> data, System.Int32 start, System.Int32 count)`
- `System.Void GetDataAsync(System.Action<System.ReadOnlySpan<T>> callback)`
- `System.Void GetDataAsync(System.Action<System.ReadOnlySpan<T>> callback, System.Int32 start, System.Int32 count)`
- `System.Void SetData(System.Span<T> data, System.Int32 elementOffset)`
- `System.Void SetData(System.Collections.Generic.List<T> data, System.Int32 elementOffset)`
- `System.Void CopyStructureCount(Sandbox.GpuBuffer destBuffer, System.Int32 destBufferOffset)`
  - For `Sandbox.GpuBuffer.UsageFlags.Append` buffers there is a hidden uint 32-bit atomic counter in the buffer that contains the number of 
writes to the buffer after invocation of the compute shader.  In order to get the value of the counter, the data needs to be copied to
another GPU buffer that can be used.
- `System.Void Clear(System.UInt32 value)`
  - Fills the entire buffer with a repeated uint32 value.
Uses the native GPU fill command (vkCmdFillBuffer) — no CPU-side allocation needed.
  - `value`: The uint32 value to fill with. Defaults to zero.
- `System.Void SetCounterValue(System.UInt32 counterValue)`
  - Sets the counter value for `Sandbox.GpuBuffer.UsageFlags.Append` or `Sandbox.GpuBuffer.UsageFlags.Counter` structured buffers.
