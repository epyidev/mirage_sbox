/** @author Epyi */

using System.Text.Json.Serialization;

namespace Sandbox.Mirage;

/// <summary>
/// One inventory cell. Empty slots are still represented by an instance with
/// <see cref="ItemId"/> null and <see cref="Count"/> = 0, so the
/// <see cref="MirageInventory.Slots"/> list always has exactly
/// <see cref="MirageInventory.SlotCount"/> entries.
///
/// Metadata is a flat string-to-string map. Encoders/decoders that need
/// structured values (json blobs, arrays, ...) can stuff a JSON string in
/// there.
/// </summary>
public sealed class MirageInventorySlot
{
	[JsonPropertyName( "itemId" )] public string ItemId { get; set; }
	[JsonPropertyName( "count" )] public int Count { get; set; }
	[JsonPropertyName( "metadata" )] public Dictionary<string, string> Metadata { get; set; } = new();

	[JsonIgnore] public bool IsEmpty => string.IsNullOrEmpty( ItemId ) || Count <= 0;

	/// <summary>Resolves the static config for this slot's item, or null if empty/unknown.</summary>
	public MirageItem Item => MirageItems.Find( ItemId );

	public MirageInventorySlot Clone()
	{
		return new MirageInventorySlot
		{
			ItemId = ItemId,
			Count = Count,
			Metadata = Metadata is null ? new Dictionary<string, string>() : new Dictionary<string, string>( Metadata )
		};
	}

	public void Clear()
	{
		ItemId = null;
		Count = 0;
		Metadata = new Dictionary<string, string>();
	}

	/// <summary>Convenience accessor for a metadata int value.</summary>
	public int GetIntMeta( string key, int fallback = 0 )
	{
		if ( Metadata is null ) return fallback;
		if ( !Metadata.TryGetValue( key, out var raw ) ) return fallback;
		return int.TryParse( raw, out var v ) ? v : fallback;
	}

	public void SetMeta( string key, string value )
	{
		Metadata ??= new Dictionary<string, string>();
		if ( value is null ) Metadata.Remove( key );
		else Metadata[key] = value;
	}
}
