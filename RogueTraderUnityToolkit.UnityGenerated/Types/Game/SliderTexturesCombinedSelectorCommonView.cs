namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SliderTexturesCombinedSelectorCommonView (12 fields) 31CF2722758670C1E73F8454331808F2/B87D64E517623786CDC3455EEA121933 */
public record class SliderTexturesCombinedSelectorCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiSelectable> m_Selectable /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Label /* None */,
    PPtr<TextMeshProUGUI> m_Counter /* None */,
    PPtr<ClickablePageNavigation> m_Paginator /* None */,
    PPtr<SlideSelectorCommonView> m_SlideSelectorCommonView /* None */,
    PPtr<TextureSelectorPagedView> m_TextureSelectorPagedView /* None */,
    VirtualListLayoutElementSettings m_LayoutSettings /* None */,
    PPtr<ConsoleHint> m_ConsoleHint /* NeedsAlign */)
{
    public static SliderTexturesCombinedSelectorCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Selectable */
        PPtr<OwlcatMultiSelectable> _m_Selectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Counter = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ClickablePageNavigation> _m_Paginator = PPtr<ClickablePageNavigation>.Read(reader);
        PPtr<SlideSelectorCommonView> _m_SlideSelectorCommonView = PPtr<SlideSelectorCommonView>.Read(reader);
        PPtr<TextureSelectorPagedView> _m_TextureSelectorPagedView = PPtr<TextureSelectorPagedView>.Read(reader);
        VirtualListLayoutElementSettings _m_LayoutSettings = VirtualListLayoutElementSettings.Read(reader);
        reader.AlignTo(4); /* m_ConsoleHint */
        PPtr<ConsoleHint> _m_ConsoleHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Selectable,
            _m_Label,
            _m_Counter,
            _m_Paginator,
            _m_SlideSelectorCommonView,
            _m_TextureSelectorPagedView,
            _m_LayoutSettings,
            _m_ConsoleHint);
    }
}

