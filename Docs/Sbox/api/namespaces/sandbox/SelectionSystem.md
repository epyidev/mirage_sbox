# Sandbox.SelectionSystem

An ordered collection of unique objects with add/remove callbacks.
Maintains insertion order and provides change notifications.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Constructors

- `SelectionSystem()`

## Properties

- `System.Action<System.Object> OnItemAdded`
  - Invoked when an item is added to the selection.
- `System.Action<System.Object> OnItemRemoved`
  - Invoked when an item is removed from the selection.
- `System.Int32 Count`
  - Gets the number of selected objects.

## Methods

### Instance methods

- `virtual System.Collections.Generic.IEnumerator<System.Object> GetEnumerator()`
  - Returns an enumerator that iterates through the selected objects in order.
- `virtual System.Void Clear()`
  - Removes all objects from the selection, invoking OnItemRemoved for each.
- `virtual System.Boolean Add(System.Object obj)`
  - Adds an object to the selection.
  - `obj`: The object to add
  - returns: True if the object was added, false if it was already selected
- `virtual System.Boolean Set(System.Object obj)`
  - Clears the selection and sets it to a single object.
  - `obj`: The object to select
  - returns: True if the selection changed, false if it was already the only selected object
- `virtual System.Boolean Remove(System.Object obj)`
  - Removes an object from the selection.
  - `obj`: The object to remove
  - returns: True if the object was removed, false if it wasn't selected
- `virtual System.Boolean Contains(System.Object obj)`
  - Checks if an object is in the selection.
  - `obj`: The object to check
  - returns: True if the object is selected
- `virtual System.Boolean Any()`
  - Checks if the selection contains any objects.
  - returns: True if there are any selected objects
