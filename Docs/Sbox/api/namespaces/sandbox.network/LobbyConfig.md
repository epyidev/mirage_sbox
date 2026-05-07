# Sandbox.Network.LobbyConfig

- **Kind:** struct
- **Namespace:** `Sandbox.Network`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `LobbyConfig()`

## Properties

- `System.Boolean DestroyWhenHostLeaves`
  - Whether to automatically destroy this lobby when the host leaves. This is only
applicable to P2P lobbies.
- `System.Boolean AutoSwitchToBestHost`
  - Whether to periodically switch to the best possible host candidate. This is only
applicable to P2P lobbies.
- `System.Boolean Hidden`
  - Whether to hide this lobby from appearing in the server list. It will still be
queryable programatically, so long as the `Sandbox.Network.LobbyConfig.Privacy` mode allows it.
- `Sandbox.Network.LobbyPrivacy Privacy`
  - Determines who is able to connect to this lobby. This will be public by default.
- `System.Int32 MaxPlayers`
  - The maximum amount of players this lobby can hold. By default, this will be
the Max Players set in the current Game Package's project settings.
- `System.String Name`
  - The name of this lobby. If this isn't set, a default lobby name will be chosen instead.
