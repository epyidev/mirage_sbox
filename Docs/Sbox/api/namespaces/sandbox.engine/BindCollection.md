# Sandbox.Engine.BindCollection

A collection of action binds. 

 BindCollection
   - Action: attack1
     - Slot0: mouse1
   - Action: selectall
     - Slot0: ctrl + a
     
The bind collection can be saved and loaded from disk via the BindSaveConfig class.

The bind collection can have a base collection which it will fall back to if it contains
the same binds. This allows us to have a "common" collection which can be shared between
all games, but can also let the games + users to override those binds if they choose.

- **Kind:** class
- **Namespace:** `Sandbox.Engine`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `BindCollection(System.String name)`
  - Creates a collection and tries to load it from disk.

## Properties

- `Sandbox.Engine.BindCollection Base`
  - The base collection. Game binds have this set to the common binds.
- `System.String CollectionName`
  - Will be either "common" or the ident of the current game.
- `System.String ConfigPath`
  - The location of the config file to load from in EngineFileSystem.Config

## Fields

- `Sandbox.CaseInsensitiveDictionary<Sandbox.Engine.BindCollection.ActionBind> Actions`
  - The actual collection of binds.

## Methods

### Instance methods

- `Sandbox.Engine.BindCollection.ActionBind GetBind(System.String actionName, System.Boolean create)`
  - Get the bind, create if it doesn't exist
- `Sandbox.Engine.BindCollection.ActionBind Set(System.String actionName, System.Int32 slot, System.String buttonName)`
  - Set the bind value for this action. This will overwrite what's in this slot.
- `System.String Get(System.String actionName, System.Int32 slot)`
  - Get the bind value at this slot
- `System.Void SaveToDisk()`
  - Save the collection to disk
