namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OcclusionGeometryClipTarget (10 fields) 8F9651F6B4D94718575772E056D9CC2A/C04374AADB2F1A5EECDEC5E4ECB327EE */
public record class OcclusionGeometryClipTarget(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int m_ActivationMode /* NeedsAlign */,
    Vector3f m_PositionLocalOffset /* None */,
    Vector3f m_PositionWorldOffset /* None */,
    Vector2f m_Size /* None */,
    Vector2f m_DynamicSize /* None */,
    int m_TargetInsideBoxOcclusionMode /* None */)
{
    public static OcclusionGeometryClipTarget Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ActivationMode */
        int _m_ActivationMode = reader.ReadS32();
        Vector3f _m_PositionLocalOffset = Vector3f.Read(reader);
        Vector3f _m_PositionWorldOffset = Vector3f.Read(reader);
        Vector2f _m_Size = Vector2f.Read(reader);
        Vector2f _m_DynamicSize = Vector2f.Read(reader);
        int _m_TargetInsideBoxOcclusionMode = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ActivationMode,
            _m_PositionLocalOffset,
            _m_PositionWorldOffset,
            _m_Size,
            _m_DynamicSize,
            _m_TargetInsideBoxOcclusionMode);
    }
}

