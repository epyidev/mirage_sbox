# Sandbox.ConsoleSystem

A library to interact with the Console System.

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static System.Void SetValue(System.String name, System.Object value)`
  - Try to set a console variable. You will only be able to set variables that you have permission to set.
- `static System.String GetValue(System.String name, System.String defaultValue)`
  - Get a console variable's value as a string.
- `static System.Void OnChangePropertySet(Sandbox.WrappedPropertySet<T> p)`
- `static System.Void OnWrappedSet(Sandbox.WrappedPropertySet<T> p)`
- `static T OnWrappedGet(Sandbox.WrappedPropertyGet<T> p)`
- `static System.Void Run(System.String command)`
  - Run this command. This should be a single command.
- `static System.Void Run(System.String command, System.Object[] arguments)`
  - Run this command, along with the arguments. We'll automatically convert them to strings and handle quoting.
