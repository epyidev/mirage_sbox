# Sandbox.Mounting.MountInfo

Information about a single mount

- **Kind:** struct
- **Namespace:** `Sandbox.Mounting`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `MountInfo(Sandbox.Mounting.BaseGameMount e)`

## Properties

- `System.String Ident`
  - A short, lowercase string that will be used to uniquely identify this asset source
- `System.String Title`
  - The display name of this
- `System.Boolean Available`
  - Is this source available, is this game installed? Can we mount it?
- `System.Boolean Mounted`
  - Is this active and mounted?
