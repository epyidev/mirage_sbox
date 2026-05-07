# Sandbox.IGameInstance

Todo: make internal - the only thing using ir right now is the binds system

- **Kind:** interface
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static Sandbox.IGameInstance Current`
- `System.Boolean IsLoading`
  - True after the game is fully loaded
- `Sandbox.Scene Scene`

## Methods

### Instance methods

- `virtual System.Void ResetBinds()`
- `virtual System.Void SaveBinds()`
- `virtual System.String GetBind(System.String actionName, System.Boolean isDefault, System.Boolean isCommon)`
- `virtual System.Void SetBind(System.String actionName, System.String buttonName)`
- `virtual System.Void TrapButtons(System.Action<System.String[]> callback)`
