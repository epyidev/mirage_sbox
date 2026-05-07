# Sandbox.WrappedPropertyGet<T>

Provides data about a wrapped property getter in a `Sandbox.CodeGeneratorAttribute` callback.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Properties

- `T Value`
  - The value from the original getter.
- `System.Object Object`
  - The object whose property is being wrapped. This will be null if we're wrapping a static property.
- `System.Boolean IsStatic`
  - Is this a static property?
- `System.String TypeName`
  - The name of the type that the property belongs to.
- `System.String PropertyName`
  - The name of the original property. If static, will return the full name including the type.
- `System.Int32 MemberIdent`
  - The identity of the original property. Used by TypeLibrary as a unique identifier for the property.
- `System.Attribute[] Attributes`
  - An array of all attributes on the original property.

## Methods

### Instance methods

- `U GetAttribute()`
  - Get the attributes of the specified type, or null if it doesn't exist.
