# Sandbox.MethodDescription

Describes a method. We use this class to wrap and return <see cref="T:System.Reflection.MethodInfo">MethodInfo</see>'s that are safe to interact with.
            
Returned by `Sandbox.Internal.TypeLibrary` and `Sandbox.TypeDescription`.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Reflection`
- **Base:** `Sandbox.MemberDescription`

## Properties

- `System.Boolean IsMethod`
  - Returns true - because this is a method
- `System.Boolean IsSpecialName`
- `System.Boolean IsVirtual`
- `System.Type ReturnType`
  - Gets the return type of this method.
- `System.Reflection.ParameterInfo[]& modreq(System.Runtime.InteropServices.InAttribute) Parameters`
  - Gets a list of parameters expected by this method

## Methods

### Instance methods

- `System.Object Invoke(System.Object targetObject, System.Object[] parameters)`
  - Invokes this method.
  - `targetObject`: Should be null if this is static, otherwise should be the object this is a member of.
  - `parameters`: An array of parameters to pass. Should be the same length as Parameters
- `T InvokeWithReturn(System.Object targetObject, System.Object[] parameters)`
  - Invokes this method and returns a value.
  - `targetObject`: Should be null if this is static, otherwise should be the object this is a member of.
  - `parameters`: An array of parameters to pass. Should be the same length as Parameters
- `T CreateDelegate()`
  - Creates a delegate bound to this method.
- `T CreateDelegate(System.Object target)`
  - Creates a delegate bound to this method.
  - `target`: Value for the first parameter / target object
- `System.Delegate CreateDelegate(System.Type delegateType)`
  - Creates a delegate bound to this method.
  - `delegateType`: Delegate type to create
- `System.Delegate CreateDelegate(System.Type delegateType, System.Object target)`
  - Creates a delegate bound to this method.
  - `delegateType`: Delegate type to create
  - `target`: Value for the first parameter / target object
