namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OwlcatAdditionalCameraData (23 fields) 0ED54DE8C5731663C4B7A1764527AAFC/2B1C4DFD036880B82D236231754C2149 */
public record class OwlcatAdditionalCameraData(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int m_CameraType /* NeedsAlign */,
    PPtr<Camera>[] m_Cameras /* None */,
    int m_RendererIndex /* None */,
    BitField m_VolumeLayerMask /* None */,
    PPtr<Transform> m_VolumeTrigger /* None */,
    int m_VolumeFrameworkUpdateModeOption /* None */,
    byte m_RenderPostProcessing /* None */,
    int m_Antialiasing /* NeedsAlign */,
    int m_AntialiasingQuality /* None */,
    byte m_Dithering /* None */,
    byte m_ClearDepth /* NeedsAlign */,
    byte m_AllowLighting /* NeedsAlign */,
    byte m_AllowDecals /* NeedsAlign */,
    byte m_AllowDistortion /* NeedsAlign */,
    byte m_AllowIndirectRendering /* NeedsAlign */,
    byte m_AllowFog /* NeedsAlign */,
    byte m_AllowVfxPreparation /* NeedsAlign */,
    PPtr<RenderTexture> m_DepthTexture /* NeedsAlign */,
    RendererFeatureFlag[] m_RendererFeaturesFlags /* None */)
{
    public static OwlcatAdditionalCameraData Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CameraType */
        int _m_CameraType = reader.ReadS32();
        PPtr<Camera>[] _m_Cameras = BuiltInArray<PPtr<Camera>>.Read(reader);
        int _m_RendererIndex = reader.ReadS32();
        BitField _m_VolumeLayerMask = BitField.Read(reader);
        PPtr<Transform> _m_VolumeTrigger = PPtr<Transform>.Read(reader);
        int _m_VolumeFrameworkUpdateModeOption = reader.ReadS32();
        byte _m_RenderPostProcessing = reader.ReadU8();
        reader.AlignTo(4); /* m_Antialiasing */
        int _m_Antialiasing = reader.ReadS32();
        int _m_AntialiasingQuality = reader.ReadS32();
        byte _m_Dithering = reader.ReadU8();
        reader.AlignTo(4); /* m_ClearDepth */
        byte _m_ClearDepth = reader.ReadU8();
        reader.AlignTo(4); /* m_AllowLighting */
        byte _m_AllowLighting = reader.ReadU8();
        reader.AlignTo(4); /* m_AllowDecals */
        byte _m_AllowDecals = reader.ReadU8();
        reader.AlignTo(4); /* m_AllowDistortion */
        byte _m_AllowDistortion = reader.ReadU8();
        reader.AlignTo(4); /* m_AllowIndirectRendering */
        byte _m_AllowIndirectRendering = reader.ReadU8();
        reader.AlignTo(4); /* m_AllowFog */
        byte _m_AllowFog = reader.ReadU8();
        reader.AlignTo(4); /* m_AllowVfxPreparation */
        byte _m_AllowVfxPreparation = reader.ReadU8();
        reader.AlignTo(4); /* m_DepthTexture */
        PPtr<RenderTexture> _m_DepthTexture = PPtr<RenderTexture>.Read(reader);
        RendererFeatureFlag[] _m_RendererFeaturesFlags = BuiltInArray<RendererFeatureFlag>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CameraType,
            _m_Cameras,
            _m_RendererIndex,
            _m_VolumeLayerMask,
            _m_VolumeTrigger,
            _m_VolumeFrameworkUpdateModeOption,
            _m_RenderPostProcessing,
            _m_Antialiasing,
            _m_AntialiasingQuality,
            _m_Dithering,
            _m_ClearDepth,
            _m_AllowLighting,
            _m_AllowDecals,
            _m_AllowDistortion,
            _m_AllowIndirectRendering,
            _m_AllowFog,
            _m_AllowVfxPreparation,
            _m_DepthTexture,
            _m_RendererFeaturesFlags);
    }
}

