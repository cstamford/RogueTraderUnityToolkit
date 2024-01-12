namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $SpriteAtlas (6 fields) SpriteAtlas 579CE7CAA3B38BC5A7A3C131EFCFF98F */
public record class SpriteAtlas (
    AsciiString m_Name,
    PPtr<Sprite>[] m_PackedSprites,
    AsciiString[] m_PackedSpriteNamesToIndex,
    Dictionary<pair_1, SpriteAtlasData> m_RenderDataMap,
    AsciiString m_Tag,
    bool m_IsVariant) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.SpriteAtlas;
    public static Hash128 Hash => new("579CE7CAA3B38BC5A7A3C131EFCFF98F");
    public static SpriteAtlas Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        PPtr<Sprite>[] m_PackedSprites_ = BuiltInArray<PPtr<Sprite>>.Read(reader);
        reader.AlignTo(4); /* m_PackedSprites */
        AsciiString[] m_PackedSpriteNamesToIndex_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_PackedSpriteNamesToIndex */
        Dictionary<pair_1, SpriteAtlasData> m_RenderDataMap_ = BuiltInMap<pair_1, SpriteAtlasData>.Read(reader);
        reader.AlignTo(4); /* m_RenderDataMap */
        AsciiString m_Tag_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Tag */
        bool m_IsVariant_ = reader.ReadBool();
        reader.AlignTo(4); /* m_IsVariant */
        
        return new(m_Name_,
            m_PackedSprites_,
            m_PackedSpriteNamesToIndex_,
            m_RenderDataMap_,
            m_Tag_,
            m_IsVariant_);
    }

    public override string ToString() => $"SpriteAtlas\n{ToString(4)}";

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

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PackedSprites[{m_PackedSprites.Length}] = {{");
        if (m_PackedSprites.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Sprite> _4 in m_PackedSprites)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_PackedSprites.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PackedSpriteNamesToIndex[{m_PackedSpriteNamesToIndex.Length}] = {{");
        if (m_PackedSpriteNamesToIndex.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in m_PackedSpriteNamesToIndex)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (m_PackedSpriteNamesToIndex.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RenderDataMap[{m_RenderDataMap.Count}] = {{");
        if (m_RenderDataMap.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<pair_1, SpriteAtlasData> _4 in m_RenderDataMap)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4.Key}] = {{ \n{_4.Value.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_RenderDataMap.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Tag: \"{m_Tag}\"");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IsVariant: {m_IsVariant}");
    }
}

