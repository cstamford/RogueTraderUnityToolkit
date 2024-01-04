namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenShipPhaseDetailedConsoleView (11 fields) D56D9E0CF1DDBDF21AD824310B391D21/2A9A0E7393A38D712A0C91043E48C028 */
public record class CharGenShipPhaseDetailedConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_PageAnimator /* NeedsAlign */,
    PPtr<ScrambledTMP> m_ShipName /* None */,
    PPtr<InfoSectionView> m_InfoView /* None */,
    PPtr<CharGenShipPhaseSelectorView> m_CharGenShipPhaseSelectorView /* None */,
    PPtr<GameObject> m_SecondaryInfoViewContainer /* None */,
    PPtr<InfoSectionView> m_SecondaryInfoView /* None */,
    PPtr<CharGenChangeNameMessageBoxConsoleView> m_MessageBoxConsoleView /* None */)
{
    public static CharGenShipPhaseDetailedConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PageAnimator */
        PPtr<FadeAnimator> _m_PageAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<ScrambledTMP> _m_ShipName = PPtr<ScrambledTMP>.Read(reader);
        PPtr<InfoSectionView> _m_InfoView = PPtr<InfoSectionView>.Read(reader);
        PPtr<CharGenShipPhaseSelectorView> _m_CharGenShipPhaseSelectorView = PPtr<CharGenShipPhaseSelectorView>.Read(reader);
        PPtr<GameObject> _m_SecondaryInfoViewContainer = PPtr<GameObject>.Read(reader);
        PPtr<InfoSectionView> _m_SecondaryInfoView = PPtr<InfoSectionView>.Read(reader);
        PPtr<CharGenChangeNameMessageBoxConsoleView> _m_MessageBoxConsoleView = PPtr<CharGenChangeNameMessageBoxConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PageAnimator,
            _m_ShipName,
            _m_InfoView,
            _m_CharGenShipPhaseSelectorView,
            _m_SecondaryInfoViewContainer,
            _m_SecondaryInfoView,
            _m_MessageBoxConsoleView);
    }
}

