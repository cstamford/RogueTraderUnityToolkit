namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemResourceItem (7 fields) 5BB0A3E3ACFAE5FB15F3F00361E7B5AB/4B21ECBBF0D57EB729EFBDF30E436952 */
public record class SystemResourceItem(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_ItemIcon /* NeedsAlign */,
    PPtr<Sprite> m_UnknownItem /* None */,
    PPtr<TextMeshProUGUI> m_ItemLabel /* None */)
{
    public static SystemResourceItem Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ItemIcon */
        PPtr<Image> _m_ItemIcon = PPtr<Image>.Read(reader);
        PPtr<Sprite> _m_UnknownItem = PPtr<Sprite>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ItemLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ItemIcon,
            _m_UnknownItem,
            _m_ItemLabel);
    }
}

