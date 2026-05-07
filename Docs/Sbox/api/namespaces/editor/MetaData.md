# Editor.MetaData

A class to CRUD json files. This should probably be a generic class since it seems
like we might want to do this with stuff other than meta files. But there's no need for
that right now, so lets leave it simple.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `System.String FilePath`
  - File path to the metadata file.

## Methods

### Instance methods

- `System.Nullable<System.Text.Json.JsonElement> GetElement(System.String keyName)`
- `T Get(System.String keyName, T defaultValue)`
- `System.String GetString(System.String keyName, System.String defaultValue)`
- `System.Boolean GetBool(System.String keyName, System.Boolean defaultValue)`
- `System.Int32 GetInt(System.String keyName, System.Int32 defaultValue)`
- `System.Single GetFloat(System.String keyName, System.Single defaultValue)`
- `System.Void Set(System.String name, T value)`
  - Set a value in the metadata file. If the value is null, the key will be removed.
