namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AreaEnterPoint (7 fields) E657532ADE1408451BA99770331A3980/504789753DA20AAB1106CBA3F191C13A */
public record class AreaEnterPoint(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    BlueprintAreaEnterPointReference m_Blueprint /* NeedsAlign */,
    byte RotateCameraOnEnter /* NeedsAlign */,
    PPtr<Transform> CameraRotationTransform /* NeedsAlign */)
{
    public static AreaEnterPoint Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Blueprint */
        BlueprintAreaEnterPointReference _m_Blueprint = BlueprintAreaEnterPointReference.Read(reader);
        reader.AlignTo(4); /* RotateCameraOnEnter */
        byte _RotateCameraOnEnter = reader.ReadU8();
        reader.AlignTo(4); /* CameraRotationTransform */
        PPtr<Transform> _CameraRotationTransform = PPtr<Transform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Blueprint,
            _RotateCameraOnEnter,
            _CameraRotationTransform);
    }
}

