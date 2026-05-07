# Sandbox.ActionGraphs.ActionGraphExtensions

- **Kind:** static class
- **Namespace:** `Sandbox.ActionGraphs`
- **Assembly:** `Sandbox.Reflection`

## Methods

### Static methods

- `static System.Object GetEmbeddedTarget(Facepunch.ActionGraphs.ActionGraph actionGraph)`
- `static System.Object GetEmbeddedTarget(Facepunch.ActionGraphs.IActionGraphDelegate actionGraph)`
- `static System.Type GetTargetType(Facepunch.ActionGraphs.ActionGraph actionGraph)`
- `static System.Type GetTargetType(Facepunch.ActionGraphs.IActionGraphDelegate actionGraph)`
- `static System.Boolean CanActionGraphRead(Sandbox.PropertyDescription property, Facepunch.ActionGraphs.NodeLibrary nodeLibrary)`
- `static System.Boolean CanActionGraphWrite(Sandbox.PropertyDescription property, Facepunch.ActionGraphs.NodeLibrary nodeLibrary)`
- `static System.Boolean CanActionGraphRead(Sandbox.FieldDescription field, Facepunch.ActionGraphs.NodeLibrary nodeLibrary)`
- `static System.Boolean CanActionGraphWrite(Sandbox.FieldDescription field, Facepunch.ActionGraphs.NodeLibrary nodeLibrary)`
- `static System.Boolean IsPure(Sandbox.MethodDescription methodDesc, Facepunch.ActionGraphs.NodeLibrary nodeLibrary)`
- `static System.Boolean AreParametersActionGraphSafe(Sandbox.MethodDescription methodDesc)`
- `static System.Boolean AreParametersActionGraphSafe(System.Reflection.MethodBase methodBase)`
- `static System.Boolean IsActionGraphIgnored(Sandbox.MemberDescription memberDesc)`
- `static System.Boolean IsActionGraphIgnored(Sandbox.TypeDescription typeDesc)`
- `static System.Void UpdateReferences(Facepunch.ActionGraphs.ActionGraph graph)`
- `static System.Collections.Generic.IReadOnlyCollection<System.Type> GetReferencedComponentTypes(Facepunch.ActionGraphs.ActionGraph graph)`
  - Gets all component types referenced using "scene.get" nodes. These components are expected
to be on the GameObject containing the graph.
