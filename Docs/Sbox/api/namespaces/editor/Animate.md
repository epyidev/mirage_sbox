# Editor.Animate

- **Kind:** static class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Methods

### Static methods

- `static System.Void Add(System.Object owningObject, System.Single secondsToTake, System.Single from, System.Single to, System.Action<System.Single> value, System.String ease)`
- `static System.Void CancelAll(System.Object owningObject, System.Boolean jumpToEnd)`
  - Cancel all of this object's active animations
- `static System.Boolean IsActive(System.Object owningObject)`
  - Returns true if this object has any active animations
- `static System.Void Frame()`
