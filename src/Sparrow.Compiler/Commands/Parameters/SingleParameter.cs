using Sparrow.Compiler.Abstractions.Commands.Parameters;

namespace Sparrow.Compiler.Commands.Parameters;

public class SingleParameter : ISingleParameter
{
    public string ParameterText { get; set; } = string.Empty;
}
