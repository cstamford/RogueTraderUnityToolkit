namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TexturesTexturesCombinedSelectorCommonView (11 fields) F088314A910C281395C7E60188686F07/D03D78DE08F311E7BB2489FC6D4D812C */
public record class TexturesTexturesCombinedSelectorCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiSelectable> m_Selectable /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Label /* None */,
    PPtr<TextMeshProUGUI> m_Counter /* None */,
    PPtr<ClickablePageNavigation> m_Paginator /* None */,
    PPtr<TextureSelectorCommonView> m_FirstTextureSelectorPagedView /* None */,
    PPtr<TextureSelectorPagedView> m_SecondTextureSelectorPagedView /* None */,
    VirtualListLayoutElementSettings m_LayoutSettings /* None */)
{
    public static TexturesTexturesCombinedSelectorCommonView Read(EndianBinaryReader reader)
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
        PPtr<TextureSelectorCommonView> _m_FirstTextureSelectorPagedView = PPtr<TextureSelectorCommonView>.Read(reader);
        PPtr<TextureSelectorPagedView> _m_SecondTextureSelectorPagedView = PPtr<TextureSelectorPagedView>.Read(reader);
        VirtualListLayoutElementSettings _m_LayoutSettings = VirtualListLayoutElementSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Selectable,
            _m_Label,
            _m_Counter,
            _m_Paginator,
            _m_FirstTextureSelectorPagedView,
            _m_SecondTextureSelectorPagedView,
            _m_LayoutSettings);
    }
}

