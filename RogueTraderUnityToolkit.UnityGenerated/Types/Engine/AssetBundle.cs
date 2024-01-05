namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $AssetBundle (11 fields) 465FDA97575AE4884F2DB4C897724942 */
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
    Dictionary<AsciiString, AsciiString> m_SceneHashes) : IUnityEngineStructure
{
    public static Hash128 Hash => new(1180686999, 1465574536, 1328395464, 2540849474);

    public static AssetBundle Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        PPtr<Object>[] _m_PreloadTable = BuiltInArray<PPtr<Object>>.Read(reader);
        reader.AlignTo(4); /* m_PreloadTable */
        Dictionary<AsciiString, AssetInfo> _m_Container = BuiltInMap<AsciiString, AssetInfo>.Read(reader);
        reader.AlignTo(4); /* m_Container */
        AssetInfo _m_MainAsset = AssetInfo.Read(reader);
        uint _m_RuntimeCompatibility = reader.ReadU32();
        AsciiString _m_AssetBundleName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AssetBundleName */
        AsciiString[] _m_Dependencies = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_Dependencies */
        bool _m_IsStreamedSceneAssetBundle = reader.ReadBool();
        reader.AlignTo(4); /* m_IsStreamedSceneAssetBundle */
        int _m_ExplicitDataLayout = reader.ReadS32();
        int _m_PathFlags = reader.ReadS32();
        Dictionary<AsciiString, AsciiString> _m_SceneHashes = BuiltInMap<AsciiString, AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_SceneHashes */
        
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

    public override string ToString() => $"AssetBundle\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PreloadTable: ");
        sb.AppendLine(m_PreloadTable.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Container: ");
        sb.AppendLine(m_Container.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MainAsset: ");
        sb.AppendLine();
        sb.Append(m_MainAsset.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RuntimeCompatibility: ");
        sb.AppendLine(m_RuntimeCompatibility.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AssetBundleName: ");
        sb.AppendLine(m_AssetBundleName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Dependencies: ");
        sb.AppendLine(m_Dependencies.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IsStreamedSceneAssetBundle: ");
        sb.AppendLine(m_IsStreamedSceneAssetBundle.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExplicitDataLayout: ");
        sb.AppendLine(m_ExplicitDataLayout.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PathFlags: ");
        sb.AppendLine(m_PathFlags.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SceneHashes: ");
        sb.AppendLine(m_SceneHashes.ToString());

        return sb.ToString();
    }
}

