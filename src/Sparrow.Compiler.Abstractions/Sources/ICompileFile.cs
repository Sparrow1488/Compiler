using Sparrow.Compiler.Abstractions.Commands;
using Sparrow.Compiler.Abstractions.Structures;

namespace Sparrow.Compiler.Abstractions.Sources;

public interface ICompileFile
{
    string Text { get; }
    PathString Path { get; }
    IEnumerable<CommandBase> Commands { get; }
}
