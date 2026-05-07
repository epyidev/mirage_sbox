/** @author Epyi */

using System.Text.RegularExpressions;

namespace Sandbox.Mirage;

/// <summary>
/// Server-side coordinator for the Mirage character lifecycle. Hooks into the
/// connect / spawn / disconnect events to:
/// 1. ensure the OOC <c>players</c> row exists and IP history is updated,
/// 2. park freshly connected players in a high-altitude limbo until they pick
///    a character (so the selection UI shows over an empty sky background),
/// 3. fan client requests (list / create / select) through to the API and
///    deliver results back via filtered broadcasts.
///
/// The class is also the home of every <c>[Rpc.Host]</c> entry point the
/// character selection UI calls into.
/// </summary>
public sealed class MirageSession : GameObjectSystem<MirageSession>, ISceneStartup, Component.INetworkListener, Global.IPlayerEvents
{
	private const int MaxCharacterSlot = 7;
	private static readonly Regex BirthDateRegex = new( @"^\d{4}-\d{2}-\d{2}$", RegexOptions.Compiled );

	public MirageSession( Scene scene ) : base( scene )
	{
	}

	void ISceneStartup.OnHostInitialize()
	{
		// Apply the on-disk config once the host scene starts. Cmdline `+convar`
		// switches have already been processed by this point, so any value the
		// dedicated server sets stays untouched.
		MirageBootConfig.Apply();

		if ( string.IsNullOrEmpty( MirageConVars.ApiToken ) )
		{
			Log.Warning( "[Mirage] mirage.api_token is empty: every API call will be rejected with 401. Set it via +mirage.api_token, the in-game console, or FileSystem.Data/mirage_config.json." );
		}
	}

	void Component.INetworkListener.OnActive( Connection channel )
	{
		if ( !Networking.IsHost || channel is null ) return;

		long steamId = (long)channel.SteamId;
		string ip = NormalizeAddress( channel.Address );
		string displayName = channel.DisplayName;

		_ = TrackOocAsync( steamId, ip, displayName );
	}

	/// <summary>
	/// <see cref="Connection.Address"/> is reported as <c>host:port</c>
	/// (e.g. <c>127.0.0.1:50640</c> or <c>[::1]:50640</c>). The backend's
	/// `recordIp` field validates as a bare IP, so strip the port before
	/// sending. Returns null if the address is empty or unparseable.
	/// </summary>
	private static string NormalizeAddress( string raw )
	{
		if ( string.IsNullOrWhiteSpace( raw ) ) return null;

		// IPv6 with optional port: "[::1]:50640" or "[::1]".
		if ( raw.StartsWith( "[" ) )
		{
			var close = raw.IndexOf( ']' );
			if ( close > 0 ) return raw.Substring( 1, close - 1 );
			return raw;
		}

		// IPv4 with optional port: "127.0.0.1:50640" or "127.0.0.1".
		var colon = raw.IndexOf( ':' );
		if ( colon < 0 ) return raw;

		// More than one colon means a bare IPv6 with no brackets, leave as-is.
		if ( raw.IndexOf( ':', colon + 1 ) >= 0 ) return raw;

		return raw.Substring( 0, colon );
	}

	void Component.INetworkListener.OnDisconnected( Connection channel )
	{
		if ( !Networking.IsHost || channel is null ) return;

		var pd = PlayerData.For( channel );
		if ( pd is null || !pd.HasActiveCharacter ) return;

		var player = Scene.GetAll<Player>().FirstOrDefault( x => x.Network.Owner?.Id == pd.PlayerId );
		if ( !player.IsValid() ) return;

		var pos = player.WorldPosition;
		float yaw = player.Controller.IsValid() ? player.Controller.EyeAngles.yaw : 0f;
		long steamId = pd.SteamId;
		string charId = pd.ActiveCharacterId;

		_ = FlushPositionAsync( steamId, charId, new MiragePosition { X = pos.x, Y = pos.y, Z = pos.z, Yaw = yaw } );
	}

