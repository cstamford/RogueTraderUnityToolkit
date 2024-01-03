namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $LightmapSettings (6 fields) (IsEngineType) */
public record class LightmapSettings(
    EnlightenSceneMapping m_EnlightenSceneMapping,
    PPtr<LightProbes> m_LightProbes,
    LightmapData[] m_Lightmaps,
    int m_LightmapsMode,
    GISettings m_GISettings,
    PPtr<LightingSettings> m_LightingSettings)
{
    public static LightmapSettings Read(EndianBinaryReader reader)
    {
        EnlightenSceneMapping m_EnlightenSceneMapping = EnlightenSceneMapping.Read(reader);
        PPtr<LightProbes> m_LightProbes = PPtr<LightProbes>.Read(reader);
        LightmapData[] m_Lightmaps = Array<LightmapData>.Read(reader);
        int m_LightmapsMode = reader.ReadS32();
        GISettings m_GISettings = GISettings.Read(reader);
        PPtr<LightingSettings> m_LightingSettings = PPtr<LightingSettings>.Read(reader);
        
        return new(m_EnlightenSceneMapping,
            m_LightProbes,
            m_Lightmaps,
            m_LightmapsMode,
            m_GISettings,
            m_LightingSettings);
    }
}

