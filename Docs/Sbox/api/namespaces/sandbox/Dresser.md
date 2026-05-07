# Sandbox.Dresser

Allows easily dressing a citizen or human in clothing

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `Dresser()`

## Properties

- `Sandbox.Dresser.ClothingSource Source`
  - Where to get the clothing from
- `System.Boolean RemoveUnownedItems`
  - When using `Sandbox.Dresser.ClothingSource.OwnerConnection`, strip any clothing items that are not owned in their Steam Inventory.
Disable only if your game handles ownership checks itself.
- `Sandbox.SkinnedModelRenderer BodyTarget`
  - Who are we dressing? This should be the renderer of the body of a Citizen or Human
- `System.Boolean ApplyHeightScale`
  - Should we change the height too?
- `System.Single ManualHeight`
- `System.Single ManualTint`
- `System.Single ManualAge`
- `System.Collections.Generic.List<Sandbox.ClothingContainer.ClothingEntry> Clothing`
- `System.Collections.Generic.List<System.String> WorkshopItems`
- `System.Boolean IsDressing`
  - True if we're dressing, in an async way

## Methods

### Instance methods

- `System.Void CancelDressing()`
  - If we're dressing in an async way - stop it.
- `System.Void Clear()`
- `System.Threading.Tasks.ValueTask Apply()`
- `System.Void Randomize()`
  - Make a random outfit
- `System.Void OnManualChange(System.Single a, System.Single b)`
  - Called when Height, Age or Tint is changed
