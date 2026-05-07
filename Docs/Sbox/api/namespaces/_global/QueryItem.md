# Sandbox.Storage.QueryItem

Details about a UGC item returned from a Steam Workshop query

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Storage`

## Constructors

- `QueryItem()`

## Properties

- `System.UInt64 Id`
- `System.String Title`
- `System.String Description`
- `System.Int32 Visibility`
- `System.Boolean Banned`
- `System.Boolean Accepted`
- `System.UInt64 FileHandle`
- `System.String Preview`
- `System.String Filename`
- `System.UInt64 Size`
- `System.String Url`
- `System.Int32 VotesUp`
- `System.Int32 VotesDown`
- `System.Single Score`
- `System.String Metadata`
- `Sandbox.Services.Players.Profile Owner`
- `System.DateTimeOffset Created`
- `System.DateTimeOffset Updated`
- `System.Collections.Generic.List<System.String> Tags`
- `System.Collections.Generic.Dictionary<System.String,System.String> KeyValues`

## Methods

### Instance methods

- `System.Threading.Tasks.Task<Sandbox.Storage.Entry> Install(System.Threading.CancellationToken token)`
  - Install this item. This can return null if it's not of the right format.
