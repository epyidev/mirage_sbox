# ConditionalVisibilityAttribute

Hide a property if a condition matches.

- **Kind:** attribute
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.InspectorVisibilityAttribute`

## Constructors

- `ConditionalVisibilityAttribute()`

## Methods

### Instance methods

- `virtual System.Boolean TestCondition(System.Object targetObject, Sandbox.TypeDescription td)`
  - The test condition.
  - `targetObject`: The class instance of the property this attribute is attached to.
  - `td`: Description of the `targetObject`'s type.
  - returns: Return true if the property should be visible.
