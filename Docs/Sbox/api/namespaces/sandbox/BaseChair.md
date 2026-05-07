# Sandbox.BaseChair

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `BaseChair()`

## Properties

- `Sandbox.GameObject SeatPosition`
  - A GameObject representing the seat position
- `Sandbox.BaseChair.AnimatorSitPose SitPose`
  - The sitting pose to use when a player is seated
- `System.Single SitHeight`
  - Height offset for sitting position, from -1 (lowest) to 1 (highest)
- `Sandbox.GameObject EyePosition`
  - A GameObject representing the eye position
- `Vector2 PitchRange`
  - Pitch range for seated players
- `Vector2 YawRange`
  - Yaw range for seated players
- `Sandbox.GameObject[] ExitPoints`
- `System.Boolean IsOccupied`
  - Returns true if the chair is currently occupied
- `System.String TooltipTitle`
  - The title of this chair's tooltip. Empty to disable.
- `System.String TooltipIcon`
  - The icon for this chair's tooltip. Either Material Icons or an Emoji.
- `System.String TooltipDescription`
  - A longer description for this chair's tooltip.

## Methods

### Instance methods

- `virtual System.Boolean CanPress(Sandbox.Component.IPressable.Event e)`
  - Chair is usable if the player can enter
- `virtual System.Boolean Press(Sandbox.Component.IPressable.Event e)`
  - Called when the player has pressed to use the chair. 
Only called if CanPress returned true.
- `System.Void Sit(Sandbox.PlayerController player)`
  - Called on the client to place the player in the chair.
- `virtual System.Void AskToLeave(Sandbox.PlayerController player)`
  - Called on the host to request leaving the chair.
- `virtual System.Boolean CanLeave(Sandbox.PlayerController player)`
  - Return true if this player can leave the chair
- `System.Void Eject(Sandbox.PlayerController player)`
  - Called on the client to eject the player from the chair.
- `Vector3 FindBestExitPoint()`
  - Returns a position to place the player when they exit the chair. This searches
through ExitPoints to find the best one, which is usually the one the player is most
facing towards.
- `virtual System.Boolean CanEnter(Sandbox.PlayerController player)`
  - Return true if this player can enter the chair
- `virtual Transform GetEyeTransform()`
  - Get the transform representing the eye position when seated
- `Sandbox.PlayerController GetOccupant()`
  - Gets the player that is currently occupying the chair
- `virtual System.Void UpdatePlayerAnimator(Sandbox.PlayerController controller, Sandbox.SkinnedModelRenderer renderer)`
  - Called to update the player's animator when seated
- `System.Void ClampEyes(Sandbox.PlayerController controller)`
  - Clamps the eye angles of a seated player between the PitchRange and YawRange
- `virtual Transform CalculateEyeTransform(Sandbox.PlayerController controller)`
  - Calculates the eye transform for a seated player
- `virtual System.Void DrawGizmos()`
  - Draws the player model sitting in the chair if it's selected
- `virtual System.Nullable<Sandbox.Component.IPressable.Tooltip> GetTooltip(Sandbox.Component.IPressable.Event e)`
