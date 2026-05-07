# Sandbox.GpuBuffer.UsageFlags

You can combine these e.g UsageFlags.Index | UsageFlags.ByteAddress for a buffer that can be used as an index buffer and in a compute shader.

- **Kind:** enum
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`
- **Declaring type:** `Sandbox.GpuBuffer`

## Values

- `Vertex` - Can be used as a vertex buffer.
- `Index` - Can be used as an index buffer.
- `ByteAddress` - Byte Address Buffer (HLSL RWByteAddressBuffer)
- `Structured` - Structured Buffer (HLSL RWStructuredBuffer)
- `Append` - Append Structured Buffer (HLSL AppendStructuredBuffer)
- `Counter`
- `IndirectDrawArguments` - Indirect argument buffer for indirect draws
<seealso cref="T:Sandbox.GpuBuffer.IndirectDrawArguments" /><seealso cref="T:Sandbox.GpuBuffer.IndirectDrawIndexedArguments" />
