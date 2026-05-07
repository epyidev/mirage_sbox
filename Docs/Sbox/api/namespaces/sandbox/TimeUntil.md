# Sandbox.TimeUntil

A convenience struct to easily manage a time countdown, based on `Sandbox.Time.Now`.<br /><br />
Typical usage would see you assigning to a variable of this type a necessary amount of seconds.
Then the struct would return the time countdown, or can be used as a bool i.e.:


```

TimeUntil nextAttack = 10;
if ( nextAttack ) { /*Do something*/ }

```

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Single Absolute`
  - Time to which we are counting down to, based on `Sandbox.Time.Now`.
- `System.Single Relative`
  - The actual countdown, in seconds.
- `System.Single Passed`
  - Amount of seconds passed since the countdown started.
- `System.Single Fraction`
  - The countdown, but as a fraction, i.e. a value from 0 (start of countdown) to 1 (end of countdown)
