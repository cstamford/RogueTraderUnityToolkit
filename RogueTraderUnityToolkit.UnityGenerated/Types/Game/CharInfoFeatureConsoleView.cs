namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoFeatureConsoleView (14 fields) BF5404F3EDF3BF06F984B51EB310754F/6C217EBCFCE3D60F298E4D58B6EF3C8C */
public record class CharInfoFeatureConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_AcronymText /* None */,
    PPtr<OwlcatMultiSelectable> m_Button /* None */,
    PPtr<Image> m_TimeIcon /* None */,
    PPtr<TextMeshProUGUI> m_DisplayName /* None */,
    PPtr<TextMeshProUGUI> m_Description /* None */,
    PPtr<TextMeshProUGUI> m_FactDescription /* None */,
    PPtr<Image> m_Rank /* None */,
    PPtr<TextMeshProUGUI> m_RankText /* None */,
    PPtr<RectTransform> m_LeftSideTooltipPlace /* None */)
{
    public static CharInfoFeatureConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AcronymText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_Button = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<Image> _m_TimeIcon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DisplayName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Description = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_FactDescription = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Rank = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RankText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RectTransform> _m_LeftSideTooltipPlace = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_AcronymText,
            _m_Button,
            _m_TimeIcon,
            _m_DisplayName,
            _m_Description,
            _m_FactDescription,
            _m_Rank,
            _m_RankText,
            _m_LeftSideTooltipPlace);
    }
}

