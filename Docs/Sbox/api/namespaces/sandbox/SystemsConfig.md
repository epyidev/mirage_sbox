# Sandbox.SystemsConfig

Configuration for GameObjectSystem properties at a project level. 
Specific scenes may override this as well - but will be serialized directly in the scene.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ConfigData`

## Constructors

- `SystemsConfig()`

## Properties

- `System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Object>> Systems`
  - Stores GameObjectSystems to property names to property values

## Methods

### Instance methods

- `System.Object GetPropertyValue(Sandbox.TypeDescription systemType, Sandbox.PropertyDescription property)`
  - Get property value for a specific system type.
Returns the configured value, or a default value for the type if not found.
- `System.Boolean TryGetPropertyValue(Sandbox.TypeDescription systemType, Sandbox.PropertyDescription property, System.Object value)`
  - Try to get property value for a specific system type.
Returns true if the property was found in the config.
- `System.Void SetPropertyValue(Sandbox.TypeDescription systemType, Sandbox.PropertyDescription property, System.Object value)`
  - Set property value for a specific system type
