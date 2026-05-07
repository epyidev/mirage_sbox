# HTTP from the host

Source: `../guides/networking/http-requests.md`. API: `../api/namespaces/sandbox/Http.md`.

The gamemode can call HTTP endpoints through the static `Sandbox.Http` class. Used by the host to talk to backend services (in our project, the Mirage API in `../../../Api/`).

## Allowed URLs (the constraint that bites)

Per the guide, verbatim:

> You can only use `http` or `https` URLs to domains (no IP addresses), and to prevent abuse, `localhost` is permitted only on ports 80/443/8080/8443.

So:

- `http://api.example.com/...` works.
- `http://localhost:8080/...` works (8080 is in the allowlist).
- `http://localhost:3000/...` does **not** work without `-allowlocalhttp`.
- `http://127.0.0.1:8080/...` does **not** work (raw IP forbidden).

The dedicated-server command-line switch `-allowlocalhttp` opens any local URL from the server. Use it for dev only.

For our Mirage API the safe production URL is `http://localhost:8080` (or a real domain when the API is on a separate host).

## Common patterns

Verbatim from the guide:

```csharp
// GET request that returns the response as a string
string response = await Http.RequestStringAsync( "https://google.com" );

// POST request of JSON content ignoring any response
await Http.RequestAsync( "https://api.facepunch.com/my/method", "POST", Http.CreateJsonContent( playerData ) );
```

For our API, we will need:

- A bearer token in the `Authorization` header. The `Http` API surface accepts headers (see the API reference at `../api/namespaces/sandbox/Http.md` for the exact overload).
- JSON request bodies via `Http.CreateJsonContent(...)`.
- JSON response parsing.

Look up the exact overloads in `../api/namespaces/sandbox/Http.md` before writing call sites; the helper names and parameter shapes are authoritative there.

## Auth

`Sandbox.Http` does not encode auth secrets for you. The bearer token must come from a server-only ConVar (see `convars-and-concmds.md`) and be passed in headers. Keep the token off any replicated ConVar.

## Why this matters for our backend

Our `Api/` README originally suggested binding on `127.0.0.1:8080`. With `Sandbox.Http`, that exact URL would be rejected. Use `http://localhost:8080` from the gamemode side (or a domain when off-host). The Mirage API itself can still bind on `127.0.0.1` at the OS level: only the URL the gamemode dials matters for the s&box allowlist.
