namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharacterVisualSettingsPCView (14 fields) E15E6786493BB83FD471DEDBC44F45B0/D9AEFEE1491933BA11CFCE194FA878D7 */
public record class CharacterVisualSettingsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Header /* None */,
    PPtr<CharacterVisualSettingsEntityPCView> m_ClothEntityView /* None */,
    PPtr<CharacterVisualSettingsEntityPCView> m_HelmetEntityView /* None */,
    PPtr<CharacterVisualSettingsEntityPCView> m_BackpackEntityView /* None */,
    PPtr<TextureSelectorPagedView> m_OutfitMainColorSelectorView /* None */,
    PPtr<TextureSelectorPagedView> m_OutfitSecondaryColorSelectorView /* None */,
    PPtr<OwlcatButton> m_Close /* None */,
    PPtr<OwlcatButton> m_Complete /* None */,
    PPtr<TextMeshProUGUI> m_CompleteLabel /* None */)
{
    public static CharacterVisualSettingsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Header = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CharacterVisualSettingsEntityPCView> _m_ClothEntityView = PPtr<CharacterVisualSettingsEntityPCView>.Read(reader);
        PPtr<CharacterVisualSettingsEntityPCView> _m_HelmetEntityView = PPtr<CharacterVisualSettingsEntityPCView>.Read(reader);
        PPtr<CharacterVisualSettingsEntityPCView> _m_BackpackEntityView = PPtr<CharacterVisualSettingsEntityPCView>.Read(reader);
        PPtr<TextureSelectorPagedView> _m_OutfitMainColorSelectorView = PPtr<TextureSelectorPagedView>.Read(reader);
        PPtr<TextureSelectorPagedView> _m_OutfitSecondaryColorSelectorView = PPtr<TextureSelectorPagedView>.Read(reader);
        PPtr<OwlcatButton> _m_Close = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_Complete = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CompleteLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_Header,
            _m_ClothEntityView,
            _m_HelmetEntityView,
            _m_BackpackEntityView,
            _m_OutfitMainColorSelectorView,
            _m_OutfitSecondaryColorSelectorView,
            _m_Close,
            _m_Complete,
            _m_CompleteLabel);
    }
}

