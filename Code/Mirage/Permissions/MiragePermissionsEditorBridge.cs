/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Tiny static layer that opens the editor on a specific client. The chat
/// command handler runs on the host and uses
/// <see cref="OpenForCaller(Connection)"/> to push an open intent down to the
/// caller's client; that client then sets the local
/// <see cref="MiragePermissionsEditorState.IsOpen"/> flag the editor panel
/// reads from.
/// </summary>
public static class MiragePermissionsEditorBridge
{
	/// <summary>Host-only. Opens the editor panel on <paramref name="caller"/>'s client.</summary>
	public static void OpenForCaller( Connection caller )
	{
		Assert.True( Networking.IsHost, "OpenForCaller must run on the host" );
		if ( caller is null ) return;
		using ( Rpc.FilterInclude( caller ) )
			RpcOpen();
	}

	[Rpc.Broadcast( NetFlags.HostOnly | NetFlags.Reliable )]
	private static void RpcOpen()
	{
		MiragePermissionsEditorState.SetOpen( true );
	}
}
