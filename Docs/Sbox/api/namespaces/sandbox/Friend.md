# Sandbox.Friend

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Friend(System.UInt64 steamid)`
- `Friend(System.Int64 steamid)`

## Properties

- `System.Boolean IsMe`
  - Returns true if this friend is the local user
- `System.UInt64 Id`
  - The friend's Steam Id
- `System.String Name`
  - The friend's name
- `System.Boolean IsOnline`
  - Returns true if your friend is online
- `System.Boolean IsFriend`
  - Returns true if this user is your friend
- `System.Boolean IsAway`
  - Returns true if your friend is away
- `System.Boolean IsBusy`
  - Returns true if this friend is marked as busy
- `System.Boolean IsSnoozing`
  - Returns true if this friend is marked as snoozing
- `System.Boolean IsPlayingThisGame`
  - Returns true if they're playing this game
- `System.Boolean IsPlayingAGame`
  - Returns true if they're playing any game

## Methods

### Instance methods

- `System.String GetRichPresence(System.String key)`
  - Returns a string that was possibly set by rich presence
- `System.Void OpenInOverlay()`
  - Opens the Steam overlay web browser to their user profile.
- `System.Void OpenAddFriendOverlay()`
  - Opens the Steam overlay with a popup that allows the local Steam user to confirm whether to add this user to their Steam friends list.
