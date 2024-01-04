namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InspectConsoleView (9 fields) FEEF148CD53D894360703FE3D8BDCD61/5C729453D0F2FF5C20FB79DBE1B5104A */
public record class InspectConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<InfoWindowConsoleView> m_InfoWindow /* NeedsAlign */,
    PPtr<RectTransform> InspectRectTransform /* None */,
    float m_MoveAnimationTime /* None */,
    CanvasTransformSettings m_StartPosition /* None */,
    CanvasTransformSettings m_SidePosition /* None */)
{
    public static InspectConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InfoWindow */
        PPtr<InfoWindowConsoleView> _m_InfoWindow = PPtr<InfoWindowConsoleView>.Read(reader);
        PPtr<RectTransform> _InspectRectTransform = PPtr<RectTransform>.Read(reader);
        float _m_MoveAnimationTime = reader.ReadF32();
        CanvasTransformSettings _m_StartPosition = CanvasTransformSettings.Read(reader);
        CanvasTransformSettings _m_SidePosition = CanvasTransformSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_InfoWindow,
            _InspectRectTransform,
            _m_MoveAnimationTime,
            _m_StartPosition,
            _m_SidePosition);
    }
}

