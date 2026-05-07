# Facepunch.ActionGraphs.ValidationExtensions

Extension methods related to validation and validation messages.

- **Kind:** static class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Methods

### Static methods

- `static System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.ValidationMessage> GetMessages(Facepunch.ActionGraphs.IMessageContext context)`
  - Gets all validation messages where this, or any child element, is the context.
- `static System.Boolean HasErrors(Facepunch.ActionGraphs.IMessageContext context)`
  - Returns true if any contained validation messages are errors. An action graph can't
be invoked if it has any errors.
