# Sandbox.SerializedProperty.CustomizableSerializedProperty

A proxy around a SerializedProperty that allows overriding any property for UI customization.
Unset values fall through to the underlying property.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`
- **Base:** `Sandbox.SerializedProperty.Proxy`
- **Declaring type:** `Sandbox.SerializedProperty`

## Constructors

- `CustomizableSerializedProperty(Sandbox.SerializedProperty property)`

## Properties

- `Sandbox.SerializedProperty ProxyTarget`
- `System.String Name`
- `System.String DisplayName`
- `System.String Description`
- `System.String GroupName`
- `System.String SourceFile`
- `System.Int32 Order`
- `System.Int32 SourceLine`
- `System.Boolean IsEditable`
- `System.Boolean IsPublic`
- `System.Boolean IsProperty`
- `System.Boolean IsField`
- `System.Boolean IsMethod`
- `System.Boolean HasChanges`
- `System.Boolean IsValid`
- `Sandbox.SerializedObject Parent`
- `System.Type PropertyType`

## Methods

### Instance methods

- `System.Void SetName(System.String value)`
  - Override the property's internal name.
- `System.Void SetDisplayName(System.String value)`
  - Override the label shown in the inspector.
- `System.Void SetDescription(System.String value)`
  - Override the tooltip / description text.
- `System.Void SetGroupName(System.String value)`
  - Override which inspector group this property appears in.
- `System.Void SetSourceFile(System.String value)`
  - Override the reported source file path.
- `System.Void SetOrder(System.Int32 value)`
  - Override the sort order within the inspector.
- `System.Void SetSourceLine(System.Int32 value)`
  - Override the reported source line number.
- `System.Void SetIsEditable(System.Boolean value)`
  - Force the property to be editable or read-only.
- `System.Void SetIsPublic(System.Boolean value)`
  - Override the public visibility flag.
- `System.Void SetIsProperty(System.Boolean value)`
  - Override whether this appears as a property.
- `System.Void SetIsField(System.Boolean value)`
  - Override whether this appears as a field.
- `System.Void SetIsMethod(System.Boolean value)`
  - Override whether this appears as a method.
- `System.Void SetHasChanges(System.Boolean value)`
  - Override the dirty/changed flag.
- `System.Void SetIsValid(System.Boolean value)`
  - Override the validity flag.
- `System.Void SetParent(Sandbox.SerializedObject value)`
  - Override the parent SerializedObject.
- `System.Void SetPropertyType(System.Type value)`
  - Override the reported property type.
- `virtual System.Collections.Generic.IEnumerable<System.Attribute> GetAttributes()`
  - Returns the underlying attributes merged with any added via `Sandbox.SerializedProperty.CustomizableSerializedProperty.AddAttribute(System.Attribute)`.
- `System.Void AddAttribute(System.Attribute attribute)`
  - Append an extra attribute visible to the editor and control widgets.
