# Sandbox.PrefabScene.VariableCollection

A collection of variabnles that have been configured for this scene

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.PrefabScene`

## Constructors

- `VariableCollection()`

## Methods

### Static methods

- `static System.ValueTuple<System.Guid,System.Guid,System.String> DeconstructKey(System.String property)`

### Instance methods

- `System.Boolean IsVariable(Sandbox.SerializedProperty property)`
- `Sandbox.PrefabVariable Create(System.String name)`
- `System.Void Remove(Sandbox.PrefabVariable variable)`
- `System.Void ClearVariable(Sandbox.SerializedProperty property)`
- `virtual System.Collections.Generic.IEnumerator<Sandbox.PrefabVariable> GetEnumerator()`
