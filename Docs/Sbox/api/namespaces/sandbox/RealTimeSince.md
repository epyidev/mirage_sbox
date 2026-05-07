# Sandbox.RealTimeSince

A convenience struct to easily measure time since an event last happened, based on `Sandbox.RealTime.GlobalNow`.<br /><br />
Typical usage would see you assigning 0 to a variable of this type to reset the timer.
Then the struct would return time since the last reset. i.e.:


```

RealTimeSince lastUsed = 0;
if ( lastUsed &gt; 10 ) { /*Do something*/ }

```

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Properties

- `System.Double Absolute`
  - Time at which the timer reset happened, based on `Sandbox.RealTime.GlobalNow`.
- `System.Single Relative`
  - Time passed since last reset, in seconds.
