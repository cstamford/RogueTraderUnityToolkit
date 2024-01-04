namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoFactionsReputationPCView (8 fields) 5CB987995A77AC91181EC6C12BAAF38F/C9B8B2E4ADE47ABDFC7946B1962A544D */
public record class CharInfoFactionsReputationPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<CharInfoFactionReputationItemPCView> m_FactionReputationItemPCView /* None */,
    PPtr<CharInfoProfitFactorItemBaseView> ProfitFactorItemBaseView /* None */)
{
    public static CharInfoFactionsReputationPCView Read(EndianBinaryReader reader)
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
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_WidgetList,
            _m_FactionReputationItemPCView,
            _ProfitFactorItemBaseView);
    }
}

