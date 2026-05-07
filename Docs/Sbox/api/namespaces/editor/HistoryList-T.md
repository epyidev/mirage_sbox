# Editor.HistoryList<T>

A helper class to store a list of strings, which can then be navigated around, saved, restored

- **Kind:** sealed class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Constructors

- `HistoryList<T>()`

## Properties

- `System.Int32 MaxItems`
  - The maximum history length
- `System.Boolean Debug`
  - Print debug information on navigation
- `T Current`
- `System.String StateCookie`
- `System.Boolean CanGoBack`
- `System.Boolean CanGoForward`

## Fields

- `System.Action<T> OnNavigate`
  - Called when navigations successfully happened.

## Methods

### Instance methods

- `System.Void Clear()`
- `System.Void Add(T text)`
- `System.Boolean Navigate(System.Int32 delta)`
  - Navigate to delta positions from the current position. For example, -1 is backwards.
Returns false if nothing changed.
