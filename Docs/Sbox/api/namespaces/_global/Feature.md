# Sandbox.Internal.IControlSheet.Feature

A feature is usually displayed as a tab, to break things up in the inspector. They can sometimes be turned on and off.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Reflection`
- **Declaring type:** `Sandbox.Internal.IControlSheet`

## Constructors

- `Feature(System.Collections.Generic.List<Sandbox.SerializedProperty> properties)`

## Properties

- `System.String Name`
  - The name of the feature, usually displayed as a tab title in the inspector.
- `System.String Description`
  - The description of the feature
- `System.String Icon`
  - The icon of the feature
- `Sandbox.EditorTint Tint`
  - Allows tinting this feature, for some reason
- `System.Collections.Generic.List<Sandbox.SerializedProperty> Properties`
  - The properties that are part of this feature, usually displayed together in the inspector.
- `Sandbox.SerializedProperty EnabledProperty`
  - If we have a FeatureEnabled property, this will be it. If not then we assume it should always be enabled.
