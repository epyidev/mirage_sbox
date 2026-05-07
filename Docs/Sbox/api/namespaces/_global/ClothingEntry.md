# Sandbox.ClothingContainer.ClothingEntry

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.ClothingContainer`

## Constructors

- `ClothingEntry()`
- `ClothingEntry(Sandbox.Clothing clothing)`

## Properties

- `Sandbox.Clothing Clothing`
  - A direct reference to the clothing item
- `System.Int32 ItemDefinitionId`
  - If this is a Steam Inventory Item then this is the item definition id. This usually means
we'll look up the clothing item from the workshop.
- `System.Nullable<System.Single> Tint`
  - Used to select a tint for the item. The gradients are defined in the item.
- `System.String Bone`
  - If this item is manually placed, this is the bone we're attached to
- `System.Nullable<Transform> Transform`
  - If this item is manually placed, this is the offset relative to the bone
