/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Per-character wallet store. Mirrors the <c>accounts</c> table on the API
/// side: one entry per <c>account_id</c> (cash, bank, and any future wallet
/// like crypto, paycheck, ...). Lives as a Component on the player and is
/// host-authoritative; the owning client sees the values for the local HUD.
///
/// On character spawn the host hydrates this from <c>MirageApiClient.GetCharacterDetailAsync</c>.
/// On flush the contents are folded into the snapshot payload. Mirage gameplay
/// systems should mutate balances exclusively through <see cref="SetAmount"/>
/// or <see cref="Add"/> so the synced state stays consistent.
/// </summary>
public sealed class MirageWallet : Component
{
	/// <summary>
	/// Default wallet ids seeded automatically when a character is first
	/// loaded with no rows. Mirrors the API's <c>DEFAULT_ACCOUNT_IDS</c>.
	/// </summary>
	public static readonly string[] DefaultAccountIds = { "cash", "bank" };

	/// <summary>
	/// Wallet balances keyed by account id. Synced from host so the local
	/// client can read its own pockets without an extra round trip.
	/// </summary>
	[Sync( SyncFlags.FromHost )] public NetDictionary<string, int> Balances { get; set; } = new();

	/// <summary>Bumped on every host-side mutation so HUDs can poll for changes.</summary>
	[Sync( SyncFlags.FromHost )] public int Version { get; set; }

	public int Get( string accountId )
	{
		if ( string.IsNullOrEmpty( accountId ) ) return 0;
		return Balances.TryGetValue( accountId, out var v ) ? v : 0;
	}

	/// <summary>Host-only. Replace the balance of <paramref name="accountId"/> with <paramref name="amount"/>.</summary>
	public void SetAmount( string accountId, int amount )
	{
		Assert.True( Networking.IsHost, "MirageWallet.SetAmount must run on the host" );
		if ( string.IsNullOrEmpty( accountId ) ) return;
		Balances[accountId] = amount;
		Version++;
	}

	/// <summary>Host-only. Add <paramref name="delta"/> to the balance, may go negative.</summary>
	public int Add( string accountId, int delta )
	{
		Assert.True( Networking.IsHost, "MirageWallet.Add must run on the host" );
		if ( string.IsNullOrEmpty( accountId ) ) return 0;
		var next = Get( accountId ) + delta;
		Balances[accountId] = next;
		Version++;
		return next;
	}

	/// <summary>
	/// Host-only. Wipe every wallet entry. Called when the character changes
	/// (relog, kick to selection) so the next load starts from a clean slate.
	/// </summary>
	public void Clear()
	{
		Assert.True( Networking.IsHost, "MirageWallet.Clear must run on the host" );
		Balances.Clear();
		Version++;
	}

	/// <summary>
	/// Host-only. Replace the entire wallet set with <paramref name="entries"/>.
	/// Default wallets missing from the source are seeded at zero so gameplay
	/// can always assume a "cash" / "bank" entry exists.
	/// </summary>
	public void Replace( IReadOnlyList<MirageAccountEntry> entries )
	{
		Assert.True( Networking.IsHost, "MirageWallet.Replace must run on the host" );
		Balances.Clear();
		if ( entries is not null )
		{
			foreach ( var e in entries )
			{
				if ( string.IsNullOrEmpty( e?.AccountId ) ) continue;
				Balances[e.AccountId] = e.Amount;
			}
		}
		foreach ( var id in DefaultAccountIds )
		{
			if ( !Balances.ContainsKey( id ) ) Balances[id] = 0;
		}
		Version++;
	}

	/// <summary>Host-only. Snapshot every wallet for the API save payload.</summary>
	public List<MirageWalletEntry> Snapshot()
	{
		var list = new List<MirageWalletEntry>( Balances.Count );
		foreach ( var kv in Balances )
		{
			list.Add( new MirageWalletEntry { AccountId = kv.Key, Amount = kv.Value } );
		}
		return list;
	}

	public static MirageWallet For( Player player ) => player?.GetComponent<MirageWallet>();
}
