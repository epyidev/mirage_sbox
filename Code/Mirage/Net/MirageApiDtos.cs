/** @author Epyi */

using System.Text.Json.Serialization;

namespace Sandbox.Mirage;

/// <summary>
/// Last known IC position of a character. Mirrors the API's `position` schema
/// (world units; yaw in degrees).
/// </summary>
public sealed class MiragePosition
{
	[JsonPropertyName( "x" )] public float X { get; set; }
	[JsonPropertyName( "y" )] public float Y { get; set; }
	[JsonPropertyName( "z" )] public float Z { get; set; }
	[JsonPropertyName( "yaw" )] public float Yaw { get; set; }
}

/// <summary>
/// One RP character belonging to a player. Mirrors the API's
/// `characterSummarySchema`. BIGINT ids round-trip as strings to stay safe past
/// the JS 53-bit number range, matching the API contract.
/// </summary>
public sealed class MirageCharacterSummary
{
	[JsonPropertyName( "id" )] public string Id { get; set; }
	[JsonPropertyName( "steamId" )] public string SteamId { get; set; }
	[JsonPropertyName( "slot" )] public int Slot { get; set; }
	[JsonPropertyName( "firstName" )] public string FirstName { get; set; }
	[JsonPropertyName( "lastName" )] public string LastName { get; set; }
	[JsonPropertyName( "birthDate" )] public string BirthDate { get; set; }
	[JsonPropertyName( "heightCm" )] public int HeightCm { get; set; }
	[JsonPropertyName( "gender" )] public string Gender { get; set; }
	[JsonPropertyName( "lastPosition" )] public MiragePosition LastPosition { get; set; }
	[JsonPropertyName( "health" )] public float Health { get; set; } = 100f;
	[JsonPropertyName( "maxHealth" )] public float MaxHealth { get; set; } = 100f;
	[JsonPropertyName( "armour" )] public float Armour { get; set; } = 0f;
	[JsonPropertyName( "createdAt" )] public string CreatedAt { get; set; }
	[JsonPropertyName( "updatedAt" )] public string UpdatedAt { get; set; }
}

/// <summary>
/// One inventory slot row. Mirrors the API's `inventoryEntrySchema`.
/// Quantity 0 rows are filtered out by the API on the way out.
/// </summary>
public sealed class MirageInventoryEntry
{
	[JsonPropertyName( "slot" )] public int Slot { get; set; }
	[JsonPropertyName( "itemId" )] public string ItemId { get; set; }
	[JsonPropertyName( "quantity" )] public int Quantity { get; set; }
	[JsonPropertyName( "metadata" ), JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
	public Dictionary<string, string> Metadata { get; set; }
}

/// <summary>
/// One wallet row attached to a character. Mirrors the API's
/// `accountEntrySchema`. <c>updatedAt</c> is informative only on reads.
/// </summary>
public sealed class MirageAccountEntry
{
	[JsonPropertyName( "accountId" )] public string AccountId { get; set; }
	[JsonPropertyName( "amount" )] public int Amount { get; set; }
	[JsonPropertyName( "updatedAt" )] public string UpdatedAt { get; set; }
}

/// <summary>
/// Full character payload returned by <c>GET /players/:steamId/characters/:id</c>.
/// Used at character spawn to hydrate the in-memory state in one HTTP call.
/// </summary>
public sealed class MirageCharacterDetail : MirageCharacterSummary
{
	[JsonPropertyName( "accounts" )] public List<MirageAccountEntry> Accounts { get; set; } = new();
	[JsonPropertyName( "inventory" )] public List<MirageInventoryEntry> Inventory { get; set; } = new();
}

/// <summary>
/// Body for <c>POST /players/:steamId/characters/:id/snapshot</c>. Carries
/// every mutable piece of a character so the API can persist them in one
/// MariaDB transaction. The host calls this every 10 minutes plus on
/// disconnect / character switch / admin save.
/// </summary>
public sealed class MirageCharacterSnapshot
{
	[JsonPropertyName( "lastPosition" ), JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
	public MiragePosition LastPosition { get; set; }
	[JsonPropertyName( "vitals" )] public MirageVitals Vitals { get; set; }
	[JsonPropertyName( "wallets" )] public List<MirageWalletEntry> Wallets { get; set; } = new();
	[JsonPropertyName( "inventory" )] public List<MirageInventoryEntry> Inventory { get; set; } = new();
}

public sealed class MirageVitals
{
	[JsonPropertyName( "health" )] public float Health { get; set; }
	[JsonPropertyName( "maxHealth" )] public float MaxHealth { get; set; }
	[JsonPropertyName( "armour" )] public float Armour { get; set; }
}

public sealed class MirageWalletEntry
{
	[JsonPropertyName( "accountId" )] public string AccountId { get; set; }
	[JsonPropertyName( "amount" )] public int Amount { get; set; }
}

/// <summary>
/// Body for `POST /players/:steamId/characters`. Mirrors `characterCreateSchema`.
/// </summary>
public sealed class MirageCharacterCreateRequest
{
	[JsonPropertyName( "slot" )] public int Slot { get; set; }
	[JsonPropertyName( "firstName" )] public string FirstName { get; set; }
	[JsonPropertyName( "lastName" )] public string LastName { get; set; }
	[JsonPropertyName( "birthDate" )] public string BirthDate { get; set; }
	[JsonPropertyName( "heightCm" )] public int HeightCm { get; set; }
	[JsonPropertyName( "gender" )] public string Gender { get; set; }
}

/// <summary>
/// OOC profile returned by `GET /players/:steamId`. Mirrors `playerSchema`.
/// IP history is not exposed here, the gamemode never needs to read it back.
/// </summary>
public sealed class MiragePlayerInfo
{
	[JsonPropertyName( "steamId" )] public string SteamId { get; set; }
	[JsonPropertyName( "displayName" )] public string DisplayName { get; set; }
	[JsonPropertyName( "createdAt" )] public string CreatedAt { get; set; }
	[JsonPropertyName( "updatedAt" )] public string UpdatedAt { get; set; }
}

/// <summary>
/// Body for `PUT /players/:steamId`. Both fields are optional, omit by leaving
/// the property null and the serializer with default options will skip nulls.
/// </summary>
internal sealed class MiragePlayerUpdateRequest
{
	[JsonPropertyName( "displayName" ), JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
	public string DisplayName { get; set; }

	[JsonPropertyName( "recordIp" ), JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
	public string RecordIp { get; set; }
}
