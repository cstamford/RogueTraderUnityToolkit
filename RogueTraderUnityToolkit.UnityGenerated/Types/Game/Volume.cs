namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Volume (9 fields) D43C7B73A82BA1E6E22FDBD903F214B6/F246C01DE6D64383A01BB48BE4D4A013 */
public record class Volume(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsGlobal /* NeedsAlign */,
    float priority /* NeedsAlign */,
    float blendDistance /* None */,
    float weight /* None */,
    PPtr<VolumeProfile> sharedProfile /* None */)
{
    public static Volume Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IsGlobal */
        byte _m_IsGlobal = reader.ReadU8();
        reader.AlignTo(4); /* priority */
        float _priority = reader.ReadF32();
        float _blendDistance = reader.ReadF32();
        float _weight = reader.ReadF32();
        PPtr<VolumeProfile> _sharedProfile = PPtr<VolumeProfile>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsGlobal,
            _priority,
            _blendDistance,
            _weight,
            _sharedProfile);
    }
}

