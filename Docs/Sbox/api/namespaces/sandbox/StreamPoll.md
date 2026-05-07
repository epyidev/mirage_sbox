# Sandbox.StreamPoll

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.String Id`
- `System.String BroadcasterId`
- `System.String BroadcasterName`
- `System.String BroadcasterLogin`
- `System.String Title`
- `Sandbox.StreamPoll.Choice[] Choices`
- `System.Boolean BitsVotingEnabled`
- `System.Int32 BitsPerVote`
- `System.Boolean ChannelPointsVotingEnabled`
- `System.Int32 ChannelPointsPerVote`
- `System.String Status`
- `System.Int32 Duration`
- `System.DateTimeOffset StartedAt`
- `System.DateTimeOffset EndedAt`

## Methods

### Instance methods

- `System.Threading.Tasks.Task<Sandbox.StreamPoll> End(System.Boolean archive)`
  - End this poll, you can optionally archive the poll, otherwise just terminate it
