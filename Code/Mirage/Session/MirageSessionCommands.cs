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
	/// <c>/relog &lt;id|me&gt;</c> flushes the target character to the API
	/// and sends them back to the character-selection limbo, without
	/// disconnecting. Self-target with <c>me</c>; admin-target with a
	/// numeric Mirage id. Permission gated by <c>command.relog</c>.
	/// </summary>
	public static void HandleRelog( CommandContext ctx )
	{
		if ( ctx.Args.Length < 1 )
		{
			ctx.ReplyError( "Usage : /relog <id|me>." );
			return;
		}

		var target = MiragePlayerLookup.Resolve( ctx, ctx.Args[0] );
		if ( target is null ) return;

		var caller = FindCallerPlayer( ctx );
		var who = target == caller ? "toi" : $"#{target.PlayerData?.MirageId}";
		ctx.Reply( $"Sauvegarde et retour à la sélection pour {who}..." );
		_ = MirageSession.SendBackToCharacterSelectAsync( target );
	}

	/// <summary>
	/// <c>/savecharacter all</c> flushes every connected character.
	/// <c>/savecharacter specific &lt;id&gt;</c> flushes a single one.
	/// Useful before a server reboot or to make sure a specific player's
	/// state is on disk. Permission gated by <c>command.savecharacter</c>.
	/// </summary>
	public static void HandleSaveCharacter( CommandContext ctx )
	{
		if ( ctx.Args.Length < 1 )
		{
			ctx.ReplyError( "Usage : /savecharacter all   |   /savecharacter specific <id>." );
			return;
		}

		var mode = ctx.Args[0];
		if ( string.Equals( mode, "all", StringComparison.OrdinalIgnoreCase ) )
		{
			ctx.Reply( "Sauvegarde de tous les personnages connectés en cours..." );
			_ = SaveAllAsync( ctx );
			return;
		}

		if ( string.Equals( mode, "specific", StringComparison.OrdinalIgnoreCase ) )
		{
			if ( ctx.Args.Length < 2 )
			{
				ctx.ReplyError( "Usage : /savecharacter specific <id>." );
				return;
			}
			var target = MiragePlayerLookup.Resolve( ctx, ctx.Args[1] );
			if ( target is null ) return;
			ctx.Reply( $"Sauvegarde de #{target.PlayerData?.MirageId} en cours..." );
			_ = SaveOneAsync( ctx, target );
			return;
		}

		ctx.ReplyError( "Sous-commande inconnue. Utilise « all » ou « specific <id> »." );
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
			Log.Warning( $"[Mirage] /savecharacter all crashed: {ex.Message}" );
			ctx.ReplyError( "Echec de la sauvegarde, regarde les logs serveur." );
		}
	}

	private static async Task SaveOneAsync( CommandContext ctx, Player target )
	{
		try
		{
			await MirageCharacterSave.FlushPlayerAsync( target );
			ctx.Reply( $"Sauvegarde terminée pour #{target.PlayerData?.MirageId}." );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] /savecharacter specific crashed: {ex.Message}" );
			ctx.ReplyError( "Echec de la sauvegarde, regarde les logs serveur." );
		}
	}

	/// <summary>
	/// <c>/goto &lt;id&gt;</c> teleports the caller to the target's current
	/// position. Permission gated by <c>command.goto</c>.
	/// </summary>
	public static void HandleGoto( CommandContext ctx )
	{
		if ( ctx.Args.Length < 1 )
		{
			ctx.ReplyError( "Usage : /goto <id>." );
			return;
		}

		var caller = FindCallerPlayer( ctx );
		if ( caller is null ) { ctx.ReplyError( "Joueur appelant introuvable." ); return; }

		var target = MiragePlayerLookup.Resolve( ctx, ctx.Args[0] );
		if ( target is null ) return;
		if ( target == caller ) { ctx.ReplyError( "Tu ne peux pas te téléporter à toi-même." ); return; }

		var dest = target.WorldPosition;
		var yaw = caller.Controller.IsValid() ? caller.Controller.EyeAngles.yaw : 0f;
		caller.MirageTeleport( dest, new Angles( 0f, yaw, 0f ) );
		ctx.Reply( $"Téléporté vers #{target.PlayerData?.MirageId}." );
	}

	/// <summary>
	/// <c>/bring &lt;id&gt;</c> teleports the target onto the caller's
	/// position. Permission gated by <c>command.bring</c>.
	/// </summary>
	public static void HandleBring( CommandContext ctx )
	{
		if ( ctx.Args.Length < 1 )
		{
			ctx.ReplyError( "Usage : /bring <id>." );
			return;
		}

		var caller = FindCallerPlayer( ctx );
		if ( caller is null ) { ctx.ReplyError( "Joueur appelant introuvable." ); return; }

		var target = MiragePlayerLookup.Resolve( ctx, ctx.Args[0] );
		if ( target is null ) return;
		if ( target == caller ) { ctx.ReplyError( "Tu es déjà sur toi-même." ); return; }

		var dest = caller.WorldPosition;
		var yaw = target.Controller.IsValid() ? target.Controller.EyeAngles.yaw : 0f;
		target.MirageTeleport( dest, new Angles( 0f, yaw, 0f ) );
		ctx.Reply( $"#{target.PlayerData?.MirageId} a été ramené à toi." );
	}

	private static Player FindCallerPlayer( CommandContext ctx )
	{
		if ( ctx.Caller is null ) return null;
		return Game.ActiveScene.GetAll<Player>()
			.FirstOrDefault( p => p.Network.Owner?.Id == ctx.Caller.Id );
	}
}
