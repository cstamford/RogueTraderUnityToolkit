namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CinemachineVirtualCamera (15 fields) DA7EA93AF00FC092A058FFF68F3658DB/3EE6F0EAA777C252AD8438DBDFC4FFAE */
public record class CinemachineVirtualCamera(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AsciiString[] m_ExcludedPropertiesInInspector /* NeedsAlign */,
    int[] m_LockStageInInspector /* NeedsAlign */,
    int m_StreamingVersion /* NeedsAlign */,
    int m_Priority /* None */,
    int m_StandbyUpdate /* None */,
    PPtr<Transform> m_LookAt /* None */,
    PPtr<Transform> m_Follow /* None */,
    LensSettings m_Lens /* None */,
    TransitionParams m_Transitions /* None */,
    int m_LegacyBlendHint /* NeedsAlign */,
    PPtr<Transform> m_ComponentOwner /* None */)
{
    public static CinemachineVirtualCamera Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ExcludedPropertiesInInspector */
        AsciiString[] _m_ExcludedPropertiesInInspector = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_LockStageInInspector */
        int[] _m_LockStageInInspector = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* m_StreamingVersion */
        int _m_StreamingVersion = reader.ReadS32();
        int _m_Priority = reader.ReadS32();
        int _m_StandbyUpdate = reader.ReadS32();
        PPtr<Transform> _m_LookAt = PPtr<Transform>.Read(reader);
        PPtr<Transform> _m_Follow = PPtr<Transform>.Read(reader);
        LensSettings _m_Lens = LensSettings.Read(reader);
        TransitionParams _m_Transitions = TransitionParams.Read(reader);
        reader.AlignTo(4); /* m_LegacyBlendHint */
        int _m_LegacyBlendHint = reader.ReadS32();
        PPtr<Transform> _m_ComponentOwner = PPtr<Transform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ExcludedPropertiesInInspector,
            _m_LockStageInInspector,
            _m_StreamingVersion,
            _m_Priority,
            _m_StandbyUpdate,
            _m_LookAt,
            _m_Follow,
            _m_Lens,
            _m_Transitions,
            _m_LegacyBlendHint,
            _m_ComponentOwner);
    }
}

