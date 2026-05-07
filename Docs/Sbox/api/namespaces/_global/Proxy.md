# Sandbox.SerializedProperty.Proxy

Allows easily creating SerializedProperty classes that wrap other properties.

- **Kind:** abstract class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`
- **Base:** `Sandbox.SerializedProperty`
- **Declaring type:** `Sandbox.SerializedProperty`

## Constructors

- `Proxy()`

## Properties

- `Sandbox.SerializedProperty ProxyTarget`
- `Sandbox.SerializedObject Parent`
- `System.Boolean IsProperty`
- `System.Boolean IsField`
- `System.Boolean IsMethod`
- `System.String Name`
- `System.String DisplayName`
- `System.String Description`
- `System.String GroupName`
- `System.Int32 Order`
- `System.Boolean IsEditable`
- `System.Boolean IsPublic`
- `System.Type PropertyType`
- `System.String SourceFile`
- `System.Int32 SourceLine`
- `System.Boolean HasChanges`
- `System.Boolean IsValid`
- `Sandbox.SerializedProperty.AsAccessor As`

## Methods

### Instance methods

- `virtual System.Boolean TryGetAsObject(Sandbox.SerializedObject obj)`
- `virtual T GetValue(T defaultValue)`
- `virtual System.Void SetValue(T value)`
- `virtual System.Collections.Generic.IEnumerable<System.Attribute> GetAttributes()`
