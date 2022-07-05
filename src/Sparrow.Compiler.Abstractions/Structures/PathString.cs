namespace Sparrow.Compiler.Abstractions.Structures
{
    public struct PathString
    {
        public PathString(string path)
        {
            Value = path;
        }

        public string Value { get; }
    }
}
