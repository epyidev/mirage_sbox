# Sandbox.Storage.Entry

A folder of content stored on disk

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Storage`

## Constructors

- `Entry(System.String type)`
  - Creates a new storage entry with the specified type
  - `type`: The content type (letters only, 1-16 characters)

## Properties

- `System.String Id`
  - The identity of this content
- `System.String Type`
  - The type of content, eg "save", "dupe"
- `System.DateTimeOffset Created`
  - When this content was created
- `Sandbox.BaseFileSystem Files`
  - This is where you save and load your files to
- `Sandbox.Texture Thumbnail`
  - Gets the thumbnail texture for this storage entry, if one exists

## Methods

### Instance methods

- `System.Void SetMeta(System.String key, T value)`
  - Set a meta value
- `T GetMeta(System.String key, T defaultValue)`
  - Get a meta value
- `System.Void SetThumbnail(Sandbox.Bitmap bitmap)`
  - Sets the thumbnail for this storage entry
  - `bitmap`: The bitmap to use as the thumbnail
- `System.Void Delete()`
  - Deletes this storage entry and all its files from disk
- `System.Void Publish(System.String title, System.String[] tags, System.Collections.Generic.Dictionary<System.String,System.String> keyvalues)`
- `System.Void Publish(Sandbox.Modals.WorkshopPublishOptions options)`
  - Publishes this storage entry to the workshop
