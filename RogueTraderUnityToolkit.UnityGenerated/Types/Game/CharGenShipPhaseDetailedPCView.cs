namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenShipPhaseDetailedPCView (13 fields) 9D5B8D949197CDE0D04C93E6BACACCBD/9146EA0A46B55523A9DDFB4CAF8D6DEB */
public record class CharGenShipPhaseDetailedPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_PageAnimator /* NeedsAlign */,
    PPtr<ScrambledTMP> m_ShipName /* None */,
    PPtr<InfoSectionView> m_InfoView /* None */,
    PPtr<CharGenShipPhaseSelectorView> m_CharGenShipPhaseSelectorView /* None */,
    PPtr<OwlcatButton> m_SetNameButton /* None */,
    PPtr<TextMeshProUGUI> m_SetNameButtonLabel /* None */,
    PPtr<OwlcatButton> m_SetRandomNameButton /* None */,
    PPtr<TextMeshProUGUI> m_SetRandomNameButtonLabel /* None */,
    PPtr<CharGenChangeNameMessageBoxPCView> m_MessageBoxPCView /* None */)
{
    public static CharGenShipPhaseDetailedPCView Read(EndianBinaryReader reader)
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
        PPtr<OwlcatButton> _m_SetNameButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SetNameButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_SetRandomNameButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SetRandomNameButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CharGenChangeNameMessageBoxPCView> _m_MessageBoxPCView = PPtr<CharGenChangeNameMessageBoxPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PageAnimator,
            _m_ShipName,
            _m_InfoView,
            _m_CharGenShipPhaseSelectorView,
            _m_SetNameButton,
            _m_SetNameButtonLabel,
            _m_SetRandomNameButton,
            _m_SetRandomNameButtonLabel,
            _m_MessageBoxPCView);
    }
}

