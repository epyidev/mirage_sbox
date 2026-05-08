/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Static configuration of one vehicle model. Lives in the
/// <see cref="MirageVehicles"/> catalogue and is keyed on its
/// lowercase <see cref="Id"/>. Mirrors the <see cref="MirageItem"/>
/// pattern: gameplay code references models through the catalogue
/// rather than hard-coding prefab paths, so adding a car is a
/// one-block edit.
/// </summary>
public sealed class MirageVehicle
{
	/// <summary>
	/// Slug-style id, lowercase letters, digits and underscores. This is
	/// what the operator types in <c>/car &lt;id&gt;</c>.
	/// </summary>
	public string Id { get; init; }

	/// <summary>Player-facing label shown when announcing a spawn.</summary>
	public string Label { get; init; }

	/// <summary>
	/// Asset path of the vehicle prefab to clone, relative to <c>Assets/</c>.
	/// Example: <c>"vehicles/default_car.prefab"</c>.
	/// </summary>
	public string PrefabPath { get; init; }

	/// <summary>Optional one-line description, surfaced by an admin browser if we add one later.</summary>
	public string Description { get; init; }

	/// <summary>
	/// Free-form category (e.g. <c>"car"</c>, <c>"truck"</c>, <c>"bike"</c>).
	/// Cosmetic for now, useful for grouping in a future picker UI.
	/// </summary>
	public string Category { get; init; } = "car";
}
