using Sparrow.Compiler.Parsers;

var compileFile = CommandsParser.ParseFile("./sources/example-1.sp88");
compileFile.Commands.First().Execute();
