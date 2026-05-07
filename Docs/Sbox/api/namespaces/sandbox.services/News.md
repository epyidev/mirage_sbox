# Sandbox.Services.News

News Posts

- **Kind:** sealed class
- **Namespace:** `Sandbox.Services`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `News()`

## Properties

- `System.Guid Id`
- `System.DateTimeOffset Created`
- `System.String Title`
- `System.String Summary`
- `System.String Url`
- `Sandbox.Services.Players.Profile Author`
- `Sandbox.Package Package`
- `System.String Media`

## Methods

### Static methods

- `static System.Threading.Tasks.Task<Sandbox.Services.News[]> GetPlatformNews(System.Int32 take, System.Int32 skip)`
- `static System.Threading.Tasks.Task<Sandbox.Services.News[]> GetPackageNews(System.String package, System.Int32 take, System.Int32 skip)`
- `static System.Threading.Tasks.Task<Sandbox.Services.News[]> GetOrganizationNews(System.String org, System.Int32 take, System.Int32 skip)`
- `static System.Threading.Tasks.Task<Sandbox.Services.News[]> GetNews(System.Int32 take, System.Int32 skip)`
