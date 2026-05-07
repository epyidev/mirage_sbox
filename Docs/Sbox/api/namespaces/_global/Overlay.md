# Sandbox.Game.Overlay

Provides static methods for displaying various modal overlays in the game UI.


The `Sandbox.Game.Overlay` class allows you to open modals for packages, maps, news, organizations, reviews, friends lists, server lists, settings, input bindings, and player profiles.
It serves as a central point for invoking user interface overlays that interact with core game and community features.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Game`

## Constructors

- `Overlay()`

## Properties

- `System.Boolean IsOpen`
  - Returns true if any overlay is open
- `System.Boolean IsPauseMenuOpen`
  - Returns true if the pause menu overlay is open

## Methods

### Static methods

- `static System.Void ShowGameModal(System.String packageIdent)`
  - Opens a modal for the specified game package
- `static System.Void ShowMapModal(System.String packageIdent)`
  - Opens a modal for the specified map package
- `static System.Void ShowPackageModal(System.String ident)`
  - Opens a modal for the specified package
- `static System.Void ShowPackageModal(System.String ident, System.String page)`
  - Opens a modal for the specified package on the specified page
- `static System.Void ShowNewsModal(Sandbox.Services.News newsitem)`
  - Opens a modal for the news item
- `static System.Void ShowOrganizationModal(Sandbox.Package.Organization org)`
  - Opens a modal for the specified organization. 
This is most likely called from a Package - so get the organization from there.
- `static System.Void ShowReviewModal(Sandbox.Package package)`
  - Opens a modal to review the specified package
- `static System.Void ShowReportModal(System.String packageIdent)`
  - Opens a modal to report the specified package
- `static System.Void ShowPackageSelector(System.String query, System.Action<Sandbox.Package> onSelect, System.Action<System.String> onFilterChanged)`
- `static System.Void ShowFriendsList()`
- `static System.Void ShowFriendsList(Sandbox.Modals.FriendsListModalOptions options)`
  - Opens a modal that shows the user's friends list
- `static System.Void ShowServerList(Sandbox.Modals.ServerListConfig config)`
  - Opens a modal that shows a list of active servers
- `static System.Void ShowSettingsModal(System.String page)`
  - Opens a modal that lets you modify your settings
Optionally, you can specify a page to open directly to: "keybinds", "video", "input", "audio", "game", "storage", "developer"
- `static System.Void ShowBinds()`
  - Opens a modal that lets you view and rebind game input actions.
- `static System.Void CreateGame(Sandbox.Modals.CreateGameOptions options)`
  - Opens a modal to create a game with a bunch of settings. We use this in the menu when you click "Create Game"
and the game has options.
- `static System.Void ShowPlayer(Sandbox.SteamId steamid, System.String page)`
  - View a selected user's profile
- `static System.Void ShowPlayerList()`
  - Open a modal that shows a list of players currently in the game
- `static System.Void WorkshopPublish(Sandbox.Modals.WorkshopPublishOptions options)`
  - Open a modal that prompts the user to publish content to the workshop
- `static System.Void ShowPauseMenu()`
  - Opens the pause menu overlay. This is the same menu that appears when pressing ESC.
- `static System.Void Close()`
  - Closes the top overlay if one exists
- `static System.Void CloseAll(System.Boolean immediate)`
  - Close all open overlays
  - `immediate`: If `true`, will skip any outros
