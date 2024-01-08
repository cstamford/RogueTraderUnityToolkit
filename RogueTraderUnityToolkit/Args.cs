using CommandLine;

namespace RogueTraderUnityToolkit;

public enum ProcessMode
{
    Codegen,
    UnityProjectExport
}

public class Args
{
    [Option("cores", Default = 0, HelpText = "How many CPU cores to use. Set to 0 for all of them.")]
    public int ThreadCount { get; set; }

    [Option("debug", Default = false, HelpText = "Includes additional debug information. (warning: verbose!)")]
    public bool Debug { get; set; }

    [Option("dir", Default = null, HelpText = "If set, exports to this directory.")]
    public string? ExportPath { get; set; }

    [Option("mode", Required = true, HelpText = "The processing mode to use.")]
    public ProcessMode Mode { get; set; }

    [Value(0, MetaName = "paths", HelpText = "Input paths to be processed.", Required = true)]
    public IEnumerable<string> ImportPaths { get; set; } = default!;
}
