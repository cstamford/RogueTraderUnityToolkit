using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Tree;
using RogueTraderUnityToolkit.Unity;
using System.Diagnostics;

namespace RogueTraderUnityToolkit.Codegen;

public class Codegen
{
    public Codegen(TreeReport report)
    {
        foreach ((UnityObjectType type, IEnumerable<TreePathObject> objs) in report.AllPathObjects
            .GroupBy(x => x.Item1.Type)
            .Select(x => (x.Key, x.Select(y => y.Item1))))
        {
            TreePathObject obj = objs.Where(x => x.Hash != default).OrderBy(x => x.Paths.Count).FirstOrDefault(objs.First());
            AsciiString name = AsciiString.From(obj.Type.ToString());
            Log.Write($"Creating {type} from {name}");
            _types.Add(CodegenTypeBuilder.ReadTreeObject(obj, name, x => new CodegenRootType(name, x, type, obj.Hash, true)));
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
                Log.Write($"Creating game type {name}");
                _types.Add(CodegenTypeBuilder.ReadTreeObject(obj, name, x => new CodegenRootType(name, x, obj.Type, obj.Hash, false)));
                continue;
            }

            Log.Write($"Could not resolve game script type for {obj.Hash}", ConsoleColor.Yellow);
        }
    }

    public void WriteStructures(string path)
    {
        IReadOnlyList<CodegenType> types = CalculateExportableTypes();

        CodegenCSharpWriter writer = new();

        bool anyGame = false;
        bool anyEngine = false;

        foreach (CodegenRootType root in types.OfType<CodegenRootType>())
        {
            anyGame |= !root.IsEngineType;
            anyEngine |= root.IsEngineType;

            string category = root.IsEngineType ? "Engine" : "Game";

            string typeDir = Path.Combine(path, category);
            Directory.CreateDirectory(typeDir);

            string typeFile = Path.Combine(typeDir, $"{root.Name}.cs");
            using StreamWriter typeWriter = File.CreateText(typeFile);

            writer.WriteHeader(typeWriter, category, [root.IsEngineType ? string.Empty : "Engine"]);
            writer.WriteType(typeWriter, root);
        }

        string referencedTypesFile = Path.Combine(path, $"ReferencedTypes.cs");
        using StreamWriter referencedTypesWriter = File.CreateText(referencedTypesFile);
        writer.WriteHeader(referencedTypesWriter, string.Empty,
            [ anyEngine ? "Engine" : string.Empty, anyGame ? "Game" : string.Empty ]);

        foreach (CodegenStructureType otherType in types
            .OfType<CodegenStructureType>()
            .Where(x => x is not CodegenRootType))
        {
            writer.WriteType(referencedTypesWriter, otherType);
        }

        List<CodegenForwardDeclType> allMissingTypes = [..types.OfType<CodegenForwardDeclType>()];
        if (allMissingTypes.Count > 0)
        {
            Log.WriteSingle($"Writing missing types: ", ConsoleColor.Yellow);
            Log.WriteSingle(string.Join(", ", allMissingTypes.Take(3).Select(x => x.ToString())), ConsoleColor.Yellow);
            Log.Write(allMissingTypes.Count > 3 ? $", {allMissingTypes.Count - 3} more..." : "", ConsoleColor.Yellow);

            foreach (CodegenForwardDeclType forwardDecl in allMissingTypes)
            {
                writer.WriteType(referencedTypesWriter, forwardDecl);
            }
        }
    }

    private IReadOnlyList<CodegenType> CalculateExportableTypes()
    {
        // Collect a big, flattened array of every type.
        List<CodegenType> fullTypeList = [];
        foreach (CodegenRootType type in _types)
        {
            GatherAllReferencedTypes(type, fullTypeList);
        }

        // We've got a whole bunch of types, now select only types that are actually unique types.
        List<CodegenType> fullTypeListUnique = [..fullTypeList.Distinct()];

        // Strip any forward declarations where we have the full implementation already.
        foreach (CodegenForwardDeclType decl in fullTypeListUnique.OfType<CodegenForwardDeclType>().ToArray())
        {
            if (fullTypeListUnique.Any(x => x.Name == decl.Name && x is not CodegenForwardDeclType))
            {
                fullTypeListUnique.Remove(decl);
            }
        }

        // Construct a list of types that have the same name but different layouts.
        Dictionary<AsciiString, CodegenType[]> aliases = fullTypeListUnique
            .GroupBy(x => x.Name)
            .Where(x => x.Count() > 1)
            .Select(x => (x.Key, x.Select(y => y).ToArray()))
            .ToDictionary(x => x.Key, x => x.Item2);

        // Update each type to point their references to the correct one.
        return fullTypeListUnique.Select(x => UpdateAllAliasTypeReferences(x, aliases)).ToList();
    }

    private static void GatherAllReferencedTypes(CodegenType type, ICollection<CodegenType> allTypes)
    {
        allTypes.Add(type);

        switch (type)
        {
            case CodegenStructureType codegenStructureType:
                foreach (CodegenStructureField field in codegenStructureType.Fields)
                    GatherAllReferencedTypes(field.Type, allTypes);
                break;

            case CodegenArrayType codegenArrayType:
                GatherAllReferencedTypes(codegenArrayType.DataType, allTypes);
                break;

            case CodegenMapType codegenMapType:
                GatherAllReferencedTypes(codegenMapType.KeyType, allTypes);
                GatherAllReferencedTypes(codegenMapType.ValueType, allTypes);
                break;

            case CodegenPPtrType codegenPPtrType:
                GatherAllReferencedTypes(new CodegenForwardDeclType(codegenPPtrType.NameT), allTypes);
                break;
        }
    }

    private static CodegenType UpdateAllAliasTypeReferences(
        CodegenType typeToUpdate,
        IReadOnlyDictionary<AsciiString, CodegenType[]> aliases)
    {
        if (aliases.TryGetValue(typeToUpdate.Name, out CodegenType[]? types))
        {
            int oldIdx = Array.IndexOf(types, typeToUpdate);
            Debug.Assert(oldIdx != -1);
            typeToUpdate = typeToUpdate with { Name = AsciiString.From($"{typeToUpdate.Name}_{oldIdx}") };
        }

        return typeToUpdate switch
        {
            CodegenArrayType arr => arr with {
                DataType = UpdateAllAliasTypeReferences(arr.DataType, aliases)
            },
            CodegenMapType map => map with {
                KeyType = UpdateAllAliasTypeReferences(map.KeyType, aliases),
                ValueType = UpdateAllAliasTypeReferences(map.ValueType, aliases)
            },
            CodegenStructureType struc => struc with { Fields = struc.Fields
                .Select(x => x with { Type = UpdateAllAliasTypeReferences(x.Type, aliases) })
                .ToList() },
            _ => typeToUpdate
        };
    }

    private readonly List<CodegenRootType> _types = [];
}
