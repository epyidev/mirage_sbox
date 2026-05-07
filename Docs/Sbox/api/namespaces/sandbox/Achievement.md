# Sandbox.Achievement

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.String Name`
- `System.String Title`
- `System.String Description`
- `System.String Icon`
- `System.Boolean IsUnlocked`
- `System.Nullable<System.DateTimeOffset> UnlockTimestamp`
- `System.Int32 Score`
- `Vector2 Range`
- `System.Single CurrentValue`
- `System.Boolean IsVisible`
  - Returns whether this achievement should be visible to the player
- `System.Boolean HasProgression`
- `System.Int32 GlobalUnlocked`
- `System.Single GlobalFraction`
- `System.Single ProgressionFraction`
  - A float, representing the progression of this stat. 0 is 0%, 1 is 100%. Not clamped.
