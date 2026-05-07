# Editor.Asset.ThumbnailRendererAttribute

Should target a static method like 
`public static Pixmap RenderThumbnail( Asset thumbnail )`
where the method returns a thumbnail for that asset type. 
This kind of sucks I don't like it.

- **Kind:** attribute
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Base:** `System.Attribute`
- **Declaring type:** `Editor.Asset`

## Constructors

- `ThumbnailRendererAttribute()`

## Properties

- `System.Int32 Priority`
  - The priority of this callback. Higher gets called first.
