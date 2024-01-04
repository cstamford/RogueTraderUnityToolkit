namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BackgroundComposerStandAlone (8 fields) BAB22F99052FFA1A4E3B21133158F878/44AC1E2A18F6A559A7D27BDD46F94FEF */
public record class BackgroundComposerStandAlone(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Material> m_DefaultSkyDomeMaterial /* NeedsAlign */,
    float m_SkyDomeScale /* None */,
    float m_CommonFadeOverride /* None */,
    PPtr<BoxCollider> m_FogOverrideCollider /* None */)
{
    public static BackgroundComposerStandAlone Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_DefaultSkyDomeMaterial */
        PPtr<Material> _m_DefaultSkyDomeMaterial = PPtr<Material>.Read(reader);
        float _m_SkyDomeScale = reader.ReadF32();
        float _m_CommonFadeOverride = reader.ReadF32();
        PPtr<BoxCollider> _m_FogOverrideCollider = PPtr<BoxCollider>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_DefaultSkyDomeMaterial,
            _m_SkyDomeScale,
            _m_CommonFadeOverride,
            _m_FogOverrideCollider);
    }
}

