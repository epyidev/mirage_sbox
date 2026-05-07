# Sandbox.UI.StyleSheet

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `StyleSheet()`

## Properties

- `static System.Collections.Generic.List<Sandbox.UI.StyleSheet> Loaded`
- `System.Collections.Generic.List<Sandbox.UI.StyleBlock> Nodes`
- `System.String FileName`
- `System.Collections.Generic.List<System.String> IncludedFiles`

## Fields

- `System.Collections.Generic.Dictionary<System.String,System.String> Variables`
- `System.Collections.Generic.Dictionary<System.String,Sandbox.UI.KeyFrames> KeyFrames`
- `System.Collections.Generic.Dictionary<System.String,Sandbox.UI.MixinDefinition> Mixins`

## Methods

### Static methods

- `static Sandbox.UI.StyleSheet FromFile(System.String filename, System.Collections.Generic.IEnumerable<System.ValueTuple<System.String,System.String>> variables, System.Boolean failSilently)`
- `static Sandbox.UI.StyleSheet FromString(System.String styles, System.String filename, System.Collections.Generic.IEnumerable<System.ValueTuple<System.String,System.String>> variables)`

### Instance methods

- `System.Void Release()`
  - Releases the filesystem watcher so we won't get file changed events.
- `System.String GetVariable(System.String name, System.String defaultValue)`
- `System.String ReplaceVariables(System.String str)`
- `System.Void AddKeyFrames(Sandbox.UI.KeyFrames frames)`
- `System.Void SetMixin(Sandbox.UI.MixinDefinition mixin)`
  - Register a mixin definition.
- `System.Boolean TryGetMixin(System.String name, Sandbox.UI.MixinDefinition mixin)`
  - Try to get a mixin by name.
- `Sandbox.UI.MixinDefinition GetMixin(System.String name)`
  - Get a mixin by name or null if not found.
