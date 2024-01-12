namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $LightmapSettings (6 fields) LightmapSettings 3427516A7A0AFF8613DFF6B947C07B91 */
public record class LightmapSettings (
    EnlightenSceneMapping m_EnlightenSceneMapping,
    PPtr<LightProbes> m_LightProbes,
    LightmapData[] m_Lightmaps,
    int m_LightmapsMode,
    GISettings m_GISettings,
    PPtr<LightingSettings> m_LightingSettings) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.LightmapSettings;
    public static Hash128 Hash => new("3427516A7A0AFF8613DFF6B947C07B91");
    public static LightmapSettings Read(EndianBinaryReader reader)
    {
        EnlightenSceneMapping m_EnlightenSceneMapping_ = EnlightenSceneMapping.Read(reader);
        reader.AlignTo(4); /* m_EnlightenSceneMapping */
        PPtr<LightProbes> m_LightProbes_ = PPtr<LightProbes>.Read(reader);
        LightmapData[] m_Lightmaps_ = BuiltInArray<LightmapData>.Read(reader);
        reader.AlignTo(4); /* m_Lightmaps */
        int m_LightmapsMode_ = reader.ReadS32();
        reader.AlignTo(4); /* m_LightmapsMode */
        GISettings m_GISettings_ = GISettings.Read(reader);
        reader.AlignTo(4); /* m_GISettings */
        PPtr<LightingSettings> m_LightingSettings_ = PPtr<LightingSettings>.Read(reader);
        
        return new(m_EnlightenSceneMapping_,
            m_LightProbes_,
            m_Lightmaps_,
            m_LightmapsMode_,
            m_GISettings_,
            m_LightingSettings_);
    }

    public override string ToString() => $"LightmapSettings\n{ToString(4)}";

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
        sb.Append($"{indent_}m_EnlightenSceneMapping: {{ \n{m_EnlightenSceneMapping.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LightProbes: {m_LightProbes}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Lightmaps[{m_Lightmaps.Length}] = {{");
        if (m_Lightmaps.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (LightmapData _4 in m_Lightmaps)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Lightmaps.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LightmapsMode: {m_LightmapsMode}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_GISettings: {{ \n{m_GISettings.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LightingSettings: {m_LightingSettings}");
    }
}

