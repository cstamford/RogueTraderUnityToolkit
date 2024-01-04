namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RangedSlider (9 fields) 09FE09F43F30A35583284925C13065ED/013DDD43CD16E9A916D2533ECD3485C4 */
public record class RangedSlider(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Slider> m_MainSlider /* NeedsAlign */,
    PPtr<Image> m_RangedImage /* None */,
    ColorRGBA m_ColorStart /* None */,
    ColorRGBA m_ColorEnd /* None */,
    float m_BlinkDuration /* None */)
{
    public static RangedSlider Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainSlider */
        PPtr<Slider> _m_MainSlider = PPtr<Slider>.Read(reader);
        PPtr<Image> _m_RangedImage = PPtr<Image>.Read(reader);
        ColorRGBA _m_ColorStart = ColorRGBA.Read(reader);
        ColorRGBA _m_ColorEnd = ColorRGBA.Read(reader);
        float _m_BlinkDuration = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainSlider,
            _m_RangedImage,
            _m_ColorStart,
            _m_ColorEnd,
            _m_BlinkDuration);
    }
}

