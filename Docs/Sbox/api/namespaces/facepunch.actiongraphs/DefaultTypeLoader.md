# Facepunch.ActionGraphs.DefaultTypeLoader

A default implementation of `Facepunch.ActionGraphs.ITypeLoader` with no access control.

- **Kind:** class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Constructors

- `DefaultTypeLoader()`

## Methods

### Instance methods

- `virtual System.String TypeToIdentifier(System.Type type)`
- `virtual System.Type TypeFromIdentifier(System.String value)`
- `virtual System.Reflection.PropertyInfo GetProperty(System.Type declaringType, System.String name)`
- `virtual System.Reflection.FieldInfo GetField(System.Type declaringType, System.String name)`
- `virtual System.Boolean CanRead(System.Reflection.PropertyInfo property)`
- `virtual System.Boolean CanWrite(System.Reflection.PropertyInfo property)`
- `virtual System.Boolean CanRead(System.Reflection.FieldInfo field)`
- `virtual System.Boolean CanWrite(System.Reflection.FieldInfo field)`
- `virtual System.Collections.Generic.IReadOnlyList<System.Reflection.ConstructorInfo> GetConstructors(System.Type declaringType)`
- `virtual System.Collections.Generic.IReadOnlyList<System.Reflection.MethodInfo> GetMethods(System.Type declaringType, System.String name)`
- `virtual System.Type GetNestedType(System.Type declaringType, System.String name)`
- `virtual System.Type MakeArrayType(System.Type elementType, System.Nullable<System.Int32> rank)`
- `virtual System.Type MakeGenericType(System.Type genericTypeDefinition, System.Type[] genericArguments)`
- `virtual System.Type LoadType(System.String assemblyName, System.String fullName)`
- `virtual System.Boolean CanCache(System.Type type)`
