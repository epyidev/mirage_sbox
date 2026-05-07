# Sandbox.Project

Represents an on-disk project.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Project()`

## Properties

- `System.Boolean HasCompiler`
  - Whether the project's code has a compiler assigned.
- `System.String ConfigFilePath`
  - Absolute path to the .addon file
- `System.IO.DirectoryInfo RootDirectory`
  - Root directory of this project
- `System.Boolean Active`
  - True if this project is active
- `System.Boolean Pinned`
  - True if this project is pinned, we'll prioritise it when sorting
- `System.DateTimeOffset LastOpened`
  - When did the user last open this project?
- `System.Boolean Broken`
  - True if this project failed to load properly for some reason
- `System.Boolean IsPublished`
  - Returns true if this project has previously been published. This is kind of a guess though
because all it does is look to see if we have a published package cached with the same ident.
- `System.String EditUrl`
  - The URL to the package's page for editing
- `System.String ViewUrl`
  - The URL to the package's page for viewing/linking
- `Sandbox.DataModel.ProjectConfig Config`
  - Configuration of the project.
- `System.Boolean IsTransient`
  - If true this project isn't a 'real' project. It's likely a temporary project created with the
intention to configure and publish a single asset.
- `System.Boolean IsBuiltIn`
  - If true this project isn't a 'real' project. It's likely a temporary project created with the
intention to configure and publish a single asset.
- `Sandbox.Package Package`
  - The package for this project. This is a mock up of the actual package.
- `static Sandbox.Project Current`
  - Current open project.

## Methods

### Static methods

- `static Sandbox.Project Load(System.String dir)`

### Instance methods

- `System.String GetRootPath()`
  - Absolute path to the location of the `.sbproj` file of the project.
- `System.String GetProjectPath()`
  - Gets the .sbproj file for this project
- `System.String GetCodePath()`
  - Absolute path to the Code folder of the project.
- `System.Boolean HasCodePath()`
  - Returns true if the Code path exists
- `System.String GetEditorPath()`
  - Absolute path to the Editor folder of the project.
- `System.Boolean HasEditorPath()`
  - Returns true if the Editor path exists
- `System.String GetAssetsPath()`
  - Absolute path to the Assets folder of the project, or `null` if not set.
- `System.String GetLocalizationPath()`
  - Absolute path to the Localization folder of the project, or `null` if not set.
- `System.Boolean HasAssetsPath()`
  - Returns true if the Assets path exists
- `System.Boolean IsSourcePublish()`
  - Return true if this project type uploads all the source files when it's published
