/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Permissions endpoints of the Mirage backend Api. Host-only, like every
/// other call site of <see cref="MirageApiClient"/>.
/// </summary>
public static partial class MirageApiClient
{
	/// <summary>
	/// Permission strings can contain any URL-allowed character, but `*` and a
	/// few others would be reinterpreted by the router otherwise. Encode them
	/// before splicing into the path.
	/// </summary>
	private static string EncodePermission( string permission )
	{
		return Uri.EscapeDataString( permission ?? "" );
	}

	/// <summary>
	/// `GET /permissions/groups`. Returns every group with its direct
	/// permissions inline. Sorted by priority descending then id ascending.
	/// </summary>
	public static async Task<List<MiragePermissionsGroupDetail>> ListGroupsAsync()
	{
		var response = await SendAsync( "/permissions/groups", "GET", null );
		var list = await ReadJsonAsync<List<MiragePermissionsGroupDetail>>( response );
		return list ?? new List<MiragePermissionsGroupDetail>();
	}

	/// <summary>`POST /permissions/groups`. Returns 409 if the id is taken.</summary>
	public static async Task<MiragePermissionsGroupSummary> CreateGroupAsync( MiragePermissionsGroupCreateRequest body )
	{
		var response = await SendAsync( "/permissions/groups", "POST", body );
		return await ReadJsonAsync<MiragePermissionsGroupSummary>( response );
	}

	/// <summary>`PATCH /permissions/groups/:id`.</summary>
	public static async Task PatchGroupAsync( string groupId, MiragePermissionsGroupPatchRequest body )
	{
		var response = await SendAsync( $"/permissions/groups/{groupId}", "PATCH", body );
		await EnsureSuccessAsync( response );
	}

	/// <summary>
	/// `DELETE /permissions/groups/:id`. Returns 409 for the reserved groups
	/// (`owner`, `default`).
	/// </summary>
	public static async Task DeleteGroupAsync( string groupId )
	{
		var response = await SendAsync( $"/permissions/groups/{groupId}", "DELETE", null );
		await EnsureSuccessAsync( response );
	}

	/// <summary>`PUT /permissions/groups/:id/permissions/:permission`. Idempotent.</summary>
	public static async Task AddGroupPermissionAsync( string groupId, string permission )
	{
		var response = await SendAsync( $"/permissions/groups/{groupId}/permissions/{EncodePermission( permission )}", "PUT", null );
		await EnsureSuccessAsync( response );
	}

	/// <summary>`DELETE /permissions/groups/:id/permissions/:permission`.</summary>
	public static async Task RemoveGroupPermissionAsync( string groupId, string permission )
	{
		var response = await SendAsync( $"/permissions/groups/{groupId}/permissions/{EncodePermission( permission )}", "DELETE", null );
		await EnsureSuccessAsync( response );
	}

	/// <summary>
	/// `GET /permissions/players`. Returns every player who has at least one
	/// row in `permissions_player_permissions`. Used by the editor's left rail
	/// to show "players with overrides".
	/// </summary>
	public static async Task<List<MiragePermissionsPlayerOverride>> ListPlayerOverridesAsync()
	{
		var response = await SendAsync( "/permissions/players", "GET", null );
		var list = await ReadJsonAsync<List<MiragePermissionsPlayerOverride>>( response );
		return list ?? new List<MiragePermissionsPlayerOverride>();
	}

	/// <summary>
	/// `GET /permissions/players/:steamId`. Always returns 200; the permissions
	/// list is empty for unknown players.
	/// </summary>
	public static async Task<MiragePermissionsPlayer> GetPlayerPermissionsAsync( long steamId )
	{
		var response = await SendAsync( $"/permissions/players/{steamId}", "GET", null );
		return await ReadJsonAsync<MiragePermissionsPlayer>( response );
	}

	/// <summary>`PUT /permissions/players/:steamId/permissions/:permission`. Idempotent.</summary>
	public static async Task AddPlayerPermissionAsync( long steamId, string permission )
	{
		var response = await SendAsync( $"/permissions/players/{steamId}/permissions/{EncodePermission( permission )}", "PUT", null );
		await EnsureSuccessAsync( response );
	}

	/// <summary>`DELETE /permissions/players/:steamId/permissions/:permission`.</summary>
	public static async Task RemovePlayerPermissionAsync( long steamId, string permission )
	{
		var response = await SendAsync( $"/permissions/players/{steamId}/permissions/{EncodePermission( permission )}", "DELETE", null );
		await EnsureSuccessAsync( response );
	}
}
