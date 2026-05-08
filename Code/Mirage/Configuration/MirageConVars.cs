/** @author Epyi */

namespace Sandbox;

/// <summary>
/// Boot-time configuration for the Mirage gamemode. Set these on the dedicated
/// server command line, e.g. `+mirage.api_url https://api.example +mirage.api_token TOKEN`.
/// Values are server-private: nothing here is replicated to clients.
/// </summary>
public static class MirageConVars
{
	[ConVar( "mirage.api_url", ConVarFlags.Hidden, Help = "Base URL of the Mirage backend API. Must satisfy Sandbox.Http's allowlist (no raw IPs, localhost only on 80/443/8080/8443)." )]
	public static string ApiUrl { get; set; } = "http://localhost:8080";

	[ConVar( "mirage.api_token", ConVarFlags.Hidden, Help = "Bearer token shared with the Mirage backend (matches API_BEARER_TOKEN). Server-private." )]
	public static string ApiToken { get; set; } = "";

	[ConVar( "mirage.api_timeout_ms", ConVarFlags.Hidden, Help = "Per-request HTTP timeout in milliseconds." )]
	public static int ApiTimeoutMs { get; set; } = 5000;

	/// <summary>
	/// World position where freshly connected players are parked while they
	/// are still picking a character. The Body renderer is disabled and the
	/// controller is frozen so they exist only as a synchronized presence,
	/// invisible to other clients.
	/// </summary>
	public static Vector3 CharacterSelectPlayerPosition { get; set; } = new Vector3( 276.06f, 3932.79f, 5750.52f );

	/// <summary>Yaw the player body is forced into during character select.</summary>
	public static float CharacterSelectPlayerYaw { get; set; } = 0f;

	/// <summary>Camera world position used while character select is open.</summary>
	public static Vector3 CharacterSelectCameraPosition { get; set; } = new Vector3( 276.06f, 3932.79f, 5814.52f );

	/// <summary>Camera angles (pitch / yaw / roll) used while character select is open.</summary>
	public static Angles CharacterSelectCameraAngles { get; set; } = new Angles( 13.05f, -89.75f, 0f );
}
