# Sandbox.SuppressNullKeyWarningAttribute

When applied to a member with `System.Collections.Generic.Dictionary`2` or `System.Collections.Generic.HashSet`1` type,
don't warn if the key of an item becomes null during a hotload because a type is removed. You should
only use this attribute if you're sure that it's safe to quietly remove entries.

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `SuppressNullKeyWarningAttribute()`
