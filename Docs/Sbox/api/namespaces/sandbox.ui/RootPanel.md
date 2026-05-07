# Sandbox.UI.RootPanel

A root panel. Serves as a container for other panels, handles things such as rendering.

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.UI.Panel`

## Constructors

- `RootPanel()`

## Properties

- `Sandbox.Rect PanelBounds`
  - Bounds of the panel, i.e. its size and position on the screen.
- `System.Single Scale`
  - The scale of this panel and its children.
- `System.Boolean RenderedManually`
  - If set to true this panel won't be rendered to the screen like a normal panel.
This is true when the panel is drawn via other means (like as a world panel).
- `System.Boolean IsWorldPanel`
  - True if this is a world panel, so should be skipped when determining cursor visibility etc
- `System.Boolean IsVR`
  - If this panel belongs to a VR overlay
- `System.Boolean IsHighQualityVR`
  - If this panel should be rendered with ~4K resolution.

## Methods

### Instance methods

- `virtual System.Void Delete(System.Boolean immediate)`
- `virtual System.Void OnDeleted()`
- `virtual System.Void UpdateBounds(Sandbox.Rect rect)`
  - Called before layout to lock the bounds of this root panel to the screen size (which is passed).
Internally this sets PanelBounds to rect and calls UpdateScale.
- `virtual System.Void UpdateScale(Sandbox.Rect screenSize)`
  - Work out scaling here. Default is to scale relative to the screen being
1920 wide. ie - scale = screensize.Width / 1920.0f;
- `virtual System.Void OnLayout(Sandbox.Rect layoutRect)`
- `System.Void RenderManual(System.Single opacity)`
  - Render this panel manually. This gives more flexibility to where UI is rendered, to texture for example.
`Sandbox.UI.RootPanel.RenderedManually` must be set to true.
