# Sandbox.Bind.Proxy

Gets and Sets a value from somewhere.

- **Kind:** abstract class
- **Namespace:** `Sandbox.Bind`
- **Assembly:** `Sandbox.Bind`

## Constructors

- `Proxy()`

## Properties

- `System.WeakReference<System.Object> Target`
  - The object to read data from and write data to.
- `System.String Name`
  - Debug name for this property
- `System.Object Value`
  - Get or set the value.
- `System.Boolean CanRead`
  - True if we can get the value.
- `System.Boolean CanWrite`
  - True if we can set the value
- `System.Boolean IsValid`
  - Should return `false` if the proxy is now invalid, like if the source object was destroyed.
