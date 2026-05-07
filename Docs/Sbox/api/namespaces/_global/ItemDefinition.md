# Sandbox.Services.Inventory.ItemDefinition

Describes a type of item that can be in the inventory

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Services.Inventory`

## Constructors

- `ItemDefinition(System.Int32 id)`

## Properties

- `System.Int32 Id`
- `System.String Name`
- `System.String Description`
- `System.String DescriptionWithMeta`
- `System.String IconUrl`
- `System.String IconUrlLarge`
- `System.String PackageIdent`
- `System.String Category`
- `System.Boolean StoreHidden`
- `System.String Asset`
- `System.Nullable<System.DateTime> SellStart`
- `System.Nullable<System.DateTime> SellEnd`
- `Sandbox.CurrencyValue Price`
  - If we're for sale, this is our price
- `Sandbox.CurrencyValue BasePrice`
  - If we're for sale but on sale, this is our regular price
