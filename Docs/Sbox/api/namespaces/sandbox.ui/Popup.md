# Sandbox.UI.Popup

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Base Library`
- **Base:** `Sandbox.UI.BasePopup`

## Constructors

- `Popup()`
- `Popup(Sandbox.UI.Panel sourcePanel, Sandbox.UI.Popup.PositionMode position, System.Single offset)`

## Properties

- `Sandbox.UI.Panel PopupSource`
- `Sandbox.UI.Panel SelectedChild`
- `Sandbox.UI.Popup.PositionMode Position`
- `System.Single PopupSourceOffset`
- `System.Boolean CloseWhenParentIsHidden`
- `System.String Title`
- `System.String Icon`

## Fields

- `Sandbox.UI.Panel Header`
- `Sandbox.UI.Label TitleLabel`
- `Sandbox.UI.IconPanel IconPanel`

## Methods

### Instance methods

- `System.Void SetPositioning(Sandbox.UI.Panel sourcePanel, Sandbox.UI.Popup.PositionMode position, System.Single offset)`
- `System.Void Success()`
- `System.Void Failure()`
- `Sandbox.UI.Panel AddOption(System.String text, System.Action action)`
- `Sandbox.UI.Panel AddOption(System.String text, System.String icon, System.Action action)`
- `System.Void MoveSelection(System.Int32 dir)`
- `virtual System.Void Tick()`
- `virtual System.Void OnLayout(Sandbox.Rect layoutRect)`
