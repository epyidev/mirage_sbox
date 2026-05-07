# FileSystem

Source: `../guides/assets/file-system.md`. API: `../api/namespaces/sandbox/FileSystem.md`, `../api/namespaces/sandbox/BaseFileSystem.md`.

## What is blocked

`System.IO.File` and the rest of the .NET filesystem APIs are blocked by the s&box code sandbox. You cannot read or write arbitrary disk paths. To touch files you go through `Sandbox.FileSystem`.

## The three filesystems

| Property | Where it points | Read | Write |
|----------|-----------------|------|-------|
| `FileSystem.Data` | `data/<org>/<game>/` (per-game data dir) | yes | yes |
| `FileSystem.OrganizationData` | `data/<org>/` (shared across the org's games) | yes | yes |
| `FileSystem.Mounted` | Aggregate of all mounted content (core game, current game, dependencies) | yes | no |

There is also `FileSystem.Cache` (a `KeyStore` field on `FileSystem`) for opportunistic caching: stored in a global cache folder and may be wiped at any time.

## Reading and writing text

```csharp
if ( !FileSystem.Data.FileExists( "player.txt" ) )
    FileSystem.Data.WriteAllText( "player.txt", "Hello, world!" );

var hello = FileSystem.Data.ReadAllText( "player.txt" );
```

## Reading and writing JSON

`WriteJson<T>` and `ReadJson<T>` only serialise **properties** (with getters and setters), not fields. The guide is explicit about this:

```csharp
public class PlayerData
{
    public int Level { get; set; }       // serialised
    public int MaxHealth { get; set; }   // serialised
    public string Username;              // NOT serialised (it is a field, not a property)

    public static void Save( PlayerData data )
    {
        FileSystem.Data.WriteJson( "player.json", data );
    }

    public static PlayerData Load()
    {
        return FileSystem.Data.ReadJson<PlayerData>( "player.json" );
    }
}
```

## When to use which

- `FileSystem.Data` is the default for any persistent state owned by this gamemode (config files, scratch saves).
- `FileSystem.OrganizationData` is for state that should outlive the current gamemode and apply to other games from the same org.
- `FileSystem.Mounted` is for reading content shipped with the game or its dependencies (read-only).

For our Mirage RP project, persistent gameplay state lives in the backend API (see `../../../Api/`), not in `FileSystem.*`. The local filesystem is fine for client-side preferences, server-side cached config, or one-off scratch files. **Do not duplicate gameplay state** between the API and a local file: the API is the source of truth.

## Path utilities

`FileSystem.NormalizeFilename(string filepath)` normalises a path so the engine accepts it (slashes, lowercasing). Use it whenever a path comes from user data.

`FileSystem.CreateMemoryFileSystem()` returns a `BaseFileSystem` that lives entirely in memory, useful for tests.
