# Sandbox.PlayerController

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `PlayerController()`

## Properties

- `System.Boolean UseAnimatorControls`
- `Sandbox.SkinnedModelRenderer Renderer`
  - The body will usually be a child object with SkinnedModelRenderer
- `System.Boolean ShowCreateBodyRenderer`
  - If true we'll show the "create body" button
- `System.Single RotationAngleLimit`
- `System.Single RotationSpeed`
- `System.Boolean EnableFootstepSounds`
- `System.Single FootstepVolume`
- `Sandbox.Audio.MixerHandle FootstepMixer`
- `System.Single AimStrengthEyes`
  - How strongly to look in the eye direction with our eyes
- `System.Single AimStrengthHead`
  - How strongly to turn in the eye direction with our head
- `System.Single AimStrengthBody`
  - How strongly to turn in the eye direction with our body
- `System.Boolean UseCameraControls`
- `System.Single EyeDistanceFromTop`
- `System.Boolean ThirdPerson`
- `System.Boolean HideBodyInFirstPerson`
- `System.Boolean UseFovFromPreferences`
- `Vector3 CameraOffset`
- `System.String ToggleCameraModeButton`
- `Sandbox.Rigidbody Body`
- `Sandbox.CapsuleCollider BodyCollider`
- `Sandbox.BoxCollider FeetCollider`
- `Sandbox.GameObject ColliderObject`
- `System.Single BodyRadius`
- `System.Single BodyHeight`
- `System.Single BodyMass`
- `Sandbox.TagSet BodyCollisionTags`
- `System.Single BrakePower`
  - We will apply extra friction when we're on the ground and our desired velocity is
lower than our current velocity, so we will slow down.
- `System.Single AirFriction`
  - How much friction to add when we're in the air. This will slow you down unless you have a wish
velocity.
- `System.Boolean ShowRigidbodyComponent`
- `System.Boolean ShowColliderComponents`
- `Vector3 WishVelocity`
- `System.Boolean IsOnGround`
- `System.Boolean IsAirborne`
  - Not touching the ground, and not swimming or climbing
- `Vector3 Velocity`
  - Our actual physical velocity minus our ground velocity
- `Vector3 GroundVelocity`
  - The velocity that the ground underneath us is moving
- `System.Boolean IsClimbing`
  - Set to true when entering a climbing `Sandbox.Movement.MoveMode`.
- `System.Boolean IsSwimming`
  - Set to true when entering a swimming `Sandbox.Movement.MoveMode`.
- `Angles EyeAngles`
  - The direction we're looking in input space.
- `Vector3 EyePosition`
  - The player's eye position, in first person mode
- `Transform EyeTransform`
  - The player's eye transform, in first person mode
- `System.Boolean IsDucking`
  - True if this player is ducking
- `System.Single Headroom`
  - The distance from the top of the head to the closest ceiling.
- `Sandbox.GameObject GroundObject`
  - The object we're standing on. Null if we're standing on nothing.
- `Sandbox.Component GroundComponent`
  - The collider component we're standing on. Null if we're standing nothing
- `Sandbox.Surface GroundSurface`
  - If we're stnding on a surface this is it
- `System.Single GroundFriction`
  - The friction property of the ground we're standing on.
- `System.Boolean GroundIsDynamic`
  - Are we standing on a surface that is physically dynamic
- `Sandbox.TimeSince TimeSinceGrounded`
  - Amount of time since this character was last on the ground
- `Sandbox.TimeSince TimeSinceUngrounded`
  - Amount of time since this character was last not on the ground
- `System.Boolean UseInputControls`
- `System.Single WalkSpeed`
- `System.Single RunSpeed`
- `System.Single DuckedSpeed`
- `System.Single JumpSpeed`
- `System.Single DuckedHeight`
- `System.Single AccelerationTime`
  - Amount of seconds it takes to get from your current speed to your requuested speed, if higher
- `System.Single DeaccelerationTime`
  - Amount of seconds it takes to get from your current speed to your requuested speed, if lower
- `System.String AltMoveButton`
  - The button that the player will press to use to run
- `System.Boolean RunByDefault`
  - If true then the player will run by default, and holding AltMoveButton will switch to walk
- `System.Boolean EnablePressing`
  - Allows to player to interact with things by "use"ing them. 
Usually by pressing the "use" button.
- `System.String UseButton`
  - The button that the player will press to use things
- `System.Single ReachLength`
  - How far from the eye can the player reach to use things
- `System.Boolean UseLookControls`
  - When true we'll move the camera around using the mouse
- `System.Boolean RotateWithGround`
- `System.Single PitchClamp`
- `System.Single LookSensitivity`
  - Allows modifying the eye angle sensitivity. Note that player preference sensitivity is already automatically applied, this is just extra.
- `System.Single CurrentHeight`
  - Gets the current character height from `Sandbox.PlayerController.BodyHeight` when standing,
otherwise uses `Sandbox.PlayerController.DuckedHeight` when ducking.
- `Sandbox.Movement.MoveMode Mode`
- `Sandbox.Component Hovered`
  - The object we're currently looking at
- `Sandbox.Component Pressed`
  - The object we're currently using by holding down USE
- `System.Collections.Generic.List<Sandbox.Component.IPressable.Tooltip> Tooltips`
  - The tooltip of the currently hovered Pressable object
- `System.Boolean StepDebug`
  - Enable debug overlays for this character

## Fields

- `System.Boolean DebugFootsteps`
  - Draw debug overlay on footsteps

## Methods

### Instance methods

- `System.Void CreateBodyRenderer()`
- `System.Void UpdateAnimation(Sandbox.SkinnedModelRenderer renderer)`
  - Update the animation for this renderer. This will update the body rotation etc too.
- `System.Void Jump(Vector3 velocity)`
  - Adds velocity in a special way. First we subtract any opposite velocity (ie, falling) then 
we add the velocity, but we clamp it to that direction. This means that if you jump when you're running
up a platform, you don't get extra jump power.
- `System.Void PlayFootstepSound(Vector3 worldPosition, System.Single volume, System.Int32 foot)`
  - Play a footstep sound at the given world position. Will only play if the player has a GroundSurface.
- `System.Void PreventGrounding(System.Single seconds)`
  - Prevent being grounded for a number of seconds
- `System.Void OnJumped()`
- `System.Void UpdateDucking(System.Boolean wantsDuck)`
  - Called during FixedUpdate when UseInputControls is enabled. Will duck if requested.
If not, and we're ducked, will unduck if there is room
- `System.Void UpdateLookAt()`
  - Called in Update when Using is enabled
- `System.Void StopPressing()`
  - Stop pressing. Pressed will become null.
- `System.Void StartPressing(Sandbox.Component obj)`
  - Start pressing a target component. This is called automatically when Use is pressed.
- `BBox BodyBox(System.Single scale, System.Single heightScale)`
  - Return an aabb representing the body
- `Sandbox.SceneTraceResult TraceBody(Vector3 from, Vector3 to, System.Single scale, System.Single heightScale)`
  - Trace the aabb body from one position to another and return the result
- `Sandbox.GameObject CreateRagdoll(System.String name)`
  - Create a ragdoll gameobject version of our render body.
