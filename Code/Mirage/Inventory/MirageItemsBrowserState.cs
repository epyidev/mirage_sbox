/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Client-side flag that controls the items browser panel opened by the
/// <c>/items</c> chat command. Mirrors the pattern used by the coords and
/// permissions editor panels.
/// </summary>
public static class MirageItemsBrowserState
{
	public static bool IsOpen { get; private set; }
	public static int Version { get; private set; }

	public static void SetOpen( bool open )
	{
		if ( IsOpen == open ) return;
		IsOpen = open;
		Version++;
	}

	public static void Reset()
	{
		IsOpen = false;
		Version++;
	}
}
