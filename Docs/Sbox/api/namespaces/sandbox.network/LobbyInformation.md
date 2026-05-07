# Sandbox.Network.LobbyInformation

- **Kind:** struct
- **Namespace:** `Sandbox.Network`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Boolean IsFull`
  - True if this lobby is full (Members &gt;= MaxMembers).
- `System.Boolean IsHidden`
  - True if this lobby should be hidden from server lists.

## Fields

- `System.UInt64 LobbyId`
- `System.UInt64 OwnerId`
- `System.Int32 Members`
- `System.Int32 MaxMembers`
- `System.String Name`
- `System.String Map`
- `System.String Game`
- `System.Int32 Ping`
  - Ping in milliseconds. Only available for dedicated servers, -1 if unknown.
- `System.Collections.Generic.Dictionary<System.String,System.String> Data`

## Methods

### Instance methods

- `System.String Get(System.String key, System.String defaultValue)`
