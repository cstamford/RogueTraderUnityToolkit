namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TextureSelectorPagedGroupView (14 fields) D9CCBC4E91B010FE4FE0A6E452D14FAB/42D942BE9D88228535B1F76AD595AEAF */
public record class TextureSelectorPagedGroupView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<GameObject> m_DescriptionObject /* None */,
    PPtr<TextMeshProUGUI> m_Description /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<TextureSelectorItemView> m_ItemPrefab /* None */,
    int m_ItemsPerRow /* None */,
    PPtr<Paginator> m_Paginator /* None */,
    PPtr<LayoutElement> m_LayoutElement /* None */,
    int m_RowNumber /* None */,
    float m_RowHeight /* None */)
{
    public static TextureSelectorPagedGroupView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_DescriptionObject = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Description = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<TextureSelectorItemView> _m_ItemPrefab = PPtr<TextureSelectorItemView>.Read(reader);
        int _m_ItemsPerRow = reader.ReadS32();
        PPtr<Paginator> _m_Paginator = PPtr<Paginator>.Read(reader);
        PPtr<LayoutElement> _m_LayoutElement = PPtr<LayoutElement>.Read(reader);
        int _m_RowNumber = reader.ReadS32();
        float _m_RowHeight = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_DescriptionObject,
            _m_Description,
            _m_WidgetList,
            _m_ItemPrefab,
            _m_ItemsPerRow,
            _m_Paginator,
            _m_LayoutElement,
            _m_RowNumber,
            _m_RowHeight);
    }
}

