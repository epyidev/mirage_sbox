/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Host-only static helper that opens the items browser panel on a single
/// client. Called by the <c>/items</c> command handler.
/// </summary>
public static class MirageItemsBrowserBridge
{
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
		MirageItemsBrowserState.SetOpen( true );
	}
}
