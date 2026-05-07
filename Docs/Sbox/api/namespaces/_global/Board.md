# Sandbox.Services.Leaderboards.Board

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Services.Leaderboards`

## Constructors

- `Board(System.String package, System.String name)`

## Properties

- `System.Int64 TargetSteamId`
  - The steamid to get information about. If unset then this defaults to the current player.
- `System.Int32 MaxEntries`
  - The maximum entries to respond with.
- `System.String Group`
  - global, country, friends
- `System.String Title`
  - The group name of this board. For example, "Global" for global, "Friends" for friends.
- `System.String DisplayName`
  - The display name of this board, which was set in the backend.
- `System.String Description`
  - The description of this board, which was set in the backend.
- `System.Int64 TotalEntries`
  - The total number of chart entries for this board.
- `System.String Unit`
  - The unit type chosen for this board
- `Sandbox.Services.Leaderboards.Entry[] Entries`
  - The group of entries for this board. This is usually the entries that surround
the TargetSteamId.

## Methods

### Instance methods

- `System.Threading.Tasks.Task Refresh(System.Threading.CancellationToken cancellation)`
