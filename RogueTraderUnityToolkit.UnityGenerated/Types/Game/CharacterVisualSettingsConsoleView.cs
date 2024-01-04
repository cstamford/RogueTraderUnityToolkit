namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharacterVisualSettingsConsoleView (13 fields) 07D858DD3239099AD4D1C0646FC777AC/B68260C9D3CACACF1154899A29E714A3 */
public record class CharacterVisualSettingsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Header /* None */,
    PPtr<CharacterVisualSettingsEntityConsoleView> m_ClothEntityView /* None */,
    PPtr<CharacterVisualSettingsEntityConsoleView> m_HelmetEntityView /* None */,
    PPtr<CharacterVisualSettingsEntityConsoleView> m_BackpackEntityView /* None */,
    PPtr<TextureSelectorPagedView> m_OutfitMainColorSelectorView /* None */,
    PPtr<TextureSelectorPagedView> m_OutfitSecondaryColorSelectorView /* None */,
    PPtr<ConsoleHint> m_CloseHint /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */)
{
    public static CharacterVisualSettingsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Header = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CharacterVisualSettingsEntityConsoleView> _m_ClothEntityView = PPtr<CharacterVisualSettingsEntityConsoleView>.Read(reader);
        PPtr<CharacterVisualSettingsEntityConsoleView> _m_HelmetEntityView = PPtr<CharacterVisualSettingsEntityConsoleView>.Read(reader);
        PPtr<CharacterVisualSettingsEntityConsoleView> _m_BackpackEntityView = PPtr<CharacterVisualSettingsEntityConsoleView>.Read(reader);
        PPtr<TextureSelectorPagedView> _m_OutfitMainColorSelectorView = PPtr<TextureSelectorPagedView>.Read(reader);
        PPtr<TextureSelectorPagedView> _m_OutfitSecondaryColorSelectorView = PPtr<TextureSelectorPagedView>.Read(reader);
        PPtr<ConsoleHint> _m_CloseHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
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
            _m_CloseHint,
            _m_HintsWidget);
    }
}

