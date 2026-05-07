# Sandbox.FloatSpan

Provides vectorized operations over a span of floats.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `FloatSpan(System.Span<System.Single> span)`

## Methods

### Instance methods

- `System.Single Max()`
- `System.Single Min()`
- `System.Single Average()`
- `System.Single Sum()`
- `System.Void Set(System.Single value)`
- `System.Void Set(System.ReadOnlySpan<System.Single> values)`
- `System.Void CopyScaled(System.ReadOnlySpan<System.Single> values, System.Single scale)`
- `System.Void Add(System.ReadOnlySpan<System.Single> values)`
- `System.Void AddScaled(System.ReadOnlySpan<System.Single> values, System.Single scale)`
- `System.Void Scale(System.Single scale)`
