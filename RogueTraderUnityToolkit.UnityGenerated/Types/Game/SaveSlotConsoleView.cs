namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SaveSlotConsoleView (17 fields) 67B3025DDD62FB6A43842FA53B02E06F/796232DA3948E9E1E18FC11C73541D82 */
public record class SaveSlotConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    byte m_IsDetailedView /* None */,
    PPtr<TextMeshProUGUI> m_NameLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_LocationLabel /* None */,
    PPtr<TextMeshProUGUI> m_TimeInGameLabel /* None */,
    PPtr<GameObject> m_DlcRequiredBlock /* None */,
    PPtr<TextMeshProUGUI> m_DlcRequiredLabel /* None */,
    PPtr<TextMeshProUGUI> m_DlcRequiredDescription /* None */,
    PPtr<RawImage> m_ScreenshotImage /* None */,
    PPtr<GameObject> m_AutoSaveMark /* None */,
    PPtr<GameObject> m_QuickSaveMark /* None */,
    PPtr<SaveLoadPortraitBaseView> m_PortraitPrefab /* None */,
    PPtr<WidgetListMVVM> m_WidgetListMvvm /* None */)
{
    public static SaveSlotConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        byte _m_IsDetailedView = reader.ReadU8();
        reader.AlignTo(4); /* m_NameLabel */
        PPtr<TextMeshProUGUI> _m_NameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LocationLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TimeInGameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_DlcRequiredBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DlcRequiredLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DlcRequiredDescription = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RawImage> _m_ScreenshotImage = PPtr<RawImage>.Read(reader);
        PPtr<GameObject> _m_AutoSaveMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_QuickSaveMark = PPtr<GameObject>.Read(reader);
        PPtr<SaveLoadPortraitBaseView> _m_PortraitPrefab = PPtr<SaveLoadPortraitBaseView>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListMvvm = PPtr<WidgetListMVVM>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_IsDetailedView,
            _m_NameLabel,
            _m_LocationLabel,
            _m_TimeInGameLabel,
            _m_DlcRequiredBlock,
            _m_DlcRequiredLabel,
            _m_DlcRequiredDescription,
            _m_ScreenshotImage,
            _m_AutoSaveMark,
            _m_QuickSaveMark,
            _m_PortraitPrefab,
            _m_WidgetListMvvm);
    }
}

