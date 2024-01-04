namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BackgroundBlurWithFade (6 fields) 1B13407C7E5CFAA5D2DBD952D9744B38/4D1EF78246FFA9DB24678EE82686CD63 */
public record class BackgroundBlurWithFade(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float m_BlurSize /* NeedsAlign */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */)
{
    public static BackgroundBlurWithFade Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_BlurSize */
        float _m_BlurSize = reader.ReadF32();
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_BlurSize,
            _m_FadeAnimator);
    }
}

