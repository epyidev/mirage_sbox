/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Client-side flag that controls whether the local player has the coords
/// panel open. Set by the server through <see cref="MirageCoordsBridge"/>
/// and read by the panel every frame.
/// </summary>
public static class MirageCoordsState
{
	public static bool IsOpen { get; private set; }
	public static int Version { get; private set; }

	internal static void SetOpen( bool open )
	{
		if ( IsOpen == open ) return;
		IsOpen = open;
		Version++;
	}
}
