namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PageNavigationPC (9 fields) AB0B6FAA0AB7A6882D73603AA318818A/5609730DEA3061AA9129B3C5BC8904D9 */
public record class PageNavigationPC(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_HasPoints /* NeedsAlign */,
    PPtr<PageNavigationPoint> m_PointPrefab /* NeedsAlign */,
    PPtr<Transform> m_PointsContainer /* None */,
    PPtr<OwlcatMultiButton> m_PreviousButton /* None */,
    PPtr<OwlcatMultiButton> m_NextButton /* None */)
{
    public static PageNavigationPC Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HasPoints */
        byte _m_HasPoints = reader.ReadU8();
        reader.AlignTo(4); /* m_PointPrefab */
        PPtr<PageNavigationPoint> _m_PointPrefab = PPtr<PageNavigationPoint>.Read(reader);
        PPtr<Transform> _m_PointsContainer = PPtr<Transform>.Read(reader);
        PPtr<OwlcatMultiButton> _m_PreviousButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_NextButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HasPoints,
            _m_PointPrefab,
            _m_PointsContainer,
            _m_PreviousButton,
            _m_NextButton);
    }
}

