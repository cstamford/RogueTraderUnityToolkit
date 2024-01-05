using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Diagnostics;

namespace Codegen;

public class Codegen
{
    public Codegen(TreeReport report)
    {
        foreach ((UnityObjectType type, IEnumerable<TreePathObject> objs) in report.AllPathObjects
            .GroupBy(x => x.Item1.Type)
            .Select(x => (x.Key, x.Select(y => y.Item1))))
        {
            bool isGameType = type == UnityObjectType.MonoBehaviour;
            Debug.Assert(isGameType || objs.Count() == 1);

            // Game script types have a bunch of fragments - only process the one with the lowest field count as the base object.
            TreePathObject obj = isGameType ? objs.MinBy(x => x.Paths.Count) : objs.First();
            AsciiString name = AsciiString.From(obj.Type.ToString());

            _typeBuilder.ReadTreeObject(obj, name, x => new CodegenEngineStructureType(name, x, obj.Hash));
        }
    }

    public void ReadGameStructures(
        TreeReport report,
        Dictionary<Hash128, AsciiString> scriptTypeNames)
    {
        foreach ((TreePathObject obj, int _) in report.AllPathObjects
            .Where(x => x.Item1.Type == UnityObjectType.MonoBehaviour))
        {
            if (scriptTypeNames.TryGetValue(obj.Hash, out AsciiString name))
            {
                _typeBuilder.ReadTreeObject(obj, name, x => new CodegenGameStructureType(name, x, obj.Hash, obj.ScriptHash));
                continue;
            }

            Log.Write($"Could not resolve game script type for {obj.Hash}", ConsoleColor.Yellow);
        }
    }

    public void WriteStructures(string path)
    {
        CodegenCSharpWriter writer = new(_typeBuilder.Types, _typeBuilder.TypesIndexLookup);

        List<AsciiString> allMissingTypes = [];
        HashSet<AsciiString> visited = [];

        bool anyGame = false;
        bool anyEngine = false;

        foreach (ICodegenType type in _typeBuilder.Types)
        {
            bool isGame = type is CodegenGameStructureType;
            bool isEngine = type is CodegenEngineStructureType;

            anyGame |= isGame;
            anyEngine |= isEngine;

            if (!isEngine && !isGame) continue;

            string category = isGame ? "Game" : "Engine";

            string typeDir = Path.Combine(path, category);
            Directory.CreateDirectory(typeDir);

            string typeFile = Path.Combine(typeDir, $"{type.Name}.cs");
            using StreamWriter typeWriter = File.CreateText(typeFile);

            writer.WriteHeader(typeWriter, category, [isGame ? "Engine" : string.Empty]);
            writer.WriteType(typeWriter, type, out AsciiString[] missingTypes);

            allMissingTypes.AddRange(missingTypes);
            visited.Add(type.Name);
        }

        string referencedTypesFile = Path.Combine(path, $"ReferencedTypes.cs");
        using StreamWriter referencedTypesWriter = File.CreateText(referencedTypesFile);
        writer.WriteHeader(referencedTypesWriter, string.Empty,
            [ anyEngine ? "Engine" : string.Empty, anyGame ? "Game" : string.Empty ]);

        foreach (ICodegenType otherType in _typeBuilder.Types.Where(x => !visited.Contains(x.Name)))
        {
            writer.WriteType(referencedTypesWriter, otherType, out AsciiString[] missingTypes);
            allMissingTypes.AddRange(missingTypes);
            visited.Add(otherType.Name);
        }

        allMissingTypes = [..allMissingTypes.Distinct().Where(x => !visited.Contains(x))];

        if (allMissingTypes.Count > 0)
        {
            Log.WriteSingle($"Writing missing types: ", ConsoleColor.Yellow);
            Log.WriteSingle(string.Join(", ", allMissingTypes.Take(3).Select(x => x.ToString())), ConsoleColor.Yellow);
            Log.Write(allMissingTypes.Count > 3 ? $", {allMissingTypes.Count - 3} more..." : "", ConsoleColor.Yellow);

            foreach (AsciiString typeName in allMissingTypes)
            {
                writer.WriteType(referencedTypesWriter, new CodegenForwardDeclType(typeName), out _);
            }
        }

        Debug.Assert(visited.Count == _typeBuilder.Types.Count);
    }

    private readonly CodegenTypeBuilder _typeBuilder = new();
}
