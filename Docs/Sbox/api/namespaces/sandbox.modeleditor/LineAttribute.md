# Sandbox.ModelEditor.LineAttribute

- **Kind:** attribute
- **Namespace:** `Sandbox.ModelEditor`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ModelEditor.Internal.BaseModelDocAttribute`

## Constructors

- `LineAttribute()`

## Properties

- `System.String BoneFrom`
  - Internal name of the key that dictates which bone to use as parent for start position.
- `System.String AttachmentFrom`
  - Internal name of the key that dictates which attachment to use as parent for start position.
- `System.String OriginFrom`
  - Internal name of the key to read line start position from.
- `System.String BoneTo`
  - Internal name of the key that dictates which bone to use as parent for end position.
- `System.String AttachmentTo`
  - Internal name of the key that dictates which attachment to use as parent for end position.
- `System.String OriginTo`
  - Internal name of the key to read line end position from.
- `System.String Enabled`
  - Internal name of the key that controls whether this helper is visible or not.
- `System.String Color`
  - A string formatted color for this helper. Format is "255 255 255"
- `System.Single Width`
  - The width of the line helper

## Methods

### Instance methods

- `virtual System.Void AddTransform(System.Text.StringBuilder sb)`
- `virtual System.Void AddKeys(System.Collections.Generic.Dictionary<System.String,System.Object> dict)`
