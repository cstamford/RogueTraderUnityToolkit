namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $LightingSettings (9 fields) (IsEngineType) */
public record class LightingSettings(
    AsciiString m_Name,
    int m_GIWorkflowMode,
    bool m_EnableBakedLightmaps,
    bool m_EnableRealtimeLightmaps,
    bool m_RealtimeEnvironmentLighting,
    float m_BounceScale,
    float m_AlbedoBoost,
    float m_IndirectOutputScale,
    bool m_UsingShadowmask)
{
    public static LightingSettings Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        int m_GIWorkflowMode = reader.ReadS32();
        bool m_EnableBakedLightmaps = reader.ReadBool();
        bool m_EnableRealtimeLightmaps = reader.ReadBool();
        bool m_RealtimeEnvironmentLighting = reader.ReadBool();
        float m_BounceScale = reader.ReadF32();
        float m_AlbedoBoost = reader.ReadF32();
        float m_IndirectOutputScale = reader.ReadF32();
        bool m_UsingShadowmask = reader.ReadBool();
        
        return new(m_Name,
            m_GIWorkflowMode,
            m_EnableBakedLightmaps,
            m_EnableRealtimeLightmaps,
            m_RealtimeEnvironmentLighting,
            m_BounceScale,
            m_AlbedoBoost,
            m_IndirectOutputScale,
            m_UsingShadowmask);
    }
}

