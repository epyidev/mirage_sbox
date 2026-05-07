# Sandbox.Internal.TypeLibrary

- **Kind:** class
- **Namespace:** `Sandbox.Internal`
- **Assembly:** `Sandbox.Reflection`

## Methods

### Instance methods

- `System.Collections.Generic.IReadOnlyList<T> GetAttributes()`
  - Get all attributes of this type
- `System.Collections.Generic.IReadOnlyList<System.ValueTuple<Sandbox.TypeDescription,T>> GetTypesWithAttribute()`
  - Get all attributes of this type. Returns the type description along with the attribute. This will 
also return types that inherit the attribute from base classes too.
- `System.Collections.Generic.IReadOnlyList<System.ValueTuple<Sandbox.TypeDescription,T>> GetTypesWithAttribute(System.Boolean inherited)`
  - Get all attributes of this type. Returns the type description along with the attribute.
If inherited is false, we will return only classes that contain this attribute directly.
- `T GetAttribute(System.Type t)`
  - Get single attribute of type, from type
- `System.Collections.Generic.IReadOnlyList<T> GetAttributes(System.Type t)`
  - Get all attribute of type, from all types assignable to type
- `System.Object Create(System.String name, System.Type targetType, System.Object[] args)`
  - Create a type instance by name and is assignable to given type, with optional arguments for its constructor.
  - `name`: Name of the type to create.
  - `targetType`: Type "constraint", as in the type instance must be assignable to this given type.
  - `args`: Optional arguments for the constructor of the selected type.
- `T Create(System.Type type, System.Object[] args)`
  - Create type instance from type.
- `T Create(System.String name, System.Boolean complainOnMissing)`
  - Create a type instance by name and is assignable to given type.
  - `name`: Name of the type to create.
  - `complainOnMissing`: Display a warning when requested type name was not found.
- `T Create(System.String name, System.Object[] args, System.Boolean complainOnMissing)`
  - Create a type instance by name and is assignable to given type.
  - `name`: Name of the type to create.
  - `complainOnMissing`: Display a warning when requested type name was not found.
- `T Create(System.Int32 ident)`
  - Create a type instance by its identity. See `Sandbox.Internal.TypeLibrary.GetIdent(System.Type)`.
- `System.Collections.Generic.IReadOnlyList<System.ValueTuple<Sandbox.MethodDescription,T>> GetMethodsWithAttribute(System.Boolean onlyStatic)`
  - Find all methods with given attribute, optionally non static
- `System.Collections.Generic.IEnumerable<Sandbox.MethodDescription> FindStaticMethods(System.String methodName)`
  - Find all static methods with given name.
- `System.Collections.Generic.IEnumerable<Sandbox.MethodDescription> FindStaticMethods(System.String methodName)`
  - Find all static methods with given name and given attribute.
- `System.Collections.Generic.IEnumerable<T> GetMemberAttributes()`
  - Find all member attributes (instances) with given attribute type.
- `System.Collections.Generic.IEnumerable<T> GetMemberAttributes(System.Boolean staticMembers)`
  - Find all static or non static only member attributes (instances) with given attribute type.
- `Sandbox.PropertyDescription[] GetPropertyDescriptions(System.Object obj, System.Boolean onlyOwn)`
  - Get a list of properties on the target object. To do this we'll just call GetDescription( obj.GetType() ) and return .Properties.
Will return an empty array if we can't access these properties.
- `System.Boolean SetProperty(System.Object target, System.String name, System.Object value)`
  - Set a named property on given object.
Will perform extra magic for string inputs and try to convert to target property type.
  - `target`: The target object to set a named property on.
  - `name`: Name of the property to set.
  - `value`: Value for the property.
  - returns: Whether the property was set or not.
- `System.Object GetPropertyValue(System.Object target, System.String name)`
  - Try to get a value from a property on an object
- `System.Byte[] ToBytes(T value)`
  - Serialize this value to bytes, where possible
- `System.Void ToBytes(T value, Sandbox.ByteStream bs)`
  - Serialize this value to bytes, where possible
- `T FromBytes(System.Byte[] data)`
  - Deserialize this from bytes. 
If the type is unknown, T can be an object.
- `T FromBytes(System.ReadOnlySpan<System.Byte> data)`
- `T FromBytes(Sandbox.ByteStream bs)`
  - Deserialize this from bytes. 
If the type is unknown, T can be an object.
- `System.Int32 GetTypeIdent(System.Type type)`
  - Get hash of a type.
- `Sandbox.TypeDescription GetType(System.Type type)`
  - Get the description for a specific type. This will return null if you don't have whitelist access to the type.
