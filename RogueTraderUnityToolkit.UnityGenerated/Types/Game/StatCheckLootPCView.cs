namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StatCheckLootPCView (8 fields) 1F703AD260012358B4B794DD7AB14177/46267D7566909789F037055BEFC3529D */
public record class StatCheckLootPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_SelectUnitHeaderLabel /* NeedsAlign */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */,
    PPtr<StatCheckLootMainPagePCView> m_StatCheckLootMainPagePCView /* None */,
    PPtr<StatCheckLootUnitsPagePCView> m_StatCheckLootUnitsPagePCView /* None */)
{
    public static StatCheckLootPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SelectUnitHeaderLabel */
        PPtr<TextMeshProUGUI> _m_SelectUnitHeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<StatCheckLootMainPagePCView> _m_StatCheckLootMainPagePCView = PPtr<StatCheckLootMainPagePCView>.Read(reader);
        PPtr<StatCheckLootUnitsPagePCView> _m_StatCheckLootUnitsPagePCView = PPtr<StatCheckLootUnitsPagePCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SelectUnitHeaderLabel,
            _m_FadeAnimator,
            _m_StatCheckLootMainPagePCView,
            _m_StatCheckLootUnitsPagePCView);
    }
}

