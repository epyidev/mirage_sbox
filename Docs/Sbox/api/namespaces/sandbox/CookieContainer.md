# Sandbox.CookieContainer

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `System.Void SetString(System.String key, System.String value)`
  - Set a cookie to be stored between sessions. The cookie will expire one month
from when it was set.
- `System.String GetString(System.String key, System.String fallback)`
  - Get a stored session cookie.
- `System.Boolean TryGetString(System.String key, System.String val)`
  - Get a stored session cookie.
- `System.Boolean TryGet(System.String key, T val)`
- `T Get(System.String key, T fallback)`
  - Load JSON encodable data from cookies
- `System.Void Set(System.String key, T value)`
  - Set JSON encodable object to data
- `System.Void Remove(System.String key)`
  - Removes a cookie from the cache entirely
