namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NewGamePhaseStoryConsoleView (10 fields) D35E7A8C21262CCAA750DDD28D94C961/206668B2FD8F56CC7544D985348B912B */
public record class NewGamePhaseStoryConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<PantographView> m_PantographView /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_MainStoryButtonLabel /* None */,
    PPtr<TextMeshProUGUI> m_MainStoryButtonDescription /* None */,
    PPtr<TextMeshProUGUI> m_OtherModsAreComingSoonLabel /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<ConsoleHint> m_ScrollStoryHint /* None */)
{
    public static NewGamePhaseStoryConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PantographView */
        PPtr<PantographView> _m_PantographView = PPtr<PantographView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MainStoryButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MainStoryButtonDescription = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_OtherModsAreComingSoonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<ConsoleHint> _m_ScrollStoryHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PantographView,
            _m_MainStoryButtonLabel,
            _m_MainStoryButtonDescription,
            _m_OtherModsAreComingSoonLabel,
            _m_ScrollRect,
            _m_ScrollStoryHint);
    }
}

