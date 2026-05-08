/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Client-side rolling log of chat lines. Survives panel rebuilds and hot
/// reloads so the player keeps their backlog. The chat UI reads from here
/// every tick and renders only the recent or all-on-focus entries.
///
/// Entries are kept until <see cref="MaxEntries"/> rolls them over.
/// </summary>
public static class MirageChatLog
{
	public const int MaxEntries = 200;

	public sealed class Entry
	{
		public MirageChatMessage Message { get; init; }
		public RealTimeSince TimeSinceAdded;
	}

	public static List<Entry> Entries { get; private set; } = new();

	/// <summary>Increments on every change; UIs poll this to know when to re-render.</summary>
	public static int Version { get; private set; }

	internal static void Append( MirageChatMessage msg )
	{
		if ( msg is null ) return;
		Entries.Add( new Entry { Message = msg, TimeSinceAdded = 0 } );
		while ( Entries.Count > MaxEntries )
		{
			Entries.RemoveAt( 0 );
		}
		Version++;
	}

	public static void Reset()
	{
		Entries.Clear();
		Version++;
	}
}
