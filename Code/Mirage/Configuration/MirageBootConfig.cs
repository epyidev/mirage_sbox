/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Boot-time config loader for the Mirage gamemode. Reads a JSON file from
/// <see cref="FileSystem.Data"/> (per-game data dir) and applies it to
/// <see cref="MirageConVars"/>. Lets developers configure the API URL and
/// bearer token in editor mode, where command-line `+convar value` switches
/// are not available.
///
/// The cmdline still wins. Each field is only pulled from the config file if
/// the matching ConVar is still at its default value, so launching the
/// dedicated server with `+mirage.api_token <token>` overrides whatever sits
/// on disk.
/// </summary>
public static class MirageBootConfig
{
	public const string FileName = "mirage_config.json";

	public sealed class ConfigShape
	{
		public string ApiUrl { get; set; }
		public string ApiToken { get; set; }
		public int? ApiTimeoutMs { get; set; }
	}

	/// <summary>
	/// Read <see cref="FileName"/> from <see cref="FileSystem.Data"/> and apply
	/// any fields it carries to <see cref="MirageConVars"/>. If the file is
	/// missing, write a stub template so the user has something to fill in.
	/// </summary>
	public static void Apply()
	{
		try
		{
			if ( !FileSystem.Data.FileExists( FileName ) )
			{
				WriteTemplate();
				Log.Info( $"[Mirage] Wrote a config template at FileSystem.Data/{FileName}, fill in 'ApiToken' and reload." );
				return;
			}

			var cfg = FileSystem.Data.ReadJson<ConfigShape>( FileName );
			if ( cfg is null ) return;

			// Only override ConVars that are still at their default. This keeps
			// `+mirage.api_token foo` on the dedicated server's command line as
			// the highest-priority source of truth.
			if ( !string.IsNullOrEmpty( cfg.ApiUrl ) && MirageConVars.ApiUrl == "http://localhost:8080" )
			{
				MirageConVars.ApiUrl = cfg.ApiUrl;
			}

			if ( !string.IsNullOrEmpty( cfg.ApiToken ) && string.IsNullOrEmpty( MirageConVars.ApiToken ) )
			{
				MirageConVars.ApiToken = cfg.ApiToken;
			}

			if ( cfg.ApiTimeoutMs is { } timeout && MirageConVars.ApiTimeoutMs == 5000 )
			{
				MirageConVars.ApiTimeoutMs = timeout;
			}

			Log.Info( $"[Mirage] Applied boot config from FileSystem.Data/{FileName}." );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] Failed to apply boot config: {ex.Message}" );
		}
	}

	private static void WriteTemplate()
	{
		var template = new ConfigShape
		{
			ApiUrl = "http://localhost:8080",
			ApiToken = "REPLACE_WITH_BEARER_TOKEN",
			ApiTimeoutMs = 5000
		};
		FileSystem.Data.WriteJson( FileName, template );
	}
}
