/** @author Epyi */

namespace Sandbox.Mirage.UI;

/// <summary>
/// Persistent on-screen interaction prompts. Use this when the player has the
/// option to press a key to do something (e.g. open a door, talk to an NPC,
/// pick up an item). The hints stack in the top-left of the screen and are
/// rendered by <c>MirageKeyHintHost</c>, which lives in <c>system.scene</c>.
///
/// API:
/// <code>
/// MirageKeyHint.Show( "door-42", "E", "Ouvrir la porte" );
/// MirageKeyHint.Hide( "door-42" );
/// </code>
///
/// Re-calling <c>Show</c> with an existing id refreshes the hint in place
/// instead of duplicating it.
/// </summary>
public static class MirageKeyHint
{
	public sealed class Hint
	{
		public string Id { get; init; }
		public string Key { get; set; }
		public string Label { get; set; }
	}

	private static readonly List<Hint> _hints = new();

	/// <summary>Active hints in display order (oldest first).</summary>
	public static IReadOnlyList<Hint> Active => _hints;

	/// <summary>Increments on every change so the host knows when to re-render.</summary>
	public static int Version { get; private set; }

	/// <summary>Show or refresh a hint. Idempotent on <paramref name="id"/>.</summary>
	public static void Show( string id, string key, string label )
	{
		if ( string.IsNullOrEmpty( id ) ) return;

		var existing = _hints.FirstOrDefault( h => h.Id == id );
		if ( existing is not null )
		{
			existing.Key = key;
			existing.Label = label;
			Version++;
			return;
		}

		_hints.Add( new Hint { Id = id, Key = key, Label = label } );
		Version++;
	}

	/// <summary>Hide a hint by id. No-op if it does not exist.</summary>
	public static void Hide( string id )
	{
		if ( string.IsNullOrEmpty( id ) ) return;
		var removed = _hints.RemoveAll( h => h.Id == id );
		if ( removed > 0 ) Version++;
	}

	/// <summary>Clear every hint. Useful at scene transitions.</summary>
	public static void Clear()
	{
		if ( _hints.Count == 0 ) return;
		_hints.Clear();
		Version++;
	}
}
