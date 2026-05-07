# Sandbox.Compression.LZ4

Encode and decode LZ4 compressed data.

- **Kind:** static class
- **Namespace:** `Sandbox.Compression`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static System.Byte[] CompressBlock(System.ReadOnlySpan<System.Byte> data, System.IO.Compression.CompressionLevel compressionLevel)`
- `static System.Int32 DecompressBlock(System.ReadOnlySpan<System.Byte> src, System.Span<System.Byte> dest)`
- `static System.Byte[] CompressFrame(System.ReadOnlySpan<System.Byte> data, System.IO.Compression.CompressionLevel compressionLevel)`
- `static System.Byte[] DecompressFrame(System.ReadOnlySpan<System.Byte> data)`
