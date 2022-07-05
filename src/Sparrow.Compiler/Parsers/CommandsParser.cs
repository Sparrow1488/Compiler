using Sparrow.Compiler.Abstractions.Commands;
using Sparrow.Compiler.Abstractions.Parsers;
using Sparrow.Compiler.Abstractions.Sources;
using Sparrow.Compiler.Abstractions.Structures;
using Sparrow.Compiler.Commands.Parameters;
using Sparrow.Compiler.Commands.Single;
using Sparrow.Compiler.Sources;

namespace Sparrow.Compiler.Parsers;

public class CommandsParser : ICommandsParser
{
    private static readonly List<CommandBase> _commandsList = new()
    {
        new PrintSingleCommand()
    };

    public static ICompileFile ParseFile(string path)
    {
        // read file
        var fileLines = File.ReadLines(path);

        // prepare classes
        var compileCommands = new List<CommandBase>();
        var compileFile = new CompileFile(new PathString(path))
        {
            Text = string.Join("\n", fileLines),
            Commands = compileCommands
        };

        // parse file
        foreach (var fileLine in fileLines)
        {
            // parse command
            var commandName = GetContainsCommand(fileLine);
            var executeCommand = _commandsList.First(x => x.Options.NormalizedName == commandName);

            // build commanad
            if (executeCommand is SingleCommandBase singleCommand)
            {
                singleCommand.SingleParameter = new SingleParameter() {
                    ParameterText = fileLine.Replace(commandName, "").Trim()
                };
            }
            compileCommands.Add(executeCommand);
        }
        return compileFile;
    }

    private static string GetContainsCommand(string fileLine)
    {
        var testCommands = _commandsList.Select(x => x.Options.NormalizedName);
        foreach (var command in testCommands)
            if (fileLine.Contains(command))
                return command;
        return "DEFAULT";
    }
}
