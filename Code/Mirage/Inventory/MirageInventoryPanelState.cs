/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Client-side flag that controls whether the local player has the
/// inventory panel open. Survives panel rebuilds so the Tab toggle works
/// across hot reloads.
/// </summary>
public static class MirageInventoryPanelState
{
	public static bool IsOpen { get; private set; }
	public static int Version { get; private set; }

	public static void SetOpen( bool open )
	{
		if ( IsOpen == open ) return;
		IsOpen = open;
		Version++;
	}

	public static void Toggle() => SetOpen( !IsOpen );

	public static void Reset()
	{
		IsOpen = false;
		Version++;
	}
}
