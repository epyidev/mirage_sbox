# Sandbox.Diagnostics.Assert

- **Kind:** static class
- **Namespace:** `Sandbox.Diagnostics`
- **Assembly:** `Sandbox.System`

## Methods

### Static methods

- `static System.Void NotNull(T obj, System.String message)`
  - Throws an exception when the given object is null.
  - `obj`: Object to test
  - `message`: Message to show when object is null
- `static System.Void NotNull(T obj)`
  - Throws an exception when the given object is null.
  - `obj`: Object to test
- `static System.Void IsNull(T obj, System.String message)`
  - Throws an exception when the given object is not null.
  - `obj`: Object to test
  - `message`: Message to show when null
- `static System.Void IsNull(T obj)`
  - Throws an exception when the given object is not null.
  - `obj`: Object to test
- `static System.Void IsValid(Sandbox.IValid obj)`
  - Throws an exception when the given object is not valid.
- `static System.Void AreEqual(T a, T b, System.String message)`
  - Throws an exception when the 2 given objects are not equal to each other.
  - `a`: Object A to test.
  - `b`: Object B to test.
  - `message`: Message to include in the exception, if any.
- `static System.Void AreNotEqual(T a, T b, System.String message)`
  - Throws an exception when the 2 given objects are equal to each other.
- `static System.Void True(System.Boolean isValid, System.String message)`
  - Throws an exception when given expression does not resolve to <b>true</b>.
  - `isValid`: The expression to test
  - `message`: Message to include in the exception, if any.
- `static System.Void False(System.Boolean isValid, System.String message)`
  - Throws an exception when given expression does not resolve to <b>false</b>.
  - `isValid`: The expression to test
  - `message`: Message to include in the exception, if any.
