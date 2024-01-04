namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FogOfWarRevealerTrigger (16 fields) 92C43C3D0846831546805D86D675043E/7326AB2A2A03F791033E3D8E71ED1F06 */
public record class FogOfWarRevealerTrigger(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsInGame /* NeedsAlign */,
    AsciiString UniqueId /* NeedsAlign */,
    byte ProceduralAnimate /* NeedsAlign */,
    byte Animated /* NeedsAlign */,
    PPtr<Animator>[] Animators /* NeedsAlign */,
    AsciiString TriggerName /* None */,
    AsciiString AgroLayer /* NeedsAlign */,
    PPtr<FogOfWarRevealerSettings>[] revealers /* NeedsAlign */,
    float ProceduralAnimationScaleSpeed /* None */,
    float ProceduralAnimationScaleLimit /* None */,
    float ProceduralAnimationScaleStep /* None */,
    byte KeepRevealerAliveAfterAnimation /* None */)
{
    public static FogOfWarRevealerTrigger Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IsInGame */
        byte _m_IsInGame = reader.ReadU8();
        reader.AlignTo(4); /* UniqueId */
        AsciiString _UniqueId = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ProceduralAnimate */
        byte _ProceduralAnimate = reader.ReadU8();
        reader.AlignTo(4); /* Animated */
        byte _Animated = reader.ReadU8();
        reader.AlignTo(4); /* Animators */
        PPtr<Animator>[] _Animators = BuiltInArray<PPtr<Animator>>.Read(reader);
        AsciiString _TriggerName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* AgroLayer */
        AsciiString _AgroLayer = BuiltInString.Read(reader);
        reader.AlignTo(4); /* revealers */
        PPtr<FogOfWarRevealerSettings>[] _revealers = BuiltInArray<PPtr<FogOfWarRevealerSettings>>.Read(reader);
        float _ProceduralAnimationScaleSpeed = reader.ReadF32();
        float _ProceduralAnimationScaleLimit = reader.ReadF32();
        float _ProceduralAnimationScaleStep = reader.ReadF32();
        byte _KeepRevealerAliveAfterAnimation = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsInGame,
            _UniqueId,
            _ProceduralAnimate,
            _Animated,
            _Animators,
            _TriggerName,
            _AgroLayer,
            _revealers,
            _ProceduralAnimationScaleSpeed,
            _ProceduralAnimationScaleLimit,
            _ProceduralAnimationScaleStep,
            _KeepRevealerAliveAfterAnimation);
    }
}

