namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DelayedSlider (10 fields) D35B5FBE0D35102B344A26DBFA98FE04/E4058C171D6D86C16326A15BA4736012 */
public record class DelayedSlider(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Slider> m_MainSlider /* NeedsAlign */,
    PPtr<Image> m_RangedImage /* None */,
    ColorRGBA m_PositiveDeltaColor /* None */,
    ColorRGBA m_NegativeDeltaColor /* None */,
    float m_DeltaShowDelay /* None */,
    float m_DeltaMoveTime /* None */)
{
    public static DelayedSlider Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainSlider */
        PPtr<Slider> _m_MainSlider = PPtr<Slider>.Read(reader);
        PPtr<Image> _m_RangedImage = PPtr<Image>.Read(reader);
        ColorRGBA _m_PositiveDeltaColor = ColorRGBA.Read(reader);
        ColorRGBA _m_NegativeDeltaColor = ColorRGBA.Read(reader);
        float _m_DeltaShowDelay = reader.ReadF32();
        float _m_DeltaMoveTime = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainSlider,
            _m_RangedImage,
            _m_PositiveDeltaColor,
            _m_NegativeDeltaColor,
            _m_DeltaShowDelay,
            _m_DeltaMoveTime);
    }
}

