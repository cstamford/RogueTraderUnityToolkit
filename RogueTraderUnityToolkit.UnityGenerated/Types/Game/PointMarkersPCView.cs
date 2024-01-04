namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PointMarkersPCView (7 fields) 9E64B6C39E4FFA7D948957C8C2AE40D3/E8580B897D8A21C66924837CE1353789 */
public record class PointMarkersPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_MarkersContainer /* NeedsAlign */,
    PPtr<PointMarkerPCView> m_MarkerView /* None */,
    PPtr<RectTransform>[] m_InfluencingContainers /* None */)
{
    public static PointMarkersPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MarkersContainer */
        PPtr<RectTransform> _m_MarkersContainer = PPtr<RectTransform>.Read(reader);
        PPtr<PointMarkerPCView> _m_MarkerView = PPtr<PointMarkerPCView>.Read(reader);
        PPtr<RectTransform>[] _m_InfluencingContainers = BuiltInArray<PPtr<RectTransform>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MarkersContainer,
            _m_MarkerView,
            _m_InfluencingContainers);
    }
}

