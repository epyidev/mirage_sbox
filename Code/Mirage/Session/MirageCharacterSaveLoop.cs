/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Host-only periodic save scheduler. Wakes up on a fixed cadence
/// (<see cref="SaveIntervalSeconds"/>) and asks <see cref="MirageCharacterSave"/>
/// to flush every connected character to the API. Disconnect, /relog and
/// /saveallcharacters bypass this loop and call <c>FlushPlayerAsync</c>
/// directly so they always save even if the timer just fired.
/// </summary>
public sealed class MirageCharacterSaveLoop : GameObjectSystem<MirageCharacterSaveLoop>
{
	/// <summary>
	/// 10 minutes between automatic flushes. Short enough that a server
	/// crash only loses a few RP minutes of work per character, long
	/// enough that the API is never hammered by the loop alone.
	/// </summary>
	private const float SaveIntervalSeconds = 600f;

	private RealTimeUntil _nextSave = SaveIntervalSeconds;

	public MirageCharacterSaveLoop( Scene scene ) : base( scene )
	{
		Listen( Stage.SceneLoaded, 0, OnSceneLoaded, "MirageCharacterSaveLoop.SceneLoaded" );
		Listen( Stage.StartUpdate, 0, OnTick, "MirageCharacterSaveLoop.Tick" );
	}

	private void OnSceneLoaded()
	{
		_nextSave = SaveIntervalSeconds;
	}

	private void OnTick()
	{
		if ( !Networking.IsHost ) return;
		if ( !_nextSave ) return;

		// Reset before launching the async work so a long save chain does
		// not stack a second flush on top of the first.
		_nextSave = SaveIntervalSeconds;
		_ = RunSaveAsync();
	}

	private static async Task RunSaveAsync()
	{
		try
		{
			var count = await MirageCharacterSave.FlushAllAsync();
			if ( count > 0 )
			{
				Log.Info( $"[Mirage] Periodic save flushed {count} character(s)." );
			}
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] Periodic save crashed: {ex.Message}" );
		}
	}
}
