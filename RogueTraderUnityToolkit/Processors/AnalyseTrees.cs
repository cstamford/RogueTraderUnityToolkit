using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Collections;
using System.Collections.Concurrent;

namespace RogueTraderUnityToolkit.Processors;

public sealed class AnalyseTrees : IAssetProcessor
{
    public AnalyseTrees()
    {
        foreach (UnityObjectType type in Enum.GetValues<UnityObjectType>())
        {
            _fields[type] = [];
        }
    }
    
    public void Process(
        Args args,
        AssetBundle bundle,
        ISerializedAsset asset,
        out int assetCountProcessed,
        out int assetCountSkipped,
        out int assetCountFailed)
    {
        assetCountProcessed = 0;
        assetCountSkipped = 0;
        assetCountFailed = 0;
        
        if (asset is not SerializedFile file)
        {
            assetCountSkipped = 1;
            return;
        }

        SerializedFileReader fileReader = new(file);
        AnalyseTreesReader treeReader = new();
        
        fileReader.ReadObjectRange(
            treeReader: treeReader,
            withDebugReader: args.Debug,
            startIdx: 0,
            endIdx: file.ObjectInstances.Length,
            fnStartedOne: (_, _) => { },
            fnFinishedOne: (i, _) =>
            {
                UnityObjectType type = file.Objects[file.ObjectInstances[i].TypeIdx].Info.Type;
                _fields[type].UpdateFrom(treeReader);

            });
        
        assetCountProcessed = file.ObjectInstances.Length;
    }

    public void End(Args args, ISerializedAsset[] assets)
    {
        int totalObjects = _fields.Sum(x => x.Value.ObjectCount);
        
        Log.Write();
        Log.Write("**Object types**");
        Log.Write();

        foreach ((UnityObjectType type, int count) in _fields
            .Where(x => x.Value.ObjectCount > 0)
            .OrderByDescending(x => x.Value.ObjectCount)
            .Select(x => (x.Key, x.Value.ObjectCount)))
        {
            Log.WriteSingle(type.ToString(), GetTypeNameColor(type));
            Log.Write($" {Percent(count, totalObjects):F1}% ({count})");
        }
        
        Log.Write();

        Dictionary<AsciiString, List<AnalyseTreesFieldPath>> complexTypes = [];

        foreach ((UnityObjectType type, AnalyseTreesTypeData data) in _fields
            .Where(x => x.Value.ObjectCount > 0)
            .OrderByDescending(x => x.Value.ObjectCount))
        {
            Log.WriteSingle("**");
            Log.WriteSingle(type.ToString(), GetTypeNameColor(type));
            Log.Write("**");
            Log.Write();
            
            foreach ((AnalyseTreesFieldPath path, int accessCount) in data
                .OrderBy(x => x.Key))
            {
                Log.WriteSingle($"{path} ");

                AnalyseTreesFieldEntry leaf = path.Path.Last(); 
                Log.WriteSingle($"{leaf.TypeName}", GetTypeNameColor(leaf.Type));
                
                float percent = Percent(accessCount, data.ObjectCount);
                Log.Write(percent < 100 ? $" {percent:F1}%" : string.Empty);
                
                for (int i = 0; i < path.Length; ++i)
                {
                    AnalyseTreesFieldEntry entry = path[i];
                    if (entry.Type != ObjectParserType.Complex) continue;
                    
                    if (complexTypes.TryGetValue(entry.TypeName, out List<AnalyseTreesFieldPath>? references))
                    {
                        references.Add(new(path.Path[i..]));
                    }
                    else
                    {
                        complexTypes.Add(entry.TypeName, [new(path.Path[i..])]);
                    }
                }
            }
            
            Log.Write();
        }
        
        // TODO From complexTypes:
        // TODO * Compute a list of structures
        // TODO * Codegen structures 
        // TODO * Extend Unity project so we can support these as builtins

        Console.ReadLine();
        return;

        static float Percent(int num, int max) => num / (float)max * 100;
    }

    private ConsoleColor GetTypeNameColor(UnityObjectType type)
    {
        if (!_colors.TryGetValue(type, out ConsoleColor col))
        {
            col = _colors.Count switch
            {
                0 => ConsoleColor.Cyan,
                1 => ConsoleColor.Magenta,
                2 => ConsoleColor.Blue,
                3 => ConsoleColor.Green,
                4 => ConsoleColor.Red,
                5 => ConsoleColor.Yellow,
                6 => ConsoleColor.DarkCyan,
                7 => ConsoleColor.DarkMagenta,
                8 => ConsoleColor.DarkBlue,
                9 => ConsoleColor.DarkGreen,
                10 => ConsoleColor.DarkRed,
                11 => ConsoleColor.DarkYellow,
                _ => ConsoleColor.Gray
            };
            _colors.Add(type, col);
        }

        return col;
    }

