using Sparrow.Compiler.Abstractions.Commands;
using Sparrow.Compiler.Abstractions.Sources;
using Sparrow.Compiler.Abstractions.Structures;

namespace Sparrow.Compiler.Sources;

public class CompileFile : ICompileFile
{
    public CompileFile(PathString path)
    {
        Path = path;
    }

    public string Text { get; set; } = string.Empty;
    public PathString Path { get; set; }
    public IEnumerable<CommandBase> Commands { get; set; } = new List<CommandBase>();
}
