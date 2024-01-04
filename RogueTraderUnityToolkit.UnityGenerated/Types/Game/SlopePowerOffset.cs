namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SlopePowerOffset (8 fields) EDB85545E688EF1486711C8A876714BA/E4F9802E3E941BA2112918EAD1E66A8F */
public record class SlopePowerOffset(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    Vector4Parameter slope /* NeedsAlign */,
    Vector4Parameter power /* NeedsAlign */,
    Vector4Parameter offset /* NeedsAlign */)
{
    public static SlopePowerOffset Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* slope */
        Vector4Parameter _slope = Vector4Parameter.Read(reader);
        reader.AlignTo(4); /* power */
        Vector4Parameter _power = Vector4Parameter.Read(reader);
        reader.AlignTo(4); /* offset */
        Vector4Parameter _offset = Vector4Parameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _slope,
            _power,
            _offset);
    }
}

