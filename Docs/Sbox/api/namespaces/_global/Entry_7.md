# Sandbox.Services.Leaderboards.Board2.Entry

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Services.Leaderboards/Board2`

## Fields

- `System.Int64 Rank`
  - The rank in the board
- `System.Double Value`
  - The value in the board
- `System.Int64 SteamId`
  - The steamid of the entry
- `System.String CountryCode`
  - The country which this entry is from
- `System.String DisplayName`
  - The player's display name
- `System.DateTimeOffset Timestamp`
  - The time this entry was created.
- `System.Collections.Generic.Dictionary<System.String,System.Object> Data`
  - Data associated with this entry
- `System.String DataUrl`
  - If set then this entry has an associated data entry. This file is 
usually a json object which was submitted with the stat. You can use
this for replays and stuff.
