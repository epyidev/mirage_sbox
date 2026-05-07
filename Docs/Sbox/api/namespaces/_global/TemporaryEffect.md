# TemporaryEffect

Destroys a GameObject after a number of seconds. If the GameObject or its children have any 
components that implement ITemporaryEffect we will wait for those to be finished before destroying.
This is particularly useful if you want to delete a GameObject but want to wait for sounds or particles 
to conclude.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `TemporaryEffect()`

## Fields

- `System.Single DestroyAfterSeconds`
  - Number of seconds to wait before destroying
- `System.Boolean WaitForChildEffects`
  - If true we will wait for any ITemporaryEffect's to finish before destroying
- `System.Boolean BecomeOrphan`
  - If the parent GameObject is destroyed we should become orphaned instead of being destroyed ourselves.
Once orphaned we'll stop all looping effects and wait to die.

## Methods

### Static methods

- `static System.Void CreateOrphans(Sandbox.GameObject gameObject, System.Boolean disableLooping)`
  - Look at the children in this GameObject and orphan any temporary effects

### Instance methods

- `virtual System.Void OnParentDestroy()`
