using CommandLine;

namespace RogueTraderUnityToolkit;

public class Args
{
    [Option("cores", Default = 0, HelpText = "How many CPU cores to use. Set to 0 for all of them.")]
    public int ThreadCount { get; set; }
    
    [Option("debug", Default = false, HelpText = "Includes additional debug information. (warning: verbose!)")]
    public bool Debug { get; set; }
    
    [Option("dir", Default = null, HelpText = "If set, exports to this directory.")]
    public string? ExportPath { get; set; }

    [Value(0, MetaName = "paths", HelpText = "Input paths to be processed.", Required = true)]
    public IEnumerable<string> ImportPaths { get; set; } = default!;
    
    [Option("stdout", Default = false, HelpText = "If set, and outDir is unset, exports to stdout.")]
    public bool ExportStdOut { get; set; }
}
