# Sandbox.Services.Players.Overview

An overview of a player. Only available if their profile isn't set to private.

- **Kind:** sealed class
- **Namespace:** `Sandbox.Services.Players`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Overview()`

## Properties

- `Sandbox.Services.Players.Profile Player`
- `System.Int64 GamesPlayed`
- `System.Int64 TotalSessions`
- `System.Int64 SecondsPlayed`
- `System.Int64 Achievements`
- `System.String AvatarJson`
  - A json string representing how their avatar is dressed
- `System.Int64 TotalComments`
- `System.Int64 TotalFavourites`
- `System.Int64 TotalReviews`
- `System.Int64 NegativeReviews`
- `System.Int64 PositiveReviews`
- `Sandbox.Package MostPlayed`
- `Sandbox.Package LatestPlayed`

## Methods

### Static methods

- `static System.Threading.Tasks.Task<Sandbox.Services.Players.Overview> Get(Sandbox.SteamId steamid)`
