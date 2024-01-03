using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Codegen;

public readonly record struct TreeReport(
    (TreePath Path, int Refcount)[] AllPaths,
    Dictionary<TreePath, int> AllPathsIds,
    IReadOnlyDictionary<TreePathObject, int> AllPathObjects,
    IReadOnlyDictionary<UnityObjectType, (TreePathObject, int)[]> AllPathObjectsPerUnityType,
    IReadOnlyDictionary<AsciiString, (TreePath, int)[]> AllPathsPerType
);

public static class TreeAnalysis
{
    public static TreeReport CalculateReport(
        IReadOnlyDictionary<TreePathObject, int> treePathObjects)
    {
        (TreePath, int)[] allPaths = treePathObjects
            .SelectMany(x => x.Key.Paths.Select(y => (y, x.Value)))
            .ToArray();

        Dictionary<TreePath, int> allPathsIds = allPaths
            .Select((x, i) => (x.Item1, i))
            .GroupBy(x => x.Item1)
            .Select(g => g.First())
            .ToDictionary();

        Dictionary<UnityObjectType, (TreePathObject, int)[]> allPathObjectsPerUnityType = treePathObjects
            .GroupBy(x => x.Key.Type)
            .ToDictionary(
                x => x.Key,
                x => x.Select(y => (y.Key, y.Value)).ToArray());

        Dictionary<AsciiString, List<(TreePath, int)>> allPathsPerRoot = [];

        foreach ((TreePath path, int refCount) in allPaths)
        {
            for (int i = 0; i < path.Length; i++)
            {
                AsciiString typeName = path[i].TypeName;

                if (!allPathsPerRoot.TryGetValue(typeName, out List<(TreePath, int)>? paths))
                {
                    paths = [];
                    allPathsPerRoot[typeName] = paths;
                }

                paths.Add((path, refCount));
            }
        }

        return new(
            AllPaths: allPaths,
            AllPathsIds: allPathsIds,
            AllPathObjects: treePathObjects,
            AllPathObjectsPerUnityType: allPathObjectsPerUnityType,
            AllPathsPerType: allPathsPerRoot.ToDictionary(
                x => x.Key,
                x => x.Value.ToArray()));
    }

    public static void WriteAllPaths(TextWriter writer, in TreeReport report)
    {
        for (int i = 0; i < report.AllPaths.Length; ++i)
        {
            (TreePath path, int refs) = report.AllPaths[i];
            writer.WriteLine($"${i} {path} {path.GetTypePath()} {refs} refs");
        }
    }

    public static void WriteFieldAccessByUnityType(TextWriter writer, in TreeReport report)
    {
        foreach ((UnityObjectType type, (TreePathObject, int)[] objects)
            in report.AllPathObjectsPerUnityType)
        {
            writer.WriteLine($"**{type}**");

            IOrderedEnumerable<(TreePathObject, int)> groups = objects
                .OrderByDescending(x => x.Item2);

            int numGroups = groups.Count();

            if (numGroups == 0) continue;

            if (numGroups == 1)
            {
                TreePathObject obj = groups.First().Item1;

                foreach (TreePath path in obj.Paths
                    .OrderBy(x => x.ToString())
                    .ThenBy(x => x.GetTypePath()))
                {
                    writer.Write(' '.Repeat(4));
                    path.WritePath(writer);
                    writer.WriteLine();
                }

                writer.WriteLine();

                continue;
            }

            int groupId = 0;

            foreach ((TreePathObject obj, int refs) in groups)
            {
                int thisGroupId = groupId++;

                writer.Write(' '.Repeat(4));
                writer.Write(thisGroupId == 0 ? $"Common" : $"Group {thisGroupId}");
                writer.Write($" ({refs} refs)");
                writer.WriteLine();

                foreach (TreePath path in obj.Paths
                    .OrderBy(x => x.ToString())
                    .ThenBy(x => x.GetTypePath()))
                {
                    writer.Write(' '.Repeat(8));
                    path.WritePath(writer);
                    writer.WriteLine();
                }

                writer.WriteLine();
            }
        }
    }

