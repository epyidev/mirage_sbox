# Sandbox.KeyStore

Allows storing files by hashed keys, rather than by actual filename. This is sometimes useful.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static Sandbox.KeyStore CreateGlobalCache()`
  - Creates a keystore which is in a global cache position. The folder can be 
deleted at any time, and it's all fine and no-one cares.

### Instance methods

- `System.Void Set(System.String key, System.Byte[] data)`
  - Store a bunch of bytes
- `System.Byte[] Get(System.String key)`
  - Get stored bytes, or return null
- `System.Boolean TryGet(System.String key, System.Byte[] data)`
  - Get stored bytes, or return false
- `System.Boolean Exists(System.String key)`
  - Check if a key exists
- `System.Void Remove(System.String key)`
  - Remove a key
