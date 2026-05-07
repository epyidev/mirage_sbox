# Sandbox.PropertyDescription

Describes a property. We use this class to wrap and return <see cref="P:Sandbox.PropertyDescription.PropertyInfo">PropertyInfo</see>'s that are safe to interact with.
            
Returned by `Sandbox.Internal.TypeLibrary` and `Sandbox.TypeDescription`.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Reflection`
- **Base:** `Sandbox.MemberDescription`

## Properties

- `System.Boolean IsProperty`
- `System.Boolean CanWrite`
  - Whether this property can be written to.
- `System.Boolean CanRead`
  - Whether this property can be read.
- `System.Boolean IsGetMethodPublic`
  - Whether the getter of this property is public.
- `System.Boolean IsSetMethodPublic`
  - Whether the setter of this property is public.
- `System.Type PropertyType`
  - Property type.
- `System.Boolean IsIndexer`
  - True if this property has index parameters

## Methods

### Instance methods

- `System.Object GetValue(System.Object obj)`
  - Get the value of this property on given object.
- `System.Void SetValue(System.Object obj, System.Object value)`
  - Set the value of this property on given object.
- `System.Boolean CheckValidationAttributes(System.Object obj, System.String[] errors, System.String name)`
