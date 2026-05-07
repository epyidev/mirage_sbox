/** @author Epyi */

using Sandbox.UI;

namespace Sandbox.Mirage.UI;

/// <summary>
/// Internal helper Panel used by <see cref="MirageScrollPanel"/> as the
/// draggable thumb on its custom scrollbar. Exposes the engine's drag
/// lifecycle as plain callbacks the parent can wire up via <c>@ref</c>.
/// </summary>
public class MirageScrollThumb : Panel
{
	public Action OnDragStartCallback { get; set; }
	public Action OnDragEndCallback { get; set; }

	public override bool WantsDrag => true;

	protected override void OnDragStart( DragEvent e )
	{
		base.OnDragStart( e );
		OnDragStartCallback?.Invoke();
	}

	protected override void OnDragEnd( DragEvent e )
	{
		base.OnDragEnd( e );
		OnDragEndCallback?.Invoke();
	}
}
