namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LightController (25 fields) FD20ECD49CC3C61DB694B158EAED6EBA/C19A7D330892F56DF7865618595CB48C */
public record class LightController(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int EditorTimeOfDay /* NeedsAlign */,
    PPtr<Light>[] LightsForEdit /* None */,
    PPtr<ShadowProxyCombinerBox>[] ShadowProxyBoxes /* None */,
    int CameraLight /* None */,
    int CameraClearFlag /* None */,
    byte CameraContourLightEnabled /* None */,
    CameraContourLightSettings ContourLightSettings /* NeedsAlign */,
    PPtr<Light> MainLight /* None */,
    PPtr<SceneLightConfig> m_SoloConfig /* None */,
    PPtr<SceneLightConfig> m_MorningConfig /* None */,
    PPtr<SceneLightConfig> m_DayConfig /* None */,
    PPtr<SceneLightConfig> m_EveningConfig /* None */,
    PPtr<SceneLightConfig> m_NightConfig /* None */,
    PPtr<ReflectionProbe>[] m_ReflectionProbes /* None */,
    PPtr<Volume>[] m_SoloPostProcessingVolumes /* None */,
    PPtr<Volume>[] m_MorningPostProcessingVolumes /* None */,
    PPtr<Volume>[] m_DayPostProcessingVolumes /* None */,
    PPtr<Volume>[] m_EveningPostProcessingVolumes /* None */,
    PPtr<Volume>[] m_NightPostProcessingVolumes /* None */,
    LocalLightSettings[] m_LocalLights /* None */,
    LocalObjectsSettings[] m_LocalObjects /* NeedsAlign */)
{
    public static LightController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* EditorTimeOfDay */
        int _EditorTimeOfDay = reader.ReadS32();
        PPtr<Light>[] _LightsForEdit = BuiltInArray<PPtr<Light>>.Read(reader);
        PPtr<ShadowProxyCombinerBox>[] _ShadowProxyBoxes = BuiltInArray<PPtr<ShadowProxyCombinerBox>>.Read(reader);
        int _CameraLight = reader.ReadS32();
        int _CameraClearFlag = reader.ReadS32();
        byte _CameraContourLightEnabled = reader.ReadU8();
        reader.AlignTo(4); /* ContourLightSettings */
        CameraContourLightSettings _ContourLightSettings = CameraContourLightSettings.Read(reader);
        PPtr<Light> _MainLight = PPtr<Light>.Read(reader);
        PPtr<SceneLightConfig> _m_SoloConfig = PPtr<SceneLightConfig>.Read(reader);
        PPtr<SceneLightConfig> _m_MorningConfig = PPtr<SceneLightConfig>.Read(reader);
        PPtr<SceneLightConfig> _m_DayConfig = PPtr<SceneLightConfig>.Read(reader);
        PPtr<SceneLightConfig> _m_EveningConfig = PPtr<SceneLightConfig>.Read(reader);
        PPtr<SceneLightConfig> _m_NightConfig = PPtr<SceneLightConfig>.Read(reader);
        PPtr<ReflectionProbe>[] _m_ReflectionProbes = BuiltInArray<PPtr<ReflectionProbe>>.Read(reader);
        PPtr<Volume>[] _m_SoloPostProcessingVolumes = BuiltInArray<PPtr<Volume>>.Read(reader);
        PPtr<Volume>[] _m_MorningPostProcessingVolumes = BuiltInArray<PPtr<Volume>>.Read(reader);
        PPtr<Volume>[] _m_DayPostProcessingVolumes = BuiltInArray<PPtr<Volume>>.Read(reader);
        PPtr<Volume>[] _m_EveningPostProcessingVolumes = BuiltInArray<PPtr<Volume>>.Read(reader);
        PPtr<Volume>[] _m_NightPostProcessingVolumes = BuiltInArray<PPtr<Volume>>.Read(reader);
        LocalLightSettings[] _m_LocalLights = BuiltInArray<LocalLightSettings>.Read(reader);
        reader.AlignTo(4); /* m_LocalObjects */
        LocalObjectsSettings[] _m_LocalObjects = BuiltInArray<LocalObjectsSettings>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _EditorTimeOfDay,
            _LightsForEdit,
            _ShadowProxyBoxes,
            _CameraLight,
            _CameraClearFlag,
            _CameraContourLightEnabled,
            _ContourLightSettings,
            _MainLight,
            _m_SoloConfig,
            _m_MorningConfig,
            _m_DayConfig,
            _m_EveningConfig,
            _m_NightConfig,
            _m_ReflectionProbes,
            _m_SoloPostProcessingVolumes,
            _m_MorningPostProcessingVolumes,
            _m_DayPostProcessingVolumes,
            _m_EveningPostProcessingVolumes,
            _m_NightPostProcessingVolumes,
            _m_LocalLights,
            _m_LocalObjects);
    }
}

