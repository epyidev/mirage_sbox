public partial class BaseWeapon
{
	/// <summary>
	/// Does this weapon consume ammo at all?
	/// </summary>
	[Property, FeatureEnabled( "Ammo" )] public bool UsesAmmo { get; set; } = true;

	/// <summary>
	/// Does this weapon use clips?
	/// </summary>
	[Property, Feature( "Ammo" )] public bool UsesClips { get; set; } = true;

	/// <summary>
	/// When reloading, we'll take ammo from the reserve as much as we can to fill to this amount.
	/// </summary>
	[Property, Feature( "Ammo" ), ShowIf( nameof( UsesClips ), true )] public int ClipMaxSize { get; set; } = 30;

	/// <summary>
	/// The default amount of bullets in a weapon's magazine on pickup.
	/// </summary>
	/// <remarks>
	/// Mirage edit: synced from the owning client (player) so the host can
	/// observe the live magazine count without an extra RPC round trip and
	/// persist it into the equipped slot's metadata when the operator
	/// switches hotbar slots.
	/// </remarks>
	[Property, Feature( "Ammo" ), ShowIf( nameof( UsesClips ), true ), Sync] public int ClipContents { get; set; } = 20;

	/// <summary>
	/// The ammo resource this weapon uses for its reserve pool.
	/// When set, reserve ammo is shared with all weapons using the same resource.
	/// When null, ammo is tracked per-weapon (tied to this weapon instance).
	/// </summary>
	[Property, Feature( "Ammo" )] public AmmoResource AmmoType { get; set; }

	/// <summary>
	/// The maximum reserve ammo this weapon can hold (used only when <see cref="AmmoType"/> is null).
	/// When <see cref="AmmoType"/> is set, the resource's <see cref="AmmoResource.MaxReserve"/> is used instead.
	/// </summary>
	[Property, Feature( "Ammo" )] public int MaxReserveAmmo
	{
		get => AmmoType?.MaxReserve ?? _maxReserveAmmo;
		set => _maxReserveAmmo = value;
	}
	private int _maxReserveAmmo = 120;

	/// <summary>
	/// The current reserve ammo. Mirage path: when the operator holds this
	/// weapon through their <see cref="Sandbox.Mirage.MirageInventory"/>
	/// hotbar slot, reserve = number of matching ammo items in the
	/// inventory. The setter is a no-op on that path because consumption
	/// goes through <see cref="Sandbox.Mirage.MirageWeaponBridge.TryConsumeReserve"/>
	/// (host-authoritative). Upstream path (no Mirage inventory): falls back
	/// to the original AmmoInventory pool / per-weapon counter.
	/// </summary>
	[Property, Feature( "Ammo" )] public int ReserveAmmo
	{
		get
		{
			if ( Sandbox.Mirage.MirageWeaponBridge.TryGetReserve( this, out var mirage ) )
				return mirage;

			if ( AmmoType is not null )
				return GetAmmoInventory()?.GetAmmo( AmmoType ) ?? 0;

			return _reserveAmmo;
		}
		set
		{
			// Mirage owns the reserve through inventory items. The reload
			// loop already calls TryConsumeReserve directly, so this setter
			// short-circuits when the bridge resolves.
			if ( Sandbox.Mirage.MirageWeaponBridge.ResolveAmmoTypeId( this ) is not null )
				return;

			if ( AmmoType is not null )
			{
				GetAmmoInventory()?.SetAmmo( AmmoType, value );
				return;
			}

			_reserveAmmo = value;
		}
	}

	/// <summary>
	/// Backing field for per-weapon reserve ammo (used when <see cref="AmmoType"/> is null).
	/// </summary>
	[Sync] private int _reserveAmmo { get; set; } = 0;

	/// <summary>
	/// How much reserve ammo this weapon starts with on pickup.
	/// When <see cref="AmmoType"/> is set, this seeds the shared pool only if the pool is empty.
	/// </summary>
	[Property, Feature( "Ammo" )] public int StartingAmmo { get; set; } = 0;

	/// <summary>
	/// How long does it take to reload?
	/// </summary>
	[Property, Feature( "Ammo" )] public float ReloadTime { get; set; } = 2.5f;

	/// <summary>
	/// Returns the player's <see cref="AmmoInventory"/>, or null if unavailable.
	/// </summary>
	private AmmoInventory GetAmmoInventory() => Owner?.GetComponent<AmmoInventory>();

	/// <summary>
	/// Can we switch to this gun?
	/// </summary>
	public override bool CanSwitch()
	{
		return true;
	}

	/// <summary>
	/// Takes ammo from the clip, or from reserve if not using clips.
	/// </summary>
	public bool TakeAmmo( int count )
	{
		if ( !UsesAmmo ) return true;
		if ( WeaponConVars.UnlimitedAmmo ) return true;

		if ( UsesClips )
		{
			if ( ClipContents < count )
				return false;

			ClipContents -= count;
			return true;
		}

		// No clips — take directly from reserve
		if ( WeaponConVars.InfiniteReserves ) return true;

		if ( AmmoType is not null )
		{
			var inv = GetAmmoInventory();
			if ( inv is null ) return false;
			return inv.TakeAmmo( AmmoType, count );
		}

		if ( _reserveAmmo < count )
			return false;

		_reserveAmmo -= count;
		return true;
	}

	/// <summary>
	/// Do we have ammo?
	/// </summary>
	public bool HasAmmo()
	{
		if ( !UsesAmmo ) return true;
		if ( WeaponConVars.UnlimitedAmmo ) return true;

		if ( UsesClips )
			return ClipContents > 0;

		if ( WeaponConVars.InfiniteReserves ) return true;

		return ReserveAmmo > 0;
	}

	/// <summary>
	/// Adds reserve ammo to this weapon (or the shared pool), clamped to max.
	/// Returns the actual amount added.
	/// </summary>
	public int AddReserveAmmo( int count )
	{
		if ( AmmoType is not null )
		{
			var inv = GetAmmoInventory();
			return inv?.AddAmmo( AmmoType, count ) ?? 0;
		}

		var space = _maxReserveAmmo - _reserveAmmo;
		var toAdd = Math.Min( count, space );
		_reserveAmmo += toAdd;
		return toAdd;
	}

	/// <summary>
	/// Mirage hook. Sent by the host to the owning client when a weapon is
	/// equipped through the Mirage hotbar so the magazine count saved on
	/// the slot is restored on the local carryable. Required because the
	/// <see cref="ClipContents"/> field is owner-authoritative (default
	/// <c>[Sync]</c>) and the host cannot write to it directly.
	/// </summary>
	[Rpc.Owner]
	public void RpcMirageSetClipContents( int value )
	{
		ClipContents = Math.Clamp( value, 0, ClipMaxSize );
	}
}
