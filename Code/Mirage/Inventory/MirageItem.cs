/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Static configuration of one item kind. Lives in <see cref="MirageItems"/>'
/// catalogue and is keyed on its lowercase <see cref="Id"/>. The runtime never
/// mutates these; per-instance state (count, durability, ammo, ...) lives in
/// <see cref="MirageInventorySlot"/> and its <c>Metadata</c> dictionary.
/// </summary>
public sealed class MirageItem
{
	/// <summary>
	/// Slug-style id, lowercase letters, digits and underscores. This is what
	/// gets stored in the inventory rows on disk and over the wire.
	/// </summary>
	public string Id { get; init; }

	/// <summary>Player-facing label shown in the UI.</summary>
	public string Label { get; init; }

	/// <summary>Weight per unit, in grams. 0 means weightless.</summary>
	public int Weight { get; init; }

	/// <summary>
	/// Maximum stack size for this item. 1 means non-stackable (ammo, weapons,
	/// armour, ...). Higher values let multiple units share one slot.
	/// </summary>
	public int MaxStack { get; init; } = 1;

	/// <summary>
	/// Optional asset path of the icon shown in the slot. Falls back to the
	/// first letter of <see cref="Label"/> when null. Example:
	/// <c>"ui/items/burger.png"</c>.
	/// </summary>
	public string Image { get; init; }

	/// <summary>
	/// Optional description shown in the tooltip/hover.
	/// </summary>
	public string Description { get; init; }

	/// <summary>
	/// Free-form category used to sort/filter (e.g. "weapon", "consumable",
	/// "tool", "misc"). Purely cosmetic for now.
	/// </summary>
	public string Category { get; init; } = "misc";

	/// <summary>
	/// If non-null, equipping this item from the hotbar spawns the prefab at
	/// this asset path as the player's active weapon. Used to bind data
	/// items to existing Sandbox <see cref="BaseCarryable"/>s without
	/// rewriting weapon logic.
	/// </summary>
	public string WeaponPrefab { get; init; }

	/// <summary>
	/// If non-null, dropping this item spawns the prefab at this asset path
	/// in the world. Falls back to the generic Mirage drop bag when null.
	/// </summary>
	public string DropPrefab { get; init; }

	/// <summary>
	/// Default metadata seeded on a fresh stack. Useful for weapon defaults
	/// (durability=100, ammo=mag size, etc.).
	/// </summary>
	public IReadOnlyDictionary<string, string> DefaultMetadata { get; init; }

	public bool IsWeapon => !string.IsNullOrEmpty( WeaponPrefab );
	public bool Stackable => MaxStack > 1;
}
