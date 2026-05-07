# Sandbox.Mapping.Door

- **Kind:** sealed class
- **Namespace:** `Sandbox.Mapping`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `Door()`

## Properties

- `Sandbox.Mapping.Door.DoorMode Mode`
  - Whether this door rotates or slides.
- `Sandbox.Curve AnimationCurve`
  - Animation curve to use, X is the time between 0-1 and Y is how much the door is open to its target angle from 0-1.
- `Sandbox.SoundEvent OpenSound`
  - Sound to play when a door is opened.
- `Sandbox.SoundEvent LockedSound`
  - Sound to play when a door is interacted with while locked.
- `Sandbox.SoundEvent OpenFinishedSound`
  - Sound to play when a door is fully opened.
- `Sandbox.SoundEvent CloseSound`
  - Sound to play when a door is closed.
- `Sandbox.SoundEvent CloseFinishedSound`
  - Sound to play when a door has finished closing.
- `Sandbox.Mapping.Door LinkedDoor`
  - Optional linked door that opens when this door opens.
Useful for double doors.
- `Sandbox.GameObject Pivot`
  - Optional pivot point, origin will be used if not specified.
- `System.Single TargetAngle`
  - How far should the door rotate.
- `Vector3 SlideOffset`
  - Local-space offset the door slides to when fully open.
- `System.Single Speed`
  - Speed. Degrees per second for rotating, units per second for sliding.
- `System.Boolean OpenAwayFromPlayer`
  - Open away from the person who uses this door.
- `System.Boolean IsUsable`
  - Can this door be opened by pressing it.
- `System.Boolean StartOpen`
  - Start in the open position.
- `System.Boolean AutoClose`
  - Automatically close after opening.
- `System.Single AutoCloseDelay`
  - Delay before automatically closing (in seconds). -1 means stay open.
- `System.Boolean IsLocked`
  - Is this door locked?
- `Sandbox.Doo OnOpen`
  - Called when the door is opened. Receives the GameObject that opened it.
- `Sandbox.Doo OnClose`
  - Called when the door is closed.
- `Sandbox.Mapping.Door.DoorState State`
- `System.String OpenTooltipTitle`
- `System.String OpenTooltipIcon`
- `System.String OpenTooltipDescription`
- `System.String CloseTooltipTitle`
- `System.String CloseTooltipIcon`
- `System.String CloseTooltipDescription`
- `System.String LockedTooltipTitle`
- `System.String LockedTooltipIcon`
- `System.String LockedTooltipDescription`

## Methods

### Instance methods

- `System.Void Open(Sandbox.GameObject presser)`
  - Opens the door. Does nothing if already open or opening.
- `System.Void Close()`
  - Closes the door. Does nothing if already closed or closing.
- `System.Void Toggle(Sandbox.GameObject presser)`
  - Toggles the door between open and closed states.
