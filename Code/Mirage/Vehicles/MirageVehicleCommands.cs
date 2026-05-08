/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Chat command handlers for the Mirage vehicle system. Wired into
/// <see cref="MirageCommands.Register"/>. The command framework runs
/// these on the host after the configured <see cref="CommandSpec.Permission"/>
/// has been validated.
/// </summary>
public static class MirageVehicleCommands
{
	/// <summary>
	/// <c>/car &lt;modelId&gt;</c> spawns the matching vehicle in front
	/// of the caller. Permission gated by <c>command.car</c>.
	/// </summary>
	public static void HandleCar( CommandContext ctx )
	{
		if ( ctx.Args.Length < 1 )
		{
			ctx.ReplyError( "Usage : /car <modelId>. Tape /cars pour la liste." );
			return;
		}

		var modelId = ctx.Args[0];
		var model = MirageVehicles.Find( modelId );
		if ( model is null )
		{
			ctx.ReplyError( $"Modèle inconnu : « {modelId} ». Tape /cars pour la liste." );
			return;
		}

		var player = FindCallerPlayer( ctx );
		if ( player is null ) { ctx.ReplyError( "Joueur introuvable." ); return; }

		var go = MirageVehicleSpawner.Spawn( player, model );
		if ( go is null )
		{
			ctx.ReplyError( $"Le prefab « {model.PrefabPath} » n'a pas pu être chargé." );
			return;
		}

		ctx.Reply( $"{model.Label} apparu. Approche-toi et appuie sur « E » pour t'asseoir." );
	}

	/// <summary>
	/// <c>/dv</c> destroys the vehicle the caller is currently in.
	/// <c>/dv &lt;radius&gt;</c> destroys every Mirage vehicle within
	/// the given radius. Permission gated by <c>command.dv</c>.
	/// </summary>
	public static void HandleDeleteVehicle( CommandContext ctx )
	{
		var player = FindCallerPlayer( ctx );
		if ( player is null ) { ctx.ReplyError( "Joueur introuvable." ); return; }

		if ( ctx.Args.Length >= 1 )
		{
			if ( !float.TryParse( ctx.Args[0], System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out var radius ) || radius <= 0f )
			{
				ctx.ReplyError( "Rayon invalide. Utilise /dv ou /dv <radius>." );
				return;
			}

			var removed = MirageVehicleSpawner.DespawnInRadius( player, radius );
			ctx.Reply( $"{removed} véhicule(s) supprimé(s) dans un rayon de {radius} unités." );
			return;
		}

		var ok = MirageVehicleSpawner.DespawnCurrent( player );
		if ( !ok )
		{
			ctx.ReplyError( "Aucun véhicule détecté à proximité." );
			return;
		}
		ctx.Reply( "Véhicule supprimé." );
	}

	/// <summary>
	/// <c>/cars</c> lists every model id registered in the catalogue,
	/// so an admin can see what is spawnable without leaving the game.
	/// </summary>
	public static void HandleCarsList( CommandContext ctx )
	{
		if ( MirageVehicles.All.Count == 0 )
		{
			ctx.Reply( "Aucun modèle de véhicule enregistré." );
			return;
		}

		ctx.Reply( $"Modèles disponibles ({MirageVehicles.All.Count}) :" );
		foreach ( var v in MirageVehicles.All )
		{
			ctx.Reply( $"  - {v.Id} ({v.Label})" );
		}
	}

	private static Player FindCallerPlayer( CommandContext ctx )
	{
		if ( ctx.Caller is null ) return null;
		return Game.ActiveScene.GetAll<Player>()
			.FirstOrDefault( p => p.Network.Owner?.Id == ctx.Caller.Id );
	}
}
