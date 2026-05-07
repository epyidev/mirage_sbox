# Sandbox.AchievementCollection

Holds achievements for a package

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `AchievementCollection(System.String packageIdent)`

## Properties

- `System.Collections.Generic.IReadOnlyCollection<Sandbox.Achievement> All`

## Methods

### Instance methods

- `Sandbox.Achievement Get(System.String name)`
  - Get achievement by name, or null of it doesn't exist
- `System.Threading.Tasks.Task RecountProgression()`
  - Use the current stats to recount the progression on stats with progression. This is purely for UI,
you can't force an achivement to unlock early by calling this.
