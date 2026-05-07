# Sandbox.ParticleFloat

Represents a floating-point value that can change over time with support for various evaluation modes.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ParticleFloat()`
- `ParticleFloat(System.Single a, System.Single b)`

## Properties

- `Sandbox.ParticleFloat.ValueType Type`
- `Sandbox.ParticleFloat.EvaluationType Evaluation`
- `Sandbox.Curve CurveA`
- `Sandbox.Curve CurveB`
- `System.Single ConstantValue`
- `System.Single ConstantA`
- `System.Single ConstantB`
- `Sandbox.CurveRange CurveRange`

## Fields

- `Vector4 Constants`

## Methods

### Static methods

- `static System.Object JsonRead(System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert)`
  - Reads a ParticleFloat instance from JSON, refactored for modularity.
- `static System.Void JsonWrite(System.Object value, System.Text.Json.Utf8JsonWriter writer)`
  - Writes a ParticleFloat instance to JSON, refactored for modularity.

### Instance methods

- `System.Single Evaluate(System.Single delta, System.Single randomFixed)`
  - Evaluates the value based on the given delta and random seed, optimized for performance.
- `System.Single Evaluate(Sandbox.IDynamicFloatContext context, System.Int32 seed, System.Int32 line)`
  - Evaluates the value using a dynamic context and seed, optimized for clarity and functionality.
- `System.Boolean IsNearlyZero()`
  - Checks if the value is nearly zero.
- `System.Single GetValue()`
  - This is only here to remain "compatible" with RangedFloat
