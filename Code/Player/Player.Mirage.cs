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
}
