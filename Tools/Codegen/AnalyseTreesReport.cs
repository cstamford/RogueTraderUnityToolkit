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
    }

    public static void DumpComplexTypesJson(
        IReadOnlyDictionary<UnityObjectType, PerTypeTreeData> data)
    {
        ComplexTypeReport complexTypes = CalculateComplexTypes(data);
        DumpComplexTypesJson(@"D:\RogueTraderModding\complexTypes.json", complexTypes);
        DumpComplexTypesRefcounts(@"D:\RogueTraderModding\complexTypesRefcounts.txt", complexTypes);
    }

    private readonly record struct ComplexTypeReport(
        Dictionary<AsciiString, HashSet<AnalyseTreesNodePath>> TypesMap,
        Dictionary<AsciiString, int> TypeReferenceCount
    );

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

    private static ComplexTypeReport CalculateComplexTypes(
        IReadOnlyDictionary<UnityObjectType, PerTypeTreeData> data)
    {
        List<AnalyseTreesNodePath> allPaths = data
            .SelectMany(x => x.Value.PathRefs.Select(y => y.Key))
            .ToList();
        
        Dictionary<AsciiString, HashSet<AnalyseTreesNodePath>> complexTypes = [];
        Dictionary<AsciiString, int> complexTypeReferences = [];

        foreach (AnalyseTreesNodePath path in allPaths.Where(x => 
            x.Self.Type == ObjectParserType.Complex ||
            (x.Self.Flags & ObjectParserNodeFlags.IsBuiltin) != 0))
        {
            AsciiString typeName = path.Self.TypeName;
            complexTypes.TryAdd(typeName, []);
            if (!complexTypeReferences.TryAdd(typeName, 1)) ++complexTypeReferences[typeName];
        }

        foreach ((AsciiString targetTypeName, HashSet<AnalyseTreesNodePath> refs) in complexTypes)
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

        return new(complexTypes, complexTypeReferences);
    }

    private static void DumpComplexTypesJson(string path, ComplexTypeReport report)
    {
        File.WriteAllText(path,
            JsonSerializer.Serialize(report.TypesMap.Select(x => new
            {
                TypeName = x.Key.ToString(),
                References = x.Value
                    .Where(y => y.Parents.IsEmpty) // first level only
                    .Select(y => new
                    {
                        Name = y.ToString(),
                        Type = y.Self.Type == ObjectParserType.Complex ? y.Self.TypeName.ToString() : y.Self.Type.ToString()
                    })
                    .OrderBy(y => y.Name)
                    .ToArray()
            }).OrderByDescending(x => x.References.Length), _opts));
        
        Log.Write($"Exported complex type report to {path}", ConsoleColor.Cyan);
    }

    private static void DumpComplexTypesRefcounts(string path, ComplexTypeReport report)
    {
        File.WriteAllLines(path, report.TypeReferenceCount
            .OrderByDescending(x => x.Value)
            .Select(x => $"{x.Key} {x.Value}"));
        
        Log.Write($"Exported complex type refcounts to {path}", ConsoleColor.Cyan);
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
    
    private static readonly JsonSerializerOptions _opts = new JsonSerializerOptions { WriteIndented = true };
}
