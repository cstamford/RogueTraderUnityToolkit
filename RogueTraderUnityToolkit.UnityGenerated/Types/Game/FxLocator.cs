namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FxLocator (8 fields) 4A74CC9B273F1712D63CE10D9DEDFA6E/D95BB496C3622024631C19E481487D7A */
public record class FxLocator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Reference m_Group /* NeedsAlign */,
    PPtr<SnapMapBase> particleMap /* NeedsAlign */,
    FxBone Data /* None */,
    PPtr<CharacterFxBonesMap> bonesMap /* NeedsAlign */)
{
    public static FxLocator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Group */
        Reference _m_Group = Reference.Read(reader);
        reader.AlignTo(4); /* particleMap */
        PPtr<SnapMapBase> _particleMap = PPtr<SnapMapBase>.Read(reader);
        FxBone _Data = FxBone.Read(reader);
        reader.AlignTo(4); /* bonesMap */
        PPtr<CharacterFxBonesMap> _bonesMap = PPtr<CharacterFxBonesMap>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Group,
            _particleMap,
            _Data,
            _bonesMap);
    }
}

