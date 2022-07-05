using Sparrow.Compiler.Abstractions.Commands.Options;

namespace Sparrow.Compiler.Abstractions.Commands;

public abstract class CommandBase
{
    public ICommandOptions Options { get; protected set; } = null!;
    public abstract void Execute();
}
