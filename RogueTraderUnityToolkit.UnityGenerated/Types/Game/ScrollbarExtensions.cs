namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ScrollbarExtensions (6 fields) FDDA5AE04B067FDCB3B03E6ED35C4D8B/F6B062FD32B54C092AA72DFC0F883EDA */
public record class ScrollbarExtensions(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_ScrollUpButton /* NeedsAlign */,
    PPtr<OwlcatButton> m_ScrollDownButton /* None */)
{
    public static ScrollbarExtensions Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ScrollUpButton */
        PPtr<OwlcatButton> _m_ScrollUpButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_ScrollDownButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ScrollUpButton,
            _m_ScrollDownButton);
    }
}

