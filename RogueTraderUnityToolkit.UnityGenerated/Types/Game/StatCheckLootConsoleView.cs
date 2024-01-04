namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StatCheckLootConsoleView (8 fields) EEE4D44AD465425E12C78A008FB152D5/EE0E3AE90C83B7C6B7DE0BB802D2FFF1 */
public record class StatCheckLootConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_SelectUnitHeaderLabel /* NeedsAlign */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */,
    PPtr<StatCheckLootMainPageConsoleView> m_StatCheckLootMainPageConsoleView /* None */,
    PPtr<StatCheckLootUnitsPageConsoleView> m_StatCheckLootUnitsPageConsoleView /* None */)
{
    public static StatCheckLootConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SelectUnitHeaderLabel */
        PPtr<TextMeshProUGUI> _m_SelectUnitHeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<StatCheckLootMainPageConsoleView> _m_StatCheckLootMainPageConsoleView = PPtr<StatCheckLootMainPageConsoleView>.Read(reader);
        PPtr<StatCheckLootUnitsPageConsoleView> _m_StatCheckLootUnitsPageConsoleView = PPtr<StatCheckLootUnitsPageConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SelectUnitHeaderLabel,
            _m_FadeAnimator,
            _m_StatCheckLootMainPageConsoleView,
            _m_StatCheckLootUnitsPageConsoleView);
    }
}

