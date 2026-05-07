# Sandbox.Application

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static System.UInt64 AppId`
  - Steam AppId of S&amp;box.
- `static System.Boolean IsUnitTest`
  - True if we're running the engine as part of a unit test
- `static System.Boolean IsHeadless`
  - True if running without a graphics window, such as in a terminal.
- `static System.Boolean IsConsoleApp`
  - True if running in a terminal like console, instead of a game window or editor.
- `static System.Boolean IsDedicatedServer`
  - True if this is a dedicated server
- `static System.Boolean IsEditor`
  - True if running with the tools or editor attached
- `static System.String Version`
  - The engine's version string
- `static System.DateTime VersionDate`
  - The date of this version, as a UTC datetime.
- `static System.Boolean IsStandalone`
  - True if the game is running in standalone mode
- `static System.String LanguageCode`
  - The language code for the current language
- `static System.Boolean IsVR`
  - True if the game is running in VR mode
- `static System.Boolean IsDebug`
- `static System.Boolean IsMicrophoneListening`
  - Returns true if the microphone is currently listening
- `static System.Boolean IsMicrophoneRecording`
  - Returns true if the microphone is currently listening and actually hearing/capturing sounds
- `static System.Boolean IsFocused`
  - Is the game window in focus?
- `static System.Boolean CheatsEnabled`
- `static Sandbox.Engine.Settings.RenderSettings RenderSettings`
  - Allows access to the RenderSettings singleton, which contains settings related to rendering in the game.
You're only able to access this when in standalone mode. When accessing in the editor, or in sbox it will return null.
- `static Editor.EditorSystem Editor`
  - Get the current editor if any. Will return null if we're not in the editor, or there is no active editor session.
