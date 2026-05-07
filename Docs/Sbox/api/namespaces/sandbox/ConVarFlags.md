# Sandbox.ConVarFlags

- **Kind:** enum
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Enum`

## Values

- `None`
- `Saved` - Saved and restored between sessions
- `Replicated` - The value of this is synced on a server. Only the server or server admins may change the value.
- `Cheat` - This is a cheat command, don't run it unless cheats are enabled
- `UserInfo` - Adds to userinfo - making it accessible via the connection class on other clients
- `Hidden` - Hide in find and autocomplete
- `ChangeNotice` - Tell clients when the value changes
- `Protected` - Can't be accessed via game code (can be changed manually via console, or tools)
- `Server` - This command will be run on the server in a multiplayer game
- `Admin` - Only an admin of the server can run this command
- `GameSetting` - A game setting that is exposed to the platform for UI editing
