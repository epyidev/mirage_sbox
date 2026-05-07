# Editor.ConsoleSystem

- **Kind:** static class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Methods

### Static methods

- `static System.Void SetValue(System.String name, System.Object value)`
  - Try to set a console variable. You will only be able to set variables that you have permission to set.
- `static System.String GetValue(System.String name, System.String defaultValue)`
  - Get a convar value as a string
- `static System.Int32 GetValueInt(System.String name, System.Int32 defaultValue)`
  - Get a convar value as an integer if possible.
- `static System.Single GetValueFloat(System.String name, System.Single defaultValue)`
  - Get a convar value as an float if possible.
- `static System.Void Run(System.String command)`
  - Run this command. This should be a single command.
