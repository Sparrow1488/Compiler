using Sparrow.Compiler.Abstractions.Commands;
using Sparrow.Compiler.Commands.Options;

namespace Sparrow.Compiler.Commands.Single;

public class PrintSingleCommand : SingleCommandBase
{
    public PrintSingleCommand()
    {
        Options = new CommandOptions() {
            Name = "Print"
        };
    }

    private const string FIRST_PRINT_MESSAGE = "print: ";

    public override void Execute()
    {
        Console.WriteLine(FIRST_PRINT_MESSAGE + SingleParameter.ParameterText);
    }
}
