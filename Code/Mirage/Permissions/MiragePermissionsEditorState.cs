/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Client-side cache of the permissions editor's last delivered snapshot.
/// The editor panel polls <see cref="Version"/> every tick and re-renders on
/// change, mirroring the <see cref="MirageClientCache"/> pattern used by the
/// character selection screen.
/// </summary>
public static class MiragePermissionsEditorState
{
	/// <summary>True once the host has delivered at least one snapshot.</summary>
	public static bool HasSnapshot { get; private set; }

	/// <summary>Most recent snapshot. Empty until <see cref="HasSnapshot"/>.</summary>
	public static MiragePermissionsEditorSnapshot Snapshot { get; private set; } = new();

	/// <summary>Last error reported by the host during a mutation, or null.</summary>
	public static string LastError { get; private set; }

	/// <summary>Increments on every change.</summary>
	public static int Version { get; private set; }

	/// <summary>True if the editor is currently visible to the local player.</summary>
	public static bool IsOpen { get; private set; }

	internal static void SetOpen( bool open )
	{
		if ( IsOpen == open ) return;
		IsOpen = open;
		Version++;
	}

	internal static void SetSnapshot( MiragePermissionsEditorSnapshot snap )
	{
		Snapshot = snap ?? new MiragePermissionsEditorSnapshot();
		HasSnapshot = true;
		LastError = null;
		Version++;
	}

	internal static void SetError( string message )
	{
		LastError = message ?? "Unknown error.";
		Version++;
	}

	public static void Reset()
	{
		HasSnapshot = false;
		Snapshot = new MiragePermissionsEditorSnapshot();
		LastError = null;
		IsOpen = false;
		Version++;
	}
}
