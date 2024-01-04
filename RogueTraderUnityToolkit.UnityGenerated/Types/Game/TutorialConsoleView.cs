namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TutorialConsoleView (6 fields) 514DC605D8A33EAEA3828FC80917863C/C9448620FFC31542D7B66D34DD37CDCE */
public record class TutorialConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TutorialBigWindowConsoleView> m_BigWindowView /* NeedsAlign */,
    PPtr<TutorialSmallWindowConsoleView> m_SmallWindowView /* None */)
{
    public static TutorialConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_BigWindowView */
        PPtr<TutorialBigWindowConsoleView> _m_BigWindowView = PPtr<TutorialBigWindowConsoleView>.Read(reader);
        PPtr<TutorialSmallWindowConsoleView> _m_SmallWindowView = PPtr<TutorialSmallWindowConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_BigWindowView,
            _m_SmallWindowView);
    }
}

