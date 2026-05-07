# Editor.Asset

- **Kind:** abstract class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `Editor.Asset.AssetTags Tags`
  - Tags for this asset, for filtering purposes in the Asset Browser.
- `System.String Name`
  - Name of the asset, usually the filename.
- `System.String Path`
  - The relative path with the asset extension. ie .wav becomes .vsnd
- `System.String RelativePath`
  - The relative path as it is on disk (ie .wav not .vsnd)
- `System.String AbsolutePath`
  - The absolute path as it is on disk (ie .wav not .vsnd)
- `System.Nullable<System.DateTime> LastOpened`
  - When the asset was last opened through the editor.
- `Editor.AssetType AssetType`
  - The type of this asset.
- `Sandbox.Package Package`
  - If this asset was downloaded from sbox.game then this will
be the package from which this asset was downloaded. If not then
it'll be null.
- `System.Boolean IsDeleted`
  - Whether the asset is deleted or not.
This can happen after `Editor.Asset.Delete` was called on it, or `Editor.Asset.AbsolutePath` is empty.
- `System.Boolean IsProcedural`
  - If true then this asset is generated at runtime somehow. Possibly from a mount system.
- `System.Boolean IsTransient`
  - This asset is generated in the transient folder. You don't need to see it, or keep it around. It will re-generate from something else.
- `System.Boolean IsCloud`
  - This asset is from the cloud, it's in the cloud folder
- `System.Boolean IsTrivialChild`
  - The asset was generated from another asset compile and has no source asset of its own. For example model break gibs .vmdl, .vtex files for materials, etc.
- `System.Boolean CanRecompile`
  - Can this asset be recompiled?
- `System.Boolean HasCachedThumbnail`
- `Editor.MetaData MetaData`
  - Asset type specific key-value based data storage.
- `System.Boolean IsCompiled`
  - Whether the asset is compiled.
- `System.Boolean IsCompiledAndUpToDate`
  - Whether the asset is compiled and all dependencies are up to date. (Slower than IsCompiled)
- `System.Boolean IsCompileFailed`
  - Whether the asset failed to compile.
- `System.Boolean HasSourceFile`
  - True if we have a source file, and aren't just a _c file
- `System.Boolean HasCompiledFile`
  - True if we have a compiled file, and aren't just a source file
- `System.Boolean HasUnsavedChanges`
  - A free-use variable for the editor to use to portray that this asset
somehow has changes that need to be saved to disk.
- `Editor.Asset.PublishSettings Publishing`
  - Access the asset publisher config.

## Methods

### Instance methods

- `System.Void LoadUserTags()`
- `System.Void Delete()`
  - Delete this asset. Will send the source and compiled files to the recycle bin.
- `virtual System.String GetCompiledFile(System.Boolean absolute)`
  - Returns the compiled file path, if the asset is compiled.
  - `absolute`: Whether the path should be absolute or relative.
  - returns: The compiled file path, or null if the asset was not compiled.
- `virtual System.String GetSourceFile(System.Boolean absolute)`
  - Returns the source file path, if the sources are present.
  - `absolute`: Whether the path should be absolute or relative.
  - returns: The source file path, or null if the source files are not present.
- `Editor.Pixmap GetAssetThumb(System.Boolean generateIfNotInCache)`
  - Returns the asset preview thumbnail, with fallback to the asset type icon if there is no preview.
- `System.Void CancelThumbBuild()`
- `virtual System.String FindStringEditInfo(System.String name)`
- `System.Void RebuildThumbnail(System.Boolean startBuild)`
  - Delete existing cached thumbnail, optionally queuing for building a new one ASAP.
  - `startBuild`: Queue building the new thumbnail ASAP, as opposed to waiting when it is actually needed and doing it then.
- `virtual System.Void OpenInEditor(System.String nativeEditor)`
  - Try to open this asset in a supported editor.
You can specify nativeEditor to open in a specific editor.
  - `nativeEditor`: A native editor specified in enginetools.txt (e.g modeldoc_editor, hammer, pet..)
