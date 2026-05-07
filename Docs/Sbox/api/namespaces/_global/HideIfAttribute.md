# HideIfAttribute

Hide this property if a given property within the same class has the given value. Used typically in the Editor Inspector.

- **Kind:** attribute
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `ConditionalVisibilityAttribute`

## Constructors

- `HideIfAttribute(System.String propertyName, System.Object value)`

## Properties

- `System.String PropertyName`
  - Property name to test.
- `System.Object Value`
  - Property value to test against.

## Methods

### Instance methods

- `virtual System.Boolean TestCondition(System.Object targetObject, Sandbox.TypeDescription td)`
- `virtual System.Boolean TestCondition(Sandbox.SerializedObject so)`
