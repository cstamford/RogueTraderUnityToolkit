using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Text.Json;

namespace Codegen;

public static class AnalyseTreesReport
{
    public static ComplexTypeReport CalculateComplexTypes(
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

    public static void WriteUnityTypeBreakdown(
        TextWriter writer,
        IReadOnlyDictionary<UnityObjectType, PerTypeTreeData> data)
    {
        int totalObjects = data.Sum(x => x.Value.ObjectCount);
        
        foreach ((UnityObjectType type, int count) in data
            .OrderByDescending(x => x.Value.ObjectCount)
            .Select(x => (x.Key, x.Value.ObjectCount)))
        {
            writer.WriteLine($"{type} {Percent(count, totalObjects):F1}% ({count})");
        }
    }

    public static void WriteUnityTypeFieldAccesses(
        TextWriter writer,
        IReadOnlyDictionary<UnityObjectType, PerTypeTreeData> data)
    {
        foreach ((UnityObjectType type, PerTypeTreeData typeData) in data
            .OrderByDescending(x => x.Value.ObjectCount))
        {
            writer.WriteLine($"**{type}**");

            IOrderedEnumerable<IGrouping<float, (AnalyseTreesNodePath Key, float)>> groups = typeData.PathRefs
                .Select(x => (x.Key, Percent(x.Value, typeData.ObjectCount)))
                .GroupBy(x => x.Item2)
                .OrderByDescending(x => x.Key);

            int numGroups = groups.Count();

            if (numGroups == 0) continue;
            
            if (numGroups == 1)
            {
                foreach (AnalyseTreesNodePath path in groups
                    .First()
                    .Select(x => x.Key)
                    .Order())
                {
                    writer.Write(' '.Repeat(4));
                    WritePath(path);
                }
                
                writer.WriteLine();

                continue;
            }

            int groupId = 0;
            
            foreach (IGrouping<float, (AnalyseTreesNodePath Key, float)> group in groups)
            {
                int thisGroupId = groupId++;

                writer.Write(' '.Repeat(4));
                writer.Write(thisGroupId == 0 ? $"Common" : $"Group {thisGroupId}");
                writer.Write($" ({group.Key:F1}%)");
                writer.WriteLine();

                foreach (AnalyseTreesNodePath path in group
                    .Select(x => x.Key)
                    .Order())
                {
                    if (thisGroupId != 0 && path.Self.Name == "Base")
                    {
                        int a = 5;
                    }
                    writer.Write(' '.Repeat(8));
                    WritePath(path);
                }

                writer.WriteLine();
            }
            
            continue;

            void WritePath(AnalyseTreesNodePath path)
            {
                writer.Write($"{path} {path.Self.TypeName}");

                if (path.Self.Type != ObjectParserType.Complex)
                {
                    writer.Write($" ({path.Self.Type})");
                }

                writer.WriteLine();
            }
        }
    }
    
    public static void WriteComplexTypesFieldAccesses(
        TextWriter writer,
        ComplexTypeReport report)
    {
        foreach ((string type, IEnumerable<(string, string)> references) in report.TypesMap
            .Select(x => (
                x.Key.ToString(), 
                x.Value.Select(y => (y.ToString(), TypeName(y.Self))).OrderBy(y => y.Item1)))
            .OrderByDescending(x => x.Item2.Count()))
        {
            writer.WriteLine($"**{type}**");

            foreach ((string refPath, string refType) in references)
            {
                writer.Write(' '.Repeat(4));
                writer.WriteLine($"{refPath} {refType}");
            }

            writer.WriteLine();
        }
    }
    
    public static void WriteComplexTypesJson(
        TextWriter writer,
        ComplexTypeReport report)
    {
        string json = JsonSerializer.Serialize(report.TypesMap.Select(x => new
        {
            TypeName = x.Key.ToString(),
            References = x.Value
                .Where(y => y.Parents.IsEmpty) // first level paths only
                .Select(y => new { Name = y.ToString(), Type = TypeName(y.Self) })
                .OrderBy(y => y.Name)
                .ToArray()
        }).OrderByDescending(x => x.References.Length), _opts);
        
        writer.Write(json);
    }

    public static void WriteComplexTypesRefcounts(
        TextWriter writer,
        ComplexTypeReport report)
    {
        foreach ((AsciiString typeName, int refCount) in report
            .TypeReferenceCount
            .OrderByDescending(x => x.Value))
        {
            writer.WriteLine($"{typeName} {refCount}");
        }
    }
    
    private static float Percent(int num, int max) => num / (float)max * 100;
    
    private static string TypeName(AnalyseTreesNodePathEntry entry) => 
        entry.Type == ObjectParserType.Complex
            ? entry.TypeName.ToString()
            : entry.Type.ToString();
    
    private static readonly JsonSerializerOptions _opts = new JsonSerializerOptions { WriteIndented = true };
}

public readonly record struct ComplexTypeReport(
    Dictionary<AsciiString, HashSet<AnalyseTreesNodePath>> TypesMap,
    Dictionary<AsciiString, int> TypeReferenceCount
);
