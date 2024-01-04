namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DirectorCameraLink (7 fields) 3EB5E68096DA4EB3FFC3520321E10813/2205D63B67B8BB47048E5C2E85C17759 */
public record class DirectorCameraLink(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int ControlAudioListenerType /* NeedsAlign */,
    PPtr<Transform> AudioListenerRoot /* None */,
    byte KeepDefaultListenerRotation /* None */)
{
    public static DirectorCameraLink Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ControlAudioListenerType */
        int _ControlAudioListenerType = reader.ReadS32();
        PPtr<Transform> _AudioListenerRoot = PPtr<Transform>.Read(reader);
        byte _KeepDefaultListenerRotation = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _ControlAudioListenerType,
            _AudioListenerRoot,
            _KeepDefaultListenerRotation);
    }
}

