# Sandbox.MultiSerializedObject

An object (or data) that can be accessed as an object

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `Sandbox.SerializedObject`

## Constructors

- `MultiSerializedObject()`

## Properties

- `System.String TypeIcon`
- `System.String TypeName`
- `System.String TypeTitle`
- `System.Boolean IsValid`
- `System.Boolean IsMultipleTargets`
  - True if the target is multiple objects
- `System.Collections.Generic.IEnumerable<System.Object> Targets`
  - A list of actual target objects - if applicable

## Methods

### Instance methods

- `System.Void Add(Sandbox.SerializedObject obj)`
  - Add an object. Don't forget to rebuild after editing!
- `System.Void Rebuild()`
  - Rebuild the object after modifying. This updates PropertyList.
