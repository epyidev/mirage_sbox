# Sandbox.Diagnostics.Logger

- **Kind:** class
- **Namespace:** `Sandbox.Diagnostics`
- **Assembly:** `Sandbox.System`

## Constructors

- `Logger(System.String name)`

## Properties

- `System.String Name`
  - Name of this logger.

## Methods

### Instance methods

- `System.Void Info(System.FormattableString message)`
- `System.Void Trace(System.FormattableString message)`
- `System.Void Warning(System.FormattableString message)`
- `System.Void Error(System.FormattableString message)`
- `System.Void Error(System.Exception exception, System.FormattableString message)`
- `System.Void Error(System.Exception exception, System.Object message)`
  - Log an exception as an error, with given message override.
  - `exception`: The exception to log.
  - `message`: The text to override exceptions' message with in the log.
- `System.Void Error(System.Exception exception)`
  - Log an exception as an error.
  - `exception`: The exception to log.
- `System.Void Warning(System.Exception exception, System.FormattableString message)`
- `System.Void Warning(System.Exception exception, System.Object message)`
  - Log an exception as a warning, with given message override.
  - `exception`: The exception to log.
  - `message`: The text to override exceptions' message with in the log.
- `System.Void Info(System.Object message)`
  - Log some information. This is the default log severity level.
  - `message`: The information to log.
- `System.Void Trace(System.Object message)`
  - Log some information. This is least severe log level.
  - `message`: The information to log.
- `System.Void Warning(System.Object message)`
  - Log a warning. This is the second most severe log level.
  - `message`: The warning to log.
- `System.Void Error(System.Object message)`
  - Log an error. This is the most severe log level.
  - `message`: The error to log.
