using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.UnityGenerated;
using System.Diagnostics;

namespace RogueTraderUnityToolkit.Processors;

public class UnityProjectExporter : IAssetProcessor
{
    public void Begin(
        Args args,
        IReadOnlyList<FileInfo> files)
    {

    }

    public void Process(
        Args args,
        ISerializedAsset asset,
        out int assetCountProcessed,
        out int assetCountSkipped,
        out int assetCountFailed)
    {
        assetCountProcessed = 0;
        assetCountSkipped = 0;
        assetCountFailed = 0;

        if (asset is SerializedFile file)
        {
            using Stream stream = file.Info.Open(file.Header.DataOffset);
            EndianBinaryReader reader = new(stream, file.Header.IsBigEndian);

            List<IUnityObject> objects = [];

            for (int i = 0; i < file.ObjectInstances.Length; ++i)
            {
                ref SerializedFileObjectInstance instance = ref file.ObjectInstances[i];
                ref SerializedFileObject obj = ref file.Objects[instance.TypeIdx];
                reader.Position = (int)instance.Offset;

                if (GeneratedTypes.TryCreateType(obj.Info.Hash, obj.Info.Type, reader, out IUnityObject createdObj))
                {
                    long remaining = (instance.Offset + instance.Size) - reader.Position;
                    Debug.Assert(remaining == 0);
                    objects.Add(createdObj);
                }
            }

            File.WriteAllText(
                Path.Combine(args.ExportPath, $"{asset.Info.Identifier}.txt"),
                string.Join("\n", objects.Select(x => x.ToString())));
        }

    }

    public void End(
        Args args,
        IReadOnlyList<FileInfo> files,
        ISerializedAsset[] assets)
    {

    }
}
