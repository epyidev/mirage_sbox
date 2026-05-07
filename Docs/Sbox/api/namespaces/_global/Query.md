# Sandbox.Storage.Query

Query the Steam Workshop for items

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Storage`

## Constructors

- `Query()`

## Properties

- `System.Collections.Generic.List<System.UInt64> FileIds`
  - Specific workshop file IDs to query. When set, other filters are ignored
and the query returns details for these specific items.
- `System.Collections.Generic.HashSet<System.String> TagsRequired`
  - Tags that the item must have all of to be included in results.
- `System.Collections.Generic.HashSet<System.String> TagsExcluded`
  - Tags that the item must not have any of to be included in results.
- `System.Collections.Generic.Dictionary<System.String,System.String> KeyValues`
  - KeyValues that the item must match to be included in results.
- `System.String SearchText`
  - Search Text
- `System.Int32 MaxCacheAge`
  - Max Cache Age in seconds
- `Sandbox.Storage.SortOrder SortOrder`
  - Sort Order
- `Sandbox.SteamId Author`
  - Filter results to items published by this Steam ID. When set, uses
a user-specific query instead of a global one.
- `System.Int32 RankTrendDays`
  - Number of days to consider for rank trend calculations

## Methods

### Instance methods

- `System.Threading.Tasks.Task<Sandbox.Storage.QueryResult> Run(System.Threading.CancellationToken token)`
  - Run the query
