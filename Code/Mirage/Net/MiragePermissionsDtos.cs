/** @author Epyi */

using System.Text.Json.Serialization;

namespace Sandbox.Mirage;

/// <summary>
/// Wire DTOs for the permissions endpoints exposed by the Mirage backend Api.
/// SteamID round-trips as a string because the value exceeds the 53-bit safe
/// integer range; mirror the API contract.
/// </summary>
public sealed class MiragePermissionsGroupDetail
{
	[JsonPropertyName( "id" )] public string Id { get; set; }
	[JsonPropertyName( "displayName" )] public string DisplayName { get; set; }
	[JsonPropertyName( "priority" )] public int Priority { get; set; }
	[JsonPropertyName( "permissions" )] public List<string> Permissions { get; set; } = new();
	[JsonPropertyName( "createdAt" )] public string CreatedAt { get; set; }
	[JsonPropertyName( "updatedAt" )] public string UpdatedAt { get; set; }
}

public sealed class MiragePermissionsGroupSummary
{
	[JsonPropertyName( "id" )] public string Id { get; set; }
	[JsonPropertyName( "displayName" )] public string DisplayName { get; set; }
	[JsonPropertyName( "priority" )] public int Priority { get; set; }
	[JsonPropertyName( "createdAt" )] public string CreatedAt { get; set; }
	[JsonPropertyName( "updatedAt" )] public string UpdatedAt { get; set; }
}

public sealed class MiragePermissionsGroupCreateRequest
{
	[JsonPropertyName( "id" )] public string Id { get; set; }
	[JsonPropertyName( "displayName" )] public string DisplayName { get; set; }
	[JsonPropertyName( "priority" )] public int Priority { get; set; }
}

public sealed class MiragePermissionsGroupPatchRequest
{
	[JsonPropertyName( "displayName" ), JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
	public string DisplayName { get; set; }

	[JsonPropertyName( "priority" ), JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
	public int? Priority { get; set; }
}

public sealed class MiragePermissionsPlayer
{
	[JsonPropertyName( "steamId" )] public string SteamId { get; set; }
	[JsonPropertyName( "permissions" )] public List<string> Permissions { get; set; } = new();
}

public sealed class MiragePermissionsPlayerOverride
{
	[JsonPropertyName( "steamId" )] public string SteamId { get; set; }
	[JsonPropertyName( "permissionCount" )] public int PermissionCount { get; set; }
}