- `virtual System.Collections.Generic.List<Editor.Asset> GetReferences(System.Boolean deep)`
  - Returns assets that this asset references/uses.
  - `deep`: Whether to recurse. For example, will also include textures referenced by the materials used by this model asset, as opposed to returning just the materials.
- `virtual System.Collections.Generic.List<Editor.Asset> GetDependants(System.Boolean deep)`
  - Returns assets that depend/use this asset.
  - `deep`: Whether to recurse. For example, will also include maps that are using models which use this material asset, as opposed to returning just the models.
- `virtual System.Collections.Generic.List<Editor.Asset> GetParents(System.Boolean deep)`
  - Returns assets that are parents of this asset (i.e. this asset is a compiled child resource of the returned assets).
  - `deep`: Whether to recurse up the parent chain.
- `virtual System.Collections.Generic.List<System.String> GetAdditionalContentFiles()`
  - Gets additional content-side related files. This includes like .rect files for materials, all .fbx and .lxo files for models, etc.
- `virtual System.Collections.Generic.List<System.String> GetAdditionalGameFiles()`
  - Gets additional game-side files to be packaged (e.g. navdata). These are files that are loaded by managed code, not as native resources.
- `virtual System.Collections.Generic.List<System.String> GetInputDependencies()`
  - Gets input dependencies for an asset. This'll be tga's for a texture and stuff like that.
- `virtual System.Collections.Generic.List<System.String> GetUnrecognizedReferencePaths()`
  - Unrecognized reference paths listed by the data that could not be resolved into Asset*s
- `virtual System.Boolean Compile(System.Boolean full)`
  - Forcibly recompile the asset.
  - `full`: TODO
- `System.Threading.Tasks.Task DumpThumbnail()`
  - Renders the thumbnail and then saves it to disk.
- `System.Threading.Tasks.Task<Editor.Pixmap> RenderThumb()`
  - Immediately render a preview thumbnail for this asset, and return it.
  - returns: The rendered preview thumbnail, or null if asset type does not support previews.
- `virtual Sandbox.Model GetPreviewModel()`
  - Try to create a preview model if we're fbx, obj, etc
- `Sandbox.Resource LoadResource()`
  - Try to load this asset as an automatically determined resource type.
If this isn't a resource type (like an Image) then it will return null.
- `T LoadResource()`
  - Try to load this asset as a `Sandbox.Resource` of given type.
  - returns: The loaded `Sandbox.Resource` instance of given type, or null on failure.
- `Sandbox.Resource LoadResource(System.Type resourceType)`
  - Try to load this asset as a `Sandbox.Resource` of given type.
  - returns: The loaded `Sandbox.Resource` instance of given type, or null on failure.
- `System.Boolean TryLoadResource(T obj)`
  - Try to load this asset as a `Sandbox.Resource` of given type.
  - `obj`: Output resource on success, null on failure.
  - returns: true if `obj` was successfully set.
- `System.String ReadJson()`
  - Try to get the raw Json string, for a managed asset type (a GameResource)
- `virtual System.Boolean SaveToDisk(Sandbox.GameResource obj)`
  - Save a game resource instance to disk. This is used internally by asset inspector and for asset creation.
  - `obj`: The instance data to save.
  - returns: Whether the instance was successfully saved or not.
- `virtual System.Void RecordOpened()`
  - Tell asset system that this asset was opened. Sticks it on the recent opened list.
- `virtual System.Threading.Tasks.ValueTask<System.Boolean> CompileIfNeededAsync(System.Single timeout)`
  - Returns a task that will resolve when the asset is compiled. If the asset is already compiled, do nothing. Does not support maps.
  - returns: true if the compile was needed, and was successful.
- `System.Void OverrideThumbnail(Editor.Pixmap pixmap)`
  - Override the Assets thumbnail with given one.
- `virtual System.Boolean SetInMemoryReplacement(System.String sourceData)`
  - Set data for this asset which will be compiled in memory. This is used to preview
asset changes (like materials) before committing to disk.
- `virtual System.Void ClearInMemoryReplacement()`
  - Reverse the changes of SetInMemoryReplacement
