using RogueTraderUnityToolkit.Core;

namespace RogueTraderUnityToolkit.Unity;

public readonly struct SerializedFileReader(SerializedFile file)
{
    public void ReadObjectRange(
        IObjectTypeTreeReader treeReader,
        bool withDebugReader,
        int startIdx,
        int endIdx,
        Action<int, int> fnStartedOne,
        Action<int, int> fnFinishedOne)
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

        using Stream stream = file.Info.Open(file.Header.DataOffset + offsetStart, offsetEnd - offsetStart);
        EndianBinaryReader reader = new(stream, file.Header.IsBigEndian);

        ObjectParser parser = new();

        if (withDebugReader)
        {
            ObjectParserDebug debug = new(() => parser.Offset);
            treeReader = new ObjectTypeTreeMultiReader(debug, treeReader);
        }

        for (int i = startIdx; i < endIdx; ++i)
        {
            ref SerializedFileObjectInstance instance = ref file.ObjectInstances[i];
            int objectBase = (int)(instance.Offset - offsetStart);

            fnStartedOne(i, endIdx);
            reader.Position = objectBase;
            parser.Read(file.Objects[instance.TypeIdx], instance, file.TypeReferences, reader, treeReader);
            fnFinishedOne(i, endIdx);

            if (parser.Offset != instance.Size)
            {
                throw new($"Expected {instance.Size} bytes but read {parser.Offset}.");
            }
        }
    }
}
