# Sandbox.Utility.Crc64

Generate 64-bit <a href="https://en.wikipedia.org/wiki/Cyclic_redundancy_check">Cyclic Redundancy Check</a> (CRC64) checksums.

- **Kind:** static class
- **Namespace:** `Sandbox.Utility`
- **Assembly:** `Sandbox.System`

## Methods

### Static methods

- `static System.UInt64 FromString(System.String str)`
  - Generates a CRC64 checksum from a string.
  - `str`: The input to generate a checksum for.
  - returns: The generated CRC64.
- `static System.Threading.Tasks.Task<System.UInt64> FromStreamAsync(System.IO.Stream stream)`
  - Generates a CRC64 checksum from a stream asynchronously.
  - `stream`: The input to generate a checksum for.
  - returns: The generated CRC64.
- `static System.UInt64 FromStream(System.IO.Stream stream)`
  - Generates a CRC64 checksum from a stream.
  - `stream`: The input to generate a checksum for.
  - returns: The generated CRC64.
- `static System.UInt64 FromBytes(System.Byte[] stream)`
  - Generates a CRC64 checksum from a byte array.
