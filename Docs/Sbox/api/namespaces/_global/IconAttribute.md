# IconAttribute

Sets the icon of a type or a type member. Colors are expected in HTML formats, like "rgb(255,255,255)" or "#FFFFFF".
This info can then be retrieved via DisplayInfo library.

- **Kind:** attribute
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `IconAttribute(System.String icon, System.String bgColor, System.String fgColor)`
- `IconAttribute(System.String icon)`

## Properties

- `System.String Value`
- `System.Nullable<Color> BackgroundColor`
  - The preferred background color for the icon.
- `System.Nullable<Color> ForegroundColor`
  - The preferred color of the icon itself.
