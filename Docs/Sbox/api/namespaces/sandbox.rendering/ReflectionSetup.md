# Sandbox.Rendering.ReflectionSetup

Allows special setup for reflections, such as offsetting the reflection plane

- **Kind:** struct
- **Namespace:** `Sandbox.Rendering`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Nullable<Color> FallbackColor`
  - If we can't render the reflection and this is set, we'll clear the render target to this color

## Fields

- `Sandbox.Rendering.ViewSetup ViewSetup`
  - Allows overriding everything you normally can
- `System.Single ClipOffset`
  - Offset the reflection plane's clip plane by this much
- `System.Boolean RenderBehind`
  - If true we'll render the reflection even if we're behind the plane
