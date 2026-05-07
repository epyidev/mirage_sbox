# Sandbox.StringToken

Strings are commonly converted to tokens in engine, to save space and speed up things like comparisons.
We wrap this functionality up in the StringToken struct, because we can apply a bunch of compile time 
optimizations to speed up the conversion.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Constructors

- `StringToken(System.String value)`
- `StringToken(System.UInt32 token)`

## Fields

- `System.UInt32 Value`

## Methods

### Static methods

- `static Sandbox.StringToken Literal(System.String value, System.UInt32 token)`
  - This is used by codegen. String literals are replaced by this function call, which
avoids having to create or lookup the string token.