    private ConsoleColor GetTypeNameColor(ObjectParserType type) => type switch
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

    private readonly ConcurrentDictionary<UnityObjectType, AnalyseTreesTypeData> _fields = [];
    private readonly Dictionary<UnityObjectType, ConsoleColor> _colors = [];
}

public sealed class AnalyseTreesReader
    : AssetProcessorTypeTreeReader<AnalyseTreesFieldPath>
{
    public Dictionary<AnalyseTreesFieldPath, int> Fields => _fields;
    
    public override void BeginTree(in ObjectTypeTree tree)
    {
        base.BeginTree(in tree);
        ++_treeDepth;
    }
    
    public override void EndTree(in ObjectTypeTree tree)
    {
        base.BeginTree(in tree);
        --_treeDepth;
    }
    
    public override void Visit(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        base.Visit(node, tree);
        
        if (_treeDepth != 1) return;
        if (TreeArrayStack.TryPeek(out ArrayFrame arr) && GetIndex(arr) != 0) return;

        AnalyseTreesFieldEntry us = new(node.Name, node.TypeName, node.Level, node.Type);
        AnalyseTreesFieldPath path;
        
        if (TryPopNodeFrames(node.Level, out AnalyseTreesFieldPath parentPath))
        {
            path = new([.. parentPath.Path, us]); // this is horrifically suboptimal
            if (!_fields.TryAdd(path, 1)) ++_fields[path];
        }
        else
        {
            path = new([us]);
        }

        TreeNodeStack.Push(path);
    }

    private readonly Dictionary<AnalyseTreesFieldPath, int> _fields = [];
    private int _treeDepth;
}

public readonly record struct AnalyseTreesFieldPath(
    AnalyseTreesFieldEntry[] Path)
    : IComparable<AnalyseTreesFieldPath>
{
    public int Length => Path.Length;
    public ref AnalyseTreesFieldEntry this[int i] => ref Path[i];
        
    public bool Equals(AnalyseTreesFieldPath other)
    {
        if (Path.Length != other.Path.Length)
        {
            return false;
        }
        
        for (int i = 0; i < Path.Length; i++)
        {
            if (!EqualityComparer<AnalyseTreesFieldEntry>.Default.Equals(Path[i], other.Path[i]))
            {
                return false;
            }
        }

        return true;
    }
    
    public int CompareTo(AnalyseTreesFieldPath rhs)
    {
        for (int i = 0; i < Math.Min(Path.Length, rhs.Path.Length); ++i)
        {
            ReadOnlyMemory<byte> lhsBytes = Path[i].Name.Bytes;
            ReadOnlyMemory<byte> rhsBytes = rhs.Path[i].Name.Bytes;
            int comparison = lhsBytes.Span.SequenceCompareTo(rhsBytes.Span);
            if (comparison != 0) return comparison;
        }
        return Path.Length.CompareTo(rhs.Path.Length);
    }

    public override int GetHashCode()
    {
        HashCode hash = new();
        foreach (AnalyseTreesFieldEntry entry in Path)
        {
            hash.Add(entry);
        }
        return hash.ToHashCode();
    }
    
    public override string ToString() => $"{string.Join('/', Path)}";
}

public readonly record struct AnalyseTreesFieldEntry(
    AsciiString Name,
    AsciiString TypeName,
    int Level,
    ObjectParserType Type)
{
    public override string ToString() => Name.ToString();
}

public sealed class AnalyseTreesTypeData : IEnumerable<KeyValuePair<AnalyseTreesFieldPath, int>>
{
    public int ObjectCount => _objCount;

    public void UpdateFrom(AnalyseTreesReader reader)
    {
        Interlocked.Increment(ref _objCount);

        foreach ((AnalyseTreesFieldPath field, int count) in reader.Fields)
        {
            _fields.AddOrUpdate(field, count, (_, oldCount) => oldCount + count);
        }
        
        reader.Fields.Clear();
    }

    public IEnumerator<KeyValuePair<AnalyseTreesFieldPath, int>> GetEnumerator() => _fields.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private int _objCount;
    private readonly ConcurrentDictionary<AnalyseTreesFieldPath, int> _fields = new();
}
