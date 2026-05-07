# Sandbox.LanguageContainer

A container for the current language, allowing access to translated phrases and language information.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.String SelectedCode`
  - The abbreviation for the language the user wants. This is set by the user in the options menu.
- `Sandbox.Localization.LanguageInformation Current`
  - Information about the current selected language. Will default to English if the current language isn't found.

## Methods

### Instance methods

- `System.String GetPhrase(System.String textToken, System.Collections.Generic.Dictionary<System.String,System.Object> data)`
