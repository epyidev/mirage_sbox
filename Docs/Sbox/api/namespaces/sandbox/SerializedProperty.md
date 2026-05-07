# Sandbox.SerializedProperty

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Constructors

- `SerializedProperty()`

## Properties

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
- `System.Boolean IsValid`
- `System.String SourceFile`
  - The source filename, if available
- `System.Int32 SourceLine`
  - The line in the source file, if available
- `System.Boolean HasChanges`
  - Returns true if the current set value differs from the actual value
- `Sandbox.SerializedObject.PropertyPreChangeDelegate OnPreChange`
  - Called when the property value is about to change.
- `Sandbox.SerializedObject.PropertyChangedDelegate OnChanged`
  - Called when the property value has changed.
- `Sandbox.SerializedObject.PropertyStartEditDelegate OnStartEdit`
  - Called when the property is about to be edited (eg. in a ControlWidget).
- `Sandbox.SerializedObject.PropertyFinishEditDelegate OnFinishEdit`
  - Called when the property has finished being edited (eg. in a ControlWidget).
- `Sandbox.SerializedProperty.AsAccessor As`
- `System.Boolean IsMultipleValues`
  - True if this holds multiple values. That might all be the same.
- `System.Boolean IsMultipleDifferentValues`
  - True if this holds multiple values, and they're all different.
- `System.Collections.Generic.IEnumerable<Sandbox.SerializedProperty> MultipleProperties`
  - Get all properties if this holds multiple values
- `System.Boolean IsNullable`
  - Return true if this is a nullable value type
- `System.Type NullableType`
  - If this is a nullable type, this will return the nullable target type
- `System.Boolean IsNull`
  - True if the value is null

## Methods

### Static methods

- `static Sandbox.SerializedProperty Create(System.String title, System.Func<T> get, System.Action<T> set, System.Attribute[] attributes)`

### Instance methods

- `virtual System.Void SetValue(T value)`
- `virtual System.Void SetValue(T value, Sandbox.SerializedProperty source)`
- `virtual T GetValue(T defaultValue)`
- `virtual System.Object GetDefault()`
  - Get the default value of a specific property type.
- `System.Boolean HasAttribute()`
  - Return true if the property has this attribute
- `System.Boolean HasAttribute(System.Type t)`
  - Return true if the property has this attribute
- `System.Boolean TryGetAttribute(T attribute)`
  - Try to get this attribute from the property. Return false on fail.
- `System.Collections.Generic.IEnumerable<T> GetAttributes()`
  - Get all of these attributes from the property.
- `System.Collections.Generic.IEnumerable<System.Attribute> GetAttributes(System.Type t)`
  - Get all of these attributes from the property.
- `virtual System.Collections.Generic.IEnumerable<System.Attribute> GetAttributes()`
  - Get all attributes from the property.
- `virtual System.Boolean TryGetAsObject(Sandbox.SerializedObject obj)`
  - Try to convert this property into a serialized object for further editing and exploration
- `virtual System.Void NoteChanged()`
  - Our value has changed, maybe our parent would like to know
- `virtual System.Void NotePreChange()`
- `virtual System.Void NoteStartEdit()`
- `virtual System.Void NoteFinishEdit()`
- `T ValueToType(System.Object value, T defaultValue)`
  - Convert an object value to a T type
- `virtual Sandbox.SerializedProperty GetKey()`
  - If this entry is a dictionary, we can get the key for it here
- `System.Boolean ShouldShow()`
  - Returns true if this property should be shown in the inspector
- `System.Void SetNullState(System.Boolean isnull)`
  - If this is a nullable type, you can use this to toggle between it being null or the default value type
- `virtual System.Void Invoke()`
  - If is method
- `Sandbox.SerializedProperty.CustomizableSerializedProperty GetCustomizable()`
  - Return a version of this property that can be customized for editor UI. You'll be able to change
things like display name and tooltip, and add extra attributes that control how editor controls interact with it.
