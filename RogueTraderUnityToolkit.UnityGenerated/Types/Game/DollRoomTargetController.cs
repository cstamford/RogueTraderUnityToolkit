namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DollRoomTargetController (8 fields) B7026EF48F11773D046D1F3E430E8341/6A8DE3145799186A327E75ED64D4EC79 */
public record class DollRoomTargetController(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Transform> Target /* NeedsAlign */,
    PPtr<RawImage> m_RawImage /* None */,
    PPtr<CanvasScalerWorkaround> m_CanvasScaler /* None */,
    float MaxAngularSpeed /* None */)
{
    public static DollRoomTargetController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Target */
        PPtr<Transform> _Target = PPtr<Transform>.Read(reader);
        PPtr<RawImage> _m_RawImage = PPtr<RawImage>.Read(reader);
        PPtr<CanvasScalerWorkaround> _m_CanvasScaler = PPtr<CanvasScalerWorkaround>.Read(reader);
        float _MaxAngularSpeed = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Target,
            _m_RawImage,
            _m_CanvasScaler,
            _MaxAngularSpeed);
    }
}

