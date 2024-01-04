namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenAppearancePhaseDetailedConsoleView (20 fields) 4F13E1469765787DCF15120ECED8662F/3F21F732147ED2FEFD48247BE25A9E98 */
public record class CharGenAppearancePhaseDetailedConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_PageAnimator /* NeedsAlign */,
    PPtr<CharGenAppearancePageSelectorView> m_PageSelectorView /* None */,
    PPtr<VirtualListVertical> m_VirtualList /* None */,
    PPtr<CharGenPortraitView> m_PortraitFullView /* None */,
    PPtr<DollRoomTargetController> m_CharacterController /* None */,
    PPtr<StringSequentialSelectorView> m_StringSequentialSelectorView /* None */,
    PPtr<SlideSelectorCommonView> m_SlideSelectorCommonView /* None */,
    PPtr<TextureSequentialSelectorView> m_TextureSequentialSelectorView /* None */,
    PPtr<TextureSelectorCommonView> m_TextureSelectorCommonView /* None */,
    PPtr<TextureSelectorPagedView> m_TextureSelectorPagedView /* None */,
    PPtr<SliderTexturesCombinedSelectorCommonView> SliderTexturesCombinedSelectorCommonView /* None */,
    PPtr<TexturesTexturesCombinedSelectorCommonView> TexturesTexturesCombinedSelectorCommonView /* None */,
    PPtr<PortraitSelectorCommonView> m_PortraitSelectorCommonView /* None */,
    PPtr<CharGenVoiceSelectorCommonView> m_CharGenVoiceSelectorCommonView /* None */,
    PPtr<ConsoleHint> m_SelectHint /* None */,
    PPtr<ConsoleHint> m_SwitchNavigationHint /* None */)
{
    public static CharGenAppearancePhaseDetailedConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PageAnimator */
        PPtr<FadeAnimator> _m_PageAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<CharGenAppearancePageSelectorView> _m_PageSelectorView = PPtr<CharGenAppearancePageSelectorView>.Read(reader);
        PPtr<VirtualListVertical> _m_VirtualList = PPtr<VirtualListVertical>.Read(reader);
        PPtr<CharGenPortraitView> _m_PortraitFullView = PPtr<CharGenPortraitView>.Read(reader);
        PPtr<DollRoomTargetController> _m_CharacterController = PPtr<DollRoomTargetController>.Read(reader);
        PPtr<StringSequentialSelectorView> _m_StringSequentialSelectorView = PPtr<StringSequentialSelectorView>.Read(reader);
        PPtr<SlideSelectorCommonView> _m_SlideSelectorCommonView = PPtr<SlideSelectorCommonView>.Read(reader);
        PPtr<TextureSequentialSelectorView> _m_TextureSequentialSelectorView = PPtr<TextureSequentialSelectorView>.Read(reader);
        PPtr<TextureSelectorCommonView> _m_TextureSelectorCommonView = PPtr<TextureSelectorCommonView>.Read(reader);
        PPtr<TextureSelectorPagedView> _m_TextureSelectorPagedView = PPtr<TextureSelectorPagedView>.Read(reader);
        PPtr<SliderTexturesCombinedSelectorCommonView> _SliderTexturesCombinedSelectorCommonView = PPtr<SliderTexturesCombinedSelectorCommonView>.Read(reader);
        PPtr<TexturesTexturesCombinedSelectorCommonView> _TexturesTexturesCombinedSelectorCommonView = PPtr<TexturesTexturesCombinedSelectorCommonView>.Read(reader);
        PPtr<PortraitSelectorCommonView> _m_PortraitSelectorCommonView = PPtr<PortraitSelectorCommonView>.Read(reader);
        PPtr<CharGenVoiceSelectorCommonView> _m_CharGenVoiceSelectorCommonView = PPtr<CharGenVoiceSelectorCommonView>.Read(reader);
        PPtr<ConsoleHint> _m_SelectHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_SwitchNavigationHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PageAnimator,
            _m_PageSelectorView,
            _m_VirtualList,
            _m_PortraitFullView,
            _m_CharacterController,
            _m_StringSequentialSelectorView,
            _m_SlideSelectorCommonView,
            _m_TextureSequentialSelectorView,
            _m_TextureSelectorCommonView,
            _m_TextureSelectorPagedView,
            _SliderTexturesCombinedSelectorCommonView,
            _TexturesTexturesCombinedSelectorCommonView,
            _m_PortraitSelectorCommonView,
            _m_CharGenVoiceSelectorCommonView,
            _m_SelectHint,
            _m_SwitchNavigationHint);
    }
}

