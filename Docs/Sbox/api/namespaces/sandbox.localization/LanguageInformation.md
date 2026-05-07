# Sandbox.Localization.LanguageInformation

- **Kind:** class
- **Namespace:** `Sandbox.Localization`
- **Assembly:** `Sandbox.System`

## Constructors

- `LanguageInformation(System.String title, System.String abbreviation, System.String parent, System.Boolean rightToLeft)`

## Properties

- `System.String Title`
  - Title of the localization language.
- `System.String Abbreviation`
  - ISO 639-1 code of the language, with optional ISO 3166-1 alpha-2 country specifiers. (for example "en-GB" for British English)
- `System.String Parent`
  - If set, the `Sandbox.Localization.LanguageInformation.Abbreviation` of the parent language. For example, Pirate English is based on English.
- `System.Boolean RightToLeft`
  - Whether the language is typed right to left, such as the Arabic language.
