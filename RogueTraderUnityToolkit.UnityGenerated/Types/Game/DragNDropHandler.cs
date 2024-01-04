namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DragNDropHandler (8 fields) AEBA43E22A124F678AC1A08E6056B99D/C664DE313F2FF9EA43A7F071A13C5A3B */
public record class DragNDropHandler(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_CountLabel /* None */,
    Vector2f m_DragImageSize /* None */,
    byte CanDrag /* None */)
{
    public static DragNDropHandler Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CountLabel = PPtr<TextMeshProUGUI>.Read(reader);
        Vector2f _m_DragImageSize = Vector2f.Read(reader);
        byte _CanDrag = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_CountLabel,
            _m_DragImageSize,
            _CanDrag);
    }
}

