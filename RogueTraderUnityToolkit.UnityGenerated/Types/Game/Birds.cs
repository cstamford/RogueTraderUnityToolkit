namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Birds (7 fields) 8FEA19E115D2F69E30786C43496D8EDB/72CC17AAD6B655F9A0CE0EC09A1ADB1B */
public record class Birds(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float Pause /* NeedsAlign */,
    float PauseMax /* None */,
    byte DrawLines /* None */)
{
    public static Birds Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Pause */
        float _Pause = reader.ReadF32();
        float _PauseMax = reader.ReadF32();
        byte _DrawLines = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Pause,
            _PauseMax,
            _DrawLines);
    }
}

