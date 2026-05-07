# Sandbox.Citizen.CitizenAnimationHelper

- **Kind:** sealed class
- **Namespace:** `Sandbox.Citizen`
- **Assembly:** `Base Library`
- **Base:** `Sandbox.Component`

## Constructors

- `CitizenAnimationHelper()`

## Properties

- `Sandbox.SkinnedModelRenderer Target`
- `Sandbox.GameObject EyeSource`
- `System.Nullable<System.Single> Height`
- `System.Boolean LookAtEnabled`
- `Sandbox.GameObject LookAt`
- `System.Single EyesWeight`
- `System.Single HeadWeight`
- `System.Single BodyWeight`
- `Sandbox.GameObject IkLeftHand`
- `Sandbox.GameObject IkRightHand`
- `Sandbox.GameObject IkLeftFoot`
- `Sandbox.GameObject IkRightFoot`
- `Transform EyeWorldTransform`
- `Rotation AimAngle`
- `System.Single AimEyesWeight`
- `System.Single AimHeadWeight`
- `System.Single AimBodyWeight`
- `System.Single MoveRotationSpeed`
- `System.Single FootShuffle`
- `System.Single DuckLevel`
- `System.Single VoiceLevel`
- `System.Boolean IsSitting`
- `System.Boolean IsGrounded`
- `System.Boolean IsSwimming`
- `System.Boolean IsClimbing`
- `System.Boolean IsNoclipping`
- `System.Boolean IsWeaponLowered`
- `Sandbox.Citizen.CitizenAnimationHelper.HoldTypes HoldType`
- `Sandbox.Citizen.CitizenAnimationHelper.Hand Handedness`
- `Sandbox.Citizen.CitizenAnimationHelper.MoveStyles MoveStyle`
- `Sandbox.Citizen.CitizenAnimationHelper.SpecialMoveStyle SpecialMove`
- `Sandbox.Citizen.CitizenAnimationHelper.SittingStyle Sitting`
- `System.Single SittingOffsetHeight`
- `System.Single SittingPose`

## Methods

### Instance methods

- `System.Void ProceduralHitReaction(Sandbox.DamageInfo info, System.Single damageScale, Vector3 force)`
- `System.Void WithLook(Vector3 lookDirection, System.Single eyesWeight, System.Single headWeight, System.Single bodyWeight)`
- `System.Void WithVelocity(Vector3 Velocity)`
- `System.Void WithWishVelocity(Vector3 Velocity)`
- `System.Void TriggerJump()`
- `System.Void TriggerDeploy()`