	void Global.IPlayerEvents.OnPlayerRespawning( PlayerRespawnEvent e )
	{
		if ( !Networking.IsHost ) return;
		if ( e?.PlayerData is null ) return;
		if ( e.PlayerData.HasActiveCharacter ) return;

		// Park the player at the limbo altitude so the character selection UI
		// is shown over an empty sky background while they pick or create one.
		var t = e.SpawnLocation;
		var limbo = new Vector3( t.Position.x, t.Position.y, MirageConVars.SpawnLimboHeight );
		e.SpawnLocation = t.WithPosition( limbo );
	}

	private static async Task TrackOocAsync( long steamId, string ip, string displayName )
	{
		try
		{
			await MirageApiClient.GetOrCreatePlayerAsync( steamId );
			if ( !string.IsNullOrEmpty( ip ) )
			{
				await MirageApiClient.RecordPlayerSeenAsync( steamId, ip, displayName );
			}
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] Failed to track OOC profile for {steamId}: {ex.Message}" );
		}
	}

	private static async Task FlushPositionAsync( long steamId, string characterId, MiragePosition pos )
	{
		try
		{
			await MirageApiClient.UpdateCharacterPositionAsync( steamId, characterId, pos );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] Failed to flush position for character {characterId}: {ex.Message}" );
		}
	}

	[Rpc.Host]
	public static void RpcRequestCharacters()
	{
		var caller = Rpc.Caller;
		if ( caller is null ) return;
		_ = HandleRequestCharactersAsync( caller );
	}

	[Rpc.Host]
	public static void RpcCreateCharacter( int slot, string firstName, string lastName, string birthDate, int heightCm, string gender )
	{
		var caller = Rpc.Caller;
		if ( caller is null ) return;

		var payload = new MirageCharacterCreateRequest
		{
			Slot = slot,
			FirstName = (firstName ?? "").Trim(),
			LastName = (lastName ?? "").Trim(),
			BirthDate = (birthDate ?? "").Trim(),
			HeightCm = heightCm,
			Gender = (gender ?? "").Trim().ToLowerInvariant()
		};

		if ( !ValidatePayload( payload, out var err ) )
		{
			using ( Rpc.FilterInclude( caller ) )
				RpcCharacterError( err );
			return;
		}

		_ = HandleCreateCharacterAsync( caller, payload );
	}

	[Rpc.Host]
	public static void RpcSelectCharacter( string characterId )
	{
		var caller = Rpc.Caller;
		if ( caller is null || string.IsNullOrEmpty( characterId ) ) return;
		_ = HandleSelectCharacterAsync( caller, characterId );
	}

	private static async Task HandleRequestCharactersAsync( Connection caller )
	{
		try
		{
			var list = await MirageApiClient.ListCharactersAsync( (long)caller.SteamId );
			await GameTask.MainThread();
			DeliverCharacters( caller, list );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] Failed to fetch characters for {caller.DisplayName}: {ex.Message}" );
			await GameTask.MainThread();
			DeliverError( caller, "Impossible de charger les personnages depuis le serveur." );
		}
	}

	private static async Task HandleCreateCharacterAsync( Connection caller, MirageCharacterCreateRequest payload )
	{
		try
		{
			await MirageApiClient.CreateCharacterAsync( (long)caller.SteamId, payload );
			var list = await MirageApiClient.ListCharactersAsync( (long)caller.SteamId );
			await GameTask.MainThread();
			DeliverCharacters( caller, list );
		}
		catch ( MirageApiException ex )
		{
			await GameTask.MainThread();
			var msg = ex.StatusCode == 409 ? "Cet emplacement est déjà utilisé." : "Impossible de créer le personnage.";
			DeliverError( caller, msg );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] Failed to create character for {caller.DisplayName}: {ex.Message}" );
			await GameTask.MainThread();
			DeliverError( caller, "Impossible de créer le personnage." );
		}
	}

	private static async Task HandleSelectCharacterAsync( Connection caller, string characterId )
	{
		try
		{
			var list = await MirageApiClient.ListCharactersAsync( (long)caller.SteamId );
			var pick = list.FirstOrDefault( c => c.Id == characterId );

			await GameTask.MainThread();

			if ( pick is null )
			{
				DeliverError( caller, "Personnage introuvable." );
				return;
			}

			var pd = PlayerData.For( caller );
			if ( pd is null ) return;

			pd.ActiveCharacterId = pick.Id;
			pd.FirstName = pick.FirstName;
			pd.LastName = pick.LastName;

			// Move the player out of limbo. Use the saved last position when
			// available, otherwise pick a SpawnPoint. The teleport runs on the
			// owning client (Rpc.Owner) so the controller picks up the new
			// position cleanly.
			var player = Game.ActiveScene.GetAll<Player>().FirstOrDefault( x => x.Network.Owner?.Id == pd.PlayerId );
			if ( player.IsValid() )
			{
				var target = ResolveCharacterSpawn( pick );
				player.MirageTeleport( target.Position, target.Rotation.Angles() );
			}
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] Failed to select character for {caller.DisplayName}: {ex.Message}" );
			await GameTask.MainThread();
			DeliverError( caller, "Impossible de sélectionner le personnage." );
		}
	}

	private static void DeliverCharacters( Connection target, List<MirageCharacterSummary> list )
	{
		var json = Sandbox.Json.Serialize( list ?? new List<MirageCharacterSummary>() );
		using ( Rpc.FilterInclude( target ) )
			RpcDeliverCharacters( json );
	}

	private static void DeliverError( Connection target, string message )
	{
		using ( Rpc.FilterInclude( target ) )
			RpcCharacterError( message );
	}

	[Rpc.Broadcast( NetFlags.HostOnly | NetFlags.Reliable )]
	private static void RpcDeliverCharacters( string charactersJson )
	{
		var list = string.IsNullOrEmpty( charactersJson )
			? new List<MirageCharacterSummary>()
			: Sandbox.Json.Deserialize<List<MirageCharacterSummary>>( charactersJson );
		MirageClientCache.SetCharacters( list );
	}

	[Rpc.Broadcast( NetFlags.HostOnly | NetFlags.Reliable )]
	private static void RpcCharacterError( string message )
	{
		MirageClientCache.SetError( message );
	}

	private static Transform ResolveCharacterSpawn( MirageCharacterSummary character )
	{
		// If the character has a saved IC position, restart there.
		if ( character?.LastPosition is { } last )
		{
			var pos = new Vector3( last.X, last.Y, last.Z );
			return new Transform( pos, Rotation.FromYaw( last.Yaw ) );
		}

		// Otherwise pick a random SpawnPoint, falling back to world origin.
		var spawnPoints = Game.ActiveScene.GetAllComponents<SpawnPoint>().ToArray();
		if ( spawnPoints.Length == 0 ) return Transform.Zero;
		var sp = Random.Shared.FromArray( spawnPoints );
		return sp.Transform.World;
	}

	private static bool ValidatePayload( MirageCharacterCreateRequest p, out string err )
	{
		err = null;
		if ( p.Slot < 0 || p.Slot > MaxCharacterSlot ) { err = "Emplacement invalide."; return false; }
		if ( string.IsNullOrEmpty( p.FirstName ) || p.FirstName.Length > 32 ) { err = "Le prénom doit faire entre 1 et 32 caractères."; return false; }
		if ( string.IsNullOrEmpty( p.LastName ) || p.LastName.Length > 32 ) { err = "Le nom doit faire entre 1 et 32 caractères."; return false; }
		if ( !BirthDateRegex.IsMatch( p.BirthDate ) ) { err = "La date de naissance doit être au format AAAA-MM-JJ."; return false; }
		if ( p.HeightCm < 50 || p.HeightCm > 272 ) { err = "La taille doit être entre 50 et 272 cm."; return false; }
		if ( p.Gender != "m" && p.Gender != "f" ) { err = "Le genre doit être 'm' ou 'f'."; return false; }
		return true;
	}
}
