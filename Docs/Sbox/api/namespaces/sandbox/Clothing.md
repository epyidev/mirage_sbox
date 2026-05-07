# Sandbox.Clothing

Describes an item of clothing and implicitly which other items it can be worn with

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameResource`

## Constructors

- `Clothing()`

## Properties

- `System.Boolean HasHumanSkin`
- `System.String HumanSkinModel`
  - Model to replace the human skin with
- `System.String HumanSkinMaterial`
  - Replace skin with this
- `System.String HumanEyesMaterial`
  - Replace skin with this
- `System.UInt64 HumanSkinBodyGroups`
  - Bodygroup on the model to choose
- `System.String HumanSkinMaterialGroup`
  - Bodygroup on the model to choose
- `Sandbox.TagSet HumanSkinTags`
  - Allows adding tags for this skin, ie "female". This affects which alternative clothing models are used with it.
- `System.String Title`
  - Name of the clothing to show in UI.
- `System.String Subtitle`
  - A subtitle for this clothing piece.
- `Sandbox.Clothing.ClothingCategory Category`
  - What kind of clothing this is?
- `System.Collections.Generic.Dictionary<System.String,System.String> ConditionalModels`
  - A list of conditional models.
(key) = tag(s), (value) = model
- `System.String Tags`
- `System.String SubCategory`
  - This should be a single word to describe the subcategory, and should match any other items you want to categorize in the same bunch. The work will be tokenized so it can become localized.
- `Sandbox.Clothing Parent`
  - The clothing to parent this too.  It will be displayed as a variation of its parent
- `System.String Model`
  - The model to bonemerge to the player when this clothing is equipped.
- `System.String HumanAltModel`
  - The model to bonemerge to the human player when this clothing is equipped.
- `System.String HumanAltFemaleModel`
  - The model to bonemerge to the human player when this clothing is equipped.
- `System.String SkinMaterial`
  - Replace the skin with this material
- `System.String EyesMaterial`
  - Replace the eyes with this material
- `System.String MaterialGroup`
  - Which material group of the model to use.
- `System.Single HeelHeight`
  - Do we need to lift the heel up?
- `Sandbox.Clothing.Slots SlotsUnder`
  - Which slots this clothing takes on "inner" layer.
- `Sandbox.Clothing.Slots SlotsOver`
  - Which slots this clothing takes on "outer" layer.
- `Sandbox.Clothing.BodyGroups HideBody`
  - Which body parts of the player model should not show when this clothing is equipped.
- `System.Boolean AllowTintSelect`
- `Sandbox.Gradient TintSelection`
- `System.Single TintDefault`
- `System.Nullable<System.Int32> SteamItemDefinitionId`
  - The Steam Item Definition ID for this clothing item, if it's an inventory item
- `Sandbox.Clothing.IconSetup Icon`
  - Icon for this clothing piece.

## Methods

### Static methods

- `static System.Collections.Generic.List<Sandbox.SceneModel> DressSceneObject(Sandbox.SceneModel citizen, System.Collections.Generic.IEnumerable<Sandbox.Clothing> Clothing)`

### Instance methods

- `System.String GetModel(System.Collections.Generic.IEnumerable<Sandbox.Clothing> clothingList)`
- `System.String GetModel(System.Collections.Generic.IEnumerable<Sandbox.Clothing> clothingList, Sandbox.TagSet tagset)`
- `System.Boolean HasPermissions()`
  - Can we wear this item?
- `System.Boolean CanBeWornWith(Sandbox.Clothing target)`
  - Return true if this item of clothing can be worn with the target item, at the same time.
