namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RadialBlur (8 fields) 5A9FC5AE1AA54C5EC62FF589304C09F4/C2C34627D81593E775C9AB51F38BA651 */
public record class RadialBlur(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    MinFloatParameter Width /* NeedsAlign */,
    MinFloatParameter Strength /* NeedsAlign */,
    Vector2Parameter Center /* NeedsAlign */)
{
    public static RadialBlur Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* Width */
        MinFloatParameter _Width = MinFloatParameter.Read(reader);
        reader.AlignTo(4); /* Strength */
        MinFloatParameter _Strength = MinFloatParameter.Read(reader);
        reader.AlignTo(4); /* Center */
        Vector2Parameter _Center = Vector2Parameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _Width,
            _Strength,
            _Center);
    }
}

