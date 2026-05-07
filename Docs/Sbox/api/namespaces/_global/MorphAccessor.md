# Sandbox.SkinnedModelRenderer.MorphAccessor

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.SkinnedModelRenderer`

## Properties

- `System.String[] Names`

## Methods

### Instance methods

- `System.Void Set(System.String name, System.Single weight)`
  - Sets a morph override value.
Uses a default blend time to smoothly transition from
the animation-driven morph to this override.
- `System.Void Set(System.String name, System.Single weight, System.Single fadeTime)`
  - Sets a morph override value with blending.
fadeTime controls how long it takes to blend between
the animation-driven morph and this override.
- `System.Boolean ContainsOverride(System.String name)`
  - Returns true if we have this value overridden (set). False means its value is likely
being driven by animation etc.
- `System.Single Get(System.String name)`
  - Get this value
- `System.Void Clear(System.String name)`
  - Clears the morph override and returns control to the animation.
Uses the default blend time to smoothly transition back.
- `System.Void Clear(System.String name, System.Single fadeTime)`
  - Clears the morph override and returns control to the animation.
fadeTime controls how long it takes to blend back to the animation-driven morph.
