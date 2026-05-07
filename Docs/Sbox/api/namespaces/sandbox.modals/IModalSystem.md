# Sandbox.Modals.IModalSystem

- **Kind:** interface
- **Namespace:** `Sandbox.Modals`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Boolean IsModalOpen`
- `System.Boolean IsPauseMenuOpen`

## Methods

### Instance methods

- `virtual System.Boolean HasModalsOpen()`
- `virtual System.Void CloseAll(System.Boolean immediate)`
- `virtual System.Void Game(System.String packageIdent)`
- `virtual System.Void Map(System.String packageIdent)`
- `virtual System.Void Package(System.String packageIdent, System.String page)`
- `virtual System.Void Organization(Sandbox.Package.Organization org)`
- `virtual System.Void Review(Sandbox.Package package)`
- `virtual System.Void Report(System.String packageIdent)`
- `virtual System.Void PackageSelect(System.String query, System.Action<Sandbox.Package> onPackageSelected, System.Action<System.String> onFilterChanged)`
- `virtual System.Void FriendsList(Sandbox.Modals.FriendsListModalOptions& modreq(System.Runtime.InteropServices.InAttribute) options)`
- `virtual System.Void Server(Sandbox.Network.LobbyInformation lobby)`
- `virtual System.Void ServerList(Sandbox.Modals.ServerListConfig& modreq(System.Runtime.InteropServices.InAttribute) config)`
- `virtual System.Void Settings(System.String page)`
- `virtual System.Void CreateGame(Sandbox.Modals.CreateGameOptions& modreq(System.Runtime.InteropServices.InAttribute) options)`
- `virtual System.Void Player(Sandbox.SteamId steamid, System.String page)`
- `virtual System.Void News(Sandbox.Services.News newsitem)`
- `virtual System.Void PlayerList()`
- `virtual System.Void WorkshopPublish(Sandbox.Modals.WorkshopPublishOptions& modreq(System.Runtime.InteropServices.InAttribute) options)`
- `virtual System.Void Notice(System.String title, System.String message, System.String icon)`
- `virtual System.Void PauseMenu()`
  - The menu that is shown when escape is pressed while playing.
