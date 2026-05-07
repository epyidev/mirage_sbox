# ConVars and ConCmds

Source: `../guides/code/code-basics/console-variables.md`. API: `../api/namespaces/_global/ConVarFlags.md`, `../api/namespaces/_global/ConVarAttribute.md`, `../api/namespaces/_global/ConCmdAttribute.md`.

Console variables and commands are declared with attributes on **static** members.

## ConCmd: a command callable from the console

```csharp
[ConCmd("hello")]
static void HelloCommand()
{
    Log.Info( "Hello there!" );
}
```

The runtime converts string arguments to the parameter types you declare:

```csharp
[ConCmd("hello")]
static void HelloCommand( string name )
{
    Log.Info( $"Hello there {name}!" );
}
```

### Server-only commands

Add `ConVarFlags.Server` to force the command to run on the host. If the first parameter is a `Connection`, the runtime fills it with the calling connection so the host knows who issued the command:

```csharp
[ConCmd( "test", ConVarFlags.Server )]
public static void TestCmd( Connection caller )
{
    Log.Info( "The caller is: " + caller.DisplayName  );
}
```

## ConVar: a tunable value

```csharp
[ConVar]
public static bool debug_bullets { get; set; } = false;
```

Must be a `static` property with a getter and setter.

## Flag matrix

Flags compose with `|`. Source listing from the official guide:

| Flag | Effect |
|------|--------|
| `ConVarFlags.Saved` | Persists to disk across sessions. |
| `ConVarFlags.Replicated` | Only the host can change it; value is synced to all clients. |
| `ConVarFlags.UserInfo` | Sent from the client to the host as part of the connection's UserInfo. |
| `ConVarFlags.Hidden` | Hidden from `find` and autocomplete. Also valid on `[ConCmd]`. |
| `ConVarFlags.GameSetting` | Surfaced in the game-creation screen as a UI control (combine with `Range`, etc.). |
| `ConVarFlags.Server` | On `[ConCmd]`, forces server-side execution. |

Examples from the guide:

```csharp
[ConVar( "bullet_count", ConVarFlags.Saved )]
public static int BulletCount { get; set; } = 6;

[ConVar( "friendly_fire", ConVarFlags.Replicated )]
public static bool FriendlyFire { get; set; } = false;

[ConVar( "view_mode", ConVarFlags.UserInfo )]
public static string ViewMode { get; set; } = "firstperson";

[ConVar( "secret", ConVarFlags.Hidden )]
public static int SecretVariableMode { get; set; } = 3;

[ConVar( "player_speed", ConVarFlags.GameSetting ), Range( 50f, 1024f, 1 )]
public static float PlayerSpeed { get; set; } = 250f;
```

## Setting ConVars at server boot

The dedicated server accepts `+name value` on the command line (see `dedicated-server.md`). Documented switches use the same syntax (`+game`, `+hostname`, `+port`, `+net_query_port`, `+net_game_server_token`). Custom ConVars declared by the gamemode follow the same convention.
