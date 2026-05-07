# Sandbox.CodeArchive.AdditionalFile

Represents a file to send to the compiler along with all the code. This is usually
something that the generator turns into code, such as a Razor file.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Compiling`
- **Declaring type:** `Sandbox.CodeArchive`

## Constructors

- `AdditionalFile(System.String Text, System.String LocalPath)`
  - Represents a file to send to the compiler along with all the code. This is usually
something that the generator turns into code, such as a Razor file.
- `AdditionalFile(Sandbox.CodeArchive.AdditionalFile original)`

## Properties

- `System.Type EqualityContract`
- `System.String Text`
- `System.String LocalPath`

## Methods

### Instance methods

- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Sandbox.CodeArchive.AdditionalFile <Clone>$()`
- `System.Void Deconstruct(System.String Text, System.String LocalPath)`
