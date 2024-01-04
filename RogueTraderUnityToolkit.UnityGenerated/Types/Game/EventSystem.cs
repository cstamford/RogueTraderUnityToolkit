namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EventSystem (7 fields) 1BDBDEBCB07E563A47BE1151E18C6116/D7CC4510186A1047CD1A81781E0AEE0E */
public record class EventSystem(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_FirstSelected /* NeedsAlign */,
    byte m_sendNavigationEvents /* None */,
    int m_DragThreshold /* NeedsAlign */)
{
    public static EventSystem Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FirstSelected */
        PPtr<GameObject> _m_FirstSelected = PPtr<GameObject>.Read(reader);
        byte _m_sendNavigationEvents = reader.ReadU8();
        reader.AlignTo(4); /* m_DragThreshold */
        int _m_DragThreshold = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FirstSelected,
            _m_sendNavigationEvents,
            _m_DragThreshold);
    }
}

