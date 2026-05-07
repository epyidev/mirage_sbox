# Sandbox.UI.StyleSheetCollection

A collection of `Sandbox.UI.StyleSheet` objects applied directly to a panel.
See `Sandbox.UI.Panel.StyleSheet`.

- **Kind:** struct
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `System.Void Add(Sandbox.UI.StyleSheet sheet)`
  - Add a stylesheet directly
- `System.Void Load(System.String filename, System.Boolean inheritVariables, System.Boolean failSilently)`
  - Load the stylesheet from a file.
- `System.Void Parse(System.String stylesheet, System.Boolean inheritVariables)`
  - Load the stylesheet from a string.
- `System.Void Remove(Sandbox.UI.StyleSheet sheet)`
  - Remove a specific `Sandbox.UI.StyleSheet` from the collection.
- `System.Void Remove(System.String wildcardGlob)`
  - Remove all stylesheets whose filename matches this wildcard glob.
- `System.Collections.Generic.IEnumerable<System.ValueTuple<System.String,System.String>> CollectVariables()`
  - Returns all CSS variables from the owning panel and its ancestors.
