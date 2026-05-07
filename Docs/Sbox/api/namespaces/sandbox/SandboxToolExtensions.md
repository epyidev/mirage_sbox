# Sandbox.SandboxToolExtensions

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Tools`

## Methods

### Static methods

- `static Editor.Asset[] GetAssets(Sandbox.Project project)`
  - Get all assets in this project
- `static System.Threading.Tasks.Task SetFavouriteAsync(Sandbox.Package package, System.Boolean state)`
  - Mark this package as a favourite
- `static System.Threading.Tasks.Task SetVoteAsync(Sandbox.Package package, System.Boolean up)`
  - Add your vote for this package
- `static System.Threading.Tasks.Task<System.Boolean> UploadFile(Sandbox.Package package, System.String absolutePath, System.String relativePath, Sandbox.Utility.DataProgress.Callback progress, System.Threading.CancellationToken token)`
  - Mark this package as a favourite
- `static System.Threading.Tasks.Task<System.Boolean> UploadFile(Sandbox.Package package, System.Byte[] contents, System.String relativePath, Sandbox.Utility.DataProgress.Callback progress, System.Threading.CancellationToken token)`
  - Upload a file used by this package
- `static System.Threading.Tasks.Task<System.Boolean> UploadVideo(Editor.Asset asset, System.Byte[] contents, System.Boolean isThumbVideo, System.Boolean hidden, System.String tag, Sandbox.Utility.DataProgress.Callback progress, System.Threading.CancellationToken token)`
  - Upload a video for this package
- `static System.Threading.Tasks.Task UpdateValue(Sandbox.Package package, System.String key, System.String value, System.Threading.CancellationToken token)`
  - Update a value on this package
- `static System.Boolean RenderToPixmap(Sandbox.SceneCamera camera, Editor.Pixmap targetPixmap, System.Boolean async)`
  - Render this camera to the target widget. Once you do this the target widget becomes "externally painted", so you
won't be able to paint on it anymore with Qt's Paint stuff.
- `static System.Boolean RenderToPixmap(Sandbox.CameraComponent camera, Editor.Pixmap targetPixmap, System.Boolean async)`
  - Render this camera to the target widget. Once you do this the target widget becomes "externally painted", so you
won't be able to paint on it anymore with Qt's Paint stuff.
- `static System.Boolean RenderToPixmap(Sandbox.Scene scene, Editor.Pixmap targetPixmap, System.Boolean async)`
  - Render this camera to the target widget. Once you do this the target widget becomes "externally painted", so you
won't be able to paint on it anymore with Qt's Paint stuff.
- `static System.Boolean RenderToVideo(Sandbox.SceneCamera camera, Sandbox.VideoWriter videoWriter, System.Nullable<System.TimeSpan> time)`
- `static System.Threading.Tasks.Task<System.Boolean> RenderToVideoAsync(Sandbox.SceneCamera camera, Sandbox.VideoWriter videoWriter, System.Nullable<System.TimeSpan> time)`
- `static Sandbox.SerializedObject GetSerialized(System.Object self)`
  - Shortcut for EditorTypeLibrary.GetSerializedObject( x )
- `static Sandbox.SandboxToolExtensions.PropertyPath FindPathInScene(Sandbox.SerializedProperty prop)`
  - Tries to find the path from a `Sandbox.GameObject` or `Sandbox.Component` to this property.
Returns `null` if not found.
- `static Sandbox.GameObject GetContainingGameObject(Sandbox.SerializedProperty prop)`
  - Tries to find the `Sandbox.GameObject` that contains the given property.
Returns `null` if not found.
- `static System.String ConstructTitle(Sandbox.SelectionSystem sys)`
  - Create a feasible title from the current selection
- `static System.Threading.Tasks.Task WaitForLoadAsync(Sandbox.Resource resource, System.Threading.CancellationToken ct)`
  - Creates a task that completes when `resource` is fully loaded.
- `static System.IDisposable BeginApplyFrame(Sandbox.MovieMaker.MoviePlayer player)`
  - Creates a scope for applying a frame in a `Sandbox.MovieMaker.MoviePlayer`.
Dispose after modifying any properties controlled by the movie.
- `static Sandbox.Bind.Link FromConsoleVariable(Sandbox.Bind.Builder self, System.String name)`
  - Bind the Left hand side to the value of the given console variable.
- `static Sandbox.Bind.Link FromConsoleVariableInt(Sandbox.Bind.Builder self, System.String name)`
  - Bind the Left hand side to the value of the given console variable as an integer.
