/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Resolves the <c>&lt;id|me&gt;</c> argument shared by most staff commands
/// (<c>/give</c>, <c>/clearinv</c>, <c>/relog</c>, <c>/goto</c>, <c>/bring</c>, ...)
/// to a connected <see cref="Player"/>. Outputs a localized French error
/// message via <see cref="CommandContext.ReplyError"/> when the lookup
/// fails, and returns null in that case so callers can simply
/// <c>if (player is null) return;</c>.
///
/// Three classes of failure are reported with distinct messages so the
/// admin can tell them apart at a glance:
///   - "me" with no active session (rare, mostly defensive),
///   - the token is not a valid id ("abc"),
///   - no player matches the id (offline or wrong number),
///   - the player matches but has no active character (limbo / character select).
/// </summary>
public static class MiragePlayerLookup
{
	/// <summary>
	/// Resolve <paramref name="token"/> to a connected player. <paramref name="requireActiveCharacter"/>
	/// gates the result behind <see cref="PlayerData.HasActiveCharacter"/>:
	/// commands that touch RP state (give, clearinv, relog, ...) need the
	/// target to be in-game, not in the character-select limbo. Some
	/// commands (e.g. an admin-only kick) might want to find a target even
	/// in limbo, hence the toggle.
	/// </summary>
	public static Player Resolve( CommandContext ctx, string token, bool requireActiveCharacter = true )
	{
		if ( ctx is null ) return null;
		if ( string.IsNullOrEmpty( token ) )
		{
			ctx.ReplyError( "Cible manquante. Utilise <id> ou « me »." );
			return null;
		}

		Player target;

		if ( string.Equals( token, "me", StringComparison.OrdinalIgnoreCase ) )
		{
			target = FindByConnection( ctx.Caller );
			if ( target is null )
			{
				ctx.ReplyError( "Impossible de retrouver ta propre session." );
				return null;
			}
		}
		else if ( int.TryParse( token, out var mirageId ) && mirageId > 0 )
		{
			target = FindByMirageId( mirageId );
			if ( target is null )
			{
				ctx.ReplyError( $"Aucun joueur connecté avec l'id {mirageId}." );
				return null;
			}
		}
		else
		{
			ctx.ReplyError( $"Cible invalide : « {token} ». Attendu : un id numérique ou « me »." );
			return null;
		}

		if ( requireActiveCharacter )
		{
			var pd = target.PlayerData;
			if ( pd is null || !pd.HasActiveCharacter )
			{
				ctx.ReplyError( "Le joueur ciblé n'a pas de personnage actif (sélection en cours)." );
				return null;
			}
		}

		return target;
	}

	/// <summary>
	/// Resolve to a connected player without printing any chat error.
	/// Useful when a command wants to handle the failure itself (e.g.
	/// the items browser silently refuses to give to limbo players).
	/// </summary>
	public static Player TryResolveSilent( Connection caller, string token, bool requireActiveCharacter = true )
	{
		if ( string.IsNullOrEmpty( token ) ) return null;
		Player target;
		if ( string.Equals( token, "me", StringComparison.OrdinalIgnoreCase ) )
		{
			target = FindByConnection( caller );
		}
		else if ( int.TryParse( token, out var mirageId ) && mirageId > 0 )
		{
			target = FindByMirageId( mirageId );
		}
		else
		{
			return null;
		}
		if ( target is null ) return null;
		if ( requireActiveCharacter )
		{
			var pd = target.PlayerData;
			if ( pd is null || !pd.HasActiveCharacter ) return null;
		}
		return target;
	}

	private static Player FindByConnection( Connection caller )
	{
		if ( caller is null ) return null;
		return Game.ActiveScene.GetAll<Player>()
			.FirstOrDefault( p => p.Network.Owner?.Id == caller.Id );
	}

	private static Player FindByMirageId( int mirageId )
	{
		if ( mirageId <= 0 ) return null;
		return Game.ActiveScene.GetAll<Player>()
			.FirstOrDefault( p => p.PlayerData?.MirageId == mirageId );
	}
}
