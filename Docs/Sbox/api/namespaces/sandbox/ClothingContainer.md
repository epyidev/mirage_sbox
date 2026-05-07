# Sandbox.ClothingContainer

Holds a collection of clothing items. Won't let you add items that aren't compatible.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ClothingContainer()`

## Properties

- `System.String DisplayName`
  - A user set name for this setup
- `System.Single Height`
  - The avatar's height. Default is 0.5f.
- `System.Single Age`
  - The avatar's age. Default is 0.0f. We'll pick a skin based on this.
- `System.Single Tint`
  - For the citizen the skin color is dynamic, based on a gradient. This is 0-1.
- `System.Boolean PrefersHuman`
  - If true, this avatar prefers to use a human model when possible

## Fields

- `System.Collections.Generic.List<Sandbox.ClothingContainer.ClothingEntry> Clothing`
  - A list of clothing items the avatar is wearing

## Methods

### Static methods

- `static Sandbox.ClothingContainer CreateFromJson(System.String json)`
  - Create the container from json definitions
- `static Sandbox.ClothingContainer CreateFromLocalUser()`
  - Create the container from the local user's setup, stripped of any unowned items.
- `static Sandbox.ClothingContainer CreateFromConnection(Sandbox.Connection connection, System.Boolean removeUnowned)`
  - Create the container from a connection's avatar, filtered to only items they are verified to own.

### Instance methods

- `System.Void Normalize()`
  - Restrict things like Height to their sensible limits
- `System.Void Toggle(Sandbox.Clothing clothing)`
  - Add a clothing item if we don't already contain it, else remove it
- `Sandbox.ClothingContainer.ClothingEntry Add(Sandbox.Clothing clothing)`
  - Add clothing item
- `System.Void Add(Sandbox.ClothingContainer.ClothingEntry clothing)`
  - Add clothing item
- `System.Void AddRange(System.Collections.Generic.IEnumerable<Sandbox.ClothingContainer.ClothingEntry> clothing)`
- `Sandbox.ClothingContainer.ClothingEntry FindEntry(Sandbox.Clothing clothing)`
  - Find a clothing entry matching this clothing item
- `System.Boolean Has(Sandbox.Clothing clothing)`
  - Returns true if we have this clothing item
- `System.Collections.Generic.IEnumerable<System.ValueTuple<System.String,System.Int32>> GetBodyGroups()`
  - Return a list of bodygroups and what their value should be
- `System.Collections.Generic.IEnumerable<System.ValueTuple<System.String,System.Int32>> GetBodyGroups(System.Collections.Generic.IEnumerable<Sandbox.Clothing> items)`
- `System.String Serialize()`
  - Serialize to Json
- `System.Void Deserialize(System.String json)`
  - Deserialize from Json
- `System.Void RemoveUnownedItems()`
  - Removes any clothing items that require Steam inventory ownership but the local user doesn't own.
- `System.Void RemoveUnownedItems(Sandbox.Connection connection)`
  - Removes clothing items that the given connection is not verified to own.
Must be called from the host or from the local player, as clients don't have access to other player inventory data.
- `System.Threading.Tasks.Task ApplyAsync(Sandbox.SkinnedModelRenderer body, System.Threading.CancellationToken token)`
  - Dresses a skinned model with an outfit. Will apply all the clothes it can immediately, then download any missing clothing.
- `System.Void Apply(Sandbox.SkinnedModelRenderer body)`
  - Dress a skinned model renderer with an outfit. Doesn't download missing clothing.
- `System.Void Reset(Sandbox.SkinnedModelRenderer body)`
  - Clear the outfit from this model, make it named
