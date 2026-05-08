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
	}
}
