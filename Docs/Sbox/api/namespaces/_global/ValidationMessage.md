# Facepunch.ActionGraphs.NodeBinding.ValidationMessage

A message generated when attempting to bind a set of named property values and input types.
Becomes a `Facepunch.ActionGraphs.ValidationMessage` during action graph validation.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Facepunch.ActionGraphs`
- **Declaring type:** `Facepunch.ActionGraphs.NodeBinding`

## Constructors

- `ValidationMessage(Facepunch.ActionGraphs.IParameterDefinition Context, Facepunch.ActionGraphs.MessageLevel Level, System.String Value, System.Object UserData)`
  - A message generated when attempting to bind a set of named property values and input types.
Becomes a `Facepunch.ActionGraphs.ValidationMessage` during action graph validation.
  - `Context`: Which property, input or output this message is relevant to.
  - `Level`: Message severity.
  - `Value`: Message content.

## Properties

- `Facepunch.ActionGraphs.IParameterDefinition Context`
  - Which property, input or output this message is relevant to.
- `Facepunch.ActionGraphs.MessageLevel Level`
  - Message severity.
- `System.String Value`
  - Message content.
- `System.Object UserData`

## Methods

### Instance methods

- `System.Void Deconstruct(Facepunch.ActionGraphs.IParameterDefinition Context, Facepunch.ActionGraphs.MessageLevel Level, System.String Value, System.Object UserData)`
