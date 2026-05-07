# Sandbox.FileSystem

A filesystem that can be accessed by the game.

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static Sandbox.BaseFileSystem Mounted`
  - All mounted content.
- `static Sandbox.BaseFileSystem Data`
  - A subset of `Sandbox.FileSystem.OrganizationData` for custom gamemode data.
- `static Sandbox.BaseFileSystem OrganizationData`
  - A filesystem for custom data, per gamemode's organization.

## Fields

- `static Sandbox.KeyStore Cache`
  - A cached keystore that can be used for anything. This is stored in a global cache folder, and may be deleted at any time.

## Methods

### Static methods

- `static System.String NormalizeFilename(System.String filepath)`
  - Normalizes given file path so the game's filesystem can understand it. Fixes slashes and lowercases the file path.
  - `filepath`: The file path to normalize
  - returns: The normalized file path
- `static Sandbox.BaseFileSystem CreateMemoryFileSystem()`
  - Create a filesystem that exists only in memory
