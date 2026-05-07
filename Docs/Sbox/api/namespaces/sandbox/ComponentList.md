# Sandbox.ComponentList

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Int32 Count`
  - Amount of components - including disabled

## Methods

### Instance methods

- `System.Collections.Generic.IEnumerable<Sandbox.Component> GetAll()`
  - Get all components, including disabled ones
- `Sandbox.Component Create(Sandbox.TypeDescription type, System.Boolean startEnabled)`
  - Add a component of this type
- `T Create(System.Boolean startEnabled)`
  - Add a component of this type
- `T Get(Sandbox.FindMode search)`
  - Get a component of this type
- `Sandbox.Component Get(System.Type type, Sandbox.FindMode find)`
  - Get a component of this type
- `System.Collections.Generic.IEnumerable<Sandbox.Component> GetAll(System.Type type, Sandbox.FindMode find)`
  - Get all components of this type
- `System.Collections.Generic.IEnumerable<Sandbox.Component> GetAll(Sandbox.FindMode find)`
  - Get all components
- `System.Collections.Generic.IEnumerable<T> GetAll(Sandbox.FindMode find)`
  - Get a list of components on this game object, optionally recurse when deep is true
- `System.Boolean TryGet(T component, Sandbox.FindMode search)`
  - Try to get this component
- `Sandbox.Component FirstOrDefault(System.Func<Sandbox.Component,System.Boolean> value)`
- `System.Void ForEach(System.String name, System.Boolean includeDisabled, System.Action<T> action)`
- `System.Void ForEach(System.String name, System.Boolean includeDisabled, System.Action<Sandbox.Component> action)`
- `System.Void Move(Sandbox.Component baseComponent, System.Int32 delta)`
  - Move the position of the component in the list by delta (-1 means up one, 1 means down one)
- `T Get(System.Boolean includeDisabled)`
  - Find component on this gameobject
- `T GetOrCreate(Sandbox.FindMode flags)`
  - Find this component, if it doesn't exist - create it.
- `T GetInAncestorsOrSelf(System.Boolean includeDisabled)`
  - Find component on this gameobject's ancestors or on self
- `T GetInAncestors(System.Boolean includeDisabled)`
  - Find component on this gameobject's ancestors
- `T GetInDescendantsOrSelf(System.Boolean includeDisabled)`
  - Find component on this gameobject's decendants or on self
- `T GetInDescendants(System.Boolean includeDisabled)`
  - Find component on this gameobject's decendants
- `T GetInChildrenOrSelf(System.Boolean includeDisabled)`
  - Find component on this gameobject's immediate children or on self
- `T GetInChildren(System.Boolean includeDisabled)`
  - Find component on this gameobject's immediate children
- `T GetInParentOrSelf(System.Boolean includeDisabled)`
  - Find component on this gameobject's parent or on self
- `T GetInParent(System.Boolean includeDisabled)`
  - Find component on this gameobject's parent
- `Sandbox.Component Get(System.Guid id)`
  - Find component on this gameobject with the specified id
