/** @author Epyi */

namespace Sandbox.Mirage.UI;

/// <summary>
/// Single source of truth for what a Mirage modal UI does to the rest of the
/// game while it is open. The panel calls
/// <see cref="SetActive(bool)"/> every frame from its <c>OnUpdate</c> with
/// the current open state. The lock then engages or disengages on the
/// transition, no matter how the panel chose to manage its own visibility.
///
/// Active behaviour:
/// <list type="bullet">
///   <item>Forces the OS cursor visible so the operator can click on the
///   panel even while the player controller would normally hide it.</item>
///   <item>Clears every gameplay-bound action so weapons, inventory, the
///   player controller and any other code that polls <c>Input.Down</c> /
///   <c>Input.Pressed</c> sees an empty input set. Razor's mouse event
///   pipeline (hover, onclick) does not flow through the action system, so
///   clicking and hovering on the panel itself keep working normally.</item>
/// </list>
///
/// Inactive behaviour (on the closing transition only):
/// <list type="bullet">
///   <item>Restores <see cref="Mouse.Visibility"/> to <c>Auto</c> so the
///   engine resumes its normal cursor behaviour, which means the cursor
///   re-locks to the game when no other interactive UI is on screen.</item>
/// </list>
///
/// Canonical use from a modal panel:
/// <code>
/// protected override void OnUpdate()
/// {
///     var open = ...;
///     SetClass( "open", open );
///     MirageModalLock.SetActive( open );
///     if ( !open ) return;
///     // ... open-state logic ...
/// }
/// </code>
/// </summary>
public static class MirageModalLock
{
	/// <summary>
	/// Every action defined in <c>ProjectSettings/Input.config</c> that maps to
	/// gameplay behaviour. Any new gameplay action added to the config should
	/// be appended here so modal panels keep blocking it.
	/// </summary>
	private static readonly string[] BlockedActions =
	{
		// Weapons
		"attack1", "attack2", "Reload",
		// Inventory
		"Slot1", "Slot2", "Slot3", "Slot4", "Slot5",
		"Slot6", "Slot7", "Slot8", "Slot9", "Slot0",
		"SlotPrev", "SlotNext", "Drop", "invprev",
		// Movement
		"Forward", "Backward", "Left", "Right",
		"Jump", "Duck", "Run", "Walk",
		// Other gameplay
		"Use", "Voice", "Flashlight", "Spray", "die", "View",
		"InspectMenu", "spawnmenu", "Score", "undo", "Chat"
	};

	private static bool _wasActive;

	/// <summary>
	/// Push the current open state of a modal panel. Calling with <c>true</c>
	/// every frame keeps the lock engaged; calling with <c>false</c> on the
	/// frame the panel closes releases it cleanly.
	/// </summary>
	public static void SetActive( bool active )
	{
		if ( active )
		{
			Engage();
		}
		else if ( _wasActive )
		{
			Disengage();
		}
		_wasActive = active;
	}

	private static void Engage()
	{
		Mouse.Visibility = MouseVisibility.Visible;

		for ( int i = 0; i < BlockedActions.Length; i++ )
		{
			Input.Clear( BlockedActions[i] );
		}
	}

	private static void Disengage()
	{
		// Hand the cursor back to the engine. With Auto, the engine shows the
		// cursor when interactive UI is on screen and locks it to the game
		// otherwise, which is the same behaviour the player controller relies
		// on by default.
		Mouse.Visibility = MouseVisibility.Auto;
	}
}
