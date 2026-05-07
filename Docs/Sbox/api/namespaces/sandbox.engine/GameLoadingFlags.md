# Sandbox.Engine.GameLoadingFlags

- **Kind:** enum
- **Namespace:** `Sandbox.Engine`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`

## Values

- `Remote` - Set if we're loading a game as a result of joining a server
- `Host` - Set if we're the hosting as the result of starting our own server
- `Reload` - Set if we want to reload the game, even if it's already loaded
- `Developer` - Set if this is a developer session. It started from an editor session and as such we shouldn't load
assemblies from the package, they should be loaded from the Network Tables instead.
