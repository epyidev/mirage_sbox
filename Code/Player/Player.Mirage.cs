/** @author Epyi */

/// <summary>
/// Mirage-specific extensions to <see cref="Player"/>. Lives in a partial so
/// the upstream Sandbox code stays untouched and the diff is easy to follow.
/// </summary>
public sealed partial class Player
{
	/// <summary>
	/// Host-issued teleport to the owning client. Used to move the player from
	/// the limbo spawn (where they wait while the character selection screen
	/// is open) to a real spawn point right after a character is bound.
	///
	/// The owner-side write keeps the controller driving movement from the
	/// new position; setting <see cref="WorldPosition"/> from the host alone
	/// would race the controller's next tick.
	/// </summary>
	[Rpc.Owner( NetFlags.HostOnly | NetFlags.Reliable )]
	public void MirageTeleport( Vector3 position, Angles eyeAngles )
	{
		if ( !IsLocalPlayer ) return;

		WorldPosition = position;

		if ( Controller.IsValid() )
		{
			Controller.EyeAngles = eyeAngles;
		}
	}

	protected override void OnUpdate()
	{
		// Pin the local player's body at the configured character-select spot
		// while no character is bound. Without this the controller still
		// applies gravity, the body falls out of the sky and racks up fall
		// damage even though it is hidden and the operator is staring at the
		// selection screen. Damage itself is also cancelled in
		// MirageSession.OnPlayerDamaging as a belt-and-suspenders guard.
		if ( !IsLocalPlayer ) return;
		if ( PlayerData is not { HasActiveCharacter: false } ) return;

		WorldPosition = MirageConVars.CharacterSelectPlayerPosition;

		// Controller.Velocity is read-only; clear the underlying Rigidbody's
		// velocity instead so falls do not accumulate frame to frame.
		if ( Controller.IsValid() && Controller.Body.IsValid() )
		{
			Controller.Body.Velocity = Vector3.Zero;
			Controller.Body.AngularVelocity = Vector3.Zero;
		}
	}
}
