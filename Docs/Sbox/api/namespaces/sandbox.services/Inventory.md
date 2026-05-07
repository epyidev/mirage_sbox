# Sandbox.Services.Inventory

Allows access to the Steam Inventory system

- **Kind:** static class
- **Namespace:** `Sandbox.Services`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static System.Collections.Generic.IReadOnlyCollection<Sandbox.Services.Inventory.Item> Items`
  - All of the items the user has in their inventory
- `static System.Collections.Generic.IReadOnlyCollection<Sandbox.Services.Inventory.ItemDefinition> Definitions`
  - All item definitions

## Methods

### Static methods

- `static System.Boolean HasItem(System.Int32 inventoryDefinitionId)`
  - Returns true if we have this item
- `static Sandbox.Services.Inventory.ItemDefinition FindDefinition(System.Int32 definitionId)`
  - Find a definition by id
