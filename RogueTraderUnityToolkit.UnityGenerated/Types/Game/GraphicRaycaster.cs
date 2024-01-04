namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GraphicRaycaster (7 fields) 76FC9864DB984548A1C1C546FA42AB1B/C6F7A29FC4C07F48CB4302B3F76A88DB */
public record class GraphicRaycaster(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IgnoreReversedGraphics /* NeedsAlign */,
    int m_BlockingObjects /* NeedsAlign */,
    BitField m_BlockingMask /* None */)
{
    public static GraphicRaycaster Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IgnoreReversedGraphics */
        byte _m_IgnoreReversedGraphics = reader.ReadU8();
        reader.AlignTo(4); /* m_BlockingObjects */
        int _m_BlockingObjects = reader.ReadS32();
        BitField _m_BlockingMask = BitField.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IgnoreReversedGraphics,
            _m_BlockingObjects,
            _m_BlockingMask);
    }
}

