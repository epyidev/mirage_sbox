# Sandbox.Input

Allows querying of player button presses and other inputs.

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static System.Int32 ControllerCount`
  - How many controllers are active right now?
- `static System.Boolean EnableVirtualCursor`
  - Whether or not the Virtual Cursor should show when using a controller. Disable this to control the cursor manually.
- `static System.Boolean UsingController`
  - Was the last button pressed a game controller button?
- `static System.Boolean EscapePressed`
  - True if escape was pressed
- `static System.Collections.Generic.IEnumerable<System.String> ActionNames`
  - Names of all actions from the current game's input settings.
- `static System.Boolean Suppressed`
  - If the input is suppressed then everything will act like there is no input
- `static Sandbox.VR.VRInput VR`
  - Virtual Reality specific input data.
- `static Vector2 MouseDelta`
  - Movement delta from the mouse.
- `static Vector2 MouseWheel`
  - The state of the mouse wheel.
- `static System.Boolean MouseCursorVisible`
  - True if the mouse cursor is visible (using UI etc)
- `static Angles AnalogLook`
  - Analog look value from the default input device. This is scaled by Preferences.Sensitivity - so you don't need to scale it afterwards.
- `static Vector3 AnalogMove`
  - Analog move value from the default input device.
- `static Sandbox.InputMotionData MotionData`
  - Current state of the current input device's motion sensor(s) if supported.
This is only supported on: Dualshock 4+, Switch Controllers, Steam Controller, Steam Deck.

## Methods

### Static methods

- `static System.Single GetAnalog(Sandbox.InputAnalog analog)`
  - An analog input, when fetched, is between -1 and 1 (0 being default)
- `static System.IDisposable PlayerScope(System.Int32 index)`
  - Push a specific player scope to be active
- `static System.Boolean Down(System.String action, System.Boolean complainOnMissing)`
  - Action is currently pressed down
- `static System.Boolean Pressed(System.String action)`
  - Action wasn't pressed but now it is
- `static System.Boolean Released(System.String action)`
  - Action was pressed but now it isn't
- `static System.Void SetAction(System.String action, System.Boolean down)`
- `static System.Void Clear(System.String action)`
  - Remove this action, so it's no longer being pressed.
- `static System.Void ClearActions()`
  - Clears the current input actions, so that none of them are active.
- `static System.Void ReleaseActions()`
  - Clears the current input actions, so that none of them are active. Unlike ClearActions
this will unpress the buttons, so they won't be active again until they're pressed again.
- `static System.Void ReleaseAction(System.String name)`
  - Releases the action, and it won't be active again until it's pressed again.
- `static System.Collections.Generic.IEnumerable<Sandbox.InputAction> GetActions()`
  - Copies all input actions to be used publicly
- `static System.String GetGroupName(System.String action)`
  - Finds the `Sandbox.InputAction.GroupName` of the given action.
  - `action`: Action name to find the group name of.
- `static System.String GetButtonOrigin(System.String name, System.Boolean ignoreController)`
  - Returns the name of a key bound to this InputAction
<example>For example:


```
Input.GetButtonOrigin( "Undo" )
```


could return `SPACE` if using keyboard or `A Button` when using a controller.
</example>
- `static Sandbox.Texture GetGlyph(System.String name, Sandbox.InputGlyphSize size, System.Boolean outline)`
  - Get a glyph texture from the controller bound to the action.
If no binding is found will return an 'UNBOUND' glyph.
- `static Sandbox.Texture GetGlyph(System.String name, Sandbox.InputGlyphSize size, Sandbox.GlyphStyle style)`
- `static Sandbox.Texture GetGlyph(Sandbox.InputAnalog analog, Sandbox.InputGlyphSize size, System.Boolean outline)`
  - Get a glyph texture from an analog input on a controller.
- `static System.String GetButtonOrigin(Sandbox.InputAnalog analog)`
  - Returns the name of the analog axis bound to this `Sandbox.InputAnalog`.
<example>For example:


```
Input.GetButtonOrigin( InputAnalog.Move )
```


could return `Left Joystick`</example>
- `static System.Void TriggerHaptics(System.Single leftMotor, System.Single rightMotor, System.Single leftTrigger, System.Single rightTrigger, System.Int32 duration)`
  - Trigger a haptic event on supported controllers including Xbox trigger impulse rumble.
  - `leftMotor`: The speed of the left motor, between 0.0 and 1.0.
  - `rightMotor`: The speed of the right motor, between 0.0 and 1.0.
  - `leftTrigger`: (Xbox One controller only) The speed of the left trigger motor, between 0.0 and 1.0.
  - `rightTrigger`: (Xbox One controller only) The speed of the right trigger motor, between 0.0 and 1.0.
  - `duration`: How long (in milliseconds) should we apply this for?
- `static System.Void TriggerHaptics(Sandbox.HapticEffect pattern, System.Single lengthScale, System.Single frequencyScale, System.Single amplitudeScale)`
  - Trigger haptics based on a predefined `Sandbox.HapticEffect`.
All `Sandbox.HapticEffect`s are normalized (start at 0, peak at 1).
  - `pattern`: The pattern to use
  - `lengthScale`: The amount to scale the pattern's length by.
  - `frequencyScale`: The amount to scale the pattern's frequency by.
  - `amplitudeScale`: The amount to scale the pattern's amplitude by.
- `static System.Void TriggerHaptics(Sandbox.HapticEffect pattern, System.Single frequencyScale, System.Single amplitudeScale)`
  - Trigger haptics based on a predefined `Sandbox.HapticEffect`.
All `Sandbox.HapticEffect`s are normalized (start at 0, peak at 1).
  - `pattern`: The pattern to use
  - `frequencyScale`: The amount to scale the pattern's frequency by.
  - `amplitudeScale`: The amount to scale the pattern's amplitude by.
- `static System.Void StopAllHaptics()`
  - Stop all vibration events on the current controller.
