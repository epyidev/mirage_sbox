# Sandbox.FeatureAttribute

Sets the category or the group of a type or a type member.
This info can then be retrieved via DisplayInfo library.

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `FeatureAttribute(System.String value)`

## Properties

- `System.String Identifier`
  - How we will group features together
- `System.String Title`
  - Title of the feature. Keep it short please!
- `System.String Description`
  - The description of the feature
- `System.String Icon`
  - Icon to show next to the feature
- `Sandbox.EditorTint Tint`
  - The color of the feature button. Helps group things, helps things to stand out. Defaults to white.