For constructed generic types, this will give you the description of the generic type definition.
- `System.Collections.Generic.IReadOnlyList<Sandbox.TypeDescription> GetGenericTypes(System.Type type, System.Type[] types)`
  - Get a list of types that implement this generic type
- `System.Collections.Generic.IReadOnlyList<Sandbox.TypeDescription> GetTypes(System.Type type)`
  - Get descriptions for all types that derive from T
- `Sandbox.TypeDescription GetType(System.String name)`
  - Find a TypeDescription that derives from `T`, by name
- `Sandbox.TypeDescription GetType(System.String name, System.Boolean preferAddonAssembly)`
  - Find a TypeDescription that derives from T by name, which can be an Alias etc.
If preferAddonAssembly is true, then if there are conflicts we'll prefer types that are 
in addon code.
- `Sandbox.TypeDescription GetType(System.String name, System.Boolean preferAddonAssembly, System.Boolean exactFullName)`
  - Find a TypeDescription that derives from T by name, which can be an Alias etc.
If preferAddonAssembly is true, then if there are conflicts we'll prefer types that are 
in addon code.
If exactFullName is true, the name must match the FullName of the type.
- `Sandbox.TypeDescription GetType(System.Type type, System.String name, System.Boolean preferAddonAssembly, System.Boolean exactFullName)`
  - Find a TypeDescription that derives from T by name, which can be an Alias etc.
If preferAddonAssembly is true, then if there are conflicts we'll prefer types that are 
in addon code.
  - `type`: The base type to search for, or null to search all types
  - `name`: The name to search for, which can be an alias or the full name depending on the value of `exactFullName`
  - `preferAddonAssembly`: If true, then if there are conflicts we'll prefer types that are in addon code.
  - `exactFullName`: If true, the name must match the FullName (or alias) of the type
- `System.Collections.Generic.IReadOnlyList<Sandbox.TypeDescription> GetTypes()`
  - Get descriptions for all types that derive from T
- `System.Collections.Generic.IEnumerable<Sandbox.TypeDescription> GetTypes()`
  - Get all types
- `Sandbox.TypeDescription GetType()`
  - Find the description for templated type
- `System.Boolean TryGetType(System.Type t, Sandbox.TypeDescription typeDescription)`
  - Find the description type
- `System.Boolean TryGetType(Sandbox.TypeDescription typeDescription)`
  - Find the description type
- `Sandbox.TypeDescription GetType(System.String name, System.Boolean exactFullName)`
  - Find a TypeDescription by name
- `Sandbox.TypeDescription GetTypeByIdent(System.Int32 ident)`
  - Find a TypeDescription by name
- `Sandbox.MemberDescription GetMemberByIdent(System.Int32 ident)`
  - Find a `Sandbox.MemberDescription` by its `Sandbox.MemberDescription.Identity`
- `Sandbox.TypeDescription GetType(System.String name, System.Type baseType)`
  - Find a TypeDescription that derives from `baseType`, by name
- `System.Type[] GetGenericArguments(System.Type genericType)`
  - Performs `System.Type.GetGenericArguments` with access control checks.
Will throw if any arguments aren't in the whitelist.
  - `genericType`: Constructed generic type to get the arguments of
- `System.Boolean HasAttribute(System.Type type)`
  - Return true if this type contains this attribute
- `System.Boolean CheckValidationAttributes(T obj)`
  - Check if all properties of this class instance pass their `System.ComponentModel.DataAnnotations.ValidationAttribute`.
  - `obj`: Object to test.
  - returns: True if all properties pass their validity checks (or if there are no checks), false otherwise.
- `System.Boolean CheckValidationAttributes(T obj, System.String[] errors)`
  - Check if all properties of this class instance pass their `System.ComponentModel.DataAnnotations.ValidationAttribute`.
  - `obj`: Object to test.
  - `errors`: string array of first invalid obj property error
  - returns: True if all properties pass their validity checks (or if there are no checks), false otherwise.
- `Sandbox.SerializedObject GetSerializedObject(System.Object target)`
  - Get a SerializedObject version of this object
- `Sandbox.SerializedObject GetSerializedObject(System.Func<System.Object> fetchTarget, Sandbox.TypeDescription typeDescription, Sandbox.SerializedProperty parent)`
- `Sandbox.EnumDescription GetEnumDescription(System.Type enumType)`
  - Get a class describing the values of an enum
- `Sandbox.SerializedProperty CreateProperty(System.String title, System.Func<T> get, System.Action<T> set, System.Attribute[] attributes, Sandbox.SerializedObject parent)`
- `Sandbox.SerializedProperty CreateProperty(System.String title, Sandbox.SerializedObject so, System.Attribute[] attributes, Sandbox.SerializedObject parent)`
  - Create a serialized property from a SerializedObject
