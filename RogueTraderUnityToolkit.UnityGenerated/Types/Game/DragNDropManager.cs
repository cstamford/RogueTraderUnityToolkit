namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DragNDropManager (6 fields) 856D3CC7AE439D66657AA0BB5FCBDF91/DAA6B7DF1A90CE0FE6F4BC7DACDAFDDA */
public record class DragNDropManager(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> Icon /* NeedsAlign */,
    PPtr<TextMeshProUGUI> Count /* None */)
{
    public static DragNDropManager Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Icon */
        PPtr<Image> _Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _Count = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Icon,
            _Count);
    }
}

