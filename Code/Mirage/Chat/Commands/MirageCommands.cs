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
			Description = "Donne un item au joueur courant",
			Permission = "command.give",
			UsageHint = "Usage : /give <itemId> [count].",
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
			Description = "Vide ton inventaire",
			Permission = "command.give",
			Handler = MirageInventoryCommands.HandleClear
		} );

		CommandRegistry.Register( new CommandSpec
		{
			Name = "relog",
			Description = "Sauvegarde ton personnage et retourne à la sélection",
			Permission = "command.relog",
			Handler = MirageSessionCommands.HandleRelog
		} );

		CommandRegistry.Register( new CommandSpec
		{
			Name = "saveallcharacters",
			Description = "Force la sauvegarde de tous les personnages connectés",
			Permission = "command.saveallcharacters",
			Handler = MirageSessionCommands.HandleSaveAllCharacters
		} );
	}
}
