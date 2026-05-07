# Sandbox.ComputeShader

A compute shader is a program that runs on the GPU, often with data provided to/from the CPU by means of a `Sandbox.GpuBuffer`1` or a `Sandbox.Texture`.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ComputeShader(System.String path)`
  - Create a compute shader from the specified path.

## Properties

- `Sandbox.RenderAttributes Attributes`
  - Attributes that are passed to the compute shader on dispatch.

## Methods

### Instance methods

- `System.Void Dispatch(System.Int32 threadsX, System.Int32 threadsY, System.Int32 threadsZ)`
  - Dispatch this compute shader using explicit thread counts.
  - `threadsX`: The number of threads to dispatch in the X dimension.
  - `threadsY`: The number of threads to dispatch in the Y dimension.
  - `threadsZ`: The number of threads to dispatch in the Z dimension.
- `System.Void DispatchIndirect(Sandbox.GpuBuffer indirectBuffer, System.UInt32 indirectElementOffset)`
  - Dispatch this compute shader by reading thread group counts (x, y, z)
from an indirect buffer of type `Sandbox.GpuBuffer.IndirectDispatchArguments`.
  - `indirectBuffer`: The GPU buffer containing one or more dispatch argument entries.
  - `indirectElementOffset`: The index of the dispatch arguments element to use (each element = 12 bytes).
- `System.Void DispatchWithAttributes(Sandbox.RenderAttributes attributes, System.Int32 threadsX, System.Int32 threadsY, System.Int32 threadsZ)`
- `System.Void DispatchIndirectWithAttributes(Sandbox.RenderAttributes attributes, Sandbox.GpuBuffer indirectBuffer, System.UInt32 indirectElementOffset)`
