/** @author Epyi */

namespace Sandbox.Mirage.UI;

/// <summary>
/// Modal popup queue. Static entry points spawn confirmation, alert and
/// custom popups; <c>MiragePopupHost</c> picks the most recent spec, renders
/// it, and dismisses on user action. One popup is shown at a time, the rest
/// queue up.
///
/// Typical use:
/// <code>
/// MiragePopup.Confirm( "Supprimer ?", "Cette action est irréversible.",
///     onConfirm: () => DoIt(),
///     variant: MiragePopup.PopupVariant.Danger );
/// </code>
/// </summary>
public static class MiragePopup
{
	public enum PopupVariant { Default, Danger }

	public sealed class Spec
	{
		public string Title { get; init; }
		public string Message { get; init; }
		public string ConfirmText { get; init; } = "OK";
		public string CancelText { get; init; }
		public PopupVariant Variant { get; init; } = PopupVariant.Default;
		public Action OnConfirm { get; init; }
		public Action OnCancel { get; init; }
	}

	private static readonly Queue<Spec> _queue = new();

	/// <summary>Currently visible spec, or null if no popup is open.</summary>
	public static Spec Current { get; private set; }

	/// <summary>Increments on every queue change so the host can re-render.</summary>
	public static int Version { get; private set; }

	/// <summary>Confirmation dialog with confirm + cancel buttons.</summary>
	public static void Confirm( string title, string message, Action onConfirm, Action onCancel = null,
		string confirmText = "Confirmer", string cancelText = "Annuler",
		PopupVariant variant = PopupVariant.Default )
	{
		Show( new Spec
		{
			Title = title,
			Message = message,
			ConfirmText = confirmText,
			CancelText = cancelText,
			Variant = variant,
			OnConfirm = onConfirm,
			OnCancel = onCancel
		} );
	}

	/// <summary>Single-button alert.</summary>
	public static void Alert( string title, string message, Action onAcknowledge = null, string buttonText = "OK" )
	{
		Show( new Spec
		{
			Title = title,
			Message = message,
			ConfirmText = buttonText,
			CancelText = null,
			OnConfirm = onAcknowledge
		} );
	}

	/// <summary>Enqueue a custom spec. Shown immediately if no popup is open.</summary>
	public static void Show( Spec spec )
	{
		if ( spec is null ) return;

		if ( Current is null )
		{
			Current = spec;
		}
		else
		{
			_queue.Enqueue( spec );
		}
		Version++;
	}

	/// <summary>Internal: invoked by the host when the user clicks confirm.</summary>
	internal static void HandleConfirm()
	{
		var current = Current;
		Advance();
		current?.OnConfirm?.Invoke();
	}

	/// <summary>Internal: invoked by the host when the user clicks cancel or escape.</summary>
	internal static void HandleCancel()
	{
		var current = Current;
		Advance();
		current?.OnCancel?.Invoke();
	}

	private static void Advance()
	{
		Current = _queue.Count > 0 ? _queue.Dequeue() : null;
		Version++;
	}

	/// <summary>Drop everything pending. Useful at scene transitions.</summary>
	public static void Clear()
	{
		_queue.Clear();
		Current = null;
		Version++;
	}
}
