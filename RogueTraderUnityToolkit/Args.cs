using CommandLine;

namespace RogueTraderUnityToolkit;

public class Args
{
    [Value(0, MetaName = "paths", HelpText = "Input paths to be processed.", Required = true)]
    public IEnumerable<string> ExportPaths { get; set; } = default!;
}
