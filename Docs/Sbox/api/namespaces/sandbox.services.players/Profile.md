# Sandbox.Services.Players.Profile

Player profile

- **Kind:** sealed class
- **Namespace:** `Sandbox.Services.Players`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Profile()`

## Properties

- `Sandbox.SteamId Id`
- `System.String Name`
- `System.String Url`
- `System.Boolean Online`
- `System.Boolean Private`
- `System.Int32 Score`
- `System.String Avatar`
- `System.Boolean IsFriend`
- `static Sandbox.Services.Players.Profile Local`

## Methods

### Static methods

- `static System.Threading.Tasks.Task<Sandbox.Services.Players.Profile> Get(Sandbox.SteamId steamid)`
