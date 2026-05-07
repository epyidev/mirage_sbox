# Sandbox.Json.Pointer

Represents a JSON Pointer as defined in RFC 6901.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Json`

## Constructors

- `Pointer(System.String value)`
  - Initializes a new instance of the `Sandbox.Json.Pointer` class with the specified string.
  - `value`: The string value of the JSON Pointer.

## Properties

- `System.Collections.Immutable.ImmutableArray<System.String> ReferenceTokens`
  - The reference tokens that make up the JSON Pointer.
- `System.Boolean IsRoot`

## Fields

- `static Sandbox.Json.Pointer Root`
  - A static instance representing the root JSON Pointer (i.e., "/").

## Methods

### Instance methods

- `Sandbox.Json.Pointer Append(System.String token)`
  - Appends a token to the JSON Pointer and returns a new `Sandbox.Json.Pointer`.
  - `token`: The token to append.
  - returns: A new `Sandbox.Json.Pointer` with the appended token.
- `Sandbox.Json.Pointer Append(System.Int32 index)`
  - Appends an integer index as a token to the JSON Pointer and returns a new `Sandbox.Json.Pointer`.
  - `index`: The integer index to append.
  - returns: A new `Sandbox.Json.Pointer` with the appended index.
- `Sandbox.Json.Pointer GetParent()`
  - Returns a new `Sandbox.Json.Pointer` representing the parent of the current pointer.
  - returns: A new `Sandbox.Json.Pointer` for the parent path.
- `System.Text.Json.Nodes.JsonNode Evaluate(System.Text.Json.Nodes.JsonNode document)`
