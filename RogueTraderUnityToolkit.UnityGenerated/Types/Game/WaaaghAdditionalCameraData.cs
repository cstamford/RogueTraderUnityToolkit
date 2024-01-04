namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WaaaghAdditionalCameraData (23 fields) B800A341185D75C14C5DF4B763B595A2/3586465AC92A0E4BB73437721A58AE08 */
public record class WaaaghAdditionalCameraData(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsLightingEnabled /* NeedsAlign */,
    byte m_RenderShadows /* NeedsAlign */,
    int m_RequiresDepthTextureOption /* NeedsAlign */,
    int m_RequiresOpaqueTextureOption /* None */,
    int m_CameraType /* None */,
    PPtr<Camera>[] m_Cameras /* None */,
    int m_RendererIndex /* None */,
    BitField m_VolumeLayerMask /* None */,
    PPtr<Transform> m_VolumeTrigger /* None */,
    int m_VolumeFrameworkUpdateModeOption /* None */,
    byte m_RenderPostProcessing /* None */,
    int m_Antialiasing /* NeedsAlign */,
    int m_AntialiasingQuality /* None */,
    byte m_StopNaN /* None */,
    byte m_Dithering /* NeedsAlign */,
    byte m_ClearDepth /* NeedsAlign */,
    byte m_AllowIndirectRendering /* NeedsAlign */,
    PPtr<RenderTexture> m_TargetDepthTexture /* NeedsAlign */,
    byte m_AllowRenderScaling /* None */)
{
    public static WaaaghAdditionalCameraData Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IsLightingEnabled */
        byte _m_IsLightingEnabled = reader.ReadU8();
        reader.AlignTo(4); /* m_RenderShadows */
        byte _m_RenderShadows = reader.ReadU8();
        reader.AlignTo(4); /* m_RequiresDepthTextureOption */
        int _m_RequiresDepthTextureOption = reader.ReadS32();
        int _m_RequiresOpaqueTextureOption = reader.ReadS32();
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
        byte _m_StopNaN = reader.ReadU8();
        reader.AlignTo(4); /* m_Dithering */
        byte _m_Dithering = reader.ReadU8();
        reader.AlignTo(4); /* m_ClearDepth */
        byte _m_ClearDepth = reader.ReadU8();
        reader.AlignTo(4); /* m_AllowIndirectRendering */
        byte _m_AllowIndirectRendering = reader.ReadU8();
        reader.AlignTo(4); /* m_TargetDepthTexture */
        PPtr<RenderTexture> _m_TargetDepthTexture = PPtr<RenderTexture>.Read(reader);
        byte _m_AllowRenderScaling = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsLightingEnabled,
            _m_RenderShadows,
            _m_RequiresDepthTextureOption,
            _m_RequiresOpaqueTextureOption,
            _m_CameraType,
            _m_Cameras,
            _m_RendererIndex,
            _m_VolumeLayerMask,
            _m_VolumeTrigger,
            _m_VolumeFrameworkUpdateModeOption,
            _m_RenderPostProcessing,
            _m_Antialiasing,
            _m_AntialiasingQuality,
            _m_StopNaN,
            _m_Dithering,
            _m_ClearDepth,
            _m_AllowIndirectRendering,
            _m_TargetDepthTexture,
            _m_AllowRenderScaling);
    }
}

