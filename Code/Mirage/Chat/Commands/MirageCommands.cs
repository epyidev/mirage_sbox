/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Built-in command declarations. Add new commands by extending
/// <see cref="Register"/> with another <see cref="CommandRegistry.Register"/>
/// call.
/// </summary>
public static class MirageCommands
{
	public static void Register()
	{
		CommandRegistry.Register( new CommandSpec
		{
			Name = "permissions",
			Description = "Gestion des permissions",
			Permission = "command.permissions",
			UsageHint = "Sous-commandes : editor.",
			Subcommands =
			{
				new CommandSpec
				{
					Name = "editor",
					Description = "Ouvre l'éditeur de permissions",
					Permission = "permission.editor",
					Handler = ( ctx ) =>
					{
						MiragePermissionsEditorBridge.OpenForCaller( ctx.Caller );
					}
				}
			}
		} );

		CommandRegistry.Register( new CommandSpec
		{
			Name = "coords",
			Description = "Affiche tes coordonnées dans plusieurs formats",
			Permission = "command.coords",
			Handler = ( ctx ) =>
			{
				MirageCoordsBridge.OpenForCaller( ctx.Caller );
			}
		} );

		CommandRegistry.Register( new CommandSpec
		{
			Name = "give",
			Description = "Donne un item à un joueur",
			Permission = "command.give",
			UsageHint = "Usage : /give <id|me> <itemId> [count].",
			Handler = MirageInventoryCommands.HandleGive
		} );

		CommandRegistry.Register( new CommandSpec
		{
			Name = "items",
			Description = "Liste les items disponibles",
			Permission = "command.give",
			Handler = MirageInventoryCommands.HandleItems
		} );

		CommandRegistry.Register( new CommandSpec
		{
			Name = "clearinv",
			Description = "Vide l'inventaire d'un joueur",
			Permission = "command.give",
			UsageHint = "Usage : /clearinv <id|me>.",
			Handler = MirageInventoryCommands.HandleClear
		} );

		CommandRegistry.Register( new CommandSpec
		{
			Name = "relog",
			Description = "Renvoie un joueur à la sélection de personnage (avec save)",
			Permission = "command.relog",
			UsageHint = "Usage : /relog <id|me>.",
			Handler = MirageSessionCommands.HandleRelog
		} );

		CommandRegistry.Register( new CommandSpec
		{
			Name = "savecharacter",
			Description = "Force la sauvegarde d'un (specific) ou de tous (all) les personnages connectés",
			Permission = "command.savecharacter",
			UsageHint = "Usage : /savecharacter all   |   /savecharacter specific <id>.",
			Handler = MirageSessionCommands.HandleSaveCharacter
		} );

		CommandRegistry.Register( new CommandSpec
		{
			Name = "goto",
			Description = "Téléporte-toi sur un joueur",
			Permission = "command.goto",
			UsageHint = "Usage : /goto <id>.",
			Handler = MirageSessionCommands.HandleGoto
		} );

		CommandRegistry.Register( new CommandSpec
		{
			Name = "bring",
			Description = "Ramène un joueur sur toi",
			Permission = "command.bring",
			UsageHint = "Usage : /bring <id>.",
			Handler = MirageSessionCommands.HandleBring
		} );

		CommandRegistry.Register( new CommandSpec
		{
			Name = "car",
			Description = "Fait apparaître un véhicule devant toi",
			Permission = "command.car",
			UsageHint = "Usage : /car <modelId>.",
			Handler = MirageVehicleCommands.HandleCar
		} );

		CommandRegistry.Register( new CommandSpec
		{
			Name = "cars",
			Description = "Liste les modèles de véhicules disponibles",
			Permission = "command.car",
			Handler = MirageVehicleCommands.HandleCarsList
		} );

		CommandRegistry.Register( new CommandSpec
		{
			Name = "dv",
			Description = "Supprime le véhicule en cours, ou tous dans un rayon",
			Permission = "command.dv",
			UsageHint = "Usage : /dv   |   /dv <radius>.",
			Handler = MirageVehicleCommands.HandleDeleteVehicle
		} );
	}
}
