# Sandbox.SteamId

Represents a Steam ID (64-bit unique identifier for Steam accounts).
Provides type-safe storage and conversion between long/ulong representations.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Constructors

- `SteamId(System.UInt64 id)`
  - Creates a Steam ID from an unsigned 64-bit integer.
- `SteamId(System.Int64 id)`
  - Creates a Steam ID from a signed 64-bit integer.

## Properties

- `System.Int64 Value`
  - Gets the Steam ID as a signed 64-bit integer.
- `System.UInt64 ValueUnsigned`
  - Gets the Steam ID as an unsigned 64-bit integer.
- `Sandbox.SteamId.AccountTypes AccountType`
  - Gets the type of Steam account this ID represents.
