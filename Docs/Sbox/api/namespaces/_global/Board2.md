# Sandbox.Services.Leaderboards.Board2

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Services.Leaderboards`

## Constructors

- `Board2(System.String package, System.String name)`

## Properties

- `System.String Stat`
- `System.Int64 TargetSteamId`
  - The steamid to get information about. If unset then this defaults to the current player.
- `System.Int32 MaxEntries`
  - The maximum entries to respond with.
- `System.Int32 Offset`
  - The offset to start at. If less than 0, we will start from the bottom.
- `System.Int64 TotalEntries`
  - The total number of chart entries for this board.
- `System.String TimePeriodDescription`
  - If you are restructing by time period, this is the name of the period
- `Sandbox.Services.Leaderboards.Board2.Entry[] Entries`
  - The group of entries for this board. This is usually the entries that surround
the TargetSteamId.

## Methods

### Instance methods

- `System.Void SetAggregationSum()`
- `System.Void SetAggregationAvg()`
- `System.Void SetAggregationMin()`
- `System.Void SetAggregationMax()`
- `System.Void SetAggregationLast()`
- `System.Void SetSortAscending()`
- `System.Void SetSortDescending()`
- `System.Void SetFriendsOnly(System.Boolean friendsOnly)`
- `System.Void SetCountryCode(System.String countryCode)`
- `System.Void SetCountryAuto()`
- `System.Void FilterByYear()`
- `System.Void FilterByMonth()`
- `System.Void FilterByWeek()`
- `System.Void FilterByDay()`
- `System.Void FilterByNone()`
- `System.Void SetDatePeriod(System.DateTime dateTime)`
- `System.Void CenterOnSteamId(System.Int64 steamid)`
  - Center the results on this steamid, show the surrounding results with this in the middle.
- `System.Void CenterOnMe()`
  - Center the results on you, show the surrounding results with you in the middle.
- `System.Void IncludeSteamIds(System.Int64[] steamids)`
  - If they have any results, include these steamids in the results - regardless of their position.
- `System.Threading.Tasks.Task Refresh(System.Threading.CancellationToken cancellation)`
