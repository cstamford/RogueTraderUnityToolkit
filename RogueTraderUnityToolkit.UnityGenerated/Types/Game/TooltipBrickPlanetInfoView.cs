namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickPlanetInfoView (14 fields) 7F9EB1B18FE17E54CD1C4AAF630F2A33/A4269C944193B2BF0A8BB65249A38AB4 */
public record class TooltipBrickPlanetInfoView(
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
    float m_DefaultConsoleFontSize /* None */)
{
    public static TooltipBrickPlanetInfoView Read(EndianBinaryReader reader)
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
            _m_DefaultConsoleFontSize);
    }
}

