namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SaveLoadMenuSelectorConsoleView (7 fields) 17CFF23AEBF642791384303E6B6F8B89/75A1D059AD3CB43D93A431F1909F7E95 */
public record class SaveLoadMenuSelectorConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SaveLoadMenuEntityBaseView> m_SaveButton /* NeedsAlign */,
    PPtr<SaveLoadMenuEntityBaseView> m_LoadButton /* None */,
    PPtr<GameObject> m_Selector /* None */)
{
    public static SaveLoadMenuSelectorConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SaveButton */
        PPtr<SaveLoadMenuEntityBaseView> _m_SaveButton = PPtr<SaveLoadMenuEntityBaseView>.Read(reader);
        PPtr<SaveLoadMenuEntityBaseView> _m_LoadButton = PPtr<SaveLoadMenuEntityBaseView>.Read(reader);
        PPtr<GameObject> _m_Selector = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SaveButton,
            _m_LoadButton,
            _m_Selector);
    }
}

