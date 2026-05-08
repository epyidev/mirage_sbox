/** @author Epyi */

using System.Text.Json.Serialization;

namespace Sandbox.Mirage;

/// <summary>
/// World pickup created when a player drops an item from the Mirage
/// inventory. Holds the serialized payload so picking it back up restores
/// the same item id, count and metadata. When an item has no specific
/// <see cref="MirageItem.DropPrefab"/> we still spawn this component on a
/// generic "bag" mesh, but the inventory ends up with the original item
/// regardless of what visual the operator picked it up from.
/// </summary>
public sealed class MirageDroppedItem : Component, Component.IPressable
{
	private const string DefaultBagModel = "models/citizen_props/cardboardbox01.vmdl";

	[Sync( SyncFlags.FromHost )] public string ItemId { get; set; }
	[Sync( SyncFlags.FromHost )] public int Count { get; set; }
	[Sync( SyncFlags.FromHost )] public string MetadataJson { get; set; }

	IPressable.Tooltip? IPressable.GetTooltip( IPressable.Event e )
	{
		var item = MirageItems.Find( ItemId );
		var label = item?.Label ?? ItemId ?? "Objet";
		var suffix = Count > 1 ? $" x{Count}" : "";
		return new IPressable.Tooltip( "Ramasser", "inventory_2", $"{label}{suffix}" );
	}

	bool IPressable.CanPress( IPressable.Event e ) => !string.IsNullOrEmpty( ItemId ) && Count > 0;

	bool IPressable.Press( IPressable.Event e )
	{
		DoPickup( e.Source.GameObject );
		return true;
	}

	[Rpc.Host]
	private void DoPickup( GameObject presserObject )
	{
		if ( !presserObject.IsValid() ) return;
		var player = presserObject.Root.GetComponent<Player>();
		if ( !player.IsValid() ) return;
		var inv = player.GetComponent<MirageInventory>();
		if ( inv is null ) return;
		if ( string.IsNullOrEmpty( ItemId ) || Count <= 0 ) return;

		Dictionary<string, string> metadata = null;
		if ( !string.IsNullOrEmpty( MetadataJson ) )
		{
			try { metadata = Sandbox.Json.Deserialize<Dictionary<string, string>>( MetadataJson ); } catch { }
		}

		var leftover = inv.Add( ItemId, Count, metadata );
		if ( leftover >= Count ) return; // inventory full, leave the drop alone

		Count = leftover;
		MirageInventoryEquip.ApplyEquip( player, inv );

		if ( Count <= 0 )
		{
			GameObject.Destroy();
		}
	}

	/// <summary>
	/// Host-only. Spawn a dropped-item world object in front of
	/// <paramref name="player"/>. Uses <paramref name="item"/>.DropPrefab if
	/// available, otherwise builds a generic crate. Either way it carries
	/// the full payload so the pickup restores the original item.
	/// </summary>
	public static void SpawnFromPlayer( Player player, MirageItem item, string itemId, int count, IReadOnlyDictionary<string, string> metadata )
	{
		Assert.True( Networking.IsHost, "MirageDroppedItem.SpawnFromPlayer must run on the host" );
		if ( !player.IsValid() ) return;
		if ( string.IsNullOrEmpty( itemId ) || count <= 0 ) return;

		var spawnPos = ResolveSpawnPosition( player );

		// Pick the visual: explicit DropPrefab wins, then weapon items fall
		// back to their carryable prefab so a dropped pistol shows the
		// pistol model, then a generic trashbag for everything else.
		string visualPrefab = item?.DropPrefab;
		if ( string.IsNullOrEmpty( visualPrefab ) && !string.IsNullOrEmpty( item?.WeaponPrefab ) )
		{
			visualPrefab = item.WeaponPrefab;
		}

		GameObject go;
		if ( !string.IsNullOrEmpty( visualPrefab ) )
		{
			var prefab = GameObject.GetPrefab( visualPrefab );
			if ( prefab.IsValid() )
			{
				go = prefab.Clone( new CloneConfig
				{
					Transform = new Transform( spawnPos ),
					StartEnabled = true
				} );

				// The Sandbox base weapon prefab carries a DroppedWeapon
				// component whose own IPressable handler routes pickups
				// into the legacy PlayerInventory. Strip it so Mirage owns
				// the pickup interaction end to end.
				var legacyPickup = go.GetComponent<DroppedWeapon>();
				if ( legacyPickup is not null ) legacyPickup.Destroy();

				// Force the carryable into its dropped state so the world
				// model, collider and rigidbody come alive (otherwise the
				// freshly-cloned prefab sits frozen as if it was held).
				var carryable = go.GetComponent<BaseCarryable>();
				if ( carryable.IsValid() ) carryable.SetDropped( true );
			}
			else
			{
				Log.Warning( $"[Mirage] Visual prefab '{visualPrefab}' could not be loaded, falling back to bag." );
				go = BuildGenericBag( spawnPos );
			}
		}
		else
		{
			go = BuildGenericBag( spawnPos );
		}

		go.Name = $"Mirage Drop ({itemId} x{count})";
		go.Tags.Add( "removable" );

		var dropped = go.GetComponent<MirageDroppedItem>();
		if ( dropped is null ) dropped = go.AddComponent<MirageDroppedItem>();
		dropped.ItemId = itemId;
		dropped.Count = count;
		dropped.MetadataJson = metadata is null ? "" : Sandbox.Json.Serialize( metadata );

		Ownable.Set( go, player.Network.Owner );
		go.NetworkSpawn();

		// Push it slightly away from the player and add a bit of velocity
		// so it does not clip the operator who just dropped it.
		var rb = go.GetComponent<Rigidbody>();
		if ( rb.IsValid() && player.Controller.IsValid() )
		{
			var ang = player.Controller.EyeAngles;
			var forward = Rotation.From( 0, ang.yaw, 0 ).Forward;
			rb.Velocity = forward * 120f + Vector3.Up * 80f;
			rb.AngularVelocity = Vector3.Random * 4f;
		}
	}

	private static Vector3 ResolveSpawnPosition( Player player )
	{
		var ang = player.Controller.IsValid() ? player.Controller.EyeAngles : Angles.Zero;
		var forward = Rotation.From( 0, ang.yaw, 0 ).Forward;
		var origin = player.WorldPosition + Vector3.Up * 48f;
		return origin + forward * 32f;
	}

	private static GameObject BuildGenericBag( Vector3 position )
	{
		var go = new GameObject( true, "Mirage Drop" );
		go.WorldPosition = position;
		// The stock s&box cardboard box is sized for an adult to carry, so
		// shrink the GameObject down to a small parcel that fits a player's
		// pocket-sized item.
		go.WorldScale = new Vector3( 0.45f, 0.45f, 0.45f );

		var renderer = go.AddComponent<ModelRenderer>();
		try { renderer.Model = Model.Load( DefaultBagModel ); } catch { }

		// The cardboardbox visual is roughly a cube, so the collider is
		// kept cubic too. Scale runs through WorldScale (0.45 above),
		// giving an effective ~22.5cm cube which matches the parcel and
		// still leaves a forgiving aim cone for the pickup raycast.
		// Center lifts the box by half its height so the collider sits
		// entirely above the GameObject origin (the model's base pivot),
		// which keeps the parcel flush with the floor instead of floating.
		var collider = go.AddComponent<BoxCollider>();
		collider.Scale = new Vector3( 50f, 50f, 50f );
		collider.Center = new Vector3( 0f, 0f, 25f );

		var rb = go.AddComponent<Rigidbody>();
		rb.MassOverride = 1.5f;

		return go;
	}
}
