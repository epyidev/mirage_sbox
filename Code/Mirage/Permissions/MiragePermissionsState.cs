/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Client-side mirror of the local player's effective permission set, kept in
/// sync by RPCs from <see cref="PermissionsSystem"/>. UIs read from here when
/// they need to know what to render or what suggestions to filter.
///
/// Only the local player's effective set is replicated to a given client. Any
/// other player's permissions are server-private.
/// </summary>
public static class MiragePermissionsState
{
	private static HashSet<string> _localEffective = new( StringComparer.OrdinalIgnoreCase );

	/// <summary>Increments on every delivery. UIs watch this to re-render.</summary>
	public static int Version { get; private set; }

	/// <summary>True once the host has delivered at least one snapshot.</summary>
	public static bool HasSnapshot { get; private set; }

	public static IReadOnlyCollection<string> LocalEffective => _localEffective;

	/// <summary>True if the local player's effective set matches the query.</summary>
	public static bool HasLocal( string permission )
	{
		return PermissionMatcher.AnyMatches( _localEffective, permission );
	}

	internal static void SetLocalEffective( IEnumerable<string> perms )
	{
		_localEffective = new HashSet<string>( perms ?? Array.Empty<string>(), StringComparer.OrdinalIgnoreCase );
		HasSnapshot = true;
		Version++;
	}

	internal static void Reset()
	{
		_localEffective.Clear();
		HasSnapshot = false;
		Version++;
	}
}
