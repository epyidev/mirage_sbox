/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Host-side service that backs the permissions editor UI. Exposes
/// <see cref="Rpc.Host"/> entry points the client calls when the operator
/// clicks something in the editor; every entry point re-checks
/// <c>permission.editor</c> on the caller before touching anything.
///
/// Mutations call into the Mirage backend Api, then refresh
/// <see cref="PermissionsSystem"/>'s cache so the next
/// <see cref="PermissionsSystem.Has(long, string)"/> lookup reflects the
/// change, then push a fresh snapshot back to the editor UI.
/// </summary>
public static class MiragePermissionsEditorService
{
	private const string EditorPermission = "permission.editor";

	[Rpc.Host]
	public static void RpcRequestState()
	{
		var caller = Rpc.Caller;
		if ( caller is null ) return;
		_ = HandleRequestStateAsync( caller );
	}

	[Rpc.Host]
	public static void RpcCreateGroup( string id, string displayName, int priority )
	{
		var caller = Rpc.Caller;
		if ( caller is null ) return;
		_ = HandleCreateGroupAsync( caller, id, displayName, priority );
	}

	[Rpc.Host]
	public static void RpcPatchGroup( string id, string displayName, int priority )
	{
		var caller = Rpc.Caller;
		if ( caller is null ) return;
		_ = HandlePatchGroupAsync( caller, id, displayName, priority );
	}

	[Rpc.Host]
	public static void RpcDeleteGroup( string id )
	{
		var caller = Rpc.Caller;
		if ( caller is null ) return;
		_ = HandleDeleteGroupAsync( caller, id );
	}

	[Rpc.Host]
	public static void RpcAddGroupPermission( string groupId, string permission )
	{
		var caller = Rpc.Caller;
		if ( caller is null ) return;
		_ = HandleAddGroupPermissionAsync( caller, groupId, permission );
	}

	[Rpc.Host]
	public static void RpcRemoveGroupPermission( string groupId, string permission )
	{
		var caller = Rpc.Caller;
		if ( caller is null ) return;
		_ = HandleRemoveGroupPermissionAsync( caller, groupId, permission );
	}

	[Rpc.Host]
	public static void RpcAddPlayerPermission( string steamId, string permission )
	{
		var caller = Rpc.Caller;
		if ( caller is null ) return;
		_ = HandleAddPlayerPermissionAsync( caller, steamId, permission );
	}

	[Rpc.Host]
	public static void RpcRemovePlayerPermission( string steamId, string permission )
	{
		var caller = Rpc.Caller;
		if ( caller is null ) return;
		_ = HandleRemovePlayerPermissionAsync( caller, steamId, permission );
	}

	private static bool RequireEditor( Connection caller, out string error )
	{
		if ( !PermissionsSystem.Current.Has( caller, EditorPermission ) )
		{
			error = "Vous n'avez pas la permission de faire cela.";
			return false;
		}
		error = null;
		return true;
	}

	private static async Task HandleRequestStateAsync( Connection caller )
	{
		if ( !RequireEditor( caller, out var err ) ) { await GameTask.MainThread(); DeliverError( caller, err ); return; }
		await RefreshAndDeliverAsync( caller );
	}

