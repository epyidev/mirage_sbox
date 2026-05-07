# Sandbox.ActionGraphExposeWhenCachedAttribute

Don't cache instances of this type when serializing action graph references, force them to be always serialized separately.
We need this for component / game object references so we can update IDs when duplicating objects / instantiating prefabs.

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `ActionGraphExposeWhenCachedAttribute()`
