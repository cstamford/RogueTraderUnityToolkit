namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SoftMaskScript (12 fields) DBEEA5D1AA38D52769A8005D8E3A1D69/DF3EB2D4C6B666B731DB53D5C7F3DB5A */
public record class SoftMaskScript(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> MaskArea /* NeedsAlign */,
    PPtr<RectTransform> maskScalingRect /* None */,
    PPtr<Texture> AlphaMask /* None */,
    float CutOff /* None */,
    byte HardBlend /* None */,
    byte FlipAlphaMask /* NeedsAlign */,
    byte DontClipMaskScalingRect /* NeedsAlign */,
    byte CascadeToALLChildren /* NeedsAlign */)
{
    public static SoftMaskScript Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* MaskArea */
        PPtr<RectTransform> _MaskArea = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _maskScalingRect = PPtr<RectTransform>.Read(reader);
        PPtr<Texture> _AlphaMask = PPtr<Texture>.Read(reader);
        float _CutOff = reader.ReadF32();
        byte _HardBlend = reader.ReadU8();
        reader.AlignTo(4); /* FlipAlphaMask */
        byte _FlipAlphaMask = reader.ReadU8();
        reader.AlignTo(4); /* DontClipMaskScalingRect */
        byte _DontClipMaskScalingRect = reader.ReadU8();
        reader.AlignTo(4); /* CascadeToALLChildren */
        byte _CascadeToALLChildren = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _MaskArea,
            _maskScalingRect,
            _AlphaMask,
            _CutOff,
            _HardBlend,
            _FlipAlphaMask,
            _DontClipMaskScalingRect,
            _CascadeToALLChildren);
    }
}

