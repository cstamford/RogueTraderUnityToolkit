namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DragPanelController (10 fields) A60BC73E751B6855B2096B8F1486567F/D8946629DEFDCE0E7DD35CFF16447D56 */
public record class DragPanelController(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Material> m_Material /* NeedsAlign */,
    ColorRGBA m_Color /* None */,
    byte m_RaycastTarget /* None */,
    Vector4f m_RaycastPadding /* NeedsAlign */,
    PPtr<RectTransform> TargetPanel /* None */,
    PPtr<RectTransform> ParentArea /* None */)
{
    public static DragPanelController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Material */
        PPtr<Material> _m_Material = PPtr<Material>.Read(reader);
        ColorRGBA _m_Color = ColorRGBA.Read(reader);
        byte _m_RaycastTarget = reader.ReadU8();
        reader.AlignTo(4); /* m_RaycastPadding */
        Vector4f _m_RaycastPadding = Vector4f.Read(reader);
        PPtr<RectTransform> _TargetPanel = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _ParentArea = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Material,
            _m_Color,
            _m_RaycastTarget,
            _m_RaycastPadding,
            _TargetPanel,
            _ParentArea);
    }
}

