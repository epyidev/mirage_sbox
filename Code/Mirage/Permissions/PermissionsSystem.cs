/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Authoritative permissions cache, host-side. Loads groups and per-player
/// permissions from the Mirage backend Api, resolves group inheritance and
/// the implicit <c>_group.default</c> membership, and answers
/// <see cref="Has(long, string)"/> queries against the resolved set.
///
/// Group inheritance is encoded as a permission string of the form
/// <c>_group.&lt;id&gt;</c>: when present in a group's or a player's permission
/// list, the holder gains every permission of that group, recursively. Cycles
/// are guarded against with a visited set.
///
/// Each connected client receives its own effective set via a filtered RPC,
/// stored in <see cref="MiragePermissionsState"/> for client-side filtering.
/// </summary>
public sealed class PermissionsSystem : GameObjectSystem<PermissionsSystem>, ISceneStartup, Component.INetworkListener
{
	public const string GroupPrefix = "_group.";
	public const string DefaultGroupId = "default";
	public const string OwnerGroupId = "owner";

	public sealed class GroupSnapshot
	{
		public string Id { get; init; }
		public string DisplayName { get; init; }
		public int Priority { get; init; }
		public HashSet<string> Permissions { get; init; } = new( StringComparer.OrdinalIgnoreCase );
	}

	private readonly Dictionary<string, GroupSnapshot> _groups = new( StringComparer.OrdinalIgnoreCase );
	private readonly Dictionary<long, HashSet<string>> _playerDirect = new();
	private readonly Dictionary<long, HashSet<string>> _playerEffective = new();

	private bool _groupsLoaded;

	public PermissionsSystem( Scene scene ) : base( scene )
	{
	}

	void ISceneStartup.OnHostInitialize()
	{
		_ = LoadAllGroupsAsync();
	}

	void Component.INetworkListener.OnActive( Connection channel )
	{
		if ( !Networking.IsHost || channel is null ) return;
		_ = LoadPlayerAsync( (long)channel.SteamId, channel );
	}

	void Component.INetworkListener.OnDisconnected( Connection channel )
	{
		if ( !Networking.IsHost || channel is null ) return;
		var sid = (long)channel.SteamId;
		_playerDirect.Remove( sid );
		_playerEffective.Remove( sid );
	}

	/// <summary>
	/// True if the effective set for <paramref name="steamId"/> matches
	/// <paramref name="permission"/>. Wildcards (<c>*</c>, <c>prefix.*</c>) are
	/// resolved by <see cref="PermissionMatcher"/>.
	/// </summary>
	public bool Has( long steamId, string permission )
	{
		if ( !_playerEffective.TryGetValue( steamId, out var set ) ) return false;
		return PermissionMatcher.AnyMatches( set, permission );
	}

	public bool Has( Connection conn, string permission )
	{
		return conn != null && Has( (long)conn.SteamId, permission );
	}

	public IReadOnlyCollection<string> EffectiveFor( long steamId )
	{
		return _playerEffective.TryGetValue( steamId, out var set ) ? set : Array.Empty<string>();
	}

	/// <summary>Direct permission rows for a player, as returned by the Api.</summary>
	public IReadOnlyCollection<string> DirectFor( long steamId )
	{
		return _playerDirect.TryGetValue( steamId, out var set ) ? set : Array.Empty<string>();
	}

	/// <summary>Snapshot of every group, ordered priority desc then id asc.</summary>
	public IReadOnlyList<GroupSnapshot> AllGroups()
	{
		return _groups.Values
			.OrderByDescending( g => g.Priority )
			.ThenBy( g => g.Id, StringComparer.Ordinal )
			.ToArray();
	}

	public GroupSnapshot Group( string id )
	{
		if ( string.IsNullOrEmpty( id ) ) return null;
		return _groups.TryGetValue( id, out var snap ) ? snap : null;
	}

	public bool GroupsLoaded => _groupsLoaded;

	/// <summary>Reload every group from the Api and recompute connected players.</summary>
	public Task ReloadGroupsAsync() => LoadAllGroupsAsync();

