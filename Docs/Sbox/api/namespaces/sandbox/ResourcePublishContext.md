# Sandbox.ResourcePublishContext

Created by the editor when publishing a resource, passed into Resource.ConfigurePublishing. This allows
the resource to configure how it wants to be published.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ResourcePublishContext()`

## Properties

- `System.Boolean PublishingEnabled`
  - Can be set to false using SetPublishingDisabled
- `System.String ReasonForDisabling`
  - If publishing is disabled this will be the message to display why.
- `System.Func<Sandbox.Bitmap> CreateThumbnailFunction`
  - A function to create a thumbnail for this resource. If not null, this will be called to create the thumbnail.
- `System.Boolean IncludeCode`
  - If true we'll include the addon's code with this
- `System.Boolean CanIncludeSourceFiles`
  - If true then we'll offer an option to upload source files with this asset. This will make it easier for people
who want to download and add it to their project, but make their own changes.

## Methods

### Instance methods

- `System.Void SetPublishingDisabled(System.String reason)`
  - Allows you to disable publishing for this resource, with a reason that'll be shown
to the user.
