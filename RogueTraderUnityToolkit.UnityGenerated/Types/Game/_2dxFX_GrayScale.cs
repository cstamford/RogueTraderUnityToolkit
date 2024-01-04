namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $_2dxFX_GrayScale (8 fields) 42AE22F46A96E45A8E96E6FC81D8BC32/B376CB6D15317B27FCC5F172EBE60C23 */
public record class _2dxFX_GrayScale(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Material> ForceMaterial /* NeedsAlign */,
    PPtr<Shader> m_Shader /* None */,
    float m_Alpha /* None */,
    float m_EffectAmount /* None */)
{
    public static _2dxFX_GrayScale Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ForceMaterial */
        PPtr<Material> _ForceMaterial = PPtr<Material>.Read(reader);
        PPtr<Shader> _m_Shader = PPtr<Shader>.Read(reader);
        float _m_Alpha = reader.ReadF32();
        float _m_EffectAmount = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _ForceMaterial,
            _m_Shader,
            _m_Alpha,
            _m_EffectAmount);
    }
}

