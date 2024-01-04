namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickPlanetPointsOfInterestView (7 fields) 7023690E0C8D34A39AE178AE96442191/97D1AC1AA5EBCC60949BA613BE3B87E5 */
public record class TooltipBrickPlanetPointsOfInterestView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_PointsOfInterestImage /* NeedsAlign */,
    PPtr<Sprite>[] m_PoiMarks /* None */,
    PPtr<TextMeshProUGUI> m_PointsOfInterestName /* None */)
{
    public static TooltipBrickPlanetPointsOfInterestView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PointsOfInterestImage */
        PPtr<Image> _m_PointsOfInterestImage = PPtr<Image>.Read(reader);
        PPtr<Sprite>[] _m_PoiMarks = BuiltInArray<PPtr<Sprite>>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PointsOfInterestName = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PointsOfInterestImage,
            _m_PoiMarks,
            _m_PointsOfInterestName);
    }
}

