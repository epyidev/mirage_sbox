/** @author Epyi */

using System.Text.Json.Serialization;

namespace Sandbox.Mirage;

/// <summary>
/// One line of chat. Three kinds: a player message, a system info line, and
/// an error reply (typically a permission denial).
/// </summary>
public sealed class MirageChatMessage
{
	public enum MessageKind { Chat, System, Error }

	[JsonPropertyName( "kind" )] public MessageKind Kind { get; set; } = MessageKind.Chat;
	[JsonPropertyName( "steamId" )] public ulong SteamId { get; set; }
	[JsonPropertyName( "author" )] public string Author { get; set; } = "";
	[JsonPropertyName( "body" )] public string Body { get; set; } = "";
}
