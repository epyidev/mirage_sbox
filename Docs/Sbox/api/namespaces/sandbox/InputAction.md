# Sandbox.InputAction

An input action defined by a game project.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `InputAction(System.String name, System.String keyboardCode, Sandbox.GamepadCode gamepadCode, System.String groupName, System.String title)`
- `InputAction()`
- `InputAction(Sandbox.InputAction other)`

## Properties

- `System.String Name`
  - The name of the input action. Used by Input.Down|Pressed|Released.
- `System.String GroupName`
  - A group name for this input when showing in a binding system
- `System.String Title`
  - A friendly name for this input action when showing in a binding system
- `System.String KeyboardCode`
  - The key or key combo we'll be watching for.
- `Sandbox.GamepadCode GamepadCode`
  - What gamepad button should this action map to?
