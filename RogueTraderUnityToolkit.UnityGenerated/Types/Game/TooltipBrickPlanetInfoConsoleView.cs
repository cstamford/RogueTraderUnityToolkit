namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickPlanetInfoConsoleView (15 fields) A98A521FBA8FE1D19FBAC54101524A7D/D058D7D3AF675D4DF8636398A04947EC */
public record class TooltipBrickPlanetInfoConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<Image> m_Image /* None */,
    PPtr<TooltipBrickPlanetResourceImageView> m_ImageResourceView /* None */,
    PPtr<GameObject> m_ImageResourcePanel /* None */,
    PPtr<TooltipBrickPlanetTraitsView> m_TraitsView /* None */,
    PPtr<GameObject> m_TraitsPanel /* None */,
    PPtr<TooltipBrickPlanetPointsOfInterestView> m_PointsOfInterestView /* None */,
    PPtr<GameObject> m_PointsOfInterestPanel /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */)
{
    public static TooltipBrickPlanetInfoConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Text */
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Image = PPtr<Image>.Read(reader);
        PPtr<TooltipBrickPlanetResourceImageView> _m_ImageResourceView = PPtr<TooltipBrickPlanetResourceImageView>.Read(reader);
        PPtr<GameObject> _m_ImageResourcePanel = PPtr<GameObject>.Read(reader);
        PPtr<TooltipBrickPlanetTraitsView> _m_TraitsView = PPtr<TooltipBrickPlanetTraitsView>.Read(reader);
        PPtr<GameObject> _m_TraitsPanel = PPtr<GameObject>.Read(reader);
        PPtr<TooltipBrickPlanetPointsOfInterestView> _m_PointsOfInterestView = PPtr<TooltipBrickPlanetPointsOfInterestView>.Read(reader);
        PPtr<GameObject> _m_PointsOfInterestPanel = PPtr<GameObject>.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Text,
            _m_Image,
            _m_ImageResourceView,
            _m_ImageResourcePanel,
            _m_TraitsView,
            _m_TraitsPanel,
            _m_PointsOfInterestView,
            _m_PointsOfInterestPanel,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize,
            _m_MultiButton);
    }
}