	/// <summary>Reload one player's direct rows and recompute their effective set.</summary>
	public Task ReloadPlayerAsync( long steamId )
	{
		var conn = Connection.All.FirstOrDefault( c => (long)c.SteamId == steamId );
		return LoadPlayerAsync( steamId, conn );
	}

	private async Task LoadAllGroupsAsync()
	{
		try
		{
			var list = await MirageApiClient.ListGroupsAsync();
			await GameTask.MainThread();

			_groups.Clear();
			foreach ( var g in list )
			{
				if ( string.IsNullOrEmpty( g?.Id ) ) continue;
				_groups[g.Id] = new GroupSnapshot
				{
					Id = g.Id,
					DisplayName = g.DisplayName ?? g.Id,
					Priority = g.Priority,
					Permissions = new HashSet<string>( g.Permissions ?? new(), StringComparer.OrdinalIgnoreCase )
				};
			}

			_groupsLoaded = true;

			// Group changes invalidate every connected player's effective set.
			foreach ( var sid in _playerDirect.Keys.ToArray() )
			{
				RecomputeEffective( sid );
				BroadcastEffectiveTo( sid );
			}
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] Failed to load permission groups: {ex.Message}" );
		}
	}

	private async Task LoadPlayerAsync( long steamId, Connection channel )
	{
		try
		{
			var resp = await MirageApiClient.GetPlayerPermissionsAsync( steamId );
			await GameTask.MainThread();

			var direct = new HashSet<string>( resp?.Permissions ?? new(), StringComparer.OrdinalIgnoreCase );
			_playerDirect[steamId] = direct;
			RecomputeEffective( steamId );

			if ( channel != null )
			{
				DeliverEffectiveTo( channel, steamId );
			}
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] Failed to load permissions for {steamId}: {ex.Message}" );
		}
	}

	private void RecomputeEffective( long steamId )
	{
		if ( !_playerDirect.TryGetValue( steamId, out var direct ) )
		{
			_playerEffective[steamId] = new HashSet<string>( StringComparer.OrdinalIgnoreCase );
			return;
		}

		var effective = new HashSet<string>( StringComparer.OrdinalIgnoreCase );
		var visited = new HashSet<string>( StringComparer.OrdinalIgnoreCase );
		var pending = new Queue<string>();

		// _group.default is implicit on every player: never written to the
		// player_permissions table, always added at resolution time.
		pending.Enqueue( DefaultGroupId );

		foreach ( var p in direct )
		{
			if ( IsGroupPermission( p, out var gid ) ) pending.Enqueue( gid );
			else effective.Add( p );
		}

		while ( pending.Count > 0 )
		{
			var gid = pending.Dequeue();
			if ( !visited.Add( gid ) ) continue;
			if ( !_groups.TryGetValue( gid, out var snap ) ) continue;

			foreach ( var p in snap.Permissions )
			{
				if ( IsGroupPermission( p, out var sub ) ) pending.Enqueue( sub );
				else effective.Add( p );
			}
		}

		_playerEffective[steamId] = effective;
	}

	public static bool IsGroupPermission( string permission, out string groupId )
	{
		if ( permission != null && permission.StartsWith( GroupPrefix, StringComparison.OrdinalIgnoreCase ) )
		{
			groupId = permission.Substring( GroupPrefix.Length );
			return groupId.Length > 0;
		}
		groupId = null;
		return false;
	}

	private void BroadcastEffectiveTo( long steamId )
	{
		var conn = Connection.All.FirstOrDefault( c => (long)c.SteamId == steamId );
		if ( conn != null ) DeliverEffectiveTo( conn, steamId );
	}

	private void DeliverEffectiveTo( Connection conn, long steamId )
	{
		if ( !_playerEffective.TryGetValue( steamId, out var set ) ) return;
		var json = Sandbox.Json.Serialize( set.ToArray() );
		using ( Rpc.FilterInclude( conn ) )
			RpcDeliverEffective( json );
	}

	[Rpc.Broadcast( NetFlags.HostOnly | NetFlags.Reliable )]
	private static void RpcDeliverEffective( string json )
	{
		var arr = string.IsNullOrEmpty( json )
			? Array.Empty<string>()
			: Sandbox.Json.Deserialize<string[]>( json );
		MiragePermissionsState.SetLocalEffective( arr );
	}
}
