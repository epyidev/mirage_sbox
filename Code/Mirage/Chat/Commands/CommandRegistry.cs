/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// In-memory catalogue of every chat command. Identical state lives on host
/// and clients: handlers are invoked only on the host, but clients walk the
/// same tree to render suggestions.
///
/// Bootstraps lazily on first call. <see cref="MirageCommands.Register"/> is
/// the canonical place to declare gameplay commands.
/// </summary>
public static class CommandRegistry
{
	private static readonly Dictionary<string, CommandSpec> _root = new( StringComparer.OrdinalIgnoreCase );
	private static bool _initialized;

	public static void Register( CommandSpec spec )
	{
		if ( spec is null || string.IsNullOrEmpty( spec.Name ) ) return;
		_root[spec.Name] = spec;
	}

	public static IEnumerable<CommandSpec> RootCommands
	{
		get
		{
			EnsureInitialized();
			return _root.Values;
		}
	}

	public static void EnsureInitialized()
	{
		if ( _initialized ) return;
		_initialized = true;
		MirageCommands.Register();
	}

	/// <summary>
	/// Host-side. Parse <paramref name="input"/>, find the deepest matching
	/// (sub)command, gate on <see cref="CommandSpec.Permission"/>, and invoke
	/// the handler. Replies (success or failure) go back to the caller through
	/// <see cref="MirageChatBus"/>.
	/// </summary>
	public static void Execute( Connection caller, string input )
	{
		EnsureInitialized();
		if ( caller is null ) return;

		var clean = (input ?? "").TrimStart();
		if ( clean.StartsWith( "/" ) ) clean = clean.Substring( 1 );

		var tokens = Tokenize( clean );
		if ( tokens.Count == 0 ) return;

		if ( !_root.TryGetValue( tokens[0], out var spec ) )
		{
			MirageChatBus.SendErrorTo( caller, $"Commande inconnue : /{tokens[0]}." );
			return;
		}

		int consumed = 1;
		while ( consumed < tokens.Count )
		{
			var subName = tokens[consumed];
			CommandSpec sub = null;
			foreach ( var s in spec.Subcommands )
			{
				if ( string.Equals( s.Name, subName, StringComparison.OrdinalIgnoreCase ) )
				{
					sub = s;
					break;
				}
			}
			if ( sub is null ) break;
			spec = sub;
			consumed++;
		}

		if ( !string.IsNullOrEmpty( spec.Permission ) )
		{
			if ( !PermissionsSystem.Current.Has( caller, spec.Permission ) )
			{
				MirageChatBus.SendErrorTo( caller, "Vous n'avez pas la permission de faire cela." );
				return;
			}
		}

		if ( spec.Handler is null )
		{
			var hint = string.IsNullOrEmpty( spec.UsageHint )
				? $"Sous-commandes disponibles : {string.Join( ", ", spec.Subcommands.Select( s => s.Name ) )}."
				: spec.UsageHint;
			MirageChatBus.SendSystemTo( caller, hint );
			return;
		}

		var args = consumed < tokens.Count ? tokens.GetRange( consumed, tokens.Count - consumed ).ToArray() : Array.Empty<string>();
		var ctx = new CommandContext { Caller = caller, RawInput = input, Args = args };

		try
		{
			spec.Handler( ctx );
		}
		catch ( Exception ex )
		{
			Log.Warning( $"[Mirage] Command /{spec.Name} threw: {ex}" );
			MirageChatBus.SendErrorTo( caller, "Erreur interne lors de l'exécution de la commande." );
		}
	}

	/// <summary>
	/// Client-side. Build the suggestion list for the current chat input.
	/// <paramref name="hasPermission"/> is consulted against
	/// <see cref="CommandSpec.Permission"/> to filter what the local player
	/// can see; pass a constant <c>true</c> on the host preview path.
	/// </summary>
	public static List<CommandSuggestion> Suggest( string input, Func<string, bool> hasPermission )
	{
		EnsureInitialized();

		var raw = input ?? "";
		var clean = raw.TrimStart();
		if ( clean.StartsWith( "/" ) ) clean = clean.Substring( 1 );

		var endsOnSpace = raw.Length > 0 && char.IsWhiteSpace( raw[raw.Length - 1] );
		var tokens = Tokenize( clean );

		List<string> completed;
		string partial;
		if ( endsOnSpace )
		{
			completed = tokens;
			partial = "";
		}
		else if ( tokens.Count == 0 )
		{
			completed = new List<string>();
			partial = "";
		}
		else
		{
			completed = tokens.GetRange( 0, tokens.Count - 1 );
			partial = tokens[tokens.Count - 1];
		}

		IEnumerable<CommandSpec> scope = _root.Values;
		foreach ( var t in completed )
		{
			CommandSpec match = null;
			foreach ( var s in scope )
			{
				if ( string.Equals( s.Name, t, StringComparison.OrdinalIgnoreCase ) )
				{
					match = s;
					break;
				}
			}
			if ( match is null )
			{
				return new List<CommandSuggestion>();
			}
			scope = match.Subcommands;
		}

		var list = new List<CommandSuggestion>();
		foreach ( var spec in scope )
		{
			if ( !spec.Name.StartsWith( partial, StringComparison.OrdinalIgnoreCase ) ) continue;
			if ( !string.IsNullOrEmpty( spec.Permission ) && hasPermission != null && !hasPermission( spec.Permission ) ) continue;

			list.Add( new CommandSuggestion
			{
				Token = spec.Name,
				DisplayName = spec.Name,
				Description = spec.Description ?? "",
				HasMore = spec.Subcommands.Count > 0
			} );
		}

		list.Sort( ( a, b ) => string.Compare( a.Token, b.Token, StringComparison.OrdinalIgnoreCase ) );
		return list;
	}

	/// <summary>
	/// Splits on whitespace, with double-quoted spans treated as one token so
	/// arguments containing spaces can be passed (<c>say "hello world"</c>).
	/// </summary>
	private static List<string> Tokenize( string input )
	{
		var tokens = new List<string>();
		if ( string.IsNullOrEmpty( input ) ) return tokens;

		int i = 0;
		while ( i < input.Length )
		{
			while ( i < input.Length && char.IsWhiteSpace( input[i] ) ) i++;
			if ( i >= input.Length ) break;

			if ( input[i] == '"' )
			{
				i++;
				int start = i;
				while ( i < input.Length && input[i] != '"' ) i++;
				tokens.Add( input.Substring( start, i - start ) );
				if ( i < input.Length ) i++;
			}
			else
			{
				int start = i;
				while ( i < input.Length && !char.IsWhiteSpace( input[i] ) ) i++;
				tokens.Add( input.Substring( start, i - start ) );
			}
		}

		return tokens;
	}
}