	private static async Task HandleCreateGroupAsync( Connection caller, string id, string displayName, int priority )
	{
		if ( !RequireEditor( caller, out var err ) ) { await GameTask.MainThread(); DeliverError( caller, err ); return; }

		try
		{
			await MirageApiClient.CreateGroupAsync( new MiragePermissionsGroupCreateRequest
			{
				Id = id,
				DisplayName = displayName,
				Priority = priority
			} );
			await PermissionsSystem.Current.ReloadGroupsAsync();
			await RefreshAndDeliverAsync( caller );
		}
		catch ( MirageApiException ex )
		{
			await GameTask.MainThread();
			DeliverError( caller, ex.StatusCode == 409 ? "Cet identifiant de groupe est déjà pris." : "Impossible de créer le groupe." );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] CreateGroup failed: {ex}" );
			await GameTask.MainThread();
			DeliverError( caller, "Impossible de créer le groupe." );
		}
	}

	private static async Task HandlePatchGroupAsync( Connection caller, string id, string displayName, int priority )
	{
		if ( !RequireEditor( caller, out var err ) ) { await GameTask.MainThread(); DeliverError( caller, err ); return; }

		try
		{
			await MirageApiClient.PatchGroupAsync( id, new MiragePermissionsGroupPatchRequest
			{
				DisplayName = displayName,
				Priority = priority
			} );
			await PermissionsSystem.Current.ReloadGroupsAsync();
			await RefreshAndDeliverAsync( caller );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] PatchGroup failed: {ex}" );
			await GameTask.MainThread();
			DeliverError( caller, "Impossible de modifier le groupe." );
		}
	}

	private static async Task HandleDeleteGroupAsync( Connection caller, string id )
	{
		if ( !RequireEditor( caller, out var err ) ) { await GameTask.MainThread(); DeliverError( caller, err ); return; }

		if ( string.Equals( id, PermissionsSystem.OwnerGroupId, StringComparison.OrdinalIgnoreCase )
			|| string.Equals( id, PermissionsSystem.DefaultGroupId, StringComparison.OrdinalIgnoreCase ) )
		{
			await GameTask.MainThread();
			DeliverError( caller, "Ce groupe ne peut pas être supprimé." );
			return;
		}

		try
		{
			await MirageApiClient.DeleteGroupAsync( id );
			await PermissionsSystem.Current.ReloadGroupsAsync();
			await RefreshAndDeliverAsync( caller );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] DeleteGroup failed: {ex}" );
			await GameTask.MainThread();
			DeliverError( caller, "Impossible de supprimer le groupe." );
		}
	}

	private static async Task HandleAddGroupPermissionAsync( Connection caller, string groupId, string permission )
	{
		if ( !RequireEditor( caller, out var err ) ) { await GameTask.MainThread(); DeliverError( caller, err ); return; }

		try
		{
			await MirageApiClient.AddGroupPermissionAsync( groupId, permission );
			await PermissionsSystem.Current.ReloadGroupsAsync();
			await RefreshAndDeliverAsync( caller );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] AddGroupPermission failed: {ex}" );
			await GameTask.MainThread();
			DeliverError( caller, "Impossible d'ajouter la permission au groupe." );
		}
	}

	private static async Task HandleRemoveGroupPermissionAsync( Connection caller, string groupId, string permission )
	{
		if ( !RequireEditor( caller, out var err ) ) { await GameTask.MainThread(); DeliverError( caller, err ); return; }

		try
		{
			await MirageApiClient.RemoveGroupPermissionAsync( groupId, permission );
			await PermissionsSystem.Current.ReloadGroupsAsync();
			await RefreshAndDeliverAsync( caller );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] RemoveGroupPermission failed: {ex}" );
			await GameTask.MainThread();
			DeliverError( caller, "Impossible de retirer la permission du groupe." );
		}
	}

	private static async Task HandleAddPlayerPermissionAsync( Connection caller, string steamIdString, string permission )
	{
		if ( !RequireEditor( caller, out var err ) ) { await GameTask.MainThread(); DeliverError( caller, err ); return; }

		if ( !long.TryParse( steamIdString, out var sid ) || sid <= 0 )
		{
			await GameTask.MainThread();
			DeliverError( caller, "SteamID invalide." );
			return;
		}

		try
		{
			await MirageApiClient.AddPlayerPermissionAsync( sid, permission );
			await PermissionsSystem.Current.ReloadPlayerAsync( sid );
			await RefreshAndDeliverAsync( caller );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] AddPlayerPermission failed: {ex}" );
			await GameTask.MainThread();
			DeliverError( caller, "Impossible d'ajouter la permission au joueur." );
		}
	}

	private static async Task HandleRemovePlayerPermissionAsync( Connection caller, string steamIdString, string permission )
	{
		if ( !RequireEditor( caller, out var err ) ) { await GameTask.MainThread(); DeliverError( caller, err ); return; }

		if ( !long.TryParse( steamIdString, out var sid ) || sid <= 0 )
		{
			await GameTask.MainThread();
			DeliverError( caller, "SteamID invalide." );
			return;
		}

		try
		{
			await MirageApiClient.RemovePlayerPermissionAsync( sid, permission );
			await PermissionsSystem.Current.ReloadPlayerAsync( sid );
			await RefreshAndDeliverAsync( caller );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] RemovePlayerPermission failed: {ex}" );
			await GameTask.MainThread();
			DeliverError( caller, "Impossible de retirer la permission du joueur." );
		}
	}

	private static async Task RefreshAndDeliverAsync( Connection caller )
	{
		try
		{
			var snap = await BuildSnapshotAsync();
			await GameTask.MainThread();
			DeliverState( caller, snap );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] RefreshAndDeliver failed: {ex}" );
			await GameTask.MainThread();
			DeliverError( caller, "Impossible de récupérer l'état des permissions." );
		}
	}

	private static async Task<MiragePermissionsEditorSnapshot> BuildSnapshotAsync()
	{
		// Sequential awaits: the s&box code sandbox forbids the ReadOnlySpan
		// overload of Task.WhenAll, and the latency cost is negligible for the
		// editor's open/refresh path.
		var groups = await MirageApiClient.ListGroupsAsync();
		var overrides = await MirageApiClient.ListPlayerOverridesAsync();

		var snap = new MiragePermissionsEditorSnapshot();

		foreach ( var g in groups )
		{
			snap.Groups.Add( new MiragePermissionsEditorGroupEntry
			{
				Id = g.Id,
				DisplayName = g.DisplayName,
				Priority = g.Priority,
				Permissions = g.Permissions ?? new List<string>()
			} );
		}

		foreach ( var ov in overrides )
		{
			if ( !long.TryParse( ov.SteamId, out var sid ) ) continue;
			var detail = await MirageApiClient.GetPlayerPermissionsAsync( sid );
			var conn = Connection.All.FirstOrDefault( c => (long)c.SteamId == sid );
			snap.Players.Add( new MiragePermissionsEditorPlayerEntry
			{
				SteamId = ov.SteamId,
				DisplayName = conn?.DisplayName ?? "",
				Permissions = detail?.Permissions ?? new List<string>()
			} );
		}

		return snap;
	}

	private static void DeliverState( Connection target, MiragePermissionsEditorSnapshot snap )
	{
		var json = Sandbox.Json.Serialize( snap );
		using ( Rpc.FilterInclude( target ) )
			RpcDeliverState( json );
	}

	private static void DeliverError( Connection target, string message )
	{
		using ( Rpc.FilterInclude( target ) )
			RpcDeliverError( message ?? "Unknown error." );
	}

	[Rpc.Broadcast( NetFlags.HostOnly | NetFlags.Reliable )]
	private static void RpcDeliverState( string json )
	{
		if ( string.IsNullOrEmpty( json ) )
		{
			MiragePermissionsEditorState.SetSnapshot( new MiragePermissionsEditorSnapshot() );
			return;
		}
		var snap = Sandbox.Json.Deserialize<MiragePermissionsEditorSnapshot>( json );
		MiragePermissionsEditorState.SetSnapshot( snap );
	}

	[Rpc.Broadcast( NetFlags.HostOnly | NetFlags.Reliable )]
	private static void RpcDeliverError( string message )
	{
		MiragePermissionsEditorState.SetError( message );
	}
}
