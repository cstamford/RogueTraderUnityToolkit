namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PointMarkerPCView (15 fields) 36E700BB71390E620C1641F20D9B74C4/719728C37DC1D71011BC7D782CBAAEA5 */
public record class PointMarkerPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_MainButton /* NeedsAlign */,
    PPtr<RectTransform> m_ScaledGroup /* None */,
    PPtr<Image> m_Portrait /* None */,
    PPtr<Image> m_SubtypeIcon /* None */,
    PPtr<Image> m_Frame /* None */,
    PPtr<Image> m_Arrow /* None */,
    PPtr<RectTransform> m_ArrowTransform /* None */,
    PPtr<PointMarkerLOSView> m_LOSView /* None */,
    PointMarkerRelationParams[] m_ParamsArray /* None */,
    float m_AppearanceTime /* None */,
    float m_MarkerJumpTime /* None */)
{
    public static PointMarkerPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainButton */
        PPtr<OwlcatButton> _m_MainButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<RectTransform> _m_ScaledGroup = PPtr<RectTransform>.Read(reader);
        PPtr<Image> _m_Portrait = PPtr<Image>.Read(reader);
        PPtr<Image> _m_SubtypeIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_Frame = PPtr<Image>.Read(reader);
        PPtr<Image> _m_Arrow = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _m_ArrowTransform = PPtr<RectTransform>.Read(reader);
        PPtr<PointMarkerLOSView> _m_LOSView = PPtr<PointMarkerLOSView>.Read(reader);
        PointMarkerRelationParams[] _m_ParamsArray = BuiltInArray<PointMarkerRelationParams>.Read(reader);
        float _m_AppearanceTime = reader.ReadF32();
        float _m_MarkerJumpTime = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainButton,
            _m_ScaledGroup,
            _m_Portrait,
            _m_SubtypeIcon,
            _m_Frame,
            _m_Arrow,
            _m_ArrowTransform,
            _m_LOSView,
            _m_ParamsArray,
            _m_AppearanceTime,
            _m_MarkerJumpTime);
    }
}

