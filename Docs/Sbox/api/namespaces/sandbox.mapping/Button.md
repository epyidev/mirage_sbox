# Sandbox.Mapping.Button

- **Kind:** sealed class
- **Namespace:** `Sandbox.Mapping`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `Button()`

## Properties

- `Sandbox.SoundEvent OnSound`
  - Sound to play when the button is pressed.
- `Sandbox.SoundEvent OffSound`
  - Sound to play when the button is released.
- `Sandbox.Doo OnPressed`
  - Called when the button is pressed. Receives the GameObject that pressed it.
- `Sandbox.Doo OnReleased`
  - Called when the button is released. Receives the GameObject that released it.
- `Sandbox.Doo OnTurnedOn`
  - Called when the button turns on. Receives the GameObject that activated it.
- `Sandbox.Doo OnTurnedOff`
  - Called when the button turns off.
- `Sandbox.Mapping.Button.ButtonMode Mode`
- `System.Boolean AutoReset`
- `System.Single ResetTime`
- `System.Boolean Move`
- `Sandbox.GameObject MoveTarget`
- `Vector3 MoveDelta`
- `Sandbox.Curve AnimationCurve`
  - Animation curve to use, X is the time between 0-1 and Y is how much the button is pressed from 0-1.
- `System.Single AnimationTime`
  - How long in seconds should it take to animate this button.
- `System.Boolean IsOn`
  - True if the button is currently on
- `System.Boolean IsAnimating`
  - True if the button is currently animating
- `System.String TooltipTitle`
- `System.String TooltipIcon`
- `System.String TooltipDescription`
- `System.String TooltipTitleOff`
- `System.String TooltipIconOff`
- `System.String TooltipDescriptionOff`

## Methods

### Instance methods

- `System.Void TurnOn(Sandbox.GameObject presser)`
  - Turns the button on. Does nothing if already on or animating.
- `System.Void TurnOff()`
  - Turns the button off. Does nothing if already off or animating.
- `System.Void Toggle(Sandbox.GameObject presser)`
  - Toggles the button between on and off states.
