# Sandbox.CharacterControllerHelper

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `CharacterControllerHelper(Sandbox.SceneTrace trace, Vector3 position, Vector3 velocity)`

## Fields

- `Vector3 Position`
- `Vector3 Velocity`
- `System.Single Bounce`
- `System.Single MaxStandableAngle`
- `Sandbox.SceneTrace Trace`

## Methods

### Instance methods

- `Sandbox.SceneTraceResult TraceFromTo(Vector3 start, Vector3 end)`
  - Trace this from one position to another
- `System.Single TryMove(System.Single timestep)`
  - Try to move to the position. Will return the fraction of the desired velocity that we traveled.
Position and Velocity will be what we recommend using.
- `Sandbox.SceneTraceResult TraceMove(Vector3 delta)`
  - Move our position by this delta using trace. If we hit something we'll stop,
we won't slide across it nicely like TryMove does.
- `System.Single TryMoveWithStep(System.Single timeDelta, System.Single stepsize)`
  - Like TryMove but will also try to step up if it hits a wall
