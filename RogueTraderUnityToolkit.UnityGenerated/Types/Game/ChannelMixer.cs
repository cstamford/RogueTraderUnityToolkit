namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ChannelMixer (14 fields) 6386F3F53868349EB227542C541717C0/C81739E205B86FE9398A37357DC3007A */
public record class ChannelMixer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    ClampedFloatParameter redOutRedIn /* NeedsAlign */,
    ClampedFloatParameter redOutGreenIn /* NeedsAlign */,
    ClampedFloatParameter redOutBlueIn /* NeedsAlign */,
    ClampedFloatParameter greenOutRedIn /* NeedsAlign */,
    ClampedFloatParameter greenOutGreenIn /* NeedsAlign */,
    ClampedFloatParameter greenOutBlueIn /* NeedsAlign */,
    ClampedFloatParameter blueOutRedIn /* NeedsAlign */,
    ClampedFloatParameter blueOutGreenIn /* NeedsAlign */,
    ClampedFloatParameter blueOutBlueIn /* NeedsAlign */)
{
    public static ChannelMixer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* redOutRedIn */
        ClampedFloatParameter _redOutRedIn = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* redOutGreenIn */
        ClampedFloatParameter _redOutGreenIn = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* redOutBlueIn */
        ClampedFloatParameter _redOutBlueIn = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* greenOutRedIn */
        ClampedFloatParameter _greenOutRedIn = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* greenOutGreenIn */
        ClampedFloatParameter _greenOutGreenIn = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* greenOutBlueIn */
        ClampedFloatParameter _greenOutBlueIn = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* blueOutRedIn */
        ClampedFloatParameter _blueOutRedIn = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* blueOutGreenIn */
        ClampedFloatParameter _blueOutGreenIn = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* blueOutBlueIn */
        ClampedFloatParameter _blueOutBlueIn = ClampedFloatParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _redOutRedIn,
            _redOutGreenIn,
            _redOutBlueIn,
            _greenOutRedIn,
            _greenOutGreenIn,
            _greenOutBlueIn,
            _blueOutRedIn,
            _blueOutGreenIn,
            _blueOutBlueIn);
    }
}

