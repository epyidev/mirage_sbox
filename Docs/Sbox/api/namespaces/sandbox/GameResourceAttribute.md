# Sandbox.GameResourceAttribute

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.AssetTypeAttribute`

## Constructors

- `GameResourceAttribute(System.String title, System.String extension, System.String description)`

## Properties

- `System.String Icon`
  - Icon to be used for this asset
Can be an absolute path of a PNG
Or a <a href="https://fonts.google.com/icons">material icon</a> for this game resource's thumbnail.
- `System.String IconBgColor`
  - Background color for this resource's thumbnail.
- `System.String IconFgColor`
  - Foreground color (icon color) for this resource's thumbnail.
- `System.Boolean CanEmbed`
  - Can this GameResource be an embedded resource?
Allows the ability to edit a resource inline instead of saving it to a specific file.
- `System.String Description`
  - Description of this game resource. This is obsolete, we'll use the xml summary description.
