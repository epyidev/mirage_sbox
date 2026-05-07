# Sandbox.StreamPrediction

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.String Id`
- `System.String BroadcasterId`
- `System.String BroadcasterLogin`
- `System.String BroadcasterName`
- `System.String Title`
- `System.String WinningOutcomeId`
- `System.Int32 PredictionWindow`
- `System.String Status`
- `System.DateTimeOffset CreatedAt`
- `System.DateTimeOffset EndedAt`
- `System.DateTimeOffset LockedAt`
- `Sandbox.StreamPrediction.Outcome[] Outcomes`

## Methods

### Instance methods

- `System.Threading.Tasks.Task<Sandbox.StreamPrediction> Lock()`
  - Lock this prediction
- `System.Threading.Tasks.Task<Sandbox.StreamPrediction> Cancel()`
  - Cancel this prediction
- `System.Threading.Tasks.Task<Sandbox.StreamPrediction> Resolve()`
  - Resolve this prediction and choose winning outcome to pay out channel points
