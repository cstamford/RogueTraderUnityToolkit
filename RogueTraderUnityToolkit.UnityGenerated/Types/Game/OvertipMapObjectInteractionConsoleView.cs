namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipMapObjectInteractionConsoleView (31 fields) 2BEF73A1EB9E338F5ED91796B4B27BD3/F1FC81EEA69DDB443DB2110CE2A5D5CA */
public record class OvertipMapObjectInteractionConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_Button /* NeedsAlign */,
    PPtr<OvertipBarkBlockView> m_BarkBlockView /* None */,
    PPtr<MapObjectOvertipNameBlockView> m_OvertipNameBlockView /* None */,
    PPtr<MapObjectOvertipSkillCheckBlockView> m_OvertipSkillCheckBlockView /* None */,
    PPtr<TextMeshProUGUI> m_ResourceCount /* None */,
    PPtr<Image> m_MainImage /* None */,
    PPtr<Image> m_HighlightImage /* None */,
    PPtr<CanvasGroup> m_HighlightImageCanvasGroup /* None */,
    PPtr<Image> m_ActiveImage /* None */,
    PPtr<CanvasGroup> m_ActiveImageCanvasGroup /* None */,
    PPtr<Image> m_DisabledImage /* None */,
    PPtr<CanvasGroup> m_DisabledImageCanvasGroup /* None */,
    UIInteractionTypeSprites m_ActionSprites /* None */,
    UIInteractionTypeSprites m_MoveSprites /* None */,
    UIInteractionTypeSprites m_InfoSprites /* None */,
    UIInteractionTypeSprites m_CreditsSprites /* None */,
    PPtr<CanvasGroup> m_InnerCanvasGroup /* None */,
    float m_OnHoverVisibility /* None */,
    float m_NotHoverVisibility /* None */,
    float m_FarDistance /* None */,
    float m_FarObjectVisibility /* None */,
    PPtr<OvertipConsoleView> m_OvertipConsoleView /* None */,
    byte m_NeedHintPositionCorrection /* None */,
    float m_ConfirmUpperY /* NeedsAlign */,
    float m_ConfirmLowerY /* None */,
    float m_PaginatorUpperY /* None */,
    float m_PaginatorLowerY /* None */)
{
    public static OvertipMapObjectInteractionConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatButton> _m_Button = PPtr<OwlcatButton>.Read(reader);
        PPtr<OvertipBarkBlockView> _m_BarkBlockView = PPtr<OvertipBarkBlockView>.Read(reader);
        PPtr<MapObjectOvertipNameBlockView> _m_OvertipNameBlockView = PPtr<MapObjectOvertipNameBlockView>.Read(reader);
        PPtr<MapObjectOvertipSkillCheckBlockView> _m_OvertipSkillCheckBlockView = PPtr<MapObjectOvertipSkillCheckBlockView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ResourceCount = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_MainImage = PPtr<Image>.Read(reader);
        PPtr<Image> _m_HighlightImage = PPtr<Image>.Read(reader);
        PPtr<CanvasGroup> _m_HighlightImageCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<Image> _m_ActiveImage = PPtr<Image>.Read(reader);
        PPtr<CanvasGroup> _m_ActiveImageCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<Image> _m_DisabledImage = PPtr<Image>.Read(reader);
        PPtr<CanvasGroup> _m_DisabledImageCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        UIInteractionTypeSprites _m_ActionSprites = UIInteractionTypeSprites.Read(reader);
        UIInteractionTypeSprites _m_MoveSprites = UIInteractionTypeSprites.Read(reader);
        UIInteractionTypeSprites _m_InfoSprites = UIInteractionTypeSprites.Read(reader);
        UIInteractionTypeSprites _m_CreditsSprites = UIInteractionTypeSprites.Read(reader);
        PPtr<CanvasGroup> _m_InnerCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        float _m_OnHoverVisibility = reader.ReadF32();
        float _m_NotHoverVisibility = reader.ReadF32();
        float _m_FarDistance = reader.ReadF32();
        float _m_FarObjectVisibility = reader.ReadF32();
        PPtr<OvertipConsoleView> _m_OvertipConsoleView = PPtr<OvertipConsoleView>.Read(reader);
        byte _m_NeedHintPositionCorrection = reader.ReadU8();
        reader.AlignTo(4); /* m_ConfirmUpperY */
        float _m_ConfirmUpperY = reader.ReadF32();
        float _m_ConfirmLowerY = reader.ReadF32();
        float _m_PaginatorUpperY = reader.ReadF32();
        float _m_PaginatorLowerY = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_BarkBlockView,
            _m_OvertipNameBlockView,
            _m_OvertipSkillCheckBlockView,
            _m_ResourceCount,
            _m_MainImage,
            _m_HighlightImage,
            _m_HighlightImageCanvasGroup,
            _m_ActiveImage,
            _m_ActiveImageCanvasGroup,
            _m_DisabledImage,
            _m_DisabledImageCanvasGroup,
            _m_ActionSprites,
            _m_MoveSprites,
            _m_InfoSprites,
            _m_CreditsSprites,
            _m_InnerCanvasGroup,
            _m_OnHoverVisibility,
            _m_NotHoverVisibility,
            _m_FarDistance,
            _m_FarObjectVisibility,
            _m_OvertipConsoleView,
            _m_NeedHintPositionCorrection,
            _m_ConfirmUpperY,
            _m_ConfirmLowerY,
            _m_PaginatorUpperY,
            _m_PaginatorLowerY);
    }
}

