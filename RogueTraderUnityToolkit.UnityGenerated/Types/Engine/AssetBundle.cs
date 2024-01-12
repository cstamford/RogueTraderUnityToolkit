namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $AssetBundle (11 fields) AssetBundle 465FDA97575AE4884F2DB4C897724942 */
public record class AssetBundle (
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
    public static UnityObjectType ObjectType => UnityObjectType.AssetBundle;
    public static Hash128 Hash => new("465FDA97575AE4884F2DB4C897724942");
    public static AssetBundle Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        PPtr<Object>[] m_PreloadTable_ = BuiltInArray<PPtr<Object>>.Read(reader);
        reader.AlignTo(4); /* m_PreloadTable */
        Dictionary<AsciiString, AssetInfo> m_Container_ = BuiltInMap<AsciiString, AssetInfo>.Read(reader);
        reader.AlignTo(4); /* m_Container */
        AssetInfo m_MainAsset_ = AssetInfo.Read(reader);
        uint m_RuntimeCompatibility_ = reader.ReadU32();
        AsciiString m_AssetBundleName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AssetBundleName */
        AsciiString[] m_Dependencies_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_Dependencies */
        bool m_IsStreamedSceneAssetBundle_ = reader.ReadBool();
        reader.AlignTo(4); /* m_IsStreamedSceneAssetBundle */
        int m_ExplicitDataLayout_ = reader.ReadS32();
        int m_PathFlags_ = reader.ReadS32();
        Dictionary<AsciiString, AsciiString> m_SceneHashes_ = BuiltInMap<AsciiString, AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_SceneHashes */
        
        return new(m_Name_,
            m_PreloadTable_,
            m_Container_,
            m_MainAsset_,
            m_RuntimeCompatibility_,
            m_AssetBundleName_,
            m_Dependencies_,
            m_IsStreamedSceneAssetBundle_,
            m_ExplicitDataLayout_,
            m_PathFlags_,
            m_SceneHashes_);
    }

    public override string ToString() => $"AssetBundle\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PreloadTable[{m_PreloadTable.Length}] = {{");
        if (m_PreloadTable.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Object> _4 in m_PreloadTable)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_PreloadTable.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Container[{m_Container.Count}] = {{");
        if (m_Container.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<AsciiString, AssetInfo> _4 in m_Container)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[\"{_4.Key}\"] = {{ \n{_4.Value.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Container.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_MainAsset: {{ \n{m_MainAsset.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RuntimeCompatibility: {m_RuntimeCompatibility}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AssetBundleName: \"{m_AssetBundleName}\"");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Dependencies[{m_Dependencies.Length}] = {{");
        if (m_Dependencies.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in m_Dependencies)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (m_Dependencies.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IsStreamedSceneAssetBundle: {m_IsStreamedSceneAssetBundle}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExplicitDataLayout: {m_ExplicitDataLayout}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PathFlags: {m_PathFlags}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SceneHashes[{m_SceneHashes.Count}] = {{");
        if (m_SceneHashes.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<AsciiString, AsciiString> _4 in m_SceneHashes)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[\"{_4.Key}\"] = \"{_4.Value}\"");
            ++_4i;
        }
        if (m_SceneHashes.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

