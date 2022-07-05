using Sparrow.Compiler.Abstractions.Commands.Parameters;

namespace Sparrow.Compiler.Abstractions.Commands;

public abstract class SingleCommandBase : CommandBase
{
    public ISingleParameter SingleParameter { get; set; }
}
