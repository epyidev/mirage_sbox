# Sandbox.TimeSince

A convenience struct to easily measure time since an event last happened, based on `Sandbox.Time.Now`.<br /><br />
Typical usage would see you assigning 0 to a variable of this type to reset the timer.
Then the struct would return time since the last reset. i.e.:


```

TimeSince lastUsed = 0;
if ( lastUsed &gt; 10 ) { /*Do something*/ }

```

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Single Absolute`
  - Time at which the timer reset happened, based on `Sandbox.Time.Now`.
- `System.Single Relative`
  - Time passed since last reset, in seconds.
