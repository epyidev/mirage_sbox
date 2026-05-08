/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Chat command handlers for the Mirage inventory. Wired into
/// <see cref="MirageCommands.Register"/>; each entry is gated on the
/// matching permission and runs on the host with the caller's player as
/// the target.
/// </summary>
public static class MirageInventoryCommands
{
	/// <summary>
	/// <c>/give &lt;id|me&gt; &lt;itemId&gt; [count]</c> gives an item to the
	/// target player. The target must be connected and out of the
	/// character-selection limbo (an empty inventory has no slots to
	/// write to). <c>me</c> targets the caller.
	/// </summary>
	public static void HandleGive( CommandContext ctx )
	{
		if ( ctx.Args.Length < 2 )
		{
			ctx.ReplyError( "Usage : /give <id|me> <itemId> [count]." );
			return;
		}

		var target = MiragePlayerLookup.Resolve( ctx, ctx.Args[0] );
		if ( target is null ) return;

		var itemId = ctx.Args[1];
		if ( !MirageItems.IsKnown( itemId ) )
		{
			ctx.ReplyError( $"Item inconnu : « {itemId} ». Tape /items pour la liste." );
			return;
		}

		var count = 1;
		if ( ctx.Args.Length >= 3 && int.TryParse( ctx.Args[2], out var parsed ) && parsed > 0 )
		{
			count = parsed;
		}

		var inv = target.GetComponent<MirageInventory>();
		if ( inv is null ) { ctx.ReplyError( "Inventaire indisponible." ); return; }

		var leftover = inv.Add( itemId, count );
		MirageInventoryEquip.ApplyEquip( target, inv );

		var given = count - leftover;
		var who = target == FindCallerPlayer( ctx ) ? "toi" : $"#{target.PlayerData?.MirageId}";
		if ( given <= 0 )
		{
			ctx.ReplyError( $"Inventaire de {who} plein." );
			return;
		}
		if ( leftover > 0 )
		{
			ctx.Reply( $"{given}x {itemId} donné(s) à {who}. {leftover} unités n'ont pas pu rentrer." );
		}
		else
		{
			ctx.Reply( $"{given}x {itemId} donné(s) à {who}." );
		}
	}

	/// <summary>
	/// `/items` opens the catalogue browser panel on the caller's client
	/// instead of dumping the whole list into the chat (illisible past a
	/// dozen entries). Permission-gated like /give since the panel can
	/// also call RpcGiveSelf inline.
	/// </summary>
	public static void HandleItems( CommandContext ctx )
	{
		MirageItemsBrowserBridge.OpenForCaller( ctx.Caller );
	}

	/// <summary>
	/// <c>/clearinv &lt;id|me&gt;</c> wipes the target's inventory. Self-target
	/// with <c>me</c>; admin-target with a numeric Mirage id.
	/// </summary>
	public static void HandleClear( CommandContext ctx )
	{
		if ( ctx.Args.Length < 1 )
		{
			ctx.ReplyError( "Usage : /clearinv <id|me>." );
			return;
		}

		var target = MiragePlayerLookup.Resolve( ctx, ctx.Args[0] );
		if ( target is null ) return;

		var inv = target.GetComponent<MirageInventory>();
		if ( inv is null ) { ctx.ReplyError( "Inventaire indisponible." ); return; }
		inv.ClearAll();
		MirageInventoryEquip.ApplyEquip( target, inv );

		var who = target == FindCallerPlayer( ctx ) ? "ton inventaire" : $"l'inventaire de #{target.PlayerData?.MirageId}";
		ctx.Reply( $"{who} a été vidé." );
	}

	private static Player FindCallerPlayer( CommandContext ctx )
	{
		if ( ctx.Caller is null ) return null;
		return Game.ActiveScene.GetAll<Player>().FirstOrDefault( p => p.Network.Owner?.Id == ctx.Caller.Id );
	}
}
