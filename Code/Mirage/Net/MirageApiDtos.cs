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
	[JsonPropertyName( "createdAt" )] public string CreatedAt { get; set; }
	[JsonPropertyName( "updatedAt" )] public string UpdatedAt { get; set; }
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
