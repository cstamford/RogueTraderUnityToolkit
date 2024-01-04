namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NewSaveSlotPCView (22 fields) 3AE23B9B0DE1EC86A5D5F690A83CFC8A/14353582D5B46745694AD189A142794F */
public record class NewSaveSlotPCView(
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
    PPtr<WidgetListMVVM> m_WidgetListMvvm /* None */,
    PPtr<TextMeshProUGUI> m_SaveLoadLabel /* None */,
    PPtr<OwlcatButton> m_SaveLoadButton /* None */,
    PPtr<TextMeshProUGUI> m_DeleteLabel /* None */,
    PPtr<OwlcatButton> m_DeleteButton /* None */,
    PPtr<PCInputField> m_PCInputField /* None */)
{
    public static NewSaveSlotPCView Read(EndianBinaryReader reader)
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
        PPtr<TextMeshProUGUI> _m_SaveLoadLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_SaveLoadButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DeleteLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_DeleteButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<PCInputField> _m_PCInputField = PPtr<PCInputField>.Read(reader);
        
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
            _m_WidgetListMvvm,
            _m_SaveLoadLabel,
            _m_SaveLoadButton,
            _m_DeleteLabel,
            _m_DeleteButton,
            _m_PCInputField);
    }
}

