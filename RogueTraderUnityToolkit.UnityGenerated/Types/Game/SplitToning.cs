namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SplitToning (8 fields) 9C8B371CA918C3E43B19F43E40D7BFAB/7160AD5F9652B5C68417303C25859875 */
public record class SplitToning(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    ColorParameter shadows /* NeedsAlign */,
    ColorParameter highlights /* NeedsAlign */,
    ClampedFloatParameter balance /* NeedsAlign */)
{
    public static SplitToning Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* shadows */
        ColorParameter _shadows = ColorParameter.Read(reader);
        reader.AlignTo(4); /* highlights */
        ColorParameter _highlights = ColorParameter.Read(reader);
        reader.AlignTo(4); /* balance */
        ClampedFloatParameter _balance = ClampedFloatParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _shadows,
            _highlights,
            _balance);
    }
}

