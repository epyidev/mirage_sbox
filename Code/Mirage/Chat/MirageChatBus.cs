/** @author Epyi */

using Sandbox.Utility;

namespace Sandbox.Mirage;

/// <summary>
/// Single entry point for everything that flows through the chat: player
/// submissions (RPC client to host), system replies, broadcast lines, and
/// command execution. The chat panel only ever calls into this class.
///
/// Wire model:
/// <list type="bullet">
///   <item>Client submits with <see cref="RpcSubmit"/>. The host parses it
///   (slash prefix means a command, else a normal chat broadcast).</item>
///   <item>Host fans messages back via <see cref="RpcDeliver"/>: either to
///   one connection (system replies, command output) or to everyone (chat).</item>
///   <item>Clients receive <see cref="RpcDeliver"/> and append the line to
///   <see cref="MirageChatLog"/>.</item>
/// </list>
/// </summary>
public static class MirageChatBus
{
	private const int MaxBodyLength = 300;

	/// <summary>
	/// Client to host. Host applies length cap, runs the slash dispatch, or
	/// broadcasts the message as a normal chat line.
	/// </summary>
	[Rpc.Host]
	public static void RpcSubmit( string text )
	{
		var caller = Rpc.Caller;
		if ( caller is null ) return;

		var trimmed = (text ?? "").Trim();
		if ( trimmed.Length == 0 ) return;
		if ( trimmed.Length > MaxBodyLength ) trimmed = trimmed.Substring( 0, MaxBodyLength );

		if ( trimmed.StartsWith( "/" ) )
		{
			CommandRegistry.Execute( caller, trimmed );
			return;
		}

		BroadcastChat( caller, trimmed );
	}

	private static void BroadcastChat( Connection caller, string body )
	{
		var name = Steam.FilterName( caller.DisplayName, caller.SteamId );
		var clean = Steam.FilterChat( body, caller.SteamId );

		Log.Info( $"[Chat] {name}: {clean}" );

		DeliverToEveryone( new MirageChatMessage
		{
			Kind = MirageChatMessage.MessageKind.Chat,
			Author = name,
			SteamId = caller.SteamId,
			Body = clean
		} );
	}

	/// <summary>
	/// Host-side. Send a system info line to one connection only.
	/// </summary>
	public static void SendSystemTo( Connection target, string body )
	{
		if ( target is null ) return;
		DeliverTo( target, new MirageChatMessage
		{
			Kind = MirageChatMessage.MessageKind.System,
			Body = body ?? ""
		} );
	}

	/// <summary>
	/// Host-side. Send a red error line to one connection only.
	/// </summary>
	public static void SendErrorTo( Connection target, string body )
	{
		if ( target is null ) return;
		DeliverTo( target, new MirageChatMessage
		{
			Kind = MirageChatMessage.MessageKind.Error,
			Body = body ?? ""
		} );
	}

	/// <summary>
	/// Host-side. Broadcast a system line to every client.
	/// </summary>
	public static void BroadcastSystem( string body )
	{
		DeliverToEveryone( new MirageChatMessage
		{
			Kind = MirageChatMessage.MessageKind.System,
			Body = body ?? ""
		} );
	}

	private static void DeliverTo( Connection target, MirageChatMessage msg )
	{
		Assert.True( Networking.IsHost, "MirageChatBus.DeliverTo must run on the host" );
		var json = Sandbox.Json.Serialize( msg );
		using ( Rpc.FilterInclude( target ) )
			RpcDeliver( json );
	}

	private static void DeliverToEveryone( MirageChatMessage msg )
	{
		Assert.True( Networking.IsHost, "MirageChatBus.DeliverToEveryone must run on the host" );
		var json = Sandbox.Json.Serialize( msg );
		RpcDeliver( json );
	}

	[Rpc.Broadcast( NetFlags.HostOnly | NetFlags.Reliable )]
	private static void RpcDeliver( string json )
	{
		if ( string.IsNullOrEmpty( json ) ) return;
		var msg = Sandbox.Json.Deserialize<MirageChatMessage>( json );
		MirageChatLog.Append( msg );
	}
}
