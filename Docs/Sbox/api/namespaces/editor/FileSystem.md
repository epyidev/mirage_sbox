# Editor.FileSystem

A filesystem that can be accessed by the game.

- **Kind:** static class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `static Sandbox.BaseFileSystem Mounted`
  - Paths from tool addons which are mounted.
- `static Sandbox.BaseFileSystem Root`
  - Root of the game's folder.
- `static Sandbox.BaseFileSystem Temporary`
  - The engine /game/.source2/ folder for temporary files and caches.
- `static Sandbox.BaseFileSystem Config`
  - The engine /game/config/ folder
- `static Sandbox.BaseFileSystem WebCache`
  - The engine /game/.source2/http/ folder.
- `static Sandbox.BaseFileSystem ProjectTemporary`
  - The current project's .sbox/ folder for temporary files and caches.
- `static Sandbox.BaseFileSystem Cloud`
  - The current project's .sbox/cloud/ folder. We download files from sbox.game right into this filesystem.
- `static Sandbox.BaseFileSystem Transient`
  - The current project's .sbox/transient/ folder. This is where assets are created at runtime. These are assets
that are created by another asset,that don't need to be stored in source control or anything - because they
can get re-created at will.
- `static Sandbox.BaseFileSystem Content`
  - Content from active addons (and content paths)
- `static Sandbox.BaseFileSystem ProjectSettings`
  - The current project's ProjectSettings folder
- `static Sandbox.BaseFileSystem Libraries`
  - The current project's Libraries folder
- `static Sandbox.BaseFileSystem Localization`
  - The current project's Localization folder

## Methods

### Static methods

- `static System.Void SuppressNextHotload()`
  - Stop the game from triggering a hotload for this file - because presumably you have
already reloaded it.
