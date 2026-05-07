# Editor.Asset.PublishSettings

This is data that is saved in an asset's meta file under "publish" to configure
its project for uploading.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.Asset`

## Constructors

- `PublishSettings()`

## Properties

- `System.Boolean Enabled`
  - Whether the asset should be published or not.
- `Sandbox.DataModel.ProjectConfig ProjectConfig`
  - Project configuration information

## Methods

### Instance methods

- `System.Void Save()`
- `Sandbox.Project CreateTemporaryProject()`
  - Create a Project usually with the intention of editing and publishing a single asset.
The project isn't stored or listed anywhere, so is considered a transient that you can load
up, edit, save and then throw away.
