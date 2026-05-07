# Sandbox.Connection.Filter

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Connection`

## Constructors

- `Filter(Sandbox.Connection.Filter.FilterType type, System.Predicate<Sandbox.Connection> predicate)`
- `Filter(Sandbox.Connection.Filter.FilterType type, System.Collections.Generic.IEnumerable<Sandbox.Connection> connections)`

## Methods

### Instance methods

- `System.Boolean IsRecipient(Sandbox.Connection connection)`
  - Is the specified `Sandbox.Connection` a valid recipient?
