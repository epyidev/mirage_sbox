# Editor.IAssetEditor

A widget (usually window) implementing this will be able to edit assets via the asset browser.
The widget should be marked with the attribute of the asset's extension, like this `[CanEdit( "asset:vsndstck" )]`

- **Kind:** interface
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `System.Boolean CanOpenMultipleAssets`
  - If this editor is able to edit multiple assets at the same time then return true
and we'll try to create only one version of that editor and AssetOpen will be called multiple times.

## Fields

- `static System.Collections.Generic.Dictionary<System.String,Editor.IAssetEditor> OpenMultiAssetEditors`
  - A list of open editors that support multiple assets at once.
- `static System.Collections.Generic.Dictionary<System.String,Editor.IAssetEditor> OpenSingleEditors`
  - A list of open editors for individual assets.

## Methods

### Static methods

- `static System.Boolean OpenInEditor(Editor.Asset asset, Editor.IAssetEditor editor)`
  - Open given asset in a new asset editor window. Will reuse already open editors for same asset type if the editor supports it. (`Editor.IAssetEditor.CanOpenMultipleAssets`)
  - returns: Whether an asset editor was found for given asset.
- `static System.Boolean TryOpenUsingStaticMethod(Editor.Asset asset)`

### Instance methods

- `virtual System.Void AssetOpen(Editor.Asset asset)`
  - Open the asset in this editor.
- `virtual System.Void SelectMember(System.String memberName)`
