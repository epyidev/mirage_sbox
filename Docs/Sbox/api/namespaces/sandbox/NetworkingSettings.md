# Sandbox.NetworkingSettings

A class that holds all configured networking settings for a game.
This is serialized as a config and shared from the server to the client.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ConfigData`

## Constructors

- `NetworkingSettings()`

## Properties

- `System.Boolean DestroyLobbyWhenHostLeaves`
  - Whether to disband the game lobby when the host leaves.
- `System.Boolean AutoSwitchToBestHost`
  - Whether to periodically switch to the best host candidate. Candidates are
scored based on their average ping and connection quality to all other peers.
- `System.Boolean ClientsCanSpawnObjects`
  - By default, can clients create objects. This can be changed per connection after join.
- `System.Boolean ClientsCanRefreshObjects`
  - By default, can clients refresh objects. This can be changed per connection after join.
- `System.Boolean ClientsCanDestroyObjects`
  - By default, can clients destroy objects. This can be changed per connection after join.
- `System.Single UpdateRate`
  - The frequency at which the network system will send updates to clients. Higher is better but
you probably want to stay in the 10-60 range.
