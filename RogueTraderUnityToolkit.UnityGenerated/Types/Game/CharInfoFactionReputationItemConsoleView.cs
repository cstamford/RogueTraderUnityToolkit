namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoFactionReputationItemConsoleView (19 fields) 588D546D8F0BC90F1F3270296B36D7DA/245AEED0375C06E459E373648A6D9A3B */
public record class CharInfoFactionReputationItemConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_FactionImage /* NeedsAlign */,
    PPtr<Image> m_InfoButton /* None */,
    PPtr<TextMeshProUGUI> m_FactionLabel /* None */,
    PPtr<TextMeshProUGUI> m_ReputationLabel /* None */,
    PPtr<TextMeshProUGUI> m_ReputationProgressValue /* None */,
    PPtr<Image> m_ReputationProgressBar /* None */,
    PPtr<TextMeshProUGUI> m_ReputationLevelRomeNumber /* None */,
    ColorRGBA m_NormalColor /* None */,
    ColorRGBA m_MaxLevelColor /* None */,
    PPtr<TextMeshProUGUI> m_VendorsLabel /* None */,
    PPtr<TextMeshProUGUI> m_FactionDescription /* None */,
    PPtr<Image> m_Background /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<FactionVendorInformationBaseView> m_FactionVendorInformationPCViewPrefab /* None */,
    PPtr<OwlcatMultiSelectable> m_Button /* None */)
{
    public static CharInfoFactionReputationItemConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FactionImage */
        PPtr<Image> _m_FactionImage = PPtr<Image>.Read(reader);
        PPtr<Image> _m_InfoButton = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_FactionLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ReputationLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ReputationProgressValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_ReputationProgressBar = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ReputationLevelRomeNumber = PPtr<TextMeshProUGUI>.Read(reader);
        ColorRGBA _m_NormalColor = ColorRGBA.Read(reader);
        ColorRGBA _m_MaxLevelColor = ColorRGBA.Read(reader);
        PPtr<TextMeshProUGUI> _m_VendorsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_FactionDescription = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Background = PPtr<Image>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<FactionVendorInformationBaseView> _m_FactionVendorInformationPCViewPrefab = PPtr<FactionVendorInformationBaseView>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_Button = PPtr<OwlcatMultiSelectable>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FactionImage,
            _m_InfoButton,
            _m_FactionLabel,
            _m_ReputationLabel,
            _m_ReputationProgressValue,
            _m_ReputationProgressBar,
            _m_ReputationLevelRomeNumber,
            _m_NormalColor,
            _m_MaxLevelColor,
            _m_VendorsLabel,
            _m_FactionDescription,
            _m_Background,
            _m_WidgetList,
            _m_FactionVendorInformationPCViewPrefab,
            _m_Button);
    }
}

