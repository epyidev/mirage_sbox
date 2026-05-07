# Sandbox.Gradient

Describes a gradient between multiple colors

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Constructors

- `Gradient(Sandbox.Gradient.ColorFrame[] frames)`
- `Gradient()`

## Properties

- `Sandbox.Gradient.BlendMode Blending`
  - The blend mode
- `System.Collections.Immutable.ImmutableList<Sandbox.Gradient.ColorFrame> Colors`
  - A list of color stops, which should be ordered by time
- `System.Collections.Immutable.ImmutableList<Sandbox.Gradient.AlphaFrame> Alphas`
  - A list of color stops, which should be ordered by time
- `Sandbox.Gradient.ColorFrame Item`

## Methods

### Static methods

- `static Sandbox.Gradient FromColors(Color[] colors)`
  - Create a gradient from colors spaced out evenly

### Instance methods

- `Sandbox.Gradient WithFrames(System.Collections.Immutable.ImmutableList<Sandbox.Gradient.ColorFrame> frames)`
- `System.Int32 AddColor(System.Single x, Color color)`
  - Add a color position
- `System.Int32 AddAlpha(System.Single x, System.Single alpha)`
  - Add an alpha position
- `System.Void FixOrder()`
  - If the lists aren't in time order for some reason, this will fix them. This should really 
just be called when serializing, and in every other situation we should assume they're
okay.
- `System.Int32 AddColor(Sandbox.Gradient.ColorFrame keyframe)`
  - Add given keyframe to this curve.
  - `keyframe`: The keyframe to add.
  - returns: The position of newly added keyframe in the `Sandbox.Gradient.Colors` list.
- `System.Int32 AddAlpha(Sandbox.Gradient.AlphaFrame keyframe)`
- `Color Evaluate(System.Single time)`
  - Evaluate the blend using the time, which is generally between 0 and 1
