using Sparrow.Compiler.Abstractions.Commands.Options;

namespace Sparrow.Compiler.Commands.Options;

public class CommandOptions : ICommandOptions
{
    public string Name { get; set; } = string.Empty;
    public string NormalizedName => Name.ToUpper();
}
