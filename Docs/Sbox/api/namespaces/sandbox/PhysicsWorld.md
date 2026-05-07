# Sandbox.PhysicsWorld

A world in which physics objects exist. You can create your own world but you really don't need to. A world for the map is created clientside and serverside automatically.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `PhysicsWorld()`
  - Create a new physics world. You should only do this if you want to simulate an extra world for some reason.

## Properties

- `System.Collections.Generic.IEnumerable<Sandbox.PhysicsBody> Bodies`
  - All bodies in the world
- `Sandbox.Physics.CollisionRules CollisionRules`
  - Set or retrieve the collision rules for this `Sandbox.PhysicsWorld`.
- `Vector3 Gravity`
  - Access the world's current gravity.
- `System.Single AirDensity`
  - Air density of this physics world, for things like air drag.
- `Sandbox.PhysicsBody Body`
  - The body of this physics world.
- `Sandbox.PhysicsGroup Group`
  - The physics group of this physics world. A physics world will contain only 1 body.
- `System.Boolean SleepingEnabled`
  - If true then bodies will be able to sleep after a period of inactivity
- `Sandbox.PhysicsSimulationMode SimulationMode`
  - Physics simulation mode. See `Sandbox.PhysicsSimulationMode` for explanation of each mode.
- `System.Int32 PositionIterations`
- `System.Int32 VelocityIterations`
- `System.Int32 SubSteps`
  - If you're seeing objects go through other objects or you have a low tickrate, you might want to increase the number of physics substeps.
This breaks physics steps down into this many substeps. The default is 1 and works pretty good.
Be aware that the number of physics ticks per second is going to be tickrate * substeps.
So if you're ticking at 90 and you have SubSteps set to 1000 then you're going to do 90,000 steps per second. So be careful here.
- `System.Single TimeScale`
- `Sandbox.PhysicsTraceBuilder Trace`
  - Raytrace against this world
- `Sandbox.SceneWorld DebugSceneWorld`
  - A SceneWorld where debug SceneObjects exist.

## Methods

### Instance methods

- `Sandbox.PhysicsGroup SetupPhysicsFromModel(Sandbox.Model model, Sandbox.PhysicsMotionType motionType)`
  - Temp function for creating model physics until entity system handles it
- `Sandbox.PhysicsGroup SetupPhysicsFromModel(Sandbox.Model model, Transform transform, Sandbox.PhysicsMotionType motionType)`
  - Temp function for creating model physics until entity system handles it
- `System.Void Delete()`
  - Delete this world and all objects inside. Will throw an exception if you try to delete a world that you didn't manually create.
- `System.Void Step(System.Single delta)`
  - Step simulation of this physics world. You can only do this on physics worlds that you manually create.
- `System.Void Step(System.Single delta, System.Int32 subSteps)`
  - Step simulation of this physics world. You can only do this on physics worlds that you manually create.
- `System.Void Step(System.Double worldTime, System.Single delta, System.Int32 subSteps)`
  - Step simulation of this physics world. You can only do this on physics worlds that you manually create.
- `System.Void SetCollisionRules(Sandbox.Physics.CollisionRules rules)`
  - Used internally to set collision rules from gamemode's project settings.
You shouldn't need to call this yourself.
- `Sandbox.Physics.CollisionRules.Result GetCollisionRule(System.String left, System.String right)`
  - Gets the specific collision rule for a pair of tags.
- `Sandbox.PhysicsTraceResult RunTrace(Sandbox.PhysicsTraceBuilder trace)`
  - Like calling PhysicsTraceBuilder.Run, except will re-target this world if it's not already the target
- `Sandbox.PhysicsTraceResult[] RunTraceAll(Sandbox.PhysicsTraceBuilder trace)`
  - Like calling PhysicsTraceBuilder.RunAll, except will re-target this world if it's not already the target
- `System.Void DebugDraw()`
  - Updates all the SceneObjects in the `Sandbox.PhysicsWorld.DebugSceneWorld`, call once per tick or frame.
