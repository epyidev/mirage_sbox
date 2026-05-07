# Sandbox.Utility.Steam

- **Kind:** static class
- **Namespace:** `Sandbox.Utility`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static Sandbox.SteamId SteamId`
  - The current user's SteamId
- `static System.String PersonaName`
  - The current user's persona name (Steam name)

## Methods

### Static methods

- `static Sandbox.SteamId.AccountTypes CategorizeSteamId(Sandbox.SteamId steamid)`
  - Return what type os SteamId this is
- `static System.Boolean IsFriend(Sandbox.SteamId steamid)`
  - Return true if this is a friend
- `static System.Boolean IsOnline(Sandbox.SteamId steamid)`
  - Return true if this person is online
- `static System.String FilterText(System.String input, System.Nullable<Sandbox.SteamId> from)`
- `static System.String FilterChat(System.String input, System.Nullable<Sandbox.SteamId> from)`
- `static System.String FilterName(System.String input, System.Nullable<Sandbox.SteamId> from)`
