# Sandbox.LaunchArguments

These are arguments that were set when launching the current game.
This is used to pre-configure the game from the menu

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static System.String Map`
  - The map to start with. It's really up to the game to use this
- `static System.Int32 MaxPlayers`
  - Preferred max players for multiplayer games. Used by games, but not enforced.
- `static Sandbox.Network.LobbyPrivacy Privacy`
  - Default privacy for lobbies created on game start.
- `static System.Collections.Generic.Dictionary<System.String,System.String> GameSettings`
  - The game settings to apply on join. These are a list of convars.
- `static System.String ServerName`
  - The hostname for the server.
