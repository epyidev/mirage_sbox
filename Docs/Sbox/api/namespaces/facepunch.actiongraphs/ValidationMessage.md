# Facepunch.ActionGraphs.ValidationMessage

A message generated during validation with a context, level, and value.

- **Kind:** struct
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Constructors

- `ValidationMessage(Facepunch.ActionGraphs.IMessageContext Context, Facepunch.ActionGraphs.MessageLevel Level, System.String Value, System.Object UserData)`
  - A message generated during validation with a context, level, and value.
  - `Context`: Action graph element most relevant to this message.
  - `Level`: Severity of the message.
  - `Value`: Message content.

## Properties

- `Facepunch.ActionGraphs.IMessageContext Context`
  - Action graph element most relevant to this message.
- `Facepunch.ActionGraphs.MessageLevel Level`
  - Severity of the message.
- `System.String Value`
  - Message content.
- `System.Object UserData`
- `System.Boolean IsError`
  - If true, this message was a cause for the action graph to fail validation.

## Methods

### Instance methods

- `System.Void Deconstruct(Facepunch.ActionGraphs.IMessageContext Context, Facepunch.ActionGraphs.MessageLevel Level, System.String Value, System.Object UserData)`
