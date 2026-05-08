/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Context passed to a command handler. Lives only on the host: the caller is
/// always a real <see cref="Connection"/>, and the reply helpers go through
/// <see cref="MirageChatBus"/> so they reach the same client's chat log.
/// </summary>
public sealed class CommandContext
{
	public Connection Caller { get; init; }
	public string RawInput { get; init; }
	public string[] Args { get; init; } = Array.Empty<string>();

	public long CallerSteamId => Caller is null ? 0L : (long)Caller.SteamId;
	public string CallerName => Caller?.DisplayName ?? "?";

	public void Reply( string body )
	{
		MirageChatBus.SendSystemTo( Caller, body );
	}

	public void ReplyError( string body )
	{
		MirageChatBus.SendErrorTo( Caller, body );
	}
}
