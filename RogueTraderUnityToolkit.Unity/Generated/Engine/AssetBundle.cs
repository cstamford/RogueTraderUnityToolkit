namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $AssetBundle (11 fields) (IsEngineType) */
public record class AssetBundle(
    AsciiString m_Name,
    PPtr<Object>[] m_PreloadTable,
    Dictionary<AsciiString, AssetInfo> m_Container,
    AssetInfo m_MainAsset,
    uint m_RuntimeCompatibility,
    AsciiString m_AssetBundleName,
    AsciiString[] m_Dependencies,
    bool m_IsStreamedSceneAssetBundle,
    int m_ExplicitDataLayout,
    int m_PathFlags,
    Dictionary<AsciiString, AsciiString> m_SceneHashes)
{
    public static AssetBundle Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        PPtr<Object>[] m_PreloadTable = Array<PPtr<Object>>.Read(reader);
        Dictionary<AsciiString, AssetInfo> m_Container = Map<AsciiString, AssetInfo>.Read(reader);
        AssetInfo m_MainAsset = AssetInfo.Read(reader);
        uint m_RuntimeCompatibility = reader.ReadU32();
        AsciiString m_AssetBundleName = String.Read(reader);
        AsciiString[] m_Dependencies = Array<AsciiString>.Read(reader);
        bool m_IsStreamedSceneAssetBundle = reader.ReadBool();
        int m_ExplicitDataLayout = reader.ReadS32();
        int m_PathFlags = reader.ReadS32();
        Dictionary<AsciiString, AsciiString> m_SceneHashes = Map<AsciiString, AsciiString>.Read(reader);
        
        return new(m_Name,
            m_PreloadTable,
            m_Container,
            m_MainAsset,
            m_RuntimeCompatibility,
            m_AssetBundleName,
            m_Dependencies,
            m_IsStreamedSceneAssetBundle,
            m_ExplicitDataLayout,
            m_PathFlags,
            m_SceneHashes);
    }
}

