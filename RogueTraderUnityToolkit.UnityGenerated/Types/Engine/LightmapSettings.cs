namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $LightmapSettings (6 fields) 3427516A7A0AFF8613DFF6B947C07B91 */
public record class LightmapSettings(
    EnlightenSceneMapping m_EnlightenSceneMapping /* None */,
    PPtr<LightProbes> m_LightProbes /* NeedsAlign */,
    LightmapData[] m_Lightmaps /* None */,
    int m_LightmapsMode /* NeedsAlign */,
    GISettings m_GISettings /* NeedsAlign */,
    PPtr<LightingSettings> m_LightingSettings /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(874991978, 2047541126, 333444793, 1203796881);
    public static LightmapSettings Read(EndianBinaryReader reader)
    {
        EnlightenSceneMapping _m_EnlightenSceneMapping = EnlightenSceneMapping.Read(reader);
        reader.AlignTo(4); /* m_LightProbes */
        PPtr<LightProbes> _m_LightProbes = PPtr<LightProbes>.Read(reader);
        LightmapData[] _m_Lightmaps = BuiltInArray<LightmapData>.Read(reader);
        reader.AlignTo(4); /* m_LightmapsMode */
        int _m_LightmapsMode = reader.ReadS32();
        reader.AlignTo(4); /* m_GISettings */
        GISettings _m_GISettings = GISettings.Read(reader);
        reader.AlignTo(4); /* m_LightingSettings */
        PPtr<LightingSettings> _m_LightingSettings = PPtr<LightingSettings>.Read(reader);
        
        return new(_m_EnlightenSceneMapping,
            _m_LightProbes,
            _m_Lightmaps,
            _m_LightmapsMode,
            _m_GISettings,
            _m_LightingSettings);
    }
}

