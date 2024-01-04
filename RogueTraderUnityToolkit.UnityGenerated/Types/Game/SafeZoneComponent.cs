namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SafeZoneComponent (6 fields) 418512A4CCE59219CEDC8703C0026AE0/7DE031D8AF0D8ED5C66BC75FB04F579F */
public record class SafeZoneComponent(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_ApplySize /* NeedsAlign */,
    byte m_ApplyPosition /* NeedsAlign */)
{
    public static SafeZoneComponent Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ApplySize */
        byte _m_ApplySize = reader.ReadU8();
        reader.AlignTo(4); /* m_ApplyPosition */
        byte _m_ApplyPosition = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ApplySize,
            _m_ApplyPosition);
    }
}

