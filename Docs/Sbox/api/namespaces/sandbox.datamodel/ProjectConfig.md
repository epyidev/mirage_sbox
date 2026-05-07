# Sandbox.DataModel.ProjectConfig

Configuration of a `Sandbox.Project`.

- **Kind:** class
- **Namespace:** `Sandbox.DataModel`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ProjectConfig()`

## Properties

- `System.IO.DirectoryInfo Directory`
  - The directory housing this addon (TODO)
- `System.IO.DirectoryInfo AssetsDirectory`
  - The directory housing this addon (TODO)
- `System.String Title`
  - The human readable title, for example "Sandbox", "Counter-Strike"
- `System.String Type`
  - The type of addon. Current valid values are "game"
- `System.String Org`
  - The ident of the org that owns this addon. For example "facepunch", "valve".
- `System.String Ident`
  - The ident of this addon. For example "sandbox", "cs" or "dm98"
- `Sandbox.Package.Type PackageType`
  - Type of the package.
- `System.String FullIdent`
  - Returns a combination of Org and Ident - for example "facepunch.sandbox" or "valve.cs".
- `System.Int32 Schema`
  - The version of the addon file. Allows us to upgrade internally.
- `System.Boolean IncludeSourceFiles`
  - If true then we'll include all the source files
- `System.String Resources`
  - A list of paths in which to look for extra assets to upload with the addon. Note that compiled asset files are automatically included.
- `System.Collections.Generic.List<System.String> PackageReferences`
  - A list of packages that this package depends on. These should be installed alongside this package.
- `System.Collections.Generic.List<System.String> EditorReferences`
  - A list of packages that this package uses but there is no need to install. For example, a map package might use
a model package - but there is no need to download that model package because any usage will organically be included
in the manifest. However, when loading this item in the editor, it'd make sense to install these 'cloud' packages.
- `System.Collections.Generic.List<System.String> Mounts`
  - A list of mounts that are required
- `System.Boolean IsStandaloneOnly`
  - Whether or not this project is standalone-only, and supports disabling the whitelist, compiling with /unsafe, etc.
- `System.Collections.Generic.Dictionary<System.String,System.Object> Metadata`
  - Custom key-value storage for this project.

## Methods

### Instance methods

- `System.String ToJson()`
  - Serialize the entire config to a JSON string.
- `System.Boolean TryGetMeta(System.String keyname, T outvalue)`
  - Try to get a value at given key in `Sandbox.DataModel.ProjectConfig.Metadata`.
  - `keyname`: The key to retrieve the value of.
  - `outvalue`: The value, if it was present in the metadata storage.
  - returns: Whether the value was successfully retrieved.
- `T GetMetaOrDefault(System.String keyname, T defaultValue)`
  - Get the package's meta value. If it's missing or the wrong type then use the default value.
- `System.Boolean SetMeta(System.String keyname, System.Object outvalue)`
  - Store custom data at given key in the `Sandbox.DataModel.ProjectConfig.Metadata`.
  - `keyname`: The key for the data.
  - `outvalue`: The data itself to store.
  - returns: Always true.
