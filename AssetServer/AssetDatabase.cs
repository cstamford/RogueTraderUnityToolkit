using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.UnityGenerated;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;
using System.Collections.Concurrent;
using System.Diagnostics;
using AssetBundleMetadata = RogueTraderUnityToolkit.UnityGenerated.Types.Engine.AssetBundle;

namespace AssetServer;

public sealed class AssetDatabase
{
    public IEnumerable<AsciiString> Scenes => _sceneHashes.Keys;

    public AssetDatabase(List<FileInfo> files)
    {
        AssetDatabaseStorage.Load(files);
        Parallel.ForEach(AssetDatabaseStorage.Assets.Values.OfType<SerializedFile>(), PopulateScenesFromFile);
        LoadShaderNames();
    }

    public AssetDatabaseScene LoadScene(AsciiString sceneName) => AssetDatabaseScene.Read(sceneName, _sceneHashes[sceneName]);

    private readonly ConcurrentDictionary<AsciiString, SerializedFile> _sceneHashes = [];

    private void PopulateScenesFromFile(SerializedFile file)
    {
        foreach (AssetBundleMetadata metadata in file
            .GetObjectPtrs<AssetBundleMetadata>(UnityObjectType.AssetBundle)
            .Select(x => x.Fetch()))
        {
            foreach ((AsciiString name, AsciiString bundleName) in metadata.m_SceneHashes)
            {
                SerializedFile sceneFile = (SerializedFile)AssetDatabaseStorage.Assets[bundleName.ToString()];
                _sceneHashes.TryAdd(name, sceneFile);
            }
        }
    }

    private void LoadShaderNames()
    {
        SerializedFile? gameManagers = AssetDatabaseStorage.Assets["globalgamemanagers"] as SerializedFile;
        Debug.Assert(gameManagers != null);

        ShaderNameRegistry registry = gameManagers.GetObject<ShaderNameRegistry>();
        foreach ((PPtr<Shader> shader, AsciiString name) in registry.m_Shaders.m_ObjectToName)
        {
            AssetDatabaseStorage.AddShader(new(gameManagers, shader), name);
        }
    }
}
