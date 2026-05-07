# Sandbox.Services.Stats.GlobalStat

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Services.Stats`

## Properties

- `System.String Name`
  - The programatic name for this stat. This should probably be called Ident
- `System.String Title`
  - The title of this stat, as defined on the backend
- `System.String Description`
  - The description of this stat, as defined on the backend
- `System.String Unit`
  - The unit of this stat as defined on the backend
- `System.Double Velocity`
  - The change in this stat in units per hour
- `System.Double Value`
  - The current stat value
- `System.String ValueString`
  - The current value formatted using Unit
- `System.Int64 Players`
  - The amount of players that have this stat
- `System.Double Max`
  - The maximum value
- `System.Double Min`
  - The minimum value
- `System.Double Avg`
  - The average value
- `System.Double Sum`
  - The sum of all values
