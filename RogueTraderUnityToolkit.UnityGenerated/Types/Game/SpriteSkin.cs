namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpriteSkin (9 fields) F57B00746E30C415B3344956DB2B2368/76D737D4F42140589B1F130011F4A57D */
public record class SpriteSkin(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Transform> m_RootBone /* NeedsAlign */,
    PPtr<Transform>[] m_BoneTransforms /* None */,
    AABB m_Bounds /* None */,
    byte m_AlwaysUpdate /* None */,
    byte m_AutoRebind /* NeedsAlign */)
{
    public static SpriteSkin Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RootBone */
        PPtr<Transform> _m_RootBone = PPtr<Transform>.Read(reader);
        PPtr<Transform>[] _m_BoneTransforms = BuiltInArray<PPtr<Transform>>.Read(reader);
        AABB _m_Bounds = AABB.Read(reader);
        byte _m_AlwaysUpdate = reader.ReadU8();
        reader.AlignTo(4); /* m_AutoRebind */
        byte _m_AutoRebind = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_RootBone,
            _m_BoneTransforms,
            _m_Bounds,
            _m_AlwaysUpdate,
            _m_AutoRebind);
    }
}

