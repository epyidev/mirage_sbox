# Sandbox.AnyOfType<T>

A wrapper that holds an instance of any concrete type assignable to `T`.
Use this as a property type when you want the inspector to let you pick from all
non-abstract implementations of an abstract class or interface.


```

public AnyOfType&lt;Scatterer&gt; MyScatterer { get; set; }

```


Serialization stores the concrete type name alongside the property values

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Constructors

- `AnyOfType<T>(T value)`

## Properties

- `T Value`
  - The concrete instance, or null if no type is selected.
- `System.Boolean HasValue`
  - Returns true if `Sandbox.AnyOfType`1.Value` is not null.
