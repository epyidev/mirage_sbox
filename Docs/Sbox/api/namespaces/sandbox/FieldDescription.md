# Sandbox.FieldDescription

Describes a field. We use this class to wrap and return <see cref="P:Sandbox.FieldDescription.FieldInfo">FieldInfo</see>'s that are safe to interact with.
            
Returned by `Sandbox.Internal.TypeLibrary` and `Sandbox.TypeDescription`.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Reflection`
- **Base:** `Sandbox.MemberDescription`

## Properties

- `System.Boolean IsField`
- `System.Boolean IsInitOnly`
- `System.Type FieldType`
  - Property type.

## Methods

### Instance methods

- `System.Object GetValue(System.Object obj)`
  - Get the value of this property on given object.
- `System.Void SetValue(System.Object obj, System.Object value)`
  - Set the value of this property on given object.
