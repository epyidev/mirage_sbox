# Sandbox.BlobData

Base class for properties that should be serialized to binary format instead of JSON.
Used for large data structures that would be inefficient as JSON.

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `BlobData()`

## Properties

- `System.Int32 Version`
  - The version of this binary data format. Used for upgrade paths.

## Methods

### Instance methods

- `virtual System.Void Serialize(Sandbox.BlobData.Writer writer)`
  - Serialize this object to binary format.
- `virtual System.Void Deserialize(Sandbox.BlobData.Reader reader)`
  - Deserialize this object from binary format.
- `virtual System.Void Upgrade(Sandbox.BlobData.Reader reader, System.Int32 fromVersion)`
  - Optional upgrade path for old data versions. Called if the data version is older than current Version.
