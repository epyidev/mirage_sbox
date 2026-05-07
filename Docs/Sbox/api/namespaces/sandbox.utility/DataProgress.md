# Sandbox.Utility.DataProgress

Provides progress information for operations that process blocks of data,
such as file uploads, downloads, or large data transfers.

- **Kind:** struct
- **Namespace:** `Sandbox.Utility`
- **Assembly:** `Sandbox.System`

## Properties

- `System.Int64 ProgressBytes`
  - The number of bytes processed so far.
- `System.Int64 TotalBytes`
  - The total number of bytes to process.
- `System.Int64 DeltaBytes`
  - The number of bytes processed since the last progress update.
- `System.Single ProgressDelta`
  - Progress as a fraction from 0.0 to 1.0.
