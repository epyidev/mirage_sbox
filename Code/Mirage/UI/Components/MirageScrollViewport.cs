/** @author Epyi */

namespace Sandbox.Mirage.UI;

/// <summary>
/// Internal viewport panel used by <see cref="MirageScrollPanel"/>. Scales
/// incoming mouse-wheel deltas before the engine's default scroll handler
/// runs, giving us a tunable wheel speed.
/// </summary>
public class MirageScrollViewport : Sandbox.UI.Panel
{
	/// <summary>
	/// Multiplier applied to incoming wheel deltas. 1 keeps the engine
	/// default; 0.5 halves the scroll speed; 2 doubles it.
	/// </summary>
	public float WheelSpeed { get; set; } = 0.5f;

	public override void OnMouseWheel( Vector2 value )
	{
		base.OnMouseWheel( value * WheelSpeed );
	}
}
