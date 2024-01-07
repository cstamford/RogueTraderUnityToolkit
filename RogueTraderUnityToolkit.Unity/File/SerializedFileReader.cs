﻿using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Buffers;

namespace RogueTraderUnityToolkit.Unity.File;

public readonly struct SerializedFileReader(SerializedFile file)
{
    public void ReadObjectRange(
        IObjectTypeTreeReader treeReader,
        bool withDebugReader,
        int startIdx,
        int endIdx,
        Action<int> fnStartedOne,
        Action<int> fnFinishedOne,
        Func<SerializedFileObjectInfo, ObjectTypeTree?> fnGetObjectTypeTree)
    {
        using SuperluminalPerf.EventMarker _ = Util.PerfScope("ReadObjectRange", new (0, 255, 0));

        long offsetStart = file.Info.Size;
        long offsetEnd = 0;

        for (int i = startIdx; i < endIdx; ++i)
        {
            ref SerializedFileObjectInstance instance = ref file.ObjectInstances[i];
            offsetStart = Math.Min(offsetStart, instance.Offset);
            offsetEnd = Math.Max(offsetEnd, instance.Offset + instance.Size);
        }

        // Construct an ordered subset. We want to read in this specific order:
        // 1. All types first, then MonoBehaviour last, because its type tends to be less predictable.
        //    Leaving them for last allows the readers to cache more efficiently.
        // 2. Ordered by offset, ascending, to make it less likely that the memory chunk has been evicted.
        // This optimization is particularly effective for big files that may have lots of seeks.

        int entriesToProcess = endIdx - startIdx;
        int[] rentedIndices = ArrayPool<int>.Shared.Rent(entriesToProcess);
        Span<int> indices = rentedIndices.AsSpan()[..entriesToProcess];
        for (int i = 0; i < indices.Length; ++i) indices[i] = i + startIdx;

        SerializedFile fileCapture = file;
        indices.Sort(Comparer<int>.Create(IndicesSorter));

        using Stream stream = file.Info.Open(file.Header.DataOffset + offsetStart, offsetEnd - offsetStart);
        EndianBinaryReader reader = new(stream, file.Header.IsBigEndian);
        ObjectParser parser = new();

        foreach (int i in indices)
        {
            // This allows us to toggle withDebugReader on via debugger. Just set withDebugReader.
            IObjectTypeTreeReader treeReaderWithDebug = withDebugReader
                ? treeReader.WithDebugReader(() => parser.Offset)
                : treeReader;

            ref SerializedFileObjectInstance instance = ref file.ObjectInstances[i];
            int objectBase = (int)(instance.Offset - offsetStart);

            ref SerializedFileObject obj = ref file.Objects[instance.TypeIdx];
            ObjectTypeTree? tree = file.Target.WithTypeTree ? obj.Tree : fnGetObjectTypeTree(obj.Info);
            if (tree == null) continue;

            fnStartedOne(i);

            try
            {
                reader.Position = objectBase;
                parser.Read(tree, file.TypeReferences, reader, treeReaderWithDebug, instance.Size);
                if (parser.Offset != instance.Size)
                {
                    throw new($"Expected {instance.Size} bytes but read {parser.Offset}.");
                }
            }
            catch (Exception e)
            {
                throw new($"Reading {obj.Info.Type} {obj.Info.Hash} {obj.Info.ScriptHash} instance {i}: {e}");
            }

            fnFinishedOne(i);
        }

        ArrayPool<int>.Shared.Return(rentedIndices);

        return;

        int IndicesSorter(int lhs, int rhs)
        {
            ref SerializedFileObjectInstance lhsInstance = ref fileCapture.ObjectInstances[lhs];
            ref SerializedFileObjectInstance rhsInstance = ref fileCapture.ObjectInstances[rhs];

            UnityObjectType lhsType = fileCapture.Objects[lhsInstance.TypeIdx].Info.Type;
            UnityObjectType rhsType = fileCapture.Objects[rhsInstance.TypeIdx].Info.Type;

            int typeComparison =
                (lhsType == UnityObjectType.MonoBehaviour ? 1 : 0)
                .CompareTo(rhsType == UnityObjectType.MonoBehaviour ? 1 : 0);

            if (typeComparison != 0)
            {
                return typeComparison;
            }

            return lhsInstance.Offset.CompareTo(rhsInstance.Offset);
        }
    }
}
