# Sandbox.RectInt

Represents a rectangle but with whole numbers

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Constructors

- `RectInt(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)`
  - Initialize a Rect at given position and with given size.
- `RectInt(Vector2Int point, Vector2Int size)`
  - Initialize a Rect at given position and with given size.

## Properties

- `System.Int32 Width`
  - Width of the rect.
- `System.Int32 Height`
  - Height of the rect.
- `System.Int32 Left`
  - Position of rect's left edge relative to its parent, can also be interpreted as its position on the X axis.
- `System.Int32 Top`
  - Position of rect's top edge relative to its parent, can also be interpreted as its position on the Y axis.
- `System.Int32 Right`
  - Position of rect's right edge relative to its parent.
- `System.Int32 Bottom`
  - Position of rect's bottom edge relative to its parent.
- `Vector2Int Position`
  - Position of this rect.
- `Vector2 Center`
  - Center of this rect.
- `Vector2Int Size`
  - Size of this rect.
- `Sandbox.RectInt WithoutPosition`
  - Returns this rect with position set to 0 on both axes.
- `Vector2Int BottomLeft`
  - Position of the bottom left edge of this rect.
- `Vector2Int BottomRight`
  - Position of the bottom right edge of this rect.
- `Vector2Int TopRight`
  - Position of the top right edge of this rect.
- `Vector2Int TopLeft`
  - Position of the top left edge of this rect.

## Methods

### Static methods

- `static Sandbox.RectInt FromPoints(Vector2Int a, Vector2Int b)`
  - Create a rect between two points. The order of the points doesn't matter.

### Instance methods

- `System.Boolean IsInside(Sandbox.RectInt rect, System.Boolean fullyInside)`
  - Return true if the passed rect is partially or fully inside this rect.
  - `rect`: The passed rect to test.
  - `fullyInside`: `true` to test if the given rect is completely inside this rect. `false` to test for an intersection.
- `System.Boolean IsInside(Vector2Int pos)`
  - Return true if the passed point is inside this rect.
- `Sandbox.RectInt Shrink(System.Int32 left, System.Int32 top, System.Int32 right, System.Int32 bottom)`
  - Returns a Rect shrunk in every direction by given values.
- `Sandbox.RectInt Shrink(System.Int32 x, System.Int32 y)`
  - Returns a Rect shrunk in every direction by given values on each axis.
- `Sandbox.RectInt Shrink(System.Int32 amt)`
  - Returns a Rect shrunk in every direction by given amount.
- `Sandbox.RectInt Grow(System.Int32 left, System.Int32 top, System.Int32 right, System.Int32 bottom)`
  - Returns a Rect grown in every direction by given amounts.
- `Sandbox.RectInt Grow(System.Int32 x, System.Int32 y)`
  - Returns a Rect grown in every direction by given values on each axis.
- `Sandbox.RectInt Grow(System.Int32 amt)`
  - Returns a Rect grown in every direction by given amount.
- `System.Void Add(Sandbox.RectInt r)`
  - Expand this Rect to contain the other rect
- `System.Void Add(Vector2Int point)`
  - Expand this Rect to contain the point
- `Sandbox.RectInt AddPoint(Vector2Int pos)`
  - Returns this rect expanded to include this point
