# Sandbox.BaseFileSystem

A filesystem. Could be on disk, or in memory, or in the cloud. Could be writable or read only.
Or it could be an aggregation of all those things, merged together and read only.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Filesystem`

## Properties

- `System.Boolean IsValid`
- `System.Boolean IsReadOnly`
  - Returns true if this filesystem is read only

## Fields

- `Zio.IFileSystem system`
- `Zio.IFileSystemWatcher watcher`

## Methods

### Instance methods

- `System.Collections.Generic.IEnumerable<System.String> FindDirectory(System.String folder, System.String pattern, System.Boolean recursive)`
  - Get a list of directories
- `System.Collections.Generic.IEnumerable<System.String> FindFile(System.String folder, System.String pattern, System.Boolean recursive)`
  - Get a list of files
- `System.Void DeleteDirectory(System.String folder, System.Boolean recursive)`
  - Delete a folder and optionally all of its contents
- `System.Void DeleteFile(System.String path)`
  - Delete a file
- `System.Void CreateDirectory(System.String folder)`
  - Create a directory - or a tree of directories.
Returns silently if the directory already exists.
- `System.Boolean FileExists(System.String path)`
  - Returns true if the file exists on this filesystem
- `System.Boolean DirectoryExists(System.String path)`
  - Returns true if the directory exists on this filesystem
- `System.String GetFullPath(System.String path)`
  - Returns the full physical path to a file or folder on disk,
or null if it isn't on disk.
- `System.Void WriteAllText(System.String path, System.String contents)`
  - Write the contents to the path. The file will be over-written if the file exists
- `System.Void WriteAllBytes(System.String path, System.Byte[] contents)`
  - Write the contents to the path. The file will be over-written if the file exists
- `System.String ReadAllText(System.String path)`
  - Read the contents of path and return it as a string.
Returns null if file not found.
- `System.Span<System.Byte> ReadAllBytes(System.String path)`
  - Read the contents of path and return it as a string
- `System.Threading.Tasks.Task<System.Byte[]> ReadAllBytesAsync(System.String path)`
  - Read the contents of path and return it as a string
- `System.Threading.Tasks.Task<System.String> ReadAllTextAsync(System.String path)`
  - Read the contents of path and return it as a string
- `Sandbox.BaseFileSystem CreateSubSystem(System.String path)`
  - Create a sub-filesystem at the specified path
- `System.IO.Stream OpenWrite(System.String path, System.IO.FileMode mode)`
  - Open a file for write. If the file exists we'll overwrite it (by default)
- `System.IO.Stream OpenRead(System.String path, System.IO.FileMode mode)`
  - Open a file for read. Will throw an exception if it doesn't exist.
- `T ReadJson(System.String filename, T defaultValue)`
  - Read Json from a file using System.Text.Json.JsonSerializer. This will throw exceptions
if not valid json.
- `T ReadJsonOrDefault(System.String filename, T returnOnError)`
  - The same as ReadJson except will return a default value on missing/error.
- `System.Void WriteJson(System.String filename, T data)`
  - Convert object to json and write it to the specified file
- `System.Int32 DirectorySize(System.String path, System.Boolean recursive)`
  - Gets the size in bytes of all the files in a directory
- `System.Threading.Tasks.Task<System.UInt64> GetCrcAsync(System.String filepath)`
  - Returns CRC64 of the file contents.
  - `filepath`: File path to the file to get CRC of.
  - returns: The CRC64, or 0 if file is not found.
- `System.UInt64 GetCrc(System.String filepath)`
  - Returns CRC64 of the file contents.
  - `filepath`: File path to the file to get CRC of.
  - returns: The CRC64, or 0 if file is not found.
- `System.Int64 FileSize(System.String filepath)`
  - Returns file size of given file.
  - `filepath`: File path to the file to look up size of.
  - returns: File size, in bytes.
