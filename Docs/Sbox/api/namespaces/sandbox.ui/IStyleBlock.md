# Sandbox.UI.IStyleBlock

A CSS rule - ie ".chin { width: 100%; height: 100%; }"

- **Kind:** interface
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.System`

## Properties

- `System.String FileName`
  - The filename of the file containing this style block (or null if none)
- `System.String AbsolutePath`
  - The absolute on disk filename for this style block (or null if not on disk)
- `System.Int32 FileLine`
  - The line in the file containing this style block
- `System.Collections.Generic.IEnumerable<System.String> SelectorStrings`
  - A list of selectors

## Methods

### Instance methods

- `virtual System.Collections.Generic.List<Sandbox.UI.IStyleBlock.StyleProperty> GetRawValues()`
  - Get the list of raw style values
- `virtual System.Boolean SetRawValue(System.String key, System.String value, System.String originalValue)`
  - Update a raw style value
