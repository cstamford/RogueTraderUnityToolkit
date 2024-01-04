namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LocalMapLegendBlockItemView (6 fields) 0B2AB27CCF89B24E9DA566CED062F177/1F22BCE7FCDC919C4253B1C160170023 */
public record class LocalMapLegendBlockItemView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_ItemImage /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_ItemLabel /* None */)
{
    public static LocalMapLegendBlockItemView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ItemImage */
        PPtr<Image> _m_ItemImage = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ItemLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ItemImage,
            _m_ItemLabel);
    }
}

