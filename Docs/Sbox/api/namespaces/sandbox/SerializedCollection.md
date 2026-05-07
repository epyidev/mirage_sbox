# Sandbox.SerializedCollection

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `Sandbox.SerializedObject`

## Constructors

- `SerializedCollection()`

## Properties

- `System.Type KeyType`
- `System.Type ValueType`
- `System.Object TargetObject`

## Fields

- `System.Action OnEntryAdded`
- `System.Action OnEntryRemoved`
- `System.Func<Sandbox.SerializedProperty,Sandbox.SerializedObject> PropertyToObject`

## Methods

### Instance methods

- `virtual System.Void SetTargetObject(System.Object obj, Sandbox.SerializedProperty property)`
- `virtual System.Boolean Remove(Sandbox.SerializedProperty property)`
- `virtual System.Boolean RemoveAt(System.Object index)`
- `virtual System.Boolean Add(System.Object value)`
- `virtual System.Boolean Add(System.Object key, System.Object value)`
- `virtual Sandbox.SerializedProperty NewKeyProperty()`
