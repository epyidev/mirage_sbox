# Sandbox.Localization.Phrase

A translated string. ie "Hello World".
It might also have variables, ie "Hello {PlayerName}".
Todo support for conditionals and plurals

- **Kind:** class
- **Namespace:** `Sandbox.Localization`
- **Assembly:** `Sandbox.System`

## Constructors

- `Phrase(System.String value)`
  - Create a SmartString from a phrase.

## Methods

### Instance methods

- `System.String Render()`
  - Render with no data - basically just returns Value
- `System.String Render(System.Collections.Generic.Dictionary<System.String,System.Object> data)`
