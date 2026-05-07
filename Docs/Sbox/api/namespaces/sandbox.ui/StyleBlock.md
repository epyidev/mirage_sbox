# Sandbox.UI.StyleBlock

A CSS rule - ie ".chin { width: 100%; height: 100%; }"

- **Kind:** sealed class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `StyleBlock()`

## Properties

- `Sandbox.UI.StyleSelector[] Selectors`
  - A list of appropriate selectors for this block (ie ".button")
- `System.Collections.Generic.IEnumerable<System.String> SelectorStrings`
  - A list of selectors for this block
- `System.String FileName`
  - The filename of the file containing this style block (or null if none)
- `System.String AbsolutePath`
  - The absolute on disk filename for this style block (or null if not on disk)
- `System.Int32 FileLine`
  - The line in the file containing this style block

## Fields

- `Sandbox.UI.Styles Styles`
  - The styles that are defined in this block

## Methods

### Instance methods

- `virtual System.Collections.Generic.List<Sandbox.UI.IStyleBlock.StyleProperty> GetRawValues()`
  - Get the list of raw style values
- `virtual System.Boolean SetRawValue(System.String key, System.String value, System.String originalValue)`
  - Update a raw style value
- `Sandbox.UI.StyleSelector Test(Sandbox.UI.IStyleTarget target, Sandbox.UI.PseudoClass forceFlag)`
  - Test whether target passes our selector tests. We use forceFlag to do alternate tests for flags like ::before and ::after.
It's basically added to the target's pseudo class list for the test.
- `System.Boolean TestBroadphase(Sandbox.UI.IStyleTarget target)`
  - Tests a few broadphase conditions to build a list of feasible
styleblocks tailored for a panel.
- `System.Boolean SetSelector(System.String selector, Sandbox.UI.StyleBlock parent)`