    public static void WriteFieldAccessByTypeName(TextWriter writer, in TreeReport report)
    {
        foreach ((AsciiString typeName, (TreePath, int)[] refs) in report.AllPathsPerType)
        {
            writer.WriteLine($"**{typeName}**");

            foreach (TreePath path in refs
                .Select(x => x.Item1)
                .OrderBy(x => x.ToString())
                .ThenBy(x => x.GetTypePath()))
            {
                // Find where it intersects.
                int idx = -1;

                for (int i = 0; i < path.Length; i++)
                {
                    if (typeName == path[i].TypeName)
                    {
                        idx = i;
                        break;
                    }
                }

                Debug.Assert(idx != -1);

                if ((idx + 1) != path.Length)
                {
                    writer.Write(' '.Repeat(4));
                    path[(idx+1)..].WritePath(writer);
                    writer.Write($" ${report.AllPathsIds[path]}");
                    writer.WriteLine();
                }
            }

            writer.WriteLine();
        }
    }

    public static void WriteHashAnalysis(TextWriter writer, in TreeReport report)
    {
        writer.WriteLine("**Hash**");
        writer.WriteLine();

        foreach ((Hash128 scriptHash, IEnumerable<TreePathObject> objs) in report.AllPathObjects
            .GroupBy(x => x.Key.ScriptHash)
            .Select(x => (x.Key, x.Select(y => y.Key))))
        {
            writer.WriteLine($"{scriptHash}");

            IEnumerable<(Hash128, IEnumerable<TreePathObject>)> subgroups = objs
                .GroupBy(x => x.Hash)
                .Select(x => (x.Key, x.Select(y => y)));

            IEnumerable<(Hash128, IEnumerable<TreePathObject>)> weirdSubgroups = subgroups
                .Where(x => x.Item2.All(y => y.Type == UnityObjectType.MonoBehaviour));

            if (weirdSubgroups.Count() > 1)
            {
                // I think this is when a MonoBehaviour has default values, we get a version with and without.
                // E.g.:
                //
                //    public bool NeedToRebakeDismemberment;
                //    public float ImpulseMax = 40f;
                //
                // Turns into two:
                //
                //    Base/NeedToRebakeDismemberment
                //    Base/ImpulseMax
                //
                //    Base/NeedToRebakeDismemberment
                //
                foreach ((Hash128 hash, IEnumerable<TreePathObject> subObjs) in weirdSubgroups)
                {
                    writer.WriteLine($"{scriptHash.Uint0} {scriptHash.Uint1} {scriptHash.Uint2} {scriptHash.Uint3}");
                    writer.WriteLine($"    {hash} count: {subObjs.Count()}");
                    writer.WriteLine($"    {hash.Uint0} {hash.Uint1} {hash.Uint2} {hash.Uint3}");

                    TreePathObject subObj = subObjs.First();
                    writer.WriteLine($"        {string.Join("\n        ", subObj.Paths.Select(x => x.ToString()))}");
                }

                bool same = weirdSubgroups
                    .Select(x => x.Item2)
                    .SequenceEqual(weirdSubgroups
                        .Select(x => x.Item2)
                        .DistinctBy(x => x.Select(y => y.Paths)));

                Debug.Assert(!same, "Is this a Unity bug?");
            }
            else
            {
                foreach ((Hash128 hash, IEnumerable<TreePathObject> subObjs) in subgroups)
                {
                    writer.WriteLine($"    {hash}");

                    foreach (TreePathObject subObj in subObjs)
                    {
                        writer.WriteLine($"        {subObj.Type}");
                    }
                }
            }
        }
    }

}

public static class Extensions
{
    public static string GetTypePath(this TreePath path) =>
        string.Join('/', path.Data.ToArray().Select(x => x.TypeName));

    public static void WritePath(this TreePath path, TextWriter writer) =>
        writer.Write($"{path} {path.Last.GetTypeName()}");

    public static string GetTypeName(this TreePathEntry entry) =>
        entry.Type == ObjectParserType.Complex
            ? entry.TypeName.ToString()
            : entry.Type.ToString();

    public static void DumpToLog(this TreePath path)
    {
        Log.Write(path.ToString());
        Log.Write(4, $"Hash: ${path.Hash}");
        Log.Write(4, $"Length: ${path.Length}");

        for (int i = 0; i < path.Length; ++i)
        {
            Log.Write(4, $"[{i}].Name {path[i].Name}");
            Log.Write(4, $"[{i}].TypeName {path[i].TypeName}");
            Log.Write(4, $"[{i}].Type {path[i].Type}");
        }
    }
}
