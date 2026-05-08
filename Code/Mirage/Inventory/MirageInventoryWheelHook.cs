/** @author Epyi */

namespace Sandbox.Mirage.UI;

/// <summary>
/// Tiny <see cref="Sandbox.UI.Panel"/> subclass whose only job is to
/// capture mouse-wheel events on its content and forward them to a
/// callback. <see cref="Sandbox.Input.MouseWheel"/> polling from a
/// <see cref="PanelComponent"/>'s <c>OnUpdate</c> is unreliable because
/// any panel in the cursor's path can absorb the wheel via its default
/// <see cref="Sandbox.UI.Panel.OnMouseWheel(Vector2)"/> handler before
/// our update runs. Wrapping the inventory grid with this hook makes
/// the wheel land here first, where we can do whatever we want with
/// it (in our case: tweak the split amount during a drag).
///
/// The base <c>OnMouseWheel</c> is intentionally NOT called: we don't
/// want the panel to scroll or propagate the event further.
/// </summary>
public class MirageInventoryWheelHook : Sandbox.UI.Panel
{
	public Action<float> OnWheel { get; set; }

	public override void OnMouseWheel( Vector2 value )
	{
		OnWheel?.Invoke( value.y );
	}
}
