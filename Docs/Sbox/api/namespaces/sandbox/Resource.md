# Sandbox.Resource

A resource loaded in the engine, such as a `Sandbox.Model` or `Sandbox.Material`.

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Resource()`

## Properties

- `System.Int32 ResourceId`
  - ID of this resource,
- `System.String ResourcePath`
  - Path to this resource.
- `System.String ResourceName`
  - File name of the resource without the extension.
- `System.Boolean IsValid`
- `System.Boolean HasUnsavedChanges`
  - True if this resource has been changed but the changes aren't written to disk
- `System.Nullable<Sandbox.Resources.EmbeddedResource> EmbeddedResource`
  - Embedded data for this resource

## Methods

### Static methods

- `static Sandbox.Bitmap CreateSimpleAssetTypeIcon(System.String icon, System.Int32 width, System.Int32 height, System.Nullable<Color> background, System.Nullable<Color> foreground)`

### Instance methods

- `Sandbox.Bitmap GetAssetTypeIcon(System.Int32 width, System.Int32 height)`
  - Get the icon for this type of asset. This is an icon that is shown in the editor.
- `virtual Sandbox.Bitmap CreateAssetTypeIcon(System.Int32 width, System.Int32 height)`
  - Create an icon for this type of asset. This is an icon that is shown in the editor.
- `virtual System.Void Finalize()`
- `virtual System.Void StateHasChanged()`
  - Should be called after the resource has been edited by the inspector
- `virtual System.Void ConfigurePublishing(Sandbox.ResourcePublishContext context)`
  - When publishing an asset we'll call into this method to allow the resource to configure how it wants to be published.
This allows your resource to make bespoke decisions to configure publishing based on its content.
- `virtual Sandbox.Bitmap RenderThumbnail(Sandbox.Resource.ThumbnailOptions options)`
  - Render a thumbnail for this specific resource.
