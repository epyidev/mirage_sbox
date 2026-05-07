# Facepunch.ActionGraphs.ITypeLoader

An implementation of this interface will wrap reflection calls, allowing
custom access control. See `Facepunch.ActionGraphs.DefaultTypeLoader` for a default implementation
with no access control.

- **Kind:** interface
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Methods

### Instance methods

- `virtual System.String TypeToIdentifier(System.Type type)`
  - Gets an identifier string that can later be used by `Facepunch.ActionGraphs.ITypeLoader.TypeFromIdentifier(System.String)` to
deserialize a type instance.
- `virtual System.Type TypeFromIdentifier(System.String value)`
  - Load a type from an identifier, as produced by `Facepunch.ActionGraphs.ITypeLoader.TypeToIdentifier(System.Type)`.
- `virtual System.Reflection.PropertyInfo GetProperty(System.Type declaringType, System.String name)`
  - Gets a named property declared on the given type. Should
return null if the property isn't found, or if it isn't allowed to be accessed.
  - `declaringType`: Declaring type that contains the property.
  - `name`: Property name.
- `virtual System.Reflection.FieldInfo GetField(System.Type declaringType, System.String name)`
  - Gets a named field declared on the given type. Should
return null if the field isn't found, or if it isn't allowed to be accessed.
  - `declaringType`: Declaring type that contains the field.
  - `name`: Field name.
- `virtual System.Boolean CanRead(System.Reflection.PropertyInfo property)`
  - Returns true if `Facepunch.ActionGraphs.ActionGraph` is allowed to read from this property.
Basic checks, like if a get method exists, will have already been performed.
- `virtual System.Boolean CanWrite(System.Reflection.PropertyInfo property)`
  - Returns true if `Facepunch.ActionGraphs.ActionGraph` is allowed to write to this property.
Basic checks, like if a set method exists, will have already been performed.
- `virtual System.Boolean CanRead(System.Reflection.FieldInfo field)`
  - Returns true if `Facepunch.ActionGraphs.ActionGraph` is allowed to read from this field.
- `virtual System.Boolean CanWrite(System.Reflection.FieldInfo field)`
  - Returns true if `Facepunch.ActionGraphs.ActionGraph` is allowed to read from this field.
Basic checks, like if it is marked `System.Reflection.FieldInfo.IsInitOnly`, will
have already been performed.
- `virtual System.Collections.Generic.IReadOnlyList<System.Reflection.ConstructorInfo> GetConstructors(System.Type declaringType)`
  - Gets all constructors declared on the given type.
  - `declaringType`: Declaring type that contains the constructors.
- `virtual System.Collections.Generic.IReadOnlyList<System.Reflection.MethodInfo> GetMethods(System.Type declaringType, System.String name)`
  - Gets all methods with the given name declared on the given type.
  - `declaringType`: Declaring type that contains the methods.
  - `name`: Method name.
- `virtual System.Type GetNestedType(System.Type declaringType, System.String name)`
  - Gets a nested type from its name and the containing type. Should
return null if the type isn't found, or if it isn't allowed to be accessed.
  - `declaringType`: Declaring type that contains the nested type.
  - `name`: Short name of the nested type, not the fully qualified name.
- `virtual System.Type MakeArrayType(System.Type elementType, System.Nullable<System.Int32> rank)`
- `virtual System.Type MakeGenericType(System.Type genericTypeDefinition, System.Type[] genericArguments)`
  - Makes a generic instance type from the given generic type definition and type
arguments. Should throw an exception if the arguments aren't valid for the generic
type definition, or if creating such a type is forbidden.
  - `genericTypeDefinition`: Generic type definition with one or more open type parameters.
  - `genericArguments`: Type arguments to use when creating the generic instance type.
