# Sandbox.UI.PanelTransform

- **Kind:** struct
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.System`

## Properties

- `System.Int32 Entries`

## Fields

- `System.Collections.Immutable.ImmutableList<Sandbox.UI.PanelTransform.Entry> List`

## Methods

### Instance methods

- `Matrix BuildTransform(System.Single width, System.Single height, Vector2 perspectiveOrigin)`
- `System.Boolean IsEmpty()`
  - Returns true if this is empty.
- `System.Boolean AddTranslate(System.Nullable<Sandbox.UI.Length> lengthX, System.Nullable<Sandbox.UI.Length> lengthY, System.Nullable<Sandbox.UI.Length> lengthZ)`
- `System.Boolean AddTranslateX(System.Nullable<Sandbox.UI.Length> length)`
- `System.Boolean AddTranslateY(System.Nullable<Sandbox.UI.Length> length)`
- `System.Boolean AddTranslateZ(System.Nullable<Sandbox.UI.Length> length)`
- `System.Boolean AddScale(System.Single scale)`
- `System.Boolean AddScale(Vector3 scale)`
- `System.Boolean AddSkew(System.Single x, System.Single y, System.Single z)`
- `System.Boolean AddRotation(System.Single x, System.Single y, System.Single z)`
- `System.Boolean AddRotation(Vector3 angles)`
- `System.Boolean AddMatrix3D(Matrix matrix)`
- `System.Boolean AddPerspective(Sandbox.UI.Length d)`
