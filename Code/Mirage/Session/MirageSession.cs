/** @author Epyi */

using System.Text.RegularExpressions;

namespace Sandbox.Mirage;

/// <summary>
/// Server-side coordinator for the Mirage character lifecycle. Hooks into the
/// connect / spawn / disconnect events to:
/// 1. ensure the OOC <c>players</c> row exists and IP history is updated,
/// 2. park freshly connected players at the configured character-select spot
///    with their <c>Body</c> renderer disabled, so they exist as a frozen,
///    invisible placeholder until they pick a character,
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

		// Atomic full-snapshot flush before the connection is gone. We
		// fire-and-forget here because the engine does not give us a way
		// to await on disconnect, but the snapshot has already been built
		// from live state by the time the request leaves the host.
		_ = MirageCharacterSave.FlushPlayerAsync( player );
	}

	void Global.IPlayerEvents.OnPlayerRespawning( PlayerRespawnEvent e )
	{
		if ( !Networking.IsHost ) return;
		if ( e?.PlayerData is null ) return;
		if ( e.PlayerData.HasActiveCharacter ) return;

		// Park the player at the configured character-select spot. Per-client
		// freeze (PlayerController.UseInputControls) and per-client camera
		// override happen on the player itself; host-side body hiding kicks
		// in on the post-spawn step below.
		e.SpawnLocation = new Transform(
			MirageConVars.CharacterSelectPlayerPosition,
			Rotation.FromYaw( MirageConVars.CharacterSelectPlayerYaw )
		);
	}

	void Global.IPlayerEvents.OnPlayerSpawned( Player player )
	{
		if ( !Networking.IsHost ) return;
		if ( player is null ) return;

		ApplyLimboVisibility( player );
		EnsureMirageInventory( player );
	}

	private static void EnsureMirageInventory( Player player )
	{
		// Player has [RequireComponent(MirageInventory)] so the engine
		// attaches one automatically. We just clear the legacy default
		// loadout so the new system starts from a known empty state on
		// every fresh spawn.
		var inv = player.GetComponent<MirageInventory>();
		if ( inv is null ) return;
		MirageInventoryEquip.ApplyEquip( player, inv );
	}

	void Global.IPlayerEvents.OnPlayerDamaging( PlayerDamageEvent e )
	{
		if ( e?.Player is null ) return;
		var pd = e.Player.PlayerData;
		if ( pd is null ) return;
		if ( pd.HasActiveCharacter ) return;

		// Limbo players are not really alive yet. Block every incoming
		// damage so nothing (fall damage, world triggers, an early-firing
		// weapon, etc.) can kill them before they have even picked a
		// character.
		e.Cancelled = true;
	}

	/// <summary>
	/// Host-side. Hide the player body GameObject while the player has no
	/// active character. The Enabled flag replicates through the network
	/// model so every client also sees them as not present.
	/// </summary>
	internal static void ApplyLimboVisibility( Player player )
	{
		if ( player is null ) return;
		var pd = player.PlayerData;
		if ( pd is null ) return;
		if ( !player.Body.IsValid() ) return;

		var visible = pd.HasActiveCharacter;
		if ( player.Body.Enabled != visible )
		{
			player.Body.Enabled = visible;
		}
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
			// Single API round trip that pulls the full character payload
			// (identity + position + vitals + wallets + inventory) so we
			// can hydrate the in-memory components in one go.
			var detail = await MirageApiClient.GetCharacterDetailAsync( (long)caller.SteamId, characterId );

			await GameTask.MainThread();

			if ( detail is null || detail.SteamId != caller.SteamId.ToString() )
			{
				DeliverError( caller, "Personnage introuvable." );
				return;
			}

			var pd = PlayerData.For( caller );
			if ( pd is null ) return;

			pd.ActiveCharacterId = detail.Id;
			pd.FirstName = detail.FirstName;
			pd.LastName = detail.LastName;

			var player = Game.ActiveScene.GetAll<Player>().FirstOrDefault( x => x.Network.Owner?.Id == pd.PlayerId );
			if ( player.IsValid() )
			{
				ApplyLoadedState( player, detail );

				var target = ResolveCharacterSpawn( detail );
				player.MirageTeleport( target.Position, target.Rotation.Angles() );
				ApplyLimboVisibility( player );
			}
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] Failed to select character for {caller.DisplayName}: {ex.Message}" );
			await GameTask.MainThread();
			DeliverError( caller, "Impossible de sélectionner le personnage." );
		}
	}

	/// <summary>
	/// Host-only. Save the active character, clear every per-character
	/// component (identity, inventory, wallet, equipped weapon), then send
	/// the player back to the character-select limbo. Used by /relog so
	/// the operator can swap character without a full deco/reco.
	/// </summary>
	public static async Task SendBackToCharacterSelectAsync( Player player )
	{
		Assert.True( Networking.IsHost, "MirageSession.SendBackToCharacterSelectAsync must run on the host" );
		if ( !player.IsValid() ) return;
		var pd = player.PlayerData;
		if ( pd is null || !pd.HasActiveCharacter ) return;

		// Persist the current character first so nothing is lost on the way out.
		await MirageCharacterSave.FlushPlayerAsync( player );

		// Clear identity. PlayerData fields are FromHost so the client
		// re-reads the limbo state. The character-select UI keys on
		// HasActiveCharacter so it reopens on its own.
		pd.ActiveCharacterId = null;
		pd.FirstName = "";
		pd.LastName = "";

		// Drop every active carryable so we do not keep the previous
		// character's gun in the new character's hand.
		var legacy = player.GetComponent<PlayerInventory>();
		if ( legacy is not null )
		{
			foreach ( var carryable in legacy.Weapons.ToArray() )
			{
				carryable?.GameObject?.Destroy();
			}
			legacy.SwitchWeapon( null, allowHolster: true );
		}

		player.GetComponent<MirageInventory>()?.ClearAll();
		player.GetComponent<MirageWallet>()?.Clear();

		// Park the player back at the character-select limbo spot.
		var target = new Transform(
			MirageConVars.CharacterSelectPlayerPosition,
			Rotation.FromYaw( MirageConVars.CharacterSelectPlayerYaw )
		);
		player.MirageTeleport( target.Position, target.Rotation.Angles() );
		ApplyLimboVisibility( player );
	}

	/// <summary>
	/// Push the API-loaded state onto the in-memory components. Health and
	/// armour go through the synced fields on <see cref="Player"/>, the
	/// wallet and the inventory each have a host-only Replace/LoadFromApi.
	/// </summary>
	private static void ApplyLoadedState( Player player, MirageCharacterDetail detail )
	{
		if ( detail is null || !player.IsValid() ) return;

		// Vitals: clamp to the engine range so a corrupt row cannot push
		// the player past the [Range] declared on Player.
		player.Health = Math.Clamp( detail.Health, 0f, player.MaxHealth );
		if ( detail.MaxHealth > 0 ) player.MaxHealth = detail.MaxHealth;
		player.Armour = Math.Clamp( detail.Armour, 0f, player.MaxArmour );

		var wallet = player.GetComponent<MirageWallet>();
		wallet?.Replace( detail.Accounts );

		var inv = player.GetComponent<MirageInventory>();
		inv?.LoadFromApi( detail.Inventory );
		MirageInventoryEquip.ApplyEquip( player, inv );
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
