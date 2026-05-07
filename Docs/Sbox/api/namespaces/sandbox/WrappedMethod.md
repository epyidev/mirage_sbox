# Sandbox.WrappedMethod

Provides data about a wrapped method in a `Sandbox.CodeGeneratorAttribute` callback.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Properties

- `System.Action Resume`
  - Invoke the original method.
- `System.Object Object`
  - The object whose method is being wrapped. This will be null if we're wrapping a static method.
- `System.Boolean IsStatic`
  - Is this a static method?
- `System.String TypeName`
  - The name of the type that the method belongs to.
- `System.String MethodName`
  - The name of the original method.
- `System.Int32 MethodIdentity`
  - The Identity of the original method. This is an integer that each MethodDescription has to distinguish itself from other methods of the same class.
- `System.Type[] GenericArguments`
  - The generic argument types of the method or null if the method is not generic.
- `System.Attribute[] Attributes`
  - An array of all attributes decorated with `Sandbox.CodeGeneratorAttribute` on the original method.

## Methods

### Instance methods

- `U GetAttribute()`
  - Get the attribute of type, or null if it doesn't exist
