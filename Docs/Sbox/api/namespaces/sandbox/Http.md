# Sandbox.Http

Lets your game make async HTTP requests.

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static System.Boolean IsAllowed(System.Uri uri)`
  - Check if the given Uri matches the following requirements:
1. Scheme is https/http or wss/ws
2. If it's localhost, only allow ports 80/443/8080/8443
3. Not an ip address
  - `uri`: The Uri to check.
  - returns: True if the Uri can be accessed, false if the Uri will be blocked.
- `static System.Boolean IsHeaderAllowed(System.String header)`
  - Checks if a given header is allowed to be set.
  - `header`: The header name to check.
  - returns: True if the header is allowed to be set.
- `static System.Threading.Tasks.Task<System.String> RequestStringAsync(System.String requestUri, System.String method, System.Net.Http.HttpContent content, System.Collections.Generic.Dictionary<System.String,System.String> headers, System.Threading.CancellationToken cancellationToken)`
- `static System.Threading.Tasks.Task<System.Byte[]> RequestBytesAsync(System.String requestUri, System.String method, System.Net.Http.HttpContent content, System.Collections.Generic.Dictionary<System.String,System.String> headers, System.Threading.CancellationToken cancellationToken)`
- `static System.Threading.Tasks.Task<System.IO.Stream> RequestStreamAsync(System.String requestUri, System.String method, System.Net.Http.HttpContent content, System.Collections.Generic.Dictionary<System.String,System.String> headers, System.Threading.CancellationToken cancellationToken)`
- `static System.Threading.Tasks.Task<T> RequestJsonAsync(System.String requestUri, System.String method, System.Net.Http.HttpContent content, System.Collections.Generic.Dictionary<System.String,System.String> headers, System.Threading.CancellationToken cancellationToken)`
- `static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> RequestAsync(System.String requestUri, System.String method, System.Net.Http.HttpContent content, System.Collections.Generic.Dictionary<System.String,System.String> headers, System.Threading.CancellationToken cancellationToken)`
- `static System.Net.Http.HttpContent CreateJsonContent(T target)`
  - Creates a new `System.Net.Http.HttpContent` instance containing the specified object serialized to JSON.
