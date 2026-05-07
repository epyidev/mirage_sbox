# Sandbox.Game

Provides global access to core game state, utilities, and operations for S&amp;box.


The `Sandbox.Game` class exposes static properties and methods to query and control the running game,
such as checking if the game is running, getting your steamid, taking screenshots, and managing game sessions.

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static System.UInt64 AppId`
  - Steam AppId of S&amp;box.
- `static System.Boolean InGame`
  - Return true if we're in a game (ie, not in the main menu)
- `static System.Boolean IsEditor`
  - Returns true if the game is running with the editor enabled
- `static System.String Ident`
  - Returns the current game's ident - ie facepunch.sandbox
- `static System.Boolean IsMainMenuVisible`
  - Returns true if the main menu is visible. Note that this will work serverside too but will only
return the state of the host.
- `static System.Boolean IsRecordingVideo`
  - True if we're currently recording a video (using the video command, or F6)
- `static System.Boolean IsClosing`
  - Set to true when the game is closing
- `static System.Boolean IsRunningInVR`
  - Return true if we're running in VR
- `static System.Boolean IsRunningOnHandheld`
  - Return true if we're running on a handheld device (the deck). Will always be false serverside.
- `static System.Random Random`
  - A shared random that is automatically seeded on tick
- `static Sandbox.SteamId SteamId`
  - Your SteamId
- `static Sandbox.PhysicsTraceBuilder PhysicsTrace`
  - Trace against the physics in the current scene
- `static Sandbox.SceneTrace SceneTrace`
  - Trace against the physics and hitboxes in the current scene
- `static System.Boolean CheatsEnabled`
  - This has to be in Game.dll so the codegen will get generated for it
- `static Sandbox.Internal.TypeLibrary TypeLibrary`
  - Provides access to the global `Sandbox.Internal.TypeLibrary` for the current game context.


The `TypeLibrary` is a runtime reflection system that describes types, their members, and relationships in the game and engine assemblies. It allows you to
find and create types by name and id. It's basically a sandboxed version of the .net reflection system.
- `static Sandbox.CookieContainer Cookies`
  - Allows access to the cookies for the current game. The cookies are used to store persistent data across game sessions, such as user preferences or session data.
Internally the cookies are encoded to JSON and stored in a file on disk.
- `static Sandbox.LanguageContainer Language`
  - Lets you get translated phrases from the localization system
- `static System.Boolean IsPlaying`
  - Indicates whether the game is currently running and actively playing a scene.
- `static System.Boolean IsPaused`
  - Indicates whether the game is currently paused.
- `static Sandbox.Scene ActiveScene`
  - The current scene that is being played.

## Methods

### Static methods

- `static System.Void SetRandomSeed(System.Int32 seed)`
  - Set the seed for Game.Random
- `static Sandbox.WebSurface CreateWebSurface()`
  - Create a limited web surface
- `static System.Void Disconnect()`
  - Disconnect from the current game session
- `static System.Void Close()`
  - Close the current game.
- `static System.Void Load(System.String gameIdent, System.Boolean keepClients)`
  - Load a game. You can configure the new game with LaunchArguments before calling this.
- `static System.Void TakeScreenshot()`
  - Capture a screenshot. Saves it in Steam.
- `static System.Void TakeHighResScreenshot(System.Int32 width, System.Int32 height)`
  - Capture a high resolution screenshot using the active scene camera.
- `static System.Boolean ChangeScene(Sandbox.SceneLoadOptions options)`
  - Change the active scene and optionally bring all connected clients to
the new scene (broadcast the scene change.) If we're in a networking
session, then only the host can change the scene.
  - `options`: The `Sandbox.SceneLoadOptions` to use which also specifies which scene to load.
  - returns: Whether the scene was changed successfully.
