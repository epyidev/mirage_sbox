# Sandbox.EventAttribute

A generic event listener. You are probably looking for Sandbox.Event.* attributes.

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `EventAttribute(System.String eventName)`

## Properties

- `System.String EventName`
  - The internal event identifier.
- `System.Int32 Priority`
  - Events with lower numbers are run first. This defaults to 0, so setting it to -1 will mean your
event will run before all other events that don't define it. Setting it to 1 would mean it'll
run after all events that don't.
