/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Client-side mailbox for character-selection traffic coming from the host.
/// The session RPCs deliver into this cache and the character selection UI
/// reads from it via a version counter, no event subscriptions required.
/// Lives on every client; entries are scoped by the local connection.
/// </summary>
public static class MirageClientCache
{
	/// <summary>
	/// Snapshot of the local player's characters as last delivered by the host.
	/// Empty list until the first delivery.
	/// </summary>
	public static List<MirageCharacterSummary> Characters { get; private set; } = new();

	/// <summary>
	/// Last error message reported by the host while handling a session RPC.
	/// Cleared automatically on the next successful delivery.
	/// </summary>
	public static string LastError { get; private set; }

	/// <summary>
	/// Increments on every delivery. UI panels watch this to know when to
	/// re-render without holding event subscriptions across hot reloads.
	/// </summary>
	public static int Version { get; private set; }

	/// <summary>
	/// True once the host has delivered at least one snapshot to this client
	/// in the current session. Distinguishes "no characters" from "not loaded".
	/// </summary>
	public static bool HasSnapshot { get; private set; }

	internal static void SetCharacters( List<MirageCharacterSummary> list )
	{
		Characters = list ?? new List<MirageCharacterSummary>();
		LastError = null;
		HasSnapshot = true;
		Version++;
	}

	internal static void SetError( string message )
	{
		LastError = message ?? "Unknown error.";
		Version++;
	}

	internal static void Reset()
	{
		Characters = new List<MirageCharacterSummary>();
		LastError = null;
		HasSnapshot = false;
		Version++;
	}
}
