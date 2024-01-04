namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipPositionRulersView (8 fields) B5748311E14D5575835A909A059CBDE8/681AA34357D522C9A839A42F0D5E3E45 */
public record class ShipPositionRulersView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_HorizontalShipPosition /* NeedsAlign */,
    PPtr<RectTransform> m_VerticalShipPosition /* None */,
    PPtr<RectTransform> m_HorizontalLine /* None */,
    PPtr<RectTransform> m_VerticalLine /* None */)
{
    public static ShipPositionRulersView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HorizontalShipPosition */
        PPtr<RectTransform> _m_HorizontalShipPosition = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_VerticalShipPosition = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_HorizontalLine = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_VerticalLine = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HorizontalShipPosition,
            _m_VerticalShipPosition,
            _m_HorizontalLine,
            _m_VerticalLine);
    }
}

