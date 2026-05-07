# Sandbox.IComponentLister

Interface for types that reference a `Sandbox.ComponentList`, to provide
convenience method for accessing that list.

- **Kind:** interface
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `Sandbox.ComponentList Components`

## Methods

### Instance methods

- `virtual T Create(System.Boolean startEnabled)`
- `virtual T Get(Sandbox.FindMode search)`
- `virtual System.Boolean TryGet(T component, Sandbox.FindMode search)`
- `virtual System.Collections.Generic.IEnumerable<T> GetAll(Sandbox.FindMode search)`
- `virtual T GetOrCreate(Sandbox.FindMode flags)`
