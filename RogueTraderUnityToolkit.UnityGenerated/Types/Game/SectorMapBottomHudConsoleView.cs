namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SectorMapBottomHudConsoleView (16 fields) 23F2E8C7947AD67518A5BD7912FD4E38/CE53A9158D37900A01F82F461E0F6CD0 */
public record class SectorMapBottomHudConsoleView(
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
    PPtr<ConsoleHint> m_ToVoidshipBridgeHint /* None */,
    PPtr<ConsoleHint> m_OpenMenuHint /* None */,
    PPtr<ConsoleHint> m_SetCameraOnShipHint /* None */)
{
    public static SectorMapBottomHudConsoleView Read(EndianBinaryReader reader)
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
        PPtr<ConsoleHint> _m_ToVoidshipBridgeHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_OpenMenuHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_SetCameraOnShipHint = PPtr<ConsoleHint>.Read(reader);
        
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
            _m_ToVoidshipBridgeHint,
            _m_OpenMenuHint,
            _m_SetCameraOnShipHint);
    }
}

