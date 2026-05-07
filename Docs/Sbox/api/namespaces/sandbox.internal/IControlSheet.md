# Sandbox.Internal.IControlSheet

Interface for a control sheet that manages the display of serialized properties in a structured way.

- **Kind:** interface
- **Namespace:** `Sandbox.Internal`
- **Assembly:** `Sandbox.Reflection`

## Methods

### Static methods

- `static System.Void FilterSortAndAdd(Sandbox.Internal.IControlSheet sheet, System.Collections.Generic.List<Sandbox.SerializedProperty> q, System.Boolean allowFeatures)`
- `static System.Void AddProperties(Sandbox.Internal.IControlSheet sheet, System.Collections.Generic.List<Sandbox.SerializedProperty> properties, System.Boolean allowFeatures)`

### Instance methods

- `virtual System.Void RemoveUnusedMethods(System.Collections.Generic.List<Sandbox.SerializedProperty> properties)`
- `virtual System.Void AddPropertiesWithGrouping(System.Collections.Generic.List<Sandbox.SerializedProperty> properties)`
- `virtual System.Void AddFeature(Sandbox.Internal.IControlSheet.Feature feature)`
  - We're adding a feature. Normally would store these in a tab control
- `virtual System.Void AddGroup(Sandbox.Internal.IControlSheet.Group group)`
  - We're adding a group. Normally would have a Group Panel with the properties as children
- `virtual System.Boolean TestFilter(Sandbox.SerializedProperty prop)`
  - Implement to filter properties that should be displayed in the control sheet.
