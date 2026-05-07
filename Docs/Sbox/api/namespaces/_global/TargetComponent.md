# Sandbox.Doo.TargetComponent

Abstracts a link to a component - which can be
* An actual component
* A GameObject and a component type
* A Variable (GameObject or Component) and a component type

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Doo`

## Constructors

- `TargetComponent()`

## Properties

- `Sandbox.Doo.TargetComponent.TargetType Type`
- `Sandbox.Component ComponentValue`
  - The Component we want to target directly.
- `Sandbox.GameObject GameObjectValue`
  - The GameObject that contains the target component.
- `System.String ComponentType`
  - The type of Component we want to access. This allows us to select members that exist on this type.
- `System.String VariableName`
  - The name of the variable we're going to use. This can be a GameObject or a Component.
- `Sandbox.FindMode FindMode`

## Methods

### Static methods

- `static System.Object JsonRead(System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert)`
- `static System.Void JsonWrite(System.Object value, System.Text.Json.Utf8JsonWriter writer)`

### Instance methods

- `System.Type GetComponentType()`
- `System.Void CollectArguments(System.Collections.Generic.HashSet<System.String> arguments)`
