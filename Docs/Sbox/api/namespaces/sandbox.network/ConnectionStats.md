# Sandbox.Network.ConnectionStats

- **Kind:** struct
- **Namespace:** `Sandbox.Network`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Int32 Ping`
  - Current ping for this connection.
- `System.Single OutPacketsPerSecond`
  - How many packets per second we're sending to this connection.
- `System.Single OutBytesPerSecond`
  - How many bytes per second we're sending to this connection.
- `System.Single InPacketsPerSecond`
  - How many packets per second we're receiving from this connection.
- `System.Single InBytesPerSecond`
  - How many bytes per second we're receiving from this connection.
- `System.Int32 SendRateBytesPerSecond`
  - Estimate rate that we believe we can send data to this connection.
- `System.Single ConnectionQuality`
  - From 0 to 1 how good is our connection to this?
