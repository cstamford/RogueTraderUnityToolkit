namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SectorMapBottomHudPCView (16 fields) 5A6EABE7CE44F10C003D7135522D4688/C16739F27C23E96F5779A9125960F451 */
public record class SectorMapBottomHudPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_ResourceCurrentValueText /* NeedsAlign */,
    ColorRGBA m_NormalTextColor /* None */,
    ColorRGBA m_PositiveChangeTextColor /* None */,
    ColorRGBA m_NegativeChangeTextColor /* None */,
    PPtr<RectTransform> m_NeedScanCircle /* None */,
    PPtr<Image> m_NeedScanHoverLights /* None */,
    PPtr<TextMeshProUGUI> m_NeedScanLabel /* None */,
    PPtr<TextMeshProUGUI> m_WillChangeNavigatorResourceCount /* None */,
    PPtr<OwlcatMultiButton> m_ScanButton /* None */,
    PPtr<OwlcatButton> m_CenterOnShipButton /* None */,
    PPtr<OwlcatButton> m_ExitToShipButton /* None */,
    PPtr<OwlcatButton> m_ShipCustomizationButton /* None */)
{
    public static SectorMapBottomHudPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ResourceCurrentValueText */
        PPtr<TextMeshProUGUI> _m_ResourceCurrentValueText = PPtr<TextMeshProUGUI>.Read(reader);
        ColorRGBA _m_NormalTextColor = ColorRGBA.Read(reader);
        ColorRGBA _m_PositiveChangeTextColor = ColorRGBA.Read(reader);
        ColorRGBA _m_NegativeChangeTextColor = ColorRGBA.Read(reader);
        PPtr<RectTransform> _m_NeedScanCircle = PPtr<RectTransform>.Read(reader);
        PPtr<Image> _m_NeedScanHoverLights = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NeedScanLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_WillChangeNavigatorResourceCount = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ScanButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatButton> _m_CenterOnShipButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_ExitToShipButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_ShipCustomizationButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ResourceCurrentValueText,
            _m_NormalTextColor,
            _m_PositiveChangeTextColor,
            _m_NegativeChangeTextColor,
            _m_NeedScanCircle,
            _m_NeedScanHoverLights,
            _m_NeedScanLabel,
            _m_WillChangeNavigatorResourceCount,
            _m_ScanButton,
            _m_CenterOnShipButton,
            _m_ExitToShipButton,
            _m_ShipCustomizationButton);
    }
}

