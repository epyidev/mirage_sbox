/** @author Epyi */

/// <summary>
/// Mirage RP identity carried on each <see cref="PlayerData"/>. Replicated from
/// host to all clients so any HUD piece can render "FirstName LastName" without
/// a round trip. The active character id stays as a string to round-trip the
/// API's BIGINT safely.
/// </summary>
public sealed partial class PlayerData
{
	/// <summary>
	/// Id of the RP character the player is currently controlling. Null while
	/// the character selection screen is open.
	/// </summary>
	[Sync( SyncFlags.FromHost )] public string ActiveCharacterId { get; set; }

	/// <summary>
	/// First name of the active character. Empty until a character is selected.
	/// </summary>
	[Sync( SyncFlags.FromHost )] public string FirstName { get; set; } = "";

	/// <summary>
	/// Last name of the active character. Empty until a character is selected.
	/// </summary>
	[Sync( SyncFlags.FromHost )] public string LastName { get; set; } = "";

	/// <summary>
	/// True once a character is bound to this connection. Until then the
	/// player is parked in the limbo spawn and the selection UI is open.
	/// </summary>
	public bool HasActiveCharacter => !string.IsNullOrEmpty( ActiveCharacterId );

	/// <summary>
	/// "FirstName LastName" or empty if no character is active. Convenience
	/// for HUD bindings.
	/// </summary>
	public string FullName
	{
		get
		{
			if ( !HasActiveCharacter ) return "";
			return $"{FirstName} {LastName}".Trim();
		}
	}
}
