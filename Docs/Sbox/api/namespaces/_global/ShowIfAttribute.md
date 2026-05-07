# ShowIfAttribute

Show this property if a given property within the same class has the given value. Used typically in the Editor Inspector.

- **Kind:** attribute
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `HideIfAttribute`

## Constructors

- `ShowIfAttribute(System.String propertyName, System.Object value)`

## Methods

### Instance methods

- `virtual System.Boolean TestCondition(System.Object targetObject, Sandbox.TypeDescription td)`
- `virtual System.Boolean TestCondition(Sandbox.SerializedObject so)`
