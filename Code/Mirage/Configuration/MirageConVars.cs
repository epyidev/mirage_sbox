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

	[ConVar( "mirage.spawn_limbo_height", ConVarFlags.Hidden, Help = "Z-axis altitude where freshly connected players are parked while the character selection screen is open." )]
	public static float SpawnLimboHeight { get; set; } = 4096f;
}
