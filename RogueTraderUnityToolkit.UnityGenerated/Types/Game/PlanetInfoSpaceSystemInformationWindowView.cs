namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PlanetInfoSpaceSystemInformationWindowView (14 fields) AA5665F595980B9F0ACF7ACD4BF34833/61E954C0DF58E8D52A12FE37001BDBDE */
public record class PlanetInfoSpaceSystemInformationWindowView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<Image> m_Image /* None */,
    PPtr<PlanetResourceImageView> m_ImageResourceView /* None */,
    PPtr<GameObject> m_ImageResourcePanel /* None */,
    PPtr<PlanetTraitsView> m_TraitsView /* None */,
    PPtr<GameObject> m_TraitsPanel /* None */,
    PPtr<PlanetPointsOfInterestView> m_PointsOfInterestView /* None */,
    PPtr<GameObject> m_PointsOfInterestPanel /* None */,
    PPtr<GameObject> m_ConsoleFocusButton /* None */,
    byte IsFocused /* None */)
{
    public static PlanetInfoSpaceSystemInformationWindowView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Text */
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Image = PPtr<Image>.Read(reader);
        PPtr<PlanetResourceImageView> _m_ImageResourceView = PPtr<PlanetResourceImageView>.Read(reader);
        PPtr<GameObject> _m_ImageResourcePanel = PPtr<GameObject>.Read(reader);
        PPtr<PlanetTraitsView> _m_TraitsView = PPtr<PlanetTraitsView>.Read(reader);
        PPtr<GameObject> _m_TraitsPanel = PPtr<GameObject>.Read(reader);
        PPtr<PlanetPointsOfInterestView> _m_PointsOfInterestView = PPtr<PlanetPointsOfInterestView>.Read(reader);
        PPtr<GameObject> _m_PointsOfInterestPanel = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_ConsoleFocusButton = PPtr<GameObject>.Read(reader);
        byte _IsFocused = reader.ReadU8();
        
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
            _m_ConsoleFocusButton,
            _IsFocused);
    }
}

