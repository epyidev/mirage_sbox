/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Host-only entry point used by the <c>/coords</c> chat command to open
/// the coords panel on the caller's client.
/// </summary>
public static class MirageCoordsBridge
{
	/// <summary>Host-only. Opens the coords panel on <paramref name="caller"/>'s client.</summary>
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
		MirageCoordsState.SetOpen( true );
	}
}
