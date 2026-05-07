# Sandbox.Package.Screenshot

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Package`

## Constructors

- `Screenshot()`

## Properties

- `System.DateTime Created`
- `System.Int32 Width`
- `System.Int32 Height`
- `System.String Url`
- `System.String Thumb`
- `System.Boolean IsVideo`
  - True if this is a loading screen rather than a regular screenshot

## Methods

### Instance methods

- `System.String GetThumbUrl(System.Int32 width, System.Int32 height)`
  - Return the URL of a thumbnail matching this exact size. For caching reasons it's going to be best if
we can keep this to round number sizes (256, 512 etc) rather than trying to exact fit.
