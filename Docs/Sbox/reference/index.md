# Hand-curated reference cards

Each card is a tight digest of a topic we actually use. Source-cited from `../guides/`. Do not invent. If a card and the upstream guide disagree, the guide wins (the card may be out of date).

| Card | Topic | Backing guide |
|------|-------|---------------|
| [`convars-and-concmds.md`](./convars-and-concmds.md) | Declaring `[ConVar]` properties and `[ConCmd]` commands, the flag matrix, server-only commands. | `../guides/code/code-basics/console-variables.md` |
| [`dedicated-server.md`](./dedicated-server.md) | Installing the dedicated server through SteamCMD, launching it, the available command-line switches. | `../guides/networking/dedicated-servers/index.md` |
| [`http-from-host.md`](./http-from-host.md) | Calling out from the gamemode through `Sandbox.Http`. URL constraints (no IPs, localhost ports), JSON helpers, the `-allowlocalhttp` switch. | `../guides/networking/http-requests.md` |
| [`rpc-messages.md`](./rpc-messages.md) | `[Rpc.Broadcast]`, `[Rpc.Owner]`, `[Rpc.Host]`, the `NetFlags` matrix, broadcast filtering. | `../guides/networking/rpc-messages.md` |
| [`ownership.md`](./ownership.md) | Networked GameObject ownership, `IsProxy`, `OwnerTransfer`, taking and dropping ownership. | `../guides/networking/ownership.md` |
| [`file-system.md`](./file-system.md) | The three filesystems (`Data`, `OrganizationData`, `Mounted`) and what each is for. JSON serialisation rules. | `../guides/assets/file-system.md` |
| [`serverside-code.md`](./serverside-code.md) | The `#if SERVER` mechanism, `*.Server.cs` files, how serverside-only code is stripped from clients. | `../guides/networking/dedicated-servers/serverside-code.md` |
