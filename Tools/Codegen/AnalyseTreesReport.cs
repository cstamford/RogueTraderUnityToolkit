using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Text.Json;

namespace Codegen;

public static class AnalyseTreesReport
{
    public static void OutputReportToLog(
        IReadOnlyDictionary<UnityObjectType, PerTypeTreeData> data)
    {
        WriteUnityTypeBreakdown(data);
        WriteUnityTypeFieldAccesses(data);
        WriteComplexTypeLayouts(data);
    }

    private static void WriteUnityTypeBreakdown(
        IReadOnlyDictionary<UnityObjectType, PerTypeTreeData> data)
    {
        int totalObjects = data.Sum(x => x.Value.ObjectCount);
        
        Log.Write();
        Log.Write("**Object types**");
        Log.Write();
        
        foreach ((UnityObjectType type, int count) in data
            .Where(x => x.Value.ObjectCount > 0)
            .OrderByDescending(x => x.Value.ObjectCount)
            .Select(x => (x.Key, x.Value.ObjectCount)))
        {
            Log.Write($"{type} {Percent(count, totalObjects):F1}% ({count})");
        }
    }

    private static void WriteUnityTypeFieldAccesses(
        IReadOnlyDictionary<UnityObjectType, PerTypeTreeData> data)
    {
        Log.Write();

        foreach ((UnityObjectType type, PerTypeTreeData typeData) in data
            .Where(x => x.Value.ObjectCount > 0)
            .OrderByDescending(x => x.Value.ObjectCount)
            .Take(10))
        {
            Log.WriteSingle($"** {type} **");
            Log.Write();

            foreach ((AnalyseTreesNodePath path, int accessCount) in typeData.PathRefs
                .OrderBy(x => x.Key))
            {
                Log.WriteSingle($"{path} ");

                AnalyseTreesNodePathEntry leaf = path.Self;
                Log.WriteSingle($"{leaf.TypeName}", GetParserTypeColour(leaf.Type));

                float percent = Percent(accessCount, typeData.ObjectCount);
                Log.Write(percent < 100 ? $" {percent:F1}%" : string.Empty);
            }

            Log.Write();
        }
    }

    private static void WriteComplexTypeLayouts(
        IReadOnlyDictionary<UnityObjectType, PerTypeTreeData> data)
    {
        List<AnalyseTreesNodePath> allPaths = data
            .SelectMany(x => x.Value.PathRefs.Select(y => y.Key))
            .ToList();
        
        Dictionary<AsciiString, HashSet<AnalyseTreesNodePath>> complexTypePathOverlaps = [];

        foreach (AnalyseTreesNodePath path in allPaths
            .Where(x => x.Self.Type == ObjectParserType.Complex))
        {
            complexTypePathOverlaps.TryAdd(path.Self.TypeName, []);
        }

        foreach ((AsciiString targetTypeName, HashSet<AnalyseTreesNodePath> refs) in complexTypePathOverlaps)
        {
            foreach (AnalyseTreesNodePath path in allPaths)
            {
                int idx;

                AnalyseTreesAllocation pathMem = path.Allocation;
                
                for (idx = pathMem.Length - 1; idx >= 0; --idx)
                {
                    if (pathMem[idx].TypeName == targetTypeName) break;
                }

                if (idx != -1)
                {
                    // Make a new path, from where we overlapped as far as possible.
                    refs.Add(new(path.Allocation[(idx + 1)..], path.Self));
                }
            }
        }
        
        File.WriteAllText("D:\\RogueTraderModding\\complexTypePathOverlaps.json",
            JsonSerializer.Serialize(complexTypePathOverlaps.Select(x => new
        {
            TypeName = x.Key.ToString(),
            References = x.Value
                .Where(y => y.Parents.IsEmpty) // first level only
                .Select(y => new
                { 
                    Name = y.ToString(),
                    Type = y.Self.Type == ObjectParserType.Complex
                        ? y.Self.TypeName.ToString()
                        : y.Self.Type.ToString()
                })
                .OrderBy(y => y.Name)
                .ToArray()
        }), new JsonSerializerOptions { WriteIndented = true }));
    }
    
    private static ConsoleColor GetParserTypeColour(ObjectParserType type) => type switch
    {
        ObjectParserType.U64 => ConsoleColor.Blue,
        ObjectParserType.U32 => ConsoleColor.Blue,
        ObjectParserType.U16 => ConsoleColor.Blue,
        ObjectParserType.U8 => ConsoleColor.Blue,
        ObjectParserType.S64 => ConsoleColor.Blue,
        ObjectParserType.S32 => ConsoleColor.Blue,
        ObjectParserType.S16 => ConsoleColor.Blue,
        ObjectParserType.S8 => ConsoleColor.Blue,
        ObjectParserType.F64 => ConsoleColor.Yellow,
        ObjectParserType.F32 => ConsoleColor.Yellow,
        ObjectParserType.Bool => ConsoleColor.Green,
        ObjectParserType.Char => ConsoleColor.DarkCyan,
        ObjectParserType.Complex => ConsoleColor.Magenta,
        ObjectParserType.String => ConsoleColor.Cyan,
        ObjectParserType.RefObjectTree => ConsoleColor.DarkRed,
        _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
    };

    private static float Percent(int num, int max) => num / (float)max * 100;
}
