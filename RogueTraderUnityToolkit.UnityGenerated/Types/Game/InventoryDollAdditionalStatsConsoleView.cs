namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InventoryDollAdditionalStatsConsoleView (24 fields) 24D2CB151878B11DC226A09E2F0F4217/0730E52B43211767F5B654E6416D3676 */
public record class InventoryDollAdditionalStatsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_DeflectionLabel /* None */,
    PPtr<TextMeshProUGUI> m_DeflectionValue /* None */,
    PPtr<OwlcatMultiButton> m_DeflectionTooltip /* None */,
    PPtr<TextMeshProUGUI> m_AbsorptionLabel /* None */,
    PPtr<TextMeshProUGUI> m_AbsorptionValue /* None */,
    PPtr<OwlcatMultiButton> m_AbsorptionTooltip /* None */,
    PPtr<TextMeshProUGUI> m_DodgeLabel /* None */,
    PPtr<TextMeshProUGUI> m_DodgeValue /* None */,
    PPtr<OwlcatMultiButton> m_DodgeTooltip /* None */,
    PPtr<TextMeshProUGUI> m_DodgePenetrationLabel /* None */,
    PPtr<TextMeshProUGUI> m_DodgePenetrationValue /* None */,
    PPtr<OwlcatMultiButton> m_DodgePenetrationTooltip /* None */,
    PPtr<TextMeshProUGUI> m_ResolveLabel /* None */,
    PPtr<TextMeshProUGUI> m_ResolveValue /* None */,
    PPtr<OwlcatMultiButton> m_ResolveTooltip /* None */,
    PPtr<TextMeshProUGUI> m_ParryLabel /* None */,
    PPtr<TextMeshProUGUI> m_ParryValue /* None */,
    PPtr<OwlcatMultiButton> m_ParryTooltip /* None */,
    int m_NavigationLayout /* None */)
{
    public static InventoryDollAdditionalStatsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DeflectionLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DeflectionValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_DeflectionTooltip = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AbsorptionLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AbsorptionValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_AbsorptionTooltip = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DodgeLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DodgeValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_DodgeTooltip = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DodgePenetrationLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DodgePenetrationValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_DodgePenetrationTooltip = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ResolveLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ResolveValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ResolveTooltip = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ParryLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ParryValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ParryTooltip = PPtr<OwlcatMultiButton>.Read(reader);
        int _m_NavigationLayout = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_DeflectionLabel,
            _m_DeflectionValue,
            _m_DeflectionTooltip,
            _m_AbsorptionLabel,
            _m_AbsorptionValue,
            _m_AbsorptionTooltip,
            _m_DodgeLabel,
            _m_DodgeValue,
            _m_DodgeTooltip,
            _m_DodgePenetrationLabel,
            _m_DodgePenetrationValue,
            _m_DodgePenetrationTooltip,
            _m_ResolveLabel,
            _m_ResolveValue,
            _m_ResolveTooltip,
            _m_ParryLabel,
            _m_ParryValue,
            _m_ParryTooltip,
            _m_NavigationLayout);
    }
}

