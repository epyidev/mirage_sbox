# Dedicated server

Source: `../guides/networking/dedicated-servers/index.md`, `../guides/networking/dedicated-servers/running-local-projects.md`, `../guides/networking/dedicated-servers/serverside-code.md`, `../guides/networking/dedicated-servers/user-permissions.md`.

## Install through SteamCMD

s&box dedicated server is Steam app id **1892930**. Install/update with SteamCMD:

```bash
./steamcmd +login anonymous +app_update 1892930 validate +quit
```

Default install path: `steamcmd/steamapps/common/sbox dedicated server`.

The optional `-beta staging` switch installs the staging branch (may not be playable by everyone).

## Launching

Windows example (`Run-Server.bat`):

```bat
echo off
sbox-server.exe +game facepunch.sandbox facepunch.flatgrass +hostname My Dedicated Server
```

Linux requires the .NET runtime (the binary is .NET-based). Example `run-server.sh`:

```bash
#!/bin/bash
./sbox-server.exe +game facepunch.sandbox facepunch.flatgrass +hostname "My Dedicated Server"
```

## Documented command-line switches

Ones explicitly listed by the guide:

| Switch | Arguments | Effect |
|--------|-----------|--------|
| `+game` | `<packageIdent>` `[mapPackageIdent]` | Game package to load and optionally a map package. |
| `+hostname` | `<name>` | Server title shown to players. |
| `+net_game_server_token` | `<token>` | Persists the server's Steam ID across restarts. Generated at https://steamcommunity.com/dev/managegameservers. Optional. |
| `+port` | `<port>` | Game port (default 27015). |
| `+net_query_port` | `<port>` | Server-info query port (default 27016). |

Other documented switches:

- `-allowlocalhttp` lets `Sandbox.Http` reach any local URL from the server (not just the default `localhost` port allowlist). See `http-from-host.md`.
- `-beta staging` (passed to SteamCMD, not the server) selects the staging branch.

The general syntax `+name value` works for any ConVar or ConCmd, since "These are just essentially a ConVar or ConCmd that is run when the server boots up" (per the guide). So custom ConVars declared by the gamemode can be set the same way.

## No `server.cfg` natively

There is **no built-in `server.cfg` exec mechanism** the way Source or FiveM has. Configuration is done through:

- Command-line switches at boot (above).
- A JSON admin config under the dedicated server's data directory (e.g. `users/config.json` per the third-party hosting docs; we have not validated this from upstream).
- The gamemode reading its own config files through `Sandbox.FileSystem.Data` at startup.

If you need an `exec`-style config loader, build it inside the gamemode using `FileSystem.Data` (see `file-system.md`).

## Loading a local project

The guide notes you can pass a path to a `.sbproj` file as a positional argument to `sbox-server.exe`. Connected clients receive code changes and hotload them. This is the standard dev loop for iterating on gamemode code without re-publishing.

## Serverside-only code

See `serverside-code.md`. The short version: wrap host-only code in `#if SERVER` or place it in `*.Server.cs` files; it is stripped from client builds when published.
