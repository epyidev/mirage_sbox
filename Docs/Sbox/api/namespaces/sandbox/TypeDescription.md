# Sandbox.TypeDescription

Describes a type. We use this class to wrap and return <see cref="T:System.Type">System.Type</see>'s that are safe to interact with.
            
Returned by `Sandbox.Internal.TypeLibrary`.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Reflection`

## Properties

- `System.Type TargetType`
  - The type this class describes.
- `Sandbox.TypeDescription BaseType`
  - The base type. This can return null if the type isn't in the type library!
- `System.Boolean IsValid`
  - Whether the class is valid or not, i.e. whether the type still exists.
- `Sandbox.MemberDescription[] Members`
  - All members (methods, properties, etc) of this type.
- `Sandbox.MemberDescription[] DeclaredMembers`
  - Members (methods, properties, etc) declared by exactly this type, and not inherited.
- `Sandbox.MethodDescription[] Methods`
  - All methods of this type.
- `Sandbox.PropertyDescription[] Properties`
  - All properties of this type.
- `Sandbox.FieldDescription[] Fields`
  - All fields on this type.
- `System.Boolean IsInterface`
  - True if the target type is an interface
- `System.Boolean IsEnum`
  - True if the target type is an enum
- `System.Boolean IsStatic`
  - True if the target type is static
- `System.Boolean IsClass`
  - True if the target type is a class
- `System.Boolean IsValueType`
  - True if the target type is a value
- `System.Boolean IsAbstract`
  - Gets a value indicating whether the System.Type is abstract and must be overridden.
- `System.String Name`
  - Name of this type.
- `System.String Namespace`
  - Namespace of this type.
- `System.String FullName`
  - Full name of this type.
- `System.String Title`
- `System.String Description`
- `System.String Icon`
- `System.String Group`
- `System.Int32 Order`
- `System.String[] Tags`
  - Tags are set via the [Tag] attribute
- `System.String[] Aliases`
- `System.Int32 Identity`
  - An integer that represents this type. Based off the class name.
- `System.String ClassName`
  - A string representing this class name. Historically this was provided by [Library( classname )].
If no special name is provided, this will be type.Name.
- `System.Int32 SourceLine`
  - The line number of this member
- `System.String SourceFile`
  - The file containing this member
- `System.Boolean IsGenericType`
  - True if we're a generic type
- `System.Type[] GenericArguments`
  - If we're a generic type this will return our generic parameters.
- `System.Type[] Interfaces`
  - If we implement any interfaces they will be here

## Methods

### Instance methods

- `System.Boolean IsNamed(System.String name, System.Boolean exactFullName)`
  - Returns true if this is named the passed name, either through classname, target class name or an alias
  - `name`: The name to check
  - `exactFullName`: If true, only the exact full name or aliases will match.
- `T GetAttribute(System.Boolean inherited)`
  - Returns the first attribute of given type, if any are present.
- `System.Collections.Generic.IEnumerable<T> GetAttributes(System.Boolean inherited)`
  - Returns all attributes of given type, if any are present.
- `System.Boolean HasAttribute(System.Boolean inherited)`
  - Returns true if the class has this attribute
- `System.Boolean HasTag(System.String tag)`
  - True if we have this tag.
- `Sandbox.PropertyDescription GetProperty(System.String name)`
  - Get property by name (will not find static properties)
- `Sandbox.PropertyDescription GetStaticProperty(System.String name)`
  - Get static property by name
- `System.Object GetValue(System.Object instance, System.String name)`
  - Get value by field or property name (will not find static members)
- `System.Object GetStaticValue(System.String name)`
  - Get value by field or property name, and which type the member is declared to store (will not find static members)
- `System.Boolean SetValue(System.Object instance, System.String name, System.Object value)`
  - Set value by field or property name (will not set static members)
- `System.Boolean SetStaticValue(System.String name, System.Object value)`
  - Set static value by field or property name
- `Sandbox.MethodDescription GetMethod(System.String name)`
  - Get a method by name (will not find static methods)
- `Sandbox.MethodDescription GetStaticMethod(System.String name)`
  - Get a method by name (will not find static methods)
- `T Create(System.Object[] args)`
  - Create an instance of this class, return it as a T.
If it can't be cast to a T we won't create it and will return null.
- `T CreateGeneric(System.Type[] typeArgs, System.Object[] args)`
  - Create an instance of this class using generic arguments
We're going to assume you know what you're doing here and let it throw any exceptions it wants.
- `System.Type MakeGenericType(System.Type[] inargs)`
  - For generic type definitions, create a type by substituting the given types for each type parameter.
Returns null if any of the type arguments violate the generic constraints.
