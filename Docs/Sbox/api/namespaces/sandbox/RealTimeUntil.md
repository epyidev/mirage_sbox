# Sandbox.RealTimeUntil

A convenience struct to easily manage a time countdown, based on `Sandbox.RealTime.GlobalNow`.<br /><br />
Typical usage would see you assigning to a variable of this type a necessary amount of seconds.
Then the struct would return the time countdown, or can be used as a bool i.e.:


```

RealTimeUntil nextAttack = 10;
if ( nextAttack ) { /*Do something*/ }

```

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Properties

- `System.Double Absolute`
  - Time to which we are counting down to, based on `Sandbox.RealTime.GlobalNow`.
- `System.Double Relative`
  - The actual countdown, in seconds.
- `System.Double Passed`
  - Amount of seconds passed since the countdown started.
- `System.Double Fraction`
  - The countdown, but as a fraction, i.e. a value from 0 (start of countdown) to 1 (end of countdown)
