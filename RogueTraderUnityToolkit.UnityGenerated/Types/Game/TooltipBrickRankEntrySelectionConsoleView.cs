namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickRankEntrySelectionConsoleView (11 fields) 2A5BAC56AB999AEE407A66C7EE251B48/6CF1C0A78D4B7D7A192B78E7B5200C0E */
public record class TooltipBrickRankEntrySelectionConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CharInfoFeatureSimpleBaseView> m_CharInfoRankEntryView /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_MainButton /* None */,
    PPtr<Image> m_MainButtonImage /* None */,
    RankEntrySelectionStateSprites[] m_StateSprites /* None */,
    PPtr<TextMeshProUGUI> m_SelectionLabel /* None */,
    float m_DefaultFontSizeLabel /* None */,
    float m_DefaultConsoleFontSizeLabel /* None */)
{
    public static TooltipBrickRankEntrySelectionConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CharInfoRankEntryView */
        PPtr<CharInfoFeatureSimpleBaseView> _m_CharInfoRankEntryView = PPtr<CharInfoFeatureSimpleBaseView>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MainButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_MainButtonImage = PPtr<Image>.Read(reader);
        RankEntrySelectionStateSprites[] _m_StateSprites = BuiltInArray<RankEntrySelectionStateSprites>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SelectionLabel = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_DefaultFontSizeLabel = reader.ReadF32();
        float _m_DefaultConsoleFontSizeLabel = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CharInfoRankEntryView,
            _m_MainButton,
            _m_MainButtonImage,
            _m_StateSprites,
            _m_SelectionLabel,
            _m_DefaultFontSizeLabel,
            _m_DefaultConsoleFontSizeLabel);
    }
}

