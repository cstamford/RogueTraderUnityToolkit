namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CinemachineComposer (19 fields) 715170B17014DDCBAF95B5C95EF19EFF/580DBCE770A68D08E1AB796A7E979725 */
public record class CinemachineComposer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Vector3f m_TrackedObjectOffset /* NeedsAlign */,
    float m_LookaheadTime /* None */,
    float m_LookaheadSmoothing /* None */,
    byte m_LookaheadIgnoreY /* None */,
    float m_HorizontalDamping /* NeedsAlign */,
    float m_VerticalDamping /* None */,
    float m_ScreenX /* None */,
    float m_ScreenY /* None */,
    float m_DeadZoneWidth /* None */,
    float m_DeadZoneHeight /* None */,
    float m_SoftZoneWidth /* None */,
    float m_SoftZoneHeight /* None */,
    float m_BiasX /* None */,
    float m_BiasY /* None */,
    byte m_CenterOnActivate /* None */)
{
    public static CinemachineComposer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TrackedObjectOffset */
        Vector3f _m_TrackedObjectOffset = Vector3f.Read(reader);
        float _m_LookaheadTime = reader.ReadF32();
        float _m_LookaheadSmoothing = reader.ReadF32();
        byte _m_LookaheadIgnoreY = reader.ReadU8();
        reader.AlignTo(4); /* m_HorizontalDamping */
        float _m_HorizontalDamping = reader.ReadF32();
        float _m_VerticalDamping = reader.ReadF32();
        float _m_ScreenX = reader.ReadF32();
        float _m_ScreenY = reader.ReadF32();
        float _m_DeadZoneWidth = reader.ReadF32();
        float _m_DeadZoneHeight = reader.ReadF32();
        float _m_SoftZoneWidth = reader.ReadF32();
        float _m_SoftZoneHeight = reader.ReadF32();
        float _m_BiasX = reader.ReadF32();
        float _m_BiasY = reader.ReadF32();
        byte _m_CenterOnActivate = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TrackedObjectOffset,
            _m_LookaheadTime,
            _m_LookaheadSmoothing,
            _m_LookaheadIgnoreY,
            _m_HorizontalDamping,
            _m_VerticalDamping,
            _m_ScreenX,
            _m_ScreenY,
            _m_DeadZoneWidth,
            _m_DeadZoneHeight,
            _m_SoftZoneWidth,
            _m_SoftZoneHeight,
            _m_BiasX,
            _m_BiasY,
            _m_CenterOnActivate);
    }
}

