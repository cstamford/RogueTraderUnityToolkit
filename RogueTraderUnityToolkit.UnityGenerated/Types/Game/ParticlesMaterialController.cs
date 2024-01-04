namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ParticlesMaterialController (13 fields) F086927E46C9CAA57D53A126AFE87D88/1462D9E754889FA5F2AB963EF0385821 */
public record class ParticlesMaterialController(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Texture2D> TexColorAlphaRamp /* NeedsAlign */,
    PPtr<Texture2D> TexTrailColorRamp /* None */,
    int m_TypeUpdate /* None */,
    int m_TrailTypeUpdate /* None */,
    Gradient ColorAlphaRamp /* None */,
    Gradient TrailColorAlphaRamp /* NeedsAlign */,
    byte RandomizeNoiseUv /* NeedsAlign */,
    byte RandomizeColorRampOffset /* NeedsAlign */,
    byte UnscaledTime /* NeedsAlign */)
{
    public static ParticlesMaterialController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* TexColorAlphaRamp */
        PPtr<Texture2D> _TexColorAlphaRamp = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _TexTrailColorRamp = PPtr<Texture2D>.Read(reader);
        int _m_TypeUpdate = reader.ReadS32();
        int _m_TrailTypeUpdate = reader.ReadS32();
        Gradient _ColorAlphaRamp = Gradient.Read(reader);
        reader.AlignTo(4); /* TrailColorAlphaRamp */
        Gradient _TrailColorAlphaRamp = Gradient.Read(reader);
        reader.AlignTo(4); /* RandomizeNoiseUv */
        byte _RandomizeNoiseUv = reader.ReadU8();
        reader.AlignTo(4); /* RandomizeColorRampOffset */
        byte _RandomizeColorRampOffset = reader.ReadU8();
        reader.AlignTo(4); /* UnscaledTime */
        byte _UnscaledTime = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _TexColorAlphaRamp,
            _TexTrailColorRamp,
            _m_TypeUpdate,
            _m_TrailTypeUpdate,
            _ColorAlphaRamp,
            _TrailColorAlphaRamp,
            _RandomizeNoiseUv,
            _RandomizeColorRampOffset,
            _UnscaledTime);
    }
}

