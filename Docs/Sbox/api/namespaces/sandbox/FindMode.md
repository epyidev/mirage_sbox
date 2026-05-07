# Sandbox.FindMode

Flags to search for Components.
I've named this something generic because I think we can re-use it to search for GameObjects too.

- **Kind:** enum
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`

## Values

- `Enabled` - Components that are enabled
- `Disabled` - Components that are disabled
- `InSelf` - Components in this object
- `InParent` - Components in our parent
- `InAncestors` - Components in all ancestors (parent, their parent, their parent, etc)
- `InChildren` - Components in our children
- `InDescendants` - Components in all decendants (our children, their children, their children etc)
- `EnabledInSelf`
- `EnabledInSelfAndDescendants`
- `EnabledInSelfAndChildren`
- `DisabledInSelf`
- `DisabledInSelfAndDescendants`
- `DisabledInSelfAndChildren`
- `EverythingInSelf`
- `EverythingInSelfAndDescendants`
- `EverythingInSelfAndChildren`
- `EverythingInSelfAndParent`
- `EverythingInSelfAndAncestors`
- `EverythingInAncestors`
- `EverythingInChildren`
- `EverythingInDescendants`
