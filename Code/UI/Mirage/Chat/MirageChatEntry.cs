/** @author Epyi */

using Sandbox.UI;

namespace Sandbox.Mirage.UI;

/// <summary>
/// Specialised <see cref="TextEntry"/> used by the Mirage chat input. The
/// stock TextEntry consumes Tab (focus cycling) and the arrow keys (text
/// cursor movement) before they can reach the surrounding panel, so the
/// chat would never see them. This subclass intercepts those keys via
/// <see cref="OnButtonTyped(ButtonEvent)"/>, fires public callbacks for the
/// chat to react to, and stops propagation so the default behaviour does
/// not also kick in.
///
/// Only OnButtonTyped is overridden, never <c>OnButtonEvent</c>. Both fire
/// for the same physical key press, so handling in both would call the
/// callback twice and the chat would, for example, jump two history
/// entries on a single arrow tap. OnButtonTyped also covers key repeat for
/// free, so the operator can hold an arrow to scroll the backlog.
/// </summary>
public class MirageChatEntry : TextEntry
{
	// Windows virtual key codes. The Button string varies (eg. "uparrow",
	// "up", platform-specific) but VirtualKey is stable.
	private const int VkTab = 9;
	private const int VkEscape = 27;
	private const int VkUp = 38;
	private const int VkDown = 40;

	/// <summary>Fires when the user presses Tab while the entry is focused.</summary>
	public Action OnTabKey { get; set; }

	/// <summary>Fires when the user presses the up arrow.</summary>
	public Action OnArrowUp { get; set; }

	/// <summary>Fires when the user presses the down arrow.</summary>
	public Action OnArrowDown { get; set; }

	public override void OnButtonTyped( ButtonEvent e )
	{
		if ( TryHandleSpecialKey( e ) )
		{
			e.StopPropagation = true;
			return;
		}
		base.OnButtonTyped( e );
	}

	protected override void OnEscape( PanelEvent e )
	{
		// The pause menu opens by polling Input.EscapePressed at the engine
		// level, completely separate from the panel event pipeline, so just
		// stopping propagation is not enough. Clear the flag too so the
		// engine sees the press as already consumed this frame.
		Input.EscapePressed = false;
		Blur();
		e.StopPropagation();
	}

	private bool TryHandleSpecialKey( ButtonEvent e )
	{
		if ( IsKey( e, VkTab, "tab" ) )
		{
			OnTabKey?.Invoke();
			return true;
		}
		if ( IsKey( e, VkUp, "uparrow", "up" ) )
		{
			OnArrowUp?.Invoke();
			return true;
		}
		if ( IsKey( e, VkDown, "downarrow", "down" ) )
		{
			OnArrowDown?.Invoke();
			return true;
		}
		return false;
	}

	private static bool IsKey( ButtonEvent e, int virtualKey, params string[] names )
	{
		if ( e.VirtualKey == virtualKey ) return true;
		if ( string.IsNullOrEmpty( e.Button ) ) return false;
		for ( int i = 0; i < names.Length; i++ )
		{
			if ( string.Equals( e.Button, names[i], StringComparison.OrdinalIgnoreCase ) )
				return true;
		}
		return false;
	}
}
