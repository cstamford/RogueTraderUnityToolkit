namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AdditionalSlider (6 fields) D8E51E7759036626DC578BDB43AA9134/C8B4A23594DB7D2B0A0953C1AB5F47BE */
public record class AdditionalSlider(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Slider> m_MainSlider /* NeedsAlign */,
    PPtr<Image> m_RangedImage /* None */)
{
    public static AdditionalSlider Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainSlider */
        PPtr<Slider> _m_MainSlider = PPtr<Slider>.Read(reader);
        PPtr<Image> _m_RangedImage = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainSlider,
            _m_RangedImage);
    }
}

