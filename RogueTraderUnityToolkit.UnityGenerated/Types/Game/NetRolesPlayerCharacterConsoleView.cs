namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetRolesPlayerCharacterConsoleView (8 fields) 4C2457B6C893C7DAE71D06CA54ED58E7/5BD715796FBEDB4C25A0A14253A52917 */
public record class NetRolesPlayerCharacterConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Portrait /* NeedsAlign */,
    PPtr<RectTransform> m_FocusButton /* None */,
    PPtr<ConsoleHint> m_HintUp /* None */,
    PPtr<ConsoleHint> m_HintDown /* None */)
{
    public static NetRolesPlayerCharacterConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Portrait */
        PPtr<Image> _m_Portrait = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _m_FocusButton = PPtr<RectTransform>.Read(reader);
        PPtr<ConsoleHint> _m_HintUp = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_HintDown = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Portrait,
            _m_FocusButton,
            _m_HintUp,
            _m_HintDown);
    }
}

