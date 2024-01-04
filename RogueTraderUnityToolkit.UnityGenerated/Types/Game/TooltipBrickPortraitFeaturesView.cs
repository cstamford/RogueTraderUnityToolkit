namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickPortraitFeaturesView (10 fields) A32D79743F9B4EA3A7D4D7A5835F574B/1235B8C44EC344262004025642467307 */
public record class TooltipBrickPortraitFeaturesView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_NameLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Available /* None */,
    PPtr<Image> m_Portrait /* None */,
    PPtr<_2dxFX_GrayScale> m_GrayScale /* None */,
    PPtr<Image>[] m_DesperateMeasureIcons /* None */,
    PPtr<Image>[] m_HeroicActIcons /* None */)
{
    public static TooltipBrickPortraitFeaturesView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_NameLabel */
        PPtr<TextMeshProUGUI> _m_NameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Available = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Portrait = PPtr<Image>.Read(reader);
        PPtr<_2dxFX_GrayScale> _m_GrayScale = PPtr<_2dxFX_GrayScale>.Read(reader);
        PPtr<Image>[] _m_DesperateMeasureIcons = BuiltInArray<PPtr<Image>>.Read(reader);
        PPtr<Image>[] _m_HeroicActIcons = BuiltInArray<PPtr<Image>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_NameLabel,
            _m_Available,
            _m_Portrait,
            _m_GrayScale,
            _m_DesperateMeasureIcons,
            _m_HeroicActIcons);
    }
}

