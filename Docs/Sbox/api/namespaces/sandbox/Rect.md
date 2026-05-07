# Sandbox.Rect

Represents a rectangle.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Constructors

- `Rect(System.Single x, System.Single y, System.Single width, System.Single height)`
  - Initialize a Rect at given position and with given size.
- `Rect(Vector2 point, Vector2 size)`
  - Initialize a Rect at given position and with given size.

## Properties

- `System.Single Width`
  - Width of the rect.
- `System.Single Height`
  - Height of the rect.
- `System.Single Left`
  - Position of rect's left edge relative to its parent, can also be interpreted as its position on the X axis.
- `System.Single Top`
  - Position of rect's top edge relative to its parent, can also be interpreted as its position on the Y axis.
- `System.Single Right`
  - Position of rect's right edge relative to its parent.
- `System.Single Bottom`
  - Position of rect's bottom edge relative to its parent.
- `Vector2 Position`
  - Position of this rect.
- `Vector2 Center`
  - Center of this rect.
- `Vector2 Size`
  - Size of this rect.
- `Sandbox.Rect WithoutPosition`
  - Returns this rect with position set to 0 on both axes.
- `Vector2 BottomLeft`
  - Position of the bottom left edge of this rect.
- `Vector2 BottomRight`
  - Position of the bottom right edge of this rect.
- `Vector2 TopRight`
  - Position of the top right edge of this rect.
- `Vector2 TopLeft`
  - Position of the top left edge of this rect.

## Methods

### Static methods

- `static Sandbox.Rect FromPoints(Vector2 a, Vector2 b)`
  - Create a rect between two points. The order of the points doesn't matter.

### Instance methods

- `System.Boolean IsInside(Sandbox.Rect rect, System.Boolean fullyInside)`
  - Return true if the passed rect is partially or fully inside this rect.
  - `rect`: The passed rect to test.
  - `fullyInside`: `true` to test if the given rect is completely inside this rect. `false` to test for an intersection.
- `System.Boolean IsInside(Vector2 pos)`
  - Return true if the passed point is inside this rect.
- `Sandbox.Rect Shrink(System.Single left, System.Single top, System.Single right, System.Single bottom)`
  - Returns a Rect shrunk in every direction by given values.
- `Sandbox.Rect Shrink(Sandbox.UI.Margin m)`
  - Returns a Rect shrunk in every direction by <see cref="T:Sandbox.UI.Margin">Margin</see>'s values.
- `Sandbox.Rect Shrink(System.Single x, System.Single y)`
  - Returns a Rect shrunk in every direction by given values on each axis.
- `Sandbox.Rect Shrink(System.Single amt)`
  - Returns a Rect shrunk in every direction by given amount.
- `Sandbox.Rect Grow(System.Single left, System.Single top, System.Single right, System.Single bottom)`
  - Returns a Rect grown in every direction by given amounts.
- `Sandbox.Rect Grow(Sandbox.UI.Margin m)`
  - Returns a Rect grown in every direction by <see cref="T:Sandbox.UI.Margin">Margin</see>'s values.
- `Sandbox.Rect Grow(System.Single x, System.Single y)`
  - Returns a Rect grown in every direction by given values on each axis.
- `Sandbox.Rect Grow(System.Single amt)`
  - Returns a Rect grown in every direction by given amount.
- `Sandbox.Rect Floor()`
  - Returns a Rect with position and size rounded down.
- `Sandbox.Rect Round()`
  - Returns a Rect with position and size rounded to closest integer values.
- `Sandbox.Rect Ceiling()`
  - Returns a Rect with position and size rounded up.
- `Vector4 ToVector4()`
  - Returns this rect as a Vector4, where X/Y/Z/W are Left/Top/Right/Bottom respectively.
- `System.Void Add(Sandbox.Rect r)`
  - Expand this Rect to contain the other rect
- `System.Void Add(Vector2 point)`
  - Expand this Rect to contain the point
- `Sandbox.Rect AddPoint(Vector2 pos)`
  - Returns this rect expanded to include this point
- `Vector2 ClosestPoint(Vector2 point)`
  - Returns the closest point on this rect to another point
- `Sandbox.Rect Align(Vector2 size, Sandbox.TextFlag align)`
  - Align the smaller rect inside this rect.
Default alignment on each axis is Top, Left.
- `Sandbox.Rect SnapToGrid()`
  - Align to a grid
- `Sandbox.Rect Contain(Vector2 size, Sandbox.TextFlag align, System.Boolean stretch)`
  - Contain a given rectangle (image) within this rectangle (frame), preserving aspect ratio.
  - `size`: Size of the rectagle (image) to try to contain within this frame rectangle.
  - `align`: Where to align the given box within this rectangle.
  - `stretch`: Whether to stretch the given rectagle (image) should its size be smaller than largest rectagle (image) size possible within this rectangle (frame).
  - returns: A rectangle with correct position and size to fit within the "parent" rectangle.
