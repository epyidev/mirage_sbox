# Sandbox.Storage.QueryResult

The results of a Steam Workshop query

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Storage`

## Constructors

- `QueryResult()`

## Properties

- `System.Int32 ResultCount`
- `System.Int32 TotalCount`
- `System.String NextCursor`
- `System.Collections.Generic.List<Sandbox.Storage.QueryItem> Items`

## Methods

### Instance methods

- `System.Boolean HasMoreResults()`
  - Returns true if there are more results to be fetched
- `System.Threading.Tasks.Task<Sandbox.Storage.QueryResult> GetNextResults(System.Threading.CancellationToken token)`
  - Get the next set of results from the query. Returns null if none.
