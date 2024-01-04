namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipPostsPanelPCView (6 fields) 7C5B772CF11AAB149F974E7E113E5D7B/273D0DBD4427BBE272D5B138D75A139B */
public record class ShipPostsPanelPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_TooltipPlace /* NeedsAlign */,
    PPtr<ShipPostPCView>[] m_ShipPostViews /* None */)
{
    public static ShipPostsPanelPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TooltipPlace */
        PPtr<RectTransform> _m_TooltipPlace = PPtr<RectTransform>.Read(reader);
        PPtr<ShipPostPCView>[] _m_ShipPostViews = BuiltInArray<PPtr<ShipPostPCView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TooltipPlace,
            _m_ShipPostViews);
    }
}

