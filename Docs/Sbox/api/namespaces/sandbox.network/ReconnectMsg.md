# Sandbox.Network.ReconnectMsg

Sent to the server to tell clients to reconnect. This is sent when
the server is changing games, or maps, and wants the current players
to follow them to the new game, or map.
We send the Game and Map to the best of our knowledge, so the client
can maybe preload them, while we are.

- **Kind:** struct
- **Namespace:** `Sandbox.Network`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.String Game`
- `System.String Map`
