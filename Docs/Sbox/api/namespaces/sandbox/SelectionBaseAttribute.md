# Sandbox.SelectionBaseAttribute

Apply this attribute to a component class to mark its GameObject as a selection base for Scene View picking.
For example, if you click on a child object within a Prefab, the root of the Prefab is selected by default.
With the SelectionBase attribute, you can designate a specific component (and its GameObject) to be treated as a selection base,
ensuring it is picked when clicking in the Scene View.

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `SelectionBaseAttribute()`
