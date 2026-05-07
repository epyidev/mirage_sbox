# Sandbox.Spline.Point

Point that defines part of the spline.
Two consecutive points define a segment of the spline.
The `Sandbox.Spline.Point.Position`,  `Sandbox.Spline.Point.In`/`Sandbox.Spline.Point.Out` Handles and <see cref="F:Sandbox.Spline.Point.Mode"></see> / properties are used to define the shape of the spline.


```

                 P1 (Position)                         
      P1 (In)           ▼           P1 (Out)                      
              o──────═══X═══──────o                    
                 ───/       \───                      
              ──/               \──                   
            -/                     \-                  
           /                         \                 
          |                           |
      P0  X                           X  P2

```

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`
- **Declaring type:** `Sandbox.Spline`

## Constructors

- `Point()`

## Fields

- `Vector3 Position`
  - The position of the spline point.
- `Vector3 In`
  - Position of the In handle relative to the point position.
- `Vector3 Out`
  - Position of the Out handle relative to the point position.
- `Sandbox.Spline.HandleMode Mode`
  - Describes how the spline should behave when entering/leaving a point.
The mmode and the handles In and Out position will determine the transition between segments.
- `System.Single Roll`
  - Roll/Twist around the tangent axis.
- `Vector3 Scale`
  - X = Scale Length, Y = Scale Width, Z = Scale Height
- `Vector3 Up`
  - Custom up vector at a spline point, can be used to calculate tangent frames (transforms) along the spline.
This allows fine grained control over the orientation of objects following the spline.
