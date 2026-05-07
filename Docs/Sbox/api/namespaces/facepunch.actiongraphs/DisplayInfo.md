# Facepunch.ActionGraphs.DisplayInfo

Display information of a `Facepunch.ActionGraphs.NodeDefinition`.

- **Kind:** class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Constructors

- `DisplayInfo(System.String Title, System.String Description, System.String Group, System.String Icon, System.Nullable<System.Boolean> Hidden, System.String[] Tags)`
- `DisplayInfo(Facepunch.ActionGraphs.DisplayInfo original)`

## Properties

- `System.Type EqualityContract`
- `System.String Title`
  - Display name of the node.
- `System.String Description`
  - Helpful text explaining the usage of the node.
- `System.String Group`
  - Category to help organize the node.
- `System.String Icon`
  - Material icon for this node.
- `System.Nullable<System.Boolean> Hidden`
  - If true, don't show this node definition in editor UI.
- `System.String[] Tags`
  - Set of tags to help organize the node.

## Methods

### Static methods

- `static Facepunch.ActionGraphs.DisplayInfo FromAttributes(System.Reflection.MemberInfo member)`
- `static Facepunch.ActionGraphs.DisplayInfo FromAttributes(System.Reflection.ParameterInfo parameter)`
- `static Facepunch.ActionGraphs.DisplayInfo FromAttributes(System.Reflection.ICustomAttributeProvider member, System.String defaultTitle)`

### Instance methods

- `Facepunch.ActionGraphs.DisplayInfo Format(System.Func<System.String,System.Object> getProperty, System.Type targetType)`
- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Facepunch.ActionGraphs.DisplayInfo <Clone>$()`
- `System.Void Deconstruct(System.String Title, System.String Description, System.String Group, System.String Icon, System.Nullable<System.Boolean> Hidden, System.String[] Tags)`
