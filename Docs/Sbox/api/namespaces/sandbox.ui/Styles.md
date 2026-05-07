# Sandbox.UI.Styles

Represents all supported CSS properties and their currently assigned values.

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.UI.BaseStyles`

## Constructors

- `Styles()`

## Properties

- `System.Boolean HasTransitions`
  - Whether this style sheet has any transitions that would need to be run.
- `System.Nullable<Sandbox.UI.Length> Padding`
- `System.Nullable<Sandbox.UI.Length> Margin`
- `System.Nullable<Sandbox.UI.Length> BorderWidth`
- `System.Nullable<Color> BorderColor`
- `System.Boolean HasBorder`

## Fields

- `Sandbox.UI.TransitionList Transitions`
  - List of transitions this style sheet has.
- `Sandbox.UI.ShadowList BoxShadow`
- `Sandbox.UI.ShadowList TextShadow`
- `Sandbox.UI.ShadowList FilterDropShadow`
- `static Sandbox.UI.Styles Default`

## Methods

### Instance methods

- `System.Void ResetAnimation()`
  - Stops the animation. If we have animation vars we'll start again.
- `System.Void StartAnimation(System.String name, System.Single duration, System.Int32 iterations, System.Single delay, System.String timing, System.String direction, System.String fillmode)`
  - Stop any previous animations and start this one. Make it last this long.
- `System.Boolean ApplyAnimation(Sandbox.UI.Panel panel)`
- `virtual System.Void Dirty()`
- `Sandbox.UI.Margin GetInset(Vector2 size)`
- `Sandbox.UI.Margin GetOutset(Vector2 size)`
- `System.Boolean Set(System.String styles)`
- `Matrix BuildTransformMatrix(Vector2 size)`
  - Creates a matrix based on this style's "transform" and other related properties
- `virtual System.Void LerpProperty(System.String name, Sandbox.UI.BaseStyles from, Sandbox.UI.BaseStyles to, System.Single delta)`
- `virtual System.Void FromLerp(Sandbox.UI.BaseStyles from, Sandbox.UI.BaseStyles to, System.Single delta)`
- `virtual System.Void Add(Sandbox.UI.BaseStyles bs)`
- `virtual System.Void From(Sandbox.UI.BaseStyles bs)`
- `System.Void ApplyScale(System.Single scale)`
- `virtual System.Boolean Set(System.String property, System.String value)`
