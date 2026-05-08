/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Chat-command handlers for character lifecycle. Wired into
/// <see cref="MirageCommands.Register"/>; each entry runs on the host
/// after <see cref="CommandRegistry"/> has already verified the caller's
/// permission.
/// </summary>
public static class MirageSessionCommands
{
	/// <summary>
	/// <c>/relog</c> flushes the caller's character to the API and sends
	/// them back to the character-selection limbo, without disconnecting.
	/// Permission gated by <c>command.relog</c>.
	/// </summary>
	public static void HandleRelog( CommandContext ctx )
	{
		var player = FindCallerPlayer( ctx );
		if ( player is null ) { ctx.ReplyError( "Joueur introuvable." ); return; }
		var pd = player.PlayerData;
		if ( pd is null || !pd.HasActiveCharacter )
		{
			ctx.ReplyError( "Aucun personnage actif." );
			return;
		}

		ctx.Reply( "Sauvegarde et retour à la sélection de personnage..." );
		_ = MirageSession.SendBackToCharacterSelectAsync( player );
	}

	/// <summary>
	/// <c>/saveallcharacters</c> manually flushes every connected
	/// character. Used before a server reboot so an admin can be sure
	/// nothing is stuck in memory. Permission gated by
	/// <c>command.saveallcharacters</c>.
	/// </summary>
	public static void HandleSaveAllCharacters( CommandContext ctx )
	{
		ctx.Reply( "Sauvegarde de tous les personnages connectés en cours..." );
		_ = SaveAllAsync( ctx );
	}

	private static async Task SaveAllAsync( CommandContext ctx )
	{
		try
		{
			var count = await MirageCharacterSave.FlushAllAsync();
			ctx.Reply( $"Sauvegarde terminée : {count} personnage(s) flushé(s)." );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] /saveallcharacters crashed: {ex.Message}" );
			ctx.ReplyError( "Echec de la sauvegarde, regarde les logs serveur." );
		}
	}

	private static Player FindCallerPlayer( CommandContext ctx )
	{
		if ( ctx.Caller is null ) return null;
		return Game.ActiveScene.GetAll<Player>()
			.FirstOrDefault( p => p.Network.Owner?.Id == ctx.Caller.Id );
	}
}
