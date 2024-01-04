namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UIFlippable (6 fields) 9447186854F86AADBB00F5938F0B8F0D/CF00DD4A571D023254178696DA140B38 */
public record class UIFlippable(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_Horizontal /* NeedsAlign */,
    byte m_Veritical /* NeedsAlign */)
{
    public static UIFlippable Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Horizontal */
        byte _m_Horizontal = reader.ReadU8();
        reader.AlignTo(4); /* m_Veritical */
        byte _m_Veritical = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Horizontal,
            _m_Veritical);
    }
}

