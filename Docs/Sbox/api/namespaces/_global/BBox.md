# BBox

An <a href="https://en.wikipedia.org/wiki/Minimum_bounding_box">Axis Aligned Bounding Box</a>.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `BBox(Vector3 mins, Vector3 maxs)`
  - Initialize an AABB with given mins and maxs corners. See `Vector3.Sort(Vector3@,Vector3@)`.
- `BBox(Vector3 center, System.Single size)`
  - Initializes a zero sized BBox with given center. This is useful if you intend to use AddPoint to expand the box later.

## Properties

- `System.Collections.Generic.IEnumerable<Vector3> Corners`
  - An enumerable that contains all corners of this AABB.
- `Vector3 Center`
  - Calculated center of the AABB.
- `Vector3 Size`
  - Calculated size of the AABB on each axis.
- `Vector3 Extents`
  - The extents of the bbox. This is half the size.
- `Vector3 RandomPointInside`
  - Returns a random point within this AABB.
- `Vector3 RandomPointOnEdge`
  - Returns a random point within this AABB.
- `System.Single Volume`
  - Returns the physical volume of this AABB.

## Fields

- `Vector3 Mins`
  - The minimum corner extents of the AABB. Values on each axis should be mathematically smaller than values on the same axis of `BBox.Maxs`. See `Vector3.Sort(Vector3@,Vector3@)`
- `Vector3 Maxs`
  - The maximum corner extents of the AABB. Values on each axis should be mathematically larger than values on the same axis of `BBox.Mins`. See `Vector3.Sort(Vector3@,Vector3@)`

## Methods

### Static methods

- `static BBox FromHeightAndRadius(System.Single height, System.Single radius)`
  - Creates an AABB of `radius` length and depth, and given `height`
- `static BBox FromPositionAndSize(Vector3 center, System.Single size)`
  - Creates an AABB at given position `center` and given `size` which acts as a <b>diameter</b> of a sphere contained within the AABB.
- `static BBox FromPositionAndSize(Vector3 center, Vector3 size)`
  - Creates an AABB at given position `center` and given `size` a.k.a. "extents".
- `static BBox FromBoxes(System.Collections.Generic.IEnumerable<BBox> boxes)`
- `static BBox FromPoints(System.Collections.Generic.IEnumerable<Vector3> points, System.Single size)`

### Instance methods

- `BBox Translate(Vector3 point)`
  - Move this box by this amount and return
- `BBox Rotate(Rotation rotation)`
  - Rotate this box by this amount and return
- `BBox Transform(Transform transform)`
  - Transform this box by this amount and return
- `System.Boolean Contains(BBox b)`
  - Returns true if this AABB completely contains given AABB
- `System.Boolean Contains(Vector3 b, System.Single epsilon)`
  - Returns true if this AABB contains given point
- `System.Boolean Overlaps(BBox b)`
  - Returns true if this AABB somewhat overlaps given AABB
- `BBox AddPoint(Vector3 point)`
  - Returns this bbox but stretched to include given point
- `BBox AddBBox(BBox point)`
  - Returns this bbox but stretched to include given bbox
- `BBox Grow(System.Single skin)`
  - Return a slightly bigger box
- `Vector3 ClosestPoint(Vector3 point)`
  - Returns the closest point on this AABB to another point
- `System.Boolean Trace(Ray ray, System.Single distance, System.Single hitDistance)`
  - Trace a ray against this box. If hit then return the distance.
- `System.Single GetVolume()`
  - Get the volume of this AABB
- `BBox Snap(System.Single distance)`
  - Snap this AABB to a grid
- `System.Single GetEdgeDistance(Vector3 localPos)`
  - Calculates the shortest distance from the specified local position to the nearest edge of the shape.
