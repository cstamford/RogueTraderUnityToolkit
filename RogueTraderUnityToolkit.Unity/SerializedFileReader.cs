﻿using RogueTraderUnityToolkit.Core;

namespace RogueTraderUnityToolkit.Unity;

public readonly struct SerializedFileReader(SerializedFile file)
{
    public void ReadObjectRange(
        int startIdx,
        int endIdx,
        IObjectTypeTreeReader treeReader,
        bool withDebugReader)
    {
        using var _ = Util.PerfScope("ReadObjectRange", new (0, 255, 0));

        long offsetStart = file.Info.Size;
        long offsetEnd = 0;

        for (int i = startIdx; i < endIdx; ++i)
        {
            ref SerializedFileObjectInstance instance = ref file.ObjectInstances[i];
            offsetStart = Math.Min(offsetStart, instance.Offset);
            offsetEnd = Math.Max(offsetEnd, instance.Offset + instance.Size);
        }

        using Stream stream = file.Info.Open(file.Header.DataOffset + offsetStart, offsetEnd - offsetStart);
        EndianBinaryReader reader = new(stream, file.Header.IsBigEndian);

        ObjectParser parser = new();

        if (withDebugReader)
        {
            ObjectParserDebugWrapper debug = new(() => parser.Offset);
            treeReader = new ObjectTypeTreeMultiReader(debug, treeReader);
        }
        
        for (int i = startIdx; i < endIdx; ++i)
        {
            ref SerializedFileObjectInstance instance = ref file.ObjectInstances[i];
            int objectBase = (int)(instance.Offset - offsetStart);

            reader.Position = objectBase;
            parser.Read(file.Objects[instance.TypeIdx], instance, file.TypeReferences, reader, treeReader);
 
            if (parser.Offset != instance.Size)
            {
                throw new($"Expected {instance.Size} bytes but read {parser.Offset}.");
            }
        }
    }
}
