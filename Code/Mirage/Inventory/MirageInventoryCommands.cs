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
	/// `/give &lt;itemId&gt; [count]` adds an item to the caller's inventory.
	/// </summary>
	public static void HandleGive( CommandContext ctx )
	{
		if ( ctx.Args.Length < 1 )
		{
			ctx.ReplyError( "Usage : /give <itemId> [count]." );
			return;
		}

		var itemId = ctx.Args[0];
		if ( !MirageItems.IsKnown( itemId ) )
		{
			ctx.ReplyError( $"Item inconnu : « {itemId} ». Tape /items pour la liste." );
			return;
		}

		var count = 1;
		if ( ctx.Args.Length >= 2 && int.TryParse( ctx.Args[1], out var parsed ) && parsed > 0 )
		{
			count = parsed;
		}

		var player = FindCallerPlayer( ctx );
		if ( player is null ) { ctx.ReplyError( "Joueur introuvable." ); return; }
		var inv = player.GetComponent<MirageInventory>();
		if ( inv is null ) { ctx.ReplyError( "Inventaire indisponible." ); return; }

		var leftover = inv.Add( itemId, count );
		MirageInventoryEquip.ApplyEquip( player, inv );

		var given = count - leftover;
		if ( given <= 0 )
		{
			ctx.ReplyError( "Inventaire plein." );
			return;
		}
		if ( leftover > 0 )
		{
			ctx.Reply( $"{given}x {itemId} ajouté(s). {leftover} unités n'ont pas pu rentrer." );
		}
		else
		{
			ctx.Reply( $"{given}x {itemId} ajouté(s)." );
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

	public static void HandleClear( CommandContext ctx )
	{
		var player = FindCallerPlayer( ctx );
		if ( player is null ) { ctx.ReplyError( "Joueur introuvable." ); return; }
		var inv = player.GetComponent<MirageInventory>();
		if ( inv is null ) { ctx.ReplyError( "Inventaire indisponible." ); return; }
		inv.Replace( Array.Empty<MirageInventorySlot>() );
		MirageInventoryEquip.ApplyEquip( player, inv );
		ctx.Reply( "Inventaire vidé." );
	}

	private static Player FindCallerPlayer( CommandContext ctx )
	{
		if ( ctx.Caller is null ) return null;
		return Game.ActiveScene.GetAll<Player>().FirstOrDefault( p => p.Network.Owner?.Id == ctx.Caller.Id );
	}
}
