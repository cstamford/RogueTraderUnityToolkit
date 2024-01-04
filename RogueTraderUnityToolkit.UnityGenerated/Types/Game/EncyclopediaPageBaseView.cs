namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EncyclopediaPageBaseView (21 fields) 8AE8003C723BAB36B4CFE680732F6F86/C4D6ED0F104880D9B1FCA490AEA2C8F0 */
public record class EncyclopediaPageBaseView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<FadeAnimator> ContentAnimator /* None */,
    PPtr<EncyclopediaPageBlockTextPCView> m_TextBlockPrefab /* None */,
    PPtr<EncyclopediaPageBlockImagePCView> m_ImageBlockPrefab /* None */,
    PPtr<EncyclopediaPageBlockUnitPCView> m_UnitBlockPrefab /* None */,
    PPtr<EncyclopediaPageBlockChildPagesPCView> m_ChildPagesPrefab /* None */,
    PPtr<EncyclopediaPageBlockBookEventPCView> m_BookEventHistoryBlockPrefab /* None */,
    PPtr<EncyclopediaPageBlockGlossaryEntryPCView> m_GlossaryEntryBlockPrefab /* None */,
    PPtr<EncyclopediaPageBlockPlanetPCView> m_PlanetBlockPrefab /* None */,
    PPtr<EncyclopediaPageBlockAstropathBriefPCView> m_AstropathBriefBlockPrefab /* None */,
    PPtr<TextMeshProUGUI> m_PageAdditionText /* None */,
    float m_DefaultFontSizeTitle /* None */,
    float m_DefaultFontSizeAdditionalText /* None */,
    float m_DefaultConsoleFontSizeTitle /* None */,
    float m_DefaultConsoleFontSizeAdditionalText /* None */)
{
    public static EncyclopediaPageBaseView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<FadeAnimator> _ContentAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<EncyclopediaPageBlockTextPCView> _m_TextBlockPrefab = PPtr<EncyclopediaPageBlockTextPCView>.Read(reader);
        PPtr<EncyclopediaPageBlockImagePCView> _m_ImageBlockPrefab = PPtr<EncyclopediaPageBlockImagePCView>.Read(reader);
        PPtr<EncyclopediaPageBlockUnitPCView> _m_UnitBlockPrefab = PPtr<EncyclopediaPageBlockUnitPCView>.Read(reader);
        PPtr<EncyclopediaPageBlockChildPagesPCView> _m_ChildPagesPrefab = PPtr<EncyclopediaPageBlockChildPagesPCView>.Read(reader);
        PPtr<EncyclopediaPageBlockBookEventPCView> _m_BookEventHistoryBlockPrefab = PPtr<EncyclopediaPageBlockBookEventPCView>.Read(reader);
        PPtr<EncyclopediaPageBlockGlossaryEntryPCView> _m_GlossaryEntryBlockPrefab = PPtr<EncyclopediaPageBlockGlossaryEntryPCView>.Read(reader);
        PPtr<EncyclopediaPageBlockPlanetPCView> _m_PlanetBlockPrefab = PPtr<EncyclopediaPageBlockPlanetPCView>.Read(reader);
        PPtr<EncyclopediaPageBlockAstropathBriefPCView> _m_AstropathBriefBlockPrefab = PPtr<EncyclopediaPageBlockAstropathBriefPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PageAdditionText = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_DefaultFontSizeTitle = reader.ReadF32();
        float _m_DefaultFontSizeAdditionalText = reader.ReadF32();
        float _m_DefaultConsoleFontSizeTitle = reader.ReadF32();
        float _m_DefaultConsoleFontSizeAdditionalText = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_WidgetList,
            _m_ScrollRect,
            _ContentAnimator,
            _m_TextBlockPrefab,
            _m_ImageBlockPrefab,
            _m_UnitBlockPrefab,
            _m_ChildPagesPrefab,
            _m_BookEventHistoryBlockPrefab,
            _m_GlossaryEntryBlockPrefab,
            _m_PlanetBlockPrefab,
            _m_AstropathBriefBlockPrefab,
            _m_PageAdditionText,
            _m_DefaultFontSizeTitle,
            _m_DefaultFontSizeAdditionalText,
            _m_DefaultConsoleFontSizeTitle,
            _m_DefaultConsoleFontSizeAdditionalText);
    }
}

