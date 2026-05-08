/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Static host-side service that backs the chat commands for vehicle
/// spawn / despawn. Each <see cref="Rpc.Host"/> entry point validates
/// its caller, resolves the player, and delegates to
/// <see cref="MirageVehicleSpawner"/>.
/// </summary>
public static class MirageVehicleService
{
	[Rpc.Host]
	public static void RpcSpawn( string modelId )
	{
		var (player, _) = ResolveCallerInventory();
		if ( player is null ) return;
		if ( !PermissionsSystem.Current.Has( Rpc.Caller, "command.car" ) ) return;

		var model = MirageVehicles.Find( modelId );
		if ( model is null ) return;

		MirageVehicleSpawner.Spawn( player, model );
	}

	[Rpc.Host]
	public static void RpcDespawnCurrent()
	{
		var (player, _) = ResolveCallerInventory();
		if ( player is null ) return;
		if ( !PermissionsSystem.Current.Has( Rpc.Caller, "command.dv" ) ) return;

		MirageVehicleSpawner.DespawnCurrent( player );
	}

	[Rpc.Host]
	public static void RpcDespawnRadius( float radius )
	{
		var (player, _) = ResolveCallerInventory();
		if ( player is null ) return;
		if ( !PermissionsSystem.Current.Has( Rpc.Caller, "command.dv" ) ) return;
		if ( radius <= 0f ) return;

		MirageVehicleSpawner.DespawnInRadius( player, radius );
	}

	private static (Player, MirageInventory) ResolveCallerInventory()
	{
		var caller = Rpc.Caller;
		if ( caller is null ) return (null, null);
		var player = Game.ActiveScene.GetAll<Player>().FirstOrDefault( x => x.Network.Owner?.Id == caller.Id );
		if ( !player.IsValid() ) return (null, null);
		var inv = player.GetComponent<MirageInventory>();
		return (player, inv);
	}
}
