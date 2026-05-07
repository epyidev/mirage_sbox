# Sandbox.Language

Allows access to translated phrases, allowing the translation of gamemodes etc

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static System.String SelectedCode`
  - The abbreviation for the language the user wants. This is set by the user in the options menu.
- `static Sandbox.Localization.LanguageInformation Current`
  - Information about the current selected language. Will default to English if the current language isn't found.

## Methods

### Static methods

- `static System.String GetPhrase(System.String textToken, System.Collections.Generic.Dictionary<System.String,System.Object> data)`
