# Serverside-only code

Source: `../guides/networking/dedicated-servers/serverside-code.md`. Related: `dedicated-server.md`.

## What it is

Code that the dedicated server compiles, but that is omitted from client builds. Lets the host hold logic that should never run on, or be visible to, clients (API tokens, database calls, anti-cheat checks).

## Constraint up front

> Serverside Code only works when running local projects.

That is, the `#if SERVER` and `*.Server.cs` mechanisms apply when the dedicated server is launched against a local `.sbproj`, not when running a published gamemode. For a published gamemode, all `#if SERVER` code is stripped at publish time.

## `#if SERVER` blocks

```csharp
protected override void OnUpdate()
{
#if SERVER
    Log.Info( "This is a server update!" );
#else
    Log.Info( "This is a client update!" );
#endif
}
```

When the dedicated server compiles this file, `SERVER` is defined and only the first branch is included. When a client compiles it, `SERVER` is not defined and the second branch is included. At publish time the server branch is stripped from the client artefact.

## `*.Server.cs` files

If you have `GameManager.cs` (a `partial class`), you can pair it with `GameManager.Server.cs`. The whole `*.Server.cs` file is implicitly wrapped in `#if SERVER`, so you avoid sprinkling preprocessor blocks across the codebase.

## Why this matters for Mirage

The bridge to the Mirage API (HTTP client, bearer token use, response parsing) is exactly the kind of code that belongs in `*.Server.cs` files. The token must never reach the client; even if a `[ConVar]` is `Hidden`, putting the call site itself behind `#if SERVER` is a second layer of defence and saves us from accidentally referencing host-only types in a client-compiled context.

Suggested layout (when we get to wiring it up):

```
Code/Api/
    ApiConfig.Server.cs       Declares mirage.api_host / mirage.api_token ConVars.
    ApiClient.Server.cs       Static class that wraps Sandbox.Http.
    CharacterCacheSystem.cs   Public surface (cache lookup, signals).
    CharacterCacheSystem.Server.cs   The actual API round-trips.
```

This keeps the public surface client-compilable while the network IO stays host-only.
