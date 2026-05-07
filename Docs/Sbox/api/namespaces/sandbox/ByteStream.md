# Sandbox.ByteStream

Write and read bytes to a stream. This aims to be as allocation free as possible while also being as fast as possible.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Properties

- `System.Boolean Writable`
  - Is this stream writable?
- `System.Int32 Position`
  - The current read or write position. Values are clamped to valid range.
- `System.Int32 Length`
  - The total size of the data
- `System.Int32 ReadRemaining`

## Methods

### Static methods

- `static Sandbox.ByteStream Create(System.Int32 size)`
  - Create a writable byte stream
- `static Sandbox.ByteStream CreateReader(System.ReadOnlySpan<System.Byte> data)`

### Instance methods

- `System.Void Dispose()`
- `System.Void EnsureCanWrite(System.Int32 size)`
  - Ensures buffer can accommodate write with overflow protection
- `System.Void EnsureCanRead(System.Int32 size)`
  - Validates read bounds with overflow protection
- `System.Void WriteArray(System.ReadOnlySpan<T> arr)`
- `System.Void WriteArray(T[] arr, System.Boolean includeCount)`
  - Writes an array of unmanaged types
- `System.Void Write(Sandbox.ByteStream stream)`
- `System.Void Write(System.Byte[] rawData)`
- `System.Void Write(System.Byte[] rawData, System.Int32 offset, System.Int32 bytes)`
- `System.Void Write(Sandbox.ByteStream stream, System.Int32 offset, System.Int32 maxSize)`
- `System.Void Write(System.String str)`
  - Writes a string
- `System.Byte[] ToArray()`
  - Get the data as an array of bytes
- `System.Void Write(T value)`
  - Writes an unmanaged type
- `T Read()`
  - Reads an unmanaged type
- `System.Boolean TryRead(T v)`
  - Try to read variable, return false if not enough data
- `T[] ReadArray(System.Int32 maxElements)`
  - Returns an array of unmanaged types
- `System.String Read(System.String defaultValue)`
- `System.Void Write(T data, System.Boolean unused)`
- `T Read(T defaultValue, System.Boolean unused)`
- `System.Object ReadObject(System.Type objectType)`
- `System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count)`
- `System.Int32 Read(System.Span<System.Byte> buffer)`
- `Sandbox.ByteStream Compress(System.IO.Compression.CompressionLevel compressionLevel)`
- `Sandbox.ByteStream Decompress()`
