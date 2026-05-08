/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Pattern matching for stored permission strings against a query.
///
/// Three forms of pattern are supported:
/// <list type="bullet">
///   <item><c>*</c> matches every permission.</item>
///   <item><c>prefix.*</c> matches every permission whose dot-separated path
///   starts with <c>prefix.</c>, at any depth (so <c>command.*</c> matches
///   <c>command.goto</c> AND <c>command.admin.kick</c>).</item>
///   <item>Anything else is matched literally, case-insensitive.</item>
/// </list>
/// </summary>
public static class PermissionMatcher
{
	public static bool Matches( string pattern, string permission )
	{
		if ( string.IsNullOrEmpty( pattern ) ) return false;
		if ( string.IsNullOrEmpty( permission ) ) return false;

		if ( pattern == "*" ) return true;

		if ( pattern.EndsWith( ".*", StringComparison.Ordinal ) )
		{
			// Keep the trailing dot so "command.*" only matches things scoped
			// under "command.", never "commandx".
			var prefix = pattern.Substring( 0, pattern.Length - 1 );
			return permission.StartsWith( prefix, StringComparison.OrdinalIgnoreCase );
		}

		return string.Equals( pattern, permission, StringComparison.OrdinalIgnoreCase );
	}

	public static bool AnyMatches( IEnumerable<string> patterns, string permission )
	{
		if ( patterns is null ) return false;
		foreach ( var p in patterns )
		{
			if ( Matches( p, permission ) ) return true;
		}
		return false;
	}
}
