# Sandbox.Modals.WorkshopPublishOptions

Passed to IModalSystem.WorkshopPublish

- **Kind:** struct
- **Namespace:** `Sandbox.Modals`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `WorkshopPublishOptions()`

## Properties

- `System.String Title`
  - The default title of this item. The user will be able to change it.
- `System.String Description`
  - The description of this item. The user will be able to change it.
- `Sandbox.Bitmap Thumbnail`
  - 512x512 thumbnail image, no transparency
- `Sandbox.Storage.Entry StorageEntry`
  - The filesystem containing the files to publish
- `System.Collections.Generic.Dictionary<System.String,System.String> KeyValues`
  - Keyvalues to store on the item. You can search and filter by these later.
- `System.Collections.Generic.HashSet<System.String> Tags`
  - Tags to set on the item. You can search and filter by these later.
- `System.String Metadata`
  - You can store metadata on the item, which is just a string. This can be read when querying items before
downloading them - so it can be useful for storing extra info you want to store.
- `Sandbox.Storage.Visibility Visibility`
  - The visibility of the item
- `System.Boolean CanSelectVisibility`
  - Can the client select the visibility for this item
- `System.Action<System.UInt64> OnComplete`
  - Called when done. The ulong is the published item id. You can access it via url
https://steamcommunity.com/sharedfiles/filedetails/?id=######
- `System.UInt64 PublishedFileId`
  - If set, update this existing workshop item instead of creating a new one.
- `System.Collections.Generic.Dictionary<System.String,Sandbox.SerializedProperty> Categories`
  - Defined categories to show in the workshop publish modal

## Methods

### Instance methods

- `System.Void AddCategory(System.String name)`
  - Adds a new category associated with the specified enum type to the collection. 
The user will be prompted to select one of the enum values when publishing.
This will be set on the file as keyvalues[name] = enum.ToString()
