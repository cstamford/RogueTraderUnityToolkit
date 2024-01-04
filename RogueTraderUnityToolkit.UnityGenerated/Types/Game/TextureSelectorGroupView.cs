namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TextureSelectorGroupView (10 fields) 11199759BACBBF40D1E8602F6163BA37/F6CB08389035550DEA9357E26D6F1751 */
public record class TextureSelectorGroupView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<GameObject> m_DescriptionObject /* None */,
    PPtr<TextMeshProUGUI> m_Description /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<TextureSelectorItemView> m_ItemPrefab /* None */,
    int m_ItemsPerRow /* None */)
{
    public static TextureSelectorGroupView Read(EndianBinaryReader reader)
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
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_DescriptionObject,
            _m_Description,
            _m_WidgetList,
            _m_ItemPrefab,
            _m_ItemsPerRow);
    }
}

