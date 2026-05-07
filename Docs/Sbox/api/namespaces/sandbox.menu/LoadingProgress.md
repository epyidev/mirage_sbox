# Sandbox.Menu.LoadingProgress

- **Kind:** struct
- **Namespace:** `Sandbox.Menu`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.String Title`
- `System.Double Fraction`
  - A value between 0 and 1, to show a progress bar
- `System.Double Mbps`
  - The current transfer rate in Megabits per second. 0 is none.
- `System.Double Percent`
  - Delta multipled by 100
- `System.Double TotalSize`
  - The total size of what we're trying to download

## Methods

### Instance methods

- `System.TimeSpan CalculateETA()`
