# Sandbox.UI.BasePopup

A panel that gets deleted automatically when clicked away from

- **Kind:** abstract class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.UI.Panel`

## Constructors

- `BasePopup()`

## Properties

- `System.Boolean StayOpen`
  - Stay open, even when CloseAll popups is called

## Methods

### Static methods

- `static System.Void CloseAll(Sandbox.UI.Panel exceptThisOne)`

### Instance methods

- `virtual System.Void OnDeleted()`
