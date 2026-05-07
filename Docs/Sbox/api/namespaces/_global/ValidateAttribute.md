# ValidateAttribute

Validates a property using a method.

- **Kind:** attribute
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Attribute`

## Constructors

- `ValidateAttribute(System.String condition, System.String message, Sandbox.LogLevel status)`
  - Specifies a method in the same class to use for validation.
  - `condition`: Name of the validation method in the current class
  - `message`: Message to display when validation fails
  - `status`: severity level to use when validation fails
- `ValidateAttribute(System.Type type, System.String condition, System.String message, Sandbox.LogLevel status)`
  - Specifies a static method in another class to use for validation.
  - `type`: The type containing the static validation method
  - `condition`: Name of the static validation method
  - `message`: Message to display when validation fails
  - `status`: severity level to use when validation fails

## Fields

- `System.String _methodName`
- `System.Type _methodOwnerType`
- `Sandbox.LogLevel _status`
- `System.String _message`

## Methods

### Instance methods

- `ValidateAttribute.Result Validate(System.Object targetObject, Sandbox.TypeDescription td, System.Object propertyValue)`
  - Validates a property value using the specified method.
