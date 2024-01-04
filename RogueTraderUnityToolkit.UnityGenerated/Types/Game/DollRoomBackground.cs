namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DollRoomBackground (9 fields) 217EA30DB798FC002067037C4F9ACC39/A6DD60BA66351E13487FF5BE12141D7E */
public record class DollRoomBackground(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int2 Resolution /* NeedsAlign */,
    byte BlurEnabled /* None */,
    int BlurIterations /* NeedsAlign */,
    int BlurType /* None */,
    float BlurSize /* None */)
{
    public static DollRoomBackground Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Resolution */
        int2 _Resolution = int2.Read(reader);
        byte _BlurEnabled = reader.ReadU8();
        reader.AlignTo(4); /* BlurIterations */
        int _BlurIterations = reader.ReadS32();
        int _BlurType = reader.ReadS32();
        float _BlurSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Resolution,
            _BlurEnabled,
            _BlurIterations,
            _BlurType,
            _BlurSize);
    }
}

