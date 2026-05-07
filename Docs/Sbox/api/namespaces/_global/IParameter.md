# Facepunch.ActionGraphs.Node.IParameter

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Facepunch.ActionGraphs`
- **Declaring type:** `Facepunch.ActionGraphs.Node`

## Properties

- `Facepunch.ActionGraphs.Node Node`
  - The parent node of this parameter.
- `System.String Name`
  - The name of this parameter.
- `System.Int32 Index`
- `Facepunch.ActionGraphs.IParameterDefinition Definition`
  - Current definition of this parameter, including type and
display information.
- `System.Type Type`
  - Value type of this parameter.
- `Facepunch.ActionGraphs.DisplayInfo Display`
  - Display info for this parameter.
- `System.Collections.Generic.IReadOnlyCollection<System.Attribute> Attributes`
  - If this parameter was generated using reflection, contains the attributes
attached to the reflected member.
