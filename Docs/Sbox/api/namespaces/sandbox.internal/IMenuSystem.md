# Sandbox.Internal.IMenuSystem

This is how the engine communicates with the menu system

- **Kind:** interface
- **Namespace:** `Sandbox.Internal`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Boolean ForceCursorVisible`
  - True if we want to force the cursor to be visible and swallow input.
This is used for the developer console and loading screens.

## Methods

### Instance methods

- `virtual System.Void Init()`
  - Called to initialize the menu system
- `virtual System.Void Shutdown()`
  - Close down the menu, delete everything
- `virtual System.Void Tick()`
  - Called every frame, to let the menu think
- `virtual System.Void Popup(System.String type, System.String title, System.String subtitle)`
  - Show a popup
- `virtual System.Void Question(System.String message, System.String icon, System.Action yes, System.Action no)`
  - Show a question
- `virtual System.Void OnPackageClosed(Sandbox.Package package)`
  - Package closed. Add a toast asking if it was cool or not
- `virtual System.Void PackageUsageChanged(System.String packageIdent, System.Int64 userCount)`
  - The backend is telling us that the number of users playing has changed
- `virtual System.Void PackageFavouritesChanged(System.String packageIdent, System.Int64 value)`
  - Notifies that the number of favourites for the specified package has changed.
