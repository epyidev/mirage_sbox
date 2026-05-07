# Sandbox.StreamUser

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.String Id`
- `System.String Login`
- `System.String DisplayName`
- `System.String UserType`
- `System.String BroadcasterType`
- `System.String Description`
- `System.String ProfileImageUrl`
- `System.String OfflineImageUrl`
- `System.Int32 ViewCount`
- `System.String Email`
- `System.DateTimeOffset CreatedAt`
- `System.Threading.Tasks.Task<System.Collections.Generic.List<Sandbox.StreamUserFollow>> Following`
  - Get following "Who is following us"
- `System.Threading.Tasks.Task<System.Collections.Generic.List<Sandbox.StreamUserFollow>> Followers`
  - Get followers "Who are we following"

## Methods

### Instance methods

- `System.Void Ban(System.String reason, System.Int32 duration)`
  - Ban user from your chat, the user will no longer be able to chat.
Optionally specify the duration, a duration of zero means perm ban
(Note: You have to be in your chat for this to work)
- `System.Void Unban()`
  - Unban user from your chat, this allows them to chat again
(Note: You have to be in your chat for this to work)
- `System.Threading.Tasks.Task<Sandbox.StreamClip> CreateClip(System.Boolean hasDelay)`
  - Create a clip of our stream, if we're streaming
- `System.Threading.Tasks.Task<Sandbox.StreamPoll> CreatePoll(System.String title, System.Int32 duration, System.String[] choices)`
  - Start a poll on our channel with multiple choices, save the poll so you can end it later on
- `System.Threading.Tasks.Task<Sandbox.StreamPrediction> CreatePrediction(System.String title, System.Int32 duration, System.String firstOutcome, System.String secondOutcome)`
  - Create a prediction on our channel to bet with channel points
