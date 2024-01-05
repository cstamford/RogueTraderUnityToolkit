namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $LightingSettings (9 fields) 7C075EB768E56392C216AAFEF21A9FC1 */
public record class LightingSettings(
    AsciiString m_Name,
    int m_GIWorkflowMode,
    bool m_EnableBakedLightmaps,
    bool m_EnableRealtimeLightmaps,
    bool m_RealtimeEnvironmentLighting,
    float m_BounceScale,
    float m_AlbedoBoost,
    float m_IndirectOutputScale,
    bool m_UsingShadowmask) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2080857783, 1759863698, 3256265470, 4061831105);

    public static LightingSettings Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        int _m_GIWorkflowMode = reader.ReadS32();
        bool _m_EnableBakedLightmaps = reader.ReadBool();
        bool _m_EnableRealtimeLightmaps = reader.ReadBool();
        bool _m_RealtimeEnvironmentLighting = reader.ReadBool();
        reader.AlignTo(4); /* m_RealtimeEnvironmentLighting */
        float _m_BounceScale = reader.ReadF32();
        float _m_AlbedoBoost = reader.ReadF32();
        float _m_IndirectOutputScale = reader.ReadF32();
        bool _m_UsingShadowmask = reader.ReadBool();
        reader.AlignTo(4); /* m_UsingShadowmask */
        
        return new(_m_Name,
            _m_GIWorkflowMode,
            _m_EnableBakedLightmaps,
            _m_EnableRealtimeLightmaps,
            _m_RealtimeEnvironmentLighting,
            _m_BounceScale,
            _m_AlbedoBoost,
            _m_IndirectOutputScale,
            _m_UsingShadowmask);
    }

    public override string ToString() => $"LightingSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GIWorkflowMode: ");
        sb.AppendLine(m_GIWorkflowMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnableBakedLightmaps: ");
        sb.AppendLine(m_EnableBakedLightmaps.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnableRealtimeLightmaps: ");
        sb.AppendLine(m_EnableRealtimeLightmaps.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RealtimeEnvironmentLighting: ");
        sb.AppendLine(m_RealtimeEnvironmentLighting.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BounceScale: ");
        sb.AppendLine(m_BounceScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AlbedoBoost: ");
        sb.AppendLine(m_AlbedoBoost.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IndirectOutputScale: ");
        sb.AppendLine(m_IndirectOutputScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UsingShadowmask: ");
        sb.AppendLine(m_UsingShadowmask.ToString());

        return sb.ToString();
    }
}

