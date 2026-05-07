# Sandbox.UI.StyleSelector

A CSS selector like "Panel.button.red:hover .text"

- **Kind:** sealed class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `StyleSelector()`

## Properties

- `System.String[] Classes`
- `System.String Id`
  - The Id selector - minus the #
https://developer.mozilla.org/en-US/docs/Web/CSS/ID_selectors
- `System.Int32 Score`

## Fields

- `Sandbox.UI.StyleBlock Block`
- `System.String AsString`
- `System.String Element`
- `Sandbox.UI.PseudoClass Flags`
- `Sandbox.UI.StyleSelector Parent`
  - Descendant combinator
A B
Child combinator
A &gt; B
Adjacent sibling combinator
A + B
General sibling combinator
A ~B
- `Sandbox.UI.StyleSelector Not`
- `System.Boolean ImmediateParent`
- `System.Boolean UniversalSelector`
  - True if this has a universal selector (*)
- `System.Boolean AdjacentSibling`
  - For + combinator
- `System.Boolean GeneralSibling`
  - For ~ combinator
- `Sandbox.UI.StyleSelector[] AnyOf`
- `Sandbox.UI.StyleSelector[] DecendantOf`
- `Sandbox.UI.StyleSelector[] Has`
- `System.Int32 SelfScore`
- `System.Func<Sandbox.UI.IStyleTarget,System.Boolean> NthChild`

## Methods

### Instance methods

- `System.Void Finalize(Sandbox.UI.StyleBlock block)`
- `System.Boolean TestBroadphase(Sandbox.UI.IStyleTarget target)`
- `System.Boolean Test(Sandbox.UI.IStyleTarget target, Sandbox.UI.PseudoClass forceFlag)`
  - Test whether target passes our selector test. We use forceFlag to do alternate tests for flags like ::before and ::after.
It's basically added to the target's pseudo class list for the test.
- `System.Boolean TestParent(Sandbox.UI.IStyleTarget target, System.Boolean recusive)`
