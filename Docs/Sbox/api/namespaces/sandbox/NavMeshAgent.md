# Sandbox.NavMeshAgent

An agent that can navigate the navmesh defined in the scene.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `NavMeshAgent()`

## Properties

- `System.Single Height`
- `System.Single Radius`
- `System.Single MaxSpeed`
- `System.Single Acceleration`
  - The maximum acceleration a agent can have. This is how fast the agent can change its velocity.
If you want snappy movement this should be as high or higher than `Sandbox.NavMeshAgent.MaxSpeed`.
- `System.Boolean UpdatePosition`
  - Set the Position of the GameObject to the agent position every frame. You can turn this off and handle it yourself by using the AgentPosition property.
- `System.Boolean UpdateRotation`
  - This will simply face the direction it is moving. It is not configurable on purpose, so you should really turn this off and be doing this yourself if you need it to do anything specific.
- `System.Collections.Generic.HashSet<Sandbox.Engine.Resources.NavMeshAreaDefinition> AllowedAreas`
  - What areas the agent is allowed to travel on. If empty, all areas are allowed.
- `System.Collections.Generic.HashSet<Sandbox.Engine.Resources.NavMeshAreaDefinition> ForbiddenAreas`
  - What areas the agent is not allowed to travel on. If empty, no areas are forbidden.
- `System.Boolean AllowDefaultArea`
  - Is the agent allowed to travel on the default area?
- `System.Boolean AutoTraverseLinks`
  - Should the agent automatically traverse links when it reaches them? Or do you want to implement your own link traversal logic?
- `System.Single Separation`
  - Gets or sets the separation factor used to control how strongly agents avoid crowding each other.
- `Vector3 AgentPosition`
  - Updated  with the agent's position, even if UpdatePosition is false
- `System.Nullable<Vector3> TargetPosition`
  - Gets the current target position for the agent, if one is set.
- `Vector3 Velocity`
- `Vector3 WishVelocity`
  - The velocity the agent would like to move at, you can pass this into a PlayerController.
- `System.Boolean IsNavigating`
  - Returns true if the agent is currently navigating to a target.
- `System.Boolean SyncAgentPosition`
- `System.Action LinkEnter`
  - Emitted when the agent enters a link.
- `System.Action LinkExit`
  - Emitted when the agent exits a link.
- `System.Boolean IsTraversingLink`
  - Returns true if the agent is currently traversing a link.

## Fields

- `System.Nullable<Sandbox.NavMeshAgent.LinkTraversalData> CurrentLinkTraversal`
  - Information about the current link traversal.

## Methods

### Instance methods

- `System.Void SetAgentPosition(Vector3 position)`
  - If you want to move the agent from one position to another
- `System.Void MoveTo(Vector3 targetPosition)`
  - Navigate to the position
- `System.Void SetPath(Sandbox.Navigation.NavMeshPath path)`
  - Assigns a precalculated path for the agent to follow.
The agent will attempt to follow the path, but may adjust its movement to avoid obstacles or other agents.
If the path becomes invalid during navigation, it may be recalculated completely.
- `Sandbox.Navigation.NavMeshPath GetPath()`
  - Returns the agent's current path as a NavMeshPath. This is not free, so avoid calling it every frame.
  - returns: A NavMeshPath containing the agent's current path information.
- `System.Void Stop()`
  - Stop moving, or whatever we're doing
- `System.Void CompleteLinkTraversal()`
  - Finish link traversal, must be called after traversing a link if AutoTraverseLinks is false.
- `Vector3 GetLookAhead(System.Single distance)`
  - Get a point on the current path, distance away from here. This is a simplified path so 
only includes the first few corners.
