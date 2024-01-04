namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DollCamera (13 fields) 7EB389D0357C58C03D2D939CC600F828/B8706A257209BEDB45826E4780F425E5 */
public record class DollCamera(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float m_Elasticity /* NeedsAlign */,
    float m_SensitivityZoom /* None */,
    float m_AutoZoomSpeed /* None */,
    float m_SmoothZoom /* None */,
    float m_MinZoom /* None */,
    float m_MaxZoom /* None */,
    DollRoomCameraZoomPreset m_DefaultZoomPreset /* None */,
    DollRoomCameraZoomPreset m_CharacterZoomPreset /* NeedsAlign */,
    PPtr<Transform> m_DefaultTargetTransform /* NeedsAlign */)
{
    public static DollCamera Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Elasticity */
        float _m_Elasticity = reader.ReadF32();
        float _m_SensitivityZoom = reader.ReadF32();
        float _m_AutoZoomSpeed = reader.ReadF32();
        float _m_SmoothZoom = reader.ReadF32();
        float _m_MinZoom = reader.ReadF32();
        float _m_MaxZoom = reader.ReadF32();
        DollRoomCameraZoomPreset _m_DefaultZoomPreset = DollRoomCameraZoomPreset.Read(reader);
        reader.AlignTo(4); /* m_CharacterZoomPreset */
        DollRoomCameraZoomPreset _m_CharacterZoomPreset = DollRoomCameraZoomPreset.Read(reader);
        reader.AlignTo(4); /* m_DefaultTargetTransform */
        PPtr<Transform> _m_DefaultTargetTransform = PPtr<Transform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Elasticity,
            _m_SensitivityZoom,
            _m_AutoZoomSpeed,
            _m_SmoothZoom,
            _m_MinZoom,
            _m_MaxZoom,
            _m_DefaultZoomPreset,
            _m_CharacterZoomPreset,
            _m_DefaultTargetTransform);
    }
}

