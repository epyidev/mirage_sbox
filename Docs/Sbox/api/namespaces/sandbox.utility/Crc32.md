# Sandbox.Utility.Crc32

Generates 32-bit <a href="https://en.wikipedia.org/wiki/Cyclic_redundancy_check">Cyclic Redundancy Check</a> (CRC32) checksums.
Used for data integrity verification and fast hashing.

- **Kind:** static class
- **Namespace:** `Sandbox.Utility`
- **Assembly:** `Sandbox.System`

## Methods

### Static methods

- `static System.UInt32 FromBytes(System.Collections.Generic.IEnumerable<System.Byte> byteStream)`
- `static System.UInt32 FromString(System.String str)`
  - Generates a CRC32 checksum from a string.
  - `str`: The input to generate a checksum for.
  - returns: The generated CRC32.
- `static System.Threading.Tasks.Task<System.UInt32> FromStreamAsync(System.IO.Stream stream)`
  - Generates a CRC32 checksum from a stream asynchronously.
  - `stream`: The input to generate a checksum for.
  - returns: The generated CRC32.
