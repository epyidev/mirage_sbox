# Sandbox.StandaloneManifest

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `StandaloneManifest()`

## Properties

- `System.String Name`
  - What is the game's name?
- `System.String Ident`
  - What ident are we running under?
- `System.String ExecutableName`
  - Game's executable name (e.g. game.exe)
- `System.UInt64 AppId`
  - The Steam App ID of the game
- `System.DateTime BuildDate`
  - Game's build date, automatically set when the game was exported.
- `System.Boolean IsVRProject`
  - Should we automatically launch this project in VR?
