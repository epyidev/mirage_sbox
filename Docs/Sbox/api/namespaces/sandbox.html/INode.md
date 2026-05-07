# Sandbox.Html.INode

- **Kind:** interface
- **Namespace:** `Sandbox.Html`
- **Assembly:** `Sandbox.System`

## Properties

- `System.Boolean IsElement`
- `System.Boolean IsText`
- `System.Boolean IsComment`
- `System.Boolean IsDocument`
- `System.String OuterHtml`
- `System.String InnerHtml`
- `System.Collections.Generic.IEnumerable<Sandbox.Html.INode> Children`
- `System.String Name`

## Methods

### Static methods

- `static Sandbox.Html.INode Parse(System.String html)`

### Instance methods

- `virtual System.String GetAttribute(System.String name, System.String def)`
- `virtual System.Int32 GetAttributeInt(System.String name, System.Int32 def)`
- `virtual System.Single GetAttributeFloat(System.String name, System.Single def)`
- `virtual System.Boolean GetAttributeBool(System.String name, System.Boolean def)`
- `virtual T GetAttribute(System.String name, T def)`
