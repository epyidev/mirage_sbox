# Editor.EditorUtility

- **Kind:** static class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `static System.Object InspectorObject`
  - Set the object to be inspected by the inspector.
- `static System.Boolean IsVulkan`
  - Used for shadergraph
- `static System.Boolean IsRecordingVideo`
  - True if we're currently recording a video (using the video command, or F6)
- `static System.Collections.Generic.IEnumerable<System.String> FontFamilies`
- `static Sandbox.Engine.Settings.RenderSettings RenderSettings`
  - Access to the client's render settings

## Methods

### Static methods

- `static System.Threading.Tasks.Task<System.String> TranslateString(System.String input, System.String language)`
  - Translate input into language
- `static Sandbox.Utility.FloatBitmap LoadBitmap(System.String filename)`
  - Load a float bitmap. This is usually a png, tga, exr, psd
- `static Editor.Asset CreateModelFromMeshFile(Editor.Asset meshFile, System.String targetAbsolutePath)`
  - Create a vmdl file from a mesh. Will return non null if the asset was created successfully
- `static Editor.Asset CreateModelFromPolygonMeshes(Sandbox.PolygonMesh[] polygonMeshes, System.String targetAbsolutePath)`
  - Create a vmdl file from polygon meshes. Will return non null if the asset was created successfully
- `static Editor.Asset CreateModelFromMeshComponents(Sandbox.MeshComponent[] meshComponents, System.String targetAbsolutePath)`
  - Create a vmdl file from mesh components. Will return non null if the asset was created successfully.
The model's origin will be placed at the first mesh component's position.
- `static System.Void AddLogger(System.Action<Sandbox.LogEvent> logger)`
- `static System.Void RemoveLogger(System.Action<Sandbox.LogEvent> logger)`
- `static Sandbox.ConCmdAttribute.AutoCompleteResult[] AutoComplete(System.String text, System.Int32 maxCount)`
- `static System.Collections.Generic.HashSet<Sandbox.Internal.IPanel> GetRootPanels()`
  - Get all the root panels.
- `static System.Void SendToRecycleBin(System.String filename)`
- `static System.Void OpenFolder(System.String path)`
  - Open a folder (or url)
- `static System.Void OpenFile(System.String path)`
  - Open a folder (or url)
- `static System.Void OpenFileFolder(System.String filepath)`
  - Open given file's folder in OS file explorer and select given file.
- `static System.Void MoveAssetToDirectory(Editor.Asset asset, System.String directory, System.Boolean overwrite)`
  - Moves an asset's source and compiled files to a directory (if they exist)
- `static System.Void RenameDirectory(System.String directory, System.String newDirectory, System.Boolean recursive)`
- `static System.Boolean RenameAsset(Editor.Asset asset, System.String newName)`
  - Moves a file to the same directory but gives it a new name
- `static System.Void CopyAssetToDirectory(Editor.Asset asset, System.String directory, System.Boolean overwrite)`
  - Copies an asset's source and compiled files to a directory (if they exist)
- `static System.Threading.Tasks.Task<System.Boolean> PutAsync(System.IO.Stream fileStream, System.String endpoint, Sandbox.Utility.DataProgress.Callback progress, System.Threading.CancellationToken token)`
- `static System.Threading.Tasks.Task<System.Boolean> DownloadAsync(System.String url, System.String targetfile, Sandbox.Utility.DataProgress.Callback progress, System.Threading.CancellationToken token)`
- `static Sandbox.SceneWorld CreateSceneWorld()`
- `static System.Void StopAssetSound()`
  - Stop a sound playing from an asset preview
- `static System.Boolean PlayAssetSound(Editor.Asset asset)`
  - Plays an asset sound in 2d space
- `static System.Boolean PlayAssetSound(Sandbox.SoundEvent file)`
  - Plays an asset sound in 2d space
- `static System.Boolean PlayAssetSound(Sandbox.SoundFile file)`
  - Plays an asset sound in 2d space
- `static Sandbox.SoundHandle PlaySound(System.String sound, System.Single startTime)`
  - Plays a sound event
- `static System.Boolean PlayRawSound(System.String file)`
  - Plays a sound via the OS, which is the way you play a sound if you
want it to be heard when the game is tabbed away
- `static System.Void ClearPackageCache()`
  - Delete the cached package info. This will cause any future requests to get fresh information
