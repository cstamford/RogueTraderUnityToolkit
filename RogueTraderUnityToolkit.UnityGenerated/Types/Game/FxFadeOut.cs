namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FxFadeOut (10 fields) 569376CEDA0DBF903DDF962584DEF57F/0A05AE6F1195B1499E7BFB3A91D45B13 */
public record class FxFadeOut(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float Duration /* NeedsAlign */,
    byte VFXGraphStopEmission /* None */,
    byte StartForceFadeOut /* NeedsAlign */,
    PPtr<ParticleSystem>[] StopParticlesEmission /* NeedsAlign */,
    CustomMaterialPropertyData[] m_CustomMaterialProperties /* None */,
    byte m_IgnoreExternalOpacitySources /* NeedsAlign */)
{
    public static FxFadeOut Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Duration */
        float _Duration = reader.ReadF32();
        byte _VFXGraphStopEmission = reader.ReadU8();
        reader.AlignTo(4); /* StartForceFadeOut */
        byte _StartForceFadeOut = reader.ReadU8();
        reader.AlignTo(4); /* StopParticlesEmission */
        PPtr<ParticleSystem>[] _StopParticlesEmission = BuiltInArray<PPtr<ParticleSystem>>.Read(reader);
        CustomMaterialPropertyData[] _m_CustomMaterialProperties = BuiltInArray<CustomMaterialPropertyData>.Read(reader);
        reader.AlignTo(4); /* m_IgnoreExternalOpacitySources */
        byte _m_IgnoreExternalOpacitySources = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Duration,
            _VFXGraphStopEmission,
            _StartForceFadeOut,
            _StopParticlesEmission,
            _m_CustomMaterialProperties,
            _m_IgnoreExternalOpacitySources);
    }
}

