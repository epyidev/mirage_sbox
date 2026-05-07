# Sandbox.NavMeshAgent.LinkTraversalData

Holds information about the current link the agent is traversing.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.NavMeshAgent`

## Properties

- `Vector3 LinkEnterPosition`
  - The start position of the traversal.
Depending on the direction traversing,
this is either LinkComponent.WorldStartPositionOnNavMesh or LinkComponent.WorldEndPositionOnNavMesh.
- `Vector3 LinkExitPosition`
  - The end position of the traversal. Where the agent should exit.
Depending on the direction traversing,
this is either LinkComponent.WorldStartPositionOnNavMesh or LinkComponent.WorldEndPositionOnNavMesh.
- `Vector3 AgentInitialPosition`
  - The position at which the agent entered the link.
- `Sandbox.NavMeshLink LinkComponent`
  - The Link component that the agent is traversing.
May be null if the agent is traversing a link created without a NavMeshLink component.