from the backend. This is useful if you just updated something and want to see the changes.
- `static Sandbox.WebSurface CreateWebSurface()`
  - Create an unlimited web surface
- `static Sandbox.SerializedObject GetSerializedObject(System.Object obj)`
  - Get a serialized object for this object. Because you're in the editor, this is an
unrestricted object, we aren't whitelisting or using TypeLibrary.
- `static Sandbox.VideoWriter CreateVideoWriter(System.String path, Sandbox.VideoWriter.Config config)`
  - Create a video writer
- `static System.IDisposable DisableTextureStreaming()`
  - Force textures to load fully when loading a model etc..
- `static System.Void Quit(System.Boolean toLauncher)`
  - Quit the whole engine
  - `toLauncher`: Open the launcher on exit, if it's not already open.
- `static System.Void DisplayDialog(System.String title, System.String message, System.String okay, System.String icon, Editor.Widget parent)`
  - Display a modal dialog message. This is a blocking call.
- `static System.Void DisplayDialog(System.String title, System.String message, System.String noLabel, System.String yesLabel, System.Action action, System.String icon, Editor.Widget parent)`
  - Display a modal dialog message. This is a blocking call.
- `static Editor.Widget OpenControlSheet(Sandbox.SerializedObject so, Editor.Widget parent, System.Boolean createWindow)`
  - Show a popup control sheet for this. You should set parent to the control from this this sheet is created.
If you do that properly, when that control is deleted, this popup will get deleted too. If you set it to null
then the control sheet will stay open until it's closed.
- `static System.String GetSearchPaths()`
  - Gets every search path seperated by ;
- `static System.String KeyValues3ToJson(System.String kvString)`
  - Some assets are kv3, we want to convert them to json
- `static System.String KeyValues1ToJson(System.String kvString)`
  - Some old ass assets are keyvalues (1). Convert them to Json so we can use them.
- `static Editor.Pixmap GetFileThumbnail(System.String filePath, System.Int32 width, System.Int32 height)`
- `static System.Void RestartEditor()`
  - Restarts the editor with the same project.
- `static System.Void RestartEditorPrompt(System.String message, System.String title)`
  - Open a dialog prompt asking the user to restart the editor.
- `static System.Boolean IsCodeFolder(System.String fullPath)`
  - Checks if a given folder is a code folder, e.g. [project root]/Code
- `static System.Boolean IsCodeFile(System.String fullPath)`
  - Checks if a given file is a code file
- `static Facepunch.ActionGraphs.ISourceLocation GetSourceLocation(Sandbox.Scene scene)`
  - Gets the source location for the given scene, used by action graph stack traces,
and so the action graph editor knows which asset to save when editing a graph.
- `static Sandbox.Project FindProjectByDirectory(System.String fullPath)`
  - Tries to find a project based on a given directory.
- `static Sandbox.GameObjectSystem GetGameObjectSystem(Sandbox.Scene scene, Sandbox.TypeDescription fromType)`
  - Gets a GameObjectSystem from its type
- `static System.Threading.Tasks.Task<Sandbox.Engine.Shaders.ShaderCompile.Results> CompileShader(System.String localPath, Sandbox.Engine.Shaders.ShaderCompileOptions options, System.Threading.CancellationToken token)`
  - Compile a fucking shader. Takes a .shader file and compiles it.
- `static System.Threading.Tasks.Task<Sandbox.Engine.Shaders.ShaderCompile.Results> CompileShader(Sandbox.BaseFileSystem fs, System.String localPath, Sandbox.Engine.Shaders.ShaderCompileOptions options, System.Threading.CancellationToken token)`
- `static Editor.Asset GetAssetFromProject(Sandbox.Project project)`
- `static System.Void FindInScene(Sandbox.Component component)`
  - Finds a component in the scene and selects it in the editor
- `static System.Void FindInScene(Sandbox.GameObject go)`
  - Finds a GameObject in the scene and selects it in the editor
- `static System.String SaveFileDialog(System.String title, System.String extension, System.String defaultPath)`
  - Open a file save dialog. Returns null on cancel, else the absolute path of the target file.
- `static System.String OpenFileDialog(System.String title, System.String extension, System.String defaultPath)`
  - Open a file open dialog. Returns null on cancel, else the absolute path of the target file.
- `static T LoadProjectSettings(System.String filename)`
  - Load a project settings file
- `static System.Void SaveProjectSettings(T data, System.String filename)`
  - Save a project settings file
