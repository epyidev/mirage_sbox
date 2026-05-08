/** @author Epyi */

using System.Text.Json.Serialization;

namespace Sandbox.Mirage;

/// <summary>
/// Snapshot of the permissions editor's state, serialized over the RPC
/// channel between host and the editor UI. Fields are flat and small to keep
/// each delivery bounded.
/// </summary>
public sealed class MiragePermissionsEditorSnapshot
{
	[JsonPropertyName( "groups" )] public List<MiragePermissionsEditorGroupEntry> Groups { get; set; } = new();
	[JsonPropertyName( "players" )] public List<MiragePermissionsEditorPlayerEntry> Players { get; set; } = new();
}

public sealed class MiragePermissionsEditorGroupEntry
{
	[JsonPropertyName( "id" )] public string Id { get; set; }
	[JsonPropertyName( "displayName" )] public string DisplayName { get; set; }
	[JsonPropertyName( "priority" )] public int Priority { get; set; }
	[JsonPropertyName( "permissions" )] public List<string> Permissions { get; set; } = new();
}

public sealed class MiragePermissionsEditorPlayerEntry
{
	[JsonPropertyName( "steamId" )] public string SteamId { get; set; }
	/// <summary>
	/// Public-facing player handle. 0 when the player is offline and the
	/// MirageId is not cached on a connected <see cref="PlayerData"/>.
	/// </summary>
	[JsonPropertyName( "mirageId" )] public int MirageId { get; set; }
	[JsonPropertyName( "displayName" )] public string DisplayName { get; set; } = "";
	[JsonPropertyName( "permissions" )] public List<string> Permissions { get; set; } = new();
}
