/** @author Epyi */

namespace Sandbox.Mirage;

/// <summary>
/// Declarative description of one chat command. Composes recursively through
/// <see cref="Subcommands"/>: the parser walks the tree token by token and
/// invokes the deepest matching <see cref="Handler"/> with the remaining
/// tokens as arguments.
///
/// <see cref="Permission"/> is checked against the caller's effective set
/// before the handler runs; null means no permission required.
/// </summary>
public sealed class CommandSpec
{
	public string Name { get; init; }
	public string Description { get; init; }
	public string UsageHint { get; init; }
	public string Permission { get; init; }
	public Action<CommandContext> Handler { get; init; }
	public List<CommandSpec> Subcommands { get; init; } = new();
}

/// <summary>
/// One suggestion entry returned by <see cref="CommandRegistry.Suggest"/> and
/// rendered in the chat input dropdown.
/// </summary>
public sealed class CommandSuggestion
{
	/// <summary>The token (subcommand name) to insert in place of the partial.</summary>
	public string Token { get; init; }

	/// <summary>What to show in the dropdown list. Currently same as <see cref="Token"/>.</summary>
	public string DisplayName { get; init; }

	/// <summary>Short hint text shown next to the token.</summary>
	public string Description { get; init; }

	/// <summary>True if this token has further subcommands to expand into.</summary>
	public bool HasMore { get; init; }
}
