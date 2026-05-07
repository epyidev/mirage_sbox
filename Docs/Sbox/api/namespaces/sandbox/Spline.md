# Sandbox.Spline

Collection of curves in 3D space.
Shape and behavior of the curves are controled through points `Sandbox.Spline.Point`, each with customizable handles, roll, scale, and up vectors.
Two consecutive points define a segment/curve of the spline.
<br /><br />
By adjusting the handles both smooth and sharp corners can be created.
The spline can also be turned into a loop, combined with linear tangents this can be used to create polygons.
Splines can also be used used for animations, camera movements, marking areas, or procedural geometry generation.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Constructors

- `Spline()`

## Properties

- `System.Boolean IsLoop`
  - Whether the spline forms a loop.
- `System.Single Length`
  - Total length of the spline.
- `BBox Bounds`
  - Total bounds of the spline.
- `System.Int32 PointCount`
  - Number of points in the spline.
- `System.Int32 SegmentCount`
  - Number of segments in the spline, a spline contains one less segment than points.

## Fields

- `System.Action SplineChanged`
  - Invoked everytime the spline shape or the properties of the spline change.

## Methods

### Instance methods

- `Sandbox.Spline.Sample SampleAtDistance(System.Single distance)`
  - Calculates a bunch of information about the spline at a specific distance.
- `Sandbox.Spline.Sample SampleAtClosestPosition(Vector3 position)`
  - Calculates a bunch of information about the spline at the position closest to the specified position.
- `System.Single GetDistanceAtPoint(System.Int32 pointIndex)`
  - Fetches how far along the spline a point is.
- `System.Single GetSegmentLength(System.Int32 segmentIndex)`
  - Fetches the length of an individual spline segment.
- `BBox GetSegmentBounds(System.Int32 segmentIndex)`
  - Bounds of an individual spline segment.
- `Sandbox.Spline.Point GetPoint(System.Int32 pointIndex)`
  - Access the information about a spline point.
- `System.Void UpdatePoint(System.Int32 pointIndex, Sandbox.Spline.Point updatedPoint)`
  - Update the information stored at a spline point.
- `System.Void InsertPoint(System.Int32 pointIndex, Sandbox.Spline.Point newPoint)`
  - Adds a point at an index
- `System.Void AddPoint(Sandbox.Spline.Point newPoint)`
  - Adds a point to the end of the spline.
- `System.Int32 AddPointAtDistance(System.Single distance, System.Boolean inferTangentModes)`
  - Adds a point at a specific distance along the spline.
Returns the index of the added spline point.
Tangents of the new point and adjacent points will be calculated so the spline shape remains the same.
Unless inferTangentModes is set to true, in which case the tangent modes will be inferred from the adjacent points.
- `System.Void RemovePoint(System.Int32 pointIndex)`
  - Removes the point at the specified index.
- `System.Void Clear()`
  - Removes all points from the spline.
- `System.Void ConvertToPolyline(System.Collections.Generic.List<Vector3> outPolyLine)`
- `System.Collections.Generic.List<Vector3> ConvertToPolyline()`
  - Converts the spline to a polyline.
