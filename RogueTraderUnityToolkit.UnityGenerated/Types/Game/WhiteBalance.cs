namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WhiteBalance (7 fields) 6979FBB9D4C1508A00C7C0A6814CCF73/9968B466D892E8E723BEC1D0A89FA6D6 */
public record class WhiteBalance(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    ClampedFloatParameter temperature /* NeedsAlign */,
    ClampedFloatParameter tint /* NeedsAlign */)
{
    public static WhiteBalance Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* temperature */
        ClampedFloatParameter _temperature = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* tint */
        ClampedFloatParameter _tint = ClampedFloatParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _temperature,
            _tint);
    }
}

