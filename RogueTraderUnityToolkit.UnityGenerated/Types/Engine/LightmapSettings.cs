namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $LightmapSettings (6 fields) 3427516A7A0AFF8613DFF6B947C07B91 */
public record class LightmapSettings(
    EnlightenSceneMapping m_EnlightenSceneMapping,
    PPtr<LightProbes> m_LightProbes,
    LightmapData[] m_Lightmaps,
    int m_LightmapsMode,
    GISettings m_GISettings,
    PPtr<LightingSettings> m_LightingSettings) : IUnityEngineStructure
{
    public static Hash128 Hash => new(874991978, 2047541126, 333444793, 1203796881);

    public static LightmapSettings Read(EndianBinaryReader reader)
    {
        EnlightenSceneMapping _m_EnlightenSceneMapping = EnlightenSceneMapping.Read(reader);
        reader.AlignTo(4); /* m_EnlightenSceneMapping */
        PPtr<LightProbes> _m_LightProbes = PPtr<LightProbes>.Read(reader);
        LightmapData[] _m_Lightmaps = BuiltInArray<LightmapData>.Read(reader);
        reader.AlignTo(4); /* m_Lightmaps */
        int _m_LightmapsMode = reader.ReadS32();
        reader.AlignTo(4); /* m_LightmapsMode */
        GISettings _m_GISettings = GISettings.Read(reader);
        reader.AlignTo(4); /* m_GISettings */
        PPtr<LightingSettings> _m_LightingSettings = PPtr<LightingSettings>.Read(reader);
        
        return new(_m_EnlightenSceneMapping,
            _m_LightProbes,
            _m_Lightmaps,
            _m_LightmapsMode,
            _m_GISettings,
            _m_LightingSettings);
    }

    public override string ToString() => $"LightmapSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnlightenSceneMapping: ");
        sb.AppendLine();
        sb.Append(m_EnlightenSceneMapping.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LightProbes: ");
        sb.AppendLine(m_LightProbes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Lightmaps: ");
        sb.AppendLine(m_Lightmaps.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LightmapsMode: ");
        sb.AppendLine(m_LightmapsMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GISettings: ");
        sb.AppendLine();
        sb.Append(m_GISettings.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LightingSettings: ");
        sb.AppendLine(m_LightingSettings.ToString());

        return sb.ToString();
    }
}

