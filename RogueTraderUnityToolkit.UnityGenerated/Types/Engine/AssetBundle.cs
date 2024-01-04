namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $AssetBundle (11 fields) 465FDA97575AE4884F2DB4C897724942 */
public record class AssetBundle(
    AsciiString m_Name /* None */,
    PPtr<Object>[] m_PreloadTable /* NeedsAlign */,
    Dictionary<AsciiString, AssetInfo> m_Container /* NeedsAlign */,
    AssetInfo m_MainAsset /* NeedsAlign */,
    uint m_RuntimeCompatibility /* None */,
    AsciiString m_AssetBundleName /* None */,
    AsciiString[] m_Dependencies /* NeedsAlign */,
    bool m_IsStreamedSceneAssetBundle /* NeedsAlign */,
    int m_ExplicitDataLayout /* NeedsAlign */,
    int m_PathFlags /* None */,
    Dictionary<AsciiString, AsciiString> m_SceneHashes /* None */) : IUnityObject
{
    public static Hash128 Hash => new(1180686999, 1465574536, 1328395464, 2540849474);
    public static AssetBundle Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PreloadTable */
        PPtr<Object>[] _m_PreloadTable = BuiltInArray<PPtr<Object>>.Read(reader);
        reader.AlignTo(4); /* m_Container */
        Dictionary<AsciiString, AssetInfo> _m_Container = BuiltInMap<AsciiString, AssetInfo>.Read(reader);
        reader.AlignTo(4); /* m_MainAsset */
        AssetInfo _m_MainAsset = AssetInfo.Read(reader);
        uint _m_RuntimeCompatibility = reader.ReadU32();
        AsciiString _m_AssetBundleName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Dependencies */
        AsciiString[] _m_Dependencies = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_IsStreamedSceneAssetBundle */
        bool _m_IsStreamedSceneAssetBundle = reader.ReadBool();
        reader.AlignTo(4); /* m_ExplicitDataLayout */
        int _m_ExplicitDataLayout = reader.ReadS32();
        int _m_PathFlags = reader.ReadS32();
        Dictionary<AsciiString, AsciiString> _m_SceneHashes = BuiltInMap<AsciiString, AsciiString>.Read(reader);
        
        return new(_m_Name,
            _m_PreloadTable,
            _m_Container,
            _m_MainAsset,
            _m_RuntimeCompatibility,
            _m_AssetBundleName,
            _m_Dependencies,
            _m_IsStreamedSceneAssetBundle,
            _m_ExplicitDataLayout,
            _m_PathFlags,
            _m_SceneHashes);
    }
}

