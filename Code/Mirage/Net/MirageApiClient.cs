/** @author Epyi */

using System.Net.Http;
using System.Threading;

namespace Sandbox.Mirage;

/// <summary>
/// Thrown when the Mirage API answers with a non-2xx status code.
/// Carries the HTTP status and the raw response body so callers can log it.
/// </summary>
public sealed class MirageApiException : Exception
{
	public int StatusCode { get; }
	public string Body { get; }

	public MirageApiException( int statusCode, string body )
		: base( $"Mirage API error {statusCode}: {body}" )
	{
		StatusCode = statusCode;
		Body = body;
	}
}

/// <summary>
/// Host-only HTTP client for the Mirage backend API. All methods assert that
/// they're being called from the host so the bearer token never leaks through
/// a misrouted call site. Reads its base URL, token and timeout from
/// <see cref="MirageConVars"/>.
/// </summary>
public static class MirageApiClient
{
	private static string BuildUrl( string path )
	{
		var baseUrl = (MirageConVars.ApiUrl ?? "").TrimEnd( '/' );
		return $"{baseUrl}{path}";
	}

	private static Dictionary<string, string> AuthHeaders()
	{
		return new Dictionary<string, string>
		{
			{ "Authorization", $"Bearer {MirageConVars.ApiToken}" }
		};
	}

	private static CancellationTokenSource MakeTimeout()
	{
		var ms = MirageConVars.ApiTimeoutMs;
		if ( ms <= 0 ) ms = 5000;
		return new CancellationTokenSource( TimeSpan.FromMilliseconds( ms ) );
	}

	private static async Task<HttpResponseMessage> SendAsync( string path, string method, object body )
	{
		Assert.True( Networking.IsHost, "MirageApiClient must only be called on the host" );

		var url = BuildUrl( path );
		var headers = AuthHeaders();
		HttpContent content = body is null ? null : Http.CreateJsonContent( body );

		using var cts = MakeTimeout();
		return await Http.RequestAsync( url, method, content, headers, cts.Token );
	}

	private static async Task<T> ReadJsonAsync<T>( HttpResponseMessage response ) where T : class
	{
		var raw = await response.Content.ReadAsStringAsync();
		if ( !response.IsSuccessStatusCode )
			throw new MirageApiException( (int)response.StatusCode, raw );

		if ( string.IsNullOrEmpty( raw ) ) return null;
		return Sandbox.Json.Deserialize<T>( raw );
	}

	private static async Task EnsureSuccessAsync( HttpResponseMessage response )
	{
		if ( response.IsSuccessStatusCode ) return;
		var raw = await response.Content.ReadAsStringAsync();
		throw new MirageApiException( (int)response.StatusCode, raw );
	}

	/// <summary>
	/// `GET /players/:steamId`. Creates the OOC row if missing and returns it.
	/// </summary>
	public static async Task<MiragePlayerInfo> GetOrCreatePlayerAsync( long steamId )
	{
		var response = await SendAsync( $"/players/{steamId}", "GET", null );
		return await ReadJsonAsync<MiragePlayerInfo>( response );
	}

	/// <summary>
	/// `PUT /players/:steamId` recording a freshly observed IP. The API appends
	/// the IP if new, or refreshes its `lastSeenAt` timestamp if already known.
	/// Display name is updated only when supplied.
	/// </summary>
	public static async Task RecordPlayerSeenAsync( long steamId, string ip, string displayName = null )
	{
		var body = new MiragePlayerUpdateRequest { RecordIp = ip, DisplayName = displayName };
		var response = await SendAsync( $"/players/{steamId}", "PUT", body );
		await EnsureSuccessAsync( response );
	}

	/// <summary>
	/// `GET /players/:steamId/characters`. Returns an empty list if the player
	/// has no saved character.
	/// </summary>
	public static async Task<List<MirageCharacterSummary>> ListCharactersAsync( long steamId )
	{
		var response = await SendAsync( $"/players/{steamId}/characters", "GET", null );
		var list = await ReadJsonAsync<List<MirageCharacterSummary>>( response );
		return list ?? new List<MirageCharacterSummary>();
	}

	/// <summary>
	/// `POST /players/:steamId/characters`. Returns the freshly created summary.
	/// Throws <see cref="MirageApiException"/> with status 409 if the slot is
	/// taken (the API is keyed on `(steam_id, slot)`).
	/// </summary>
	public static async Task<MirageCharacterSummary> CreateCharacterAsync( long steamId, MirageCharacterCreateRequest request )
	{
		var response = await SendAsync( $"/players/{steamId}/characters", "POST", request );
		return await ReadJsonAsync<MirageCharacterSummary>( response );
	}

	/// <summary>
	/// `PUT /players/:steamId/characters/:id` patching the character's last
	/// known IC position. Used at logout / disconnect to flush the in-memory
	/// session back to disk.
	/// </summary>
	public static async Task UpdateCharacterPositionAsync( long steamId, string characterId, MiragePosition position )
	{
		var body = new { lastPosition = position };
		var response = await SendAsync( $"/players/{steamId}/characters/{characterId}", "PUT", body );
		await EnsureSuccessAsync( response );
	}
}
