namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CinemachineBrain (14 fields) 7B019AA4B5C65B80DA0339965D3D33A5/7DC5C6B76D7C1E906A54BC25098C50D4 */
public record class CinemachineBrain(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_ShowDebugText /* NeedsAlign */,
    byte m_ShowCameraFrustum /* NeedsAlign */,
    byte m_IgnoreTimeScale /* NeedsAlign */,
    PPtr<Transform> m_WorldUpOverride /* NeedsAlign */,
    int m_UpdateMethod /* None */,
    int m_BlendUpdateMethod /* None */,
    CinemachineBlendDefinition m_DefaultBlend /* None */,
    PPtr<CinemachineBlenderSettings> m_CustomBlends /* NeedsAlign */,
    BrainEvent m_CameraCutEvent /* None */,
    VcamActivatedEvent m_CameraActivatedEvent /* NeedsAlign */)
{
    public static CinemachineBrain Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ShowDebugText */
        byte _m_ShowDebugText = reader.ReadU8();
        reader.AlignTo(4); /* m_ShowCameraFrustum */
        byte _m_ShowCameraFrustum = reader.ReadU8();
        reader.AlignTo(4); /* m_IgnoreTimeScale */
        byte _m_IgnoreTimeScale = reader.ReadU8();
        reader.AlignTo(4); /* m_WorldUpOverride */
        PPtr<Transform> _m_WorldUpOverride = PPtr<Transform>.Read(reader);
        int _m_UpdateMethod = reader.ReadS32();
        int _m_BlendUpdateMethod = reader.ReadS32();
        CinemachineBlendDefinition _m_DefaultBlend = CinemachineBlendDefinition.Read(reader);
        reader.AlignTo(4); /* m_CustomBlends */
        PPtr<CinemachineBlenderSettings> _m_CustomBlends = PPtr<CinemachineBlenderSettings>.Read(reader);
        BrainEvent _m_CameraCutEvent = BrainEvent.Read(reader);
        reader.AlignTo(4); /* m_CameraActivatedEvent */
        VcamActivatedEvent _m_CameraActivatedEvent = VcamActivatedEvent.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ShowDebugText,
            _m_ShowCameraFrustum,
            _m_IgnoreTimeScale,
            _m_WorldUpOverride,
            _m_UpdateMethod,
            _m_BlendUpdateMethod,
            _m_DefaultBlend,
            _m_CustomBlends,
            _m_CameraCutEvent,
            _m_CameraActivatedEvent);
    }
}

