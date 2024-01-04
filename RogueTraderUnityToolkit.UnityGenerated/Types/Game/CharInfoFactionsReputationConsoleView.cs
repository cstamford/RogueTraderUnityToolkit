namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoFactionsReputationConsoleView (9 fields) 28D0BC669101B431539DB630712F93B9/8E2ED24362B5D47AF26552DA7E4D2630 */
public record class CharInfoFactionsReputationConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<CharInfoFactionReputationItemPCView> m_FactionReputationItemPCView /* None */,
    PPtr<CharInfoProfitFactorItemBaseView> ProfitFactorItemBaseView /* None */,
    int m_RowsCount /* None */)
{
    public static CharInfoFactionsReputationConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharInfoFactionReputationItemPCView> _m_FactionReputationItemPCView = PPtr<CharInfoFactionReputationItemPCView>.Read(reader);
        PPtr<CharInfoProfitFactorItemBaseView> _ProfitFactorItemBaseView = PPtr<CharInfoProfitFactorItemBaseView>.Read(reader);
        int _m_RowsCount = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_WidgetList,
            _m_FactionReputationItemPCView,
            _ProfitFactorItemBaseView,
            _m_RowsCount);
    }
}

