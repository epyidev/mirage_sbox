# Facepunch.ActionGraphs.JsonExtensions

Extension methods for `System.Text.Json` types.

- **Kind:** static class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Methods

### Static methods

- `static System.Void AddActionGraphConverters(System.Text.Json.JsonSerializerOptions options, Facepunch.ActionGraphs.NodeLibrary nodeLibrary)`
  - Adds the ability for this `System.Text.Json.JsonSerializerOptions` to convert `Facepunch.ActionGraphs.ActionGraph`,
`!:ActionGraph&lt;T&gt;`, and `System.Delegate` instances implemented with action graphs.
- `static System.Void AddActionGraphConverters(System.Text.Json.JsonSerializerOptions options, Facepunch.ActionGraphs.GetNodeLibraryDelegate getNodeLibrary)`
  - Adds the ability for this `System.Text.Json.JsonSerializerOptions` to convert `Facepunch.ActionGraphs.ActionGraph`,
`!:ActionGraph&lt;T&gt;`, and `System.Delegate` instances implemented with action graphs.
