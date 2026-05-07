# Sandbox.UI.Margin

Represents a <see cref="T:Sandbox.Rect">Rect</see> where each side is the thickness of an edge/padding/margin/border, rather than positions.

- **Kind:** struct
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.System`

## Constructors

- `Margin(Sandbox.Rect r)`
- `Margin(System.Single uniform)`
- `Margin(System.Single horizontal, System.Single vertical)`
- `Margin(System.Single left, System.Single top, System.Single right, System.Single bottom)`
- `Margin(System.Nullable<System.Single> left, System.Nullable<System.Single> top, System.Nullable<System.Single> right, System.Nullable<System.Single> bottom)`

## Properties

- `System.Single Width`
  - Width of the inner square contained within the margin.
- `System.Single Height`
  - Height of the inner square contained within the margin.
- `System.Single Left`
  - Thickness of the left side margin.
- `System.Single Top`
  - Thickness of the top margin.
- `System.Single Right`
  - Thickness of the right side margin.
- `System.Single Bottom`
  - Thickness of the bottom margin.
- `Vector2 Position`
  - Position of the inner top left corder of the margin/border.
- `Vector2 Size`
  - Size of the inner square contained within the margin.
- `Vector2 EdgeSize`
  - When the Rect describes edges, this returns the total size of the edges in each direction

## Methods

### Instance methods

- `Sandbox.UI.Margin EdgeAdd(Sandbox.UI.Margin edges)`
  - Where padding is an edge type rect, will return this rect expanded with those edges.
- `Sandbox.UI.Margin EdgeSubtract(Sandbox.UI.Margin edges)`
  - Where padding is an edge type rect, will return this rect expanded with those edges.
- `System.Boolean IsNearlyZero(System.Double tolerance)`
  - Returns true if margin is practically zero
