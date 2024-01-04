namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Animation (8 fields) 6EACAB9E81FE6FC68388008E1BCC8F72 */
public record class Animation(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<AnimationClip> m_Animation /* NeedsAlign */,
    PPtr<AnimationClip>[] m_Animations /* None */,
    int m_WrapMode /* NeedsAlign */,
    bool m_PlayAutomatically /* None */,
    bool m_AnimatePhysics /* None */,
    int m_CullingType /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(1856809886, 2180935622, 2206728334, 466390898);
    public static Animation Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Animation */
        PPtr<AnimationClip> _m_Animation = PPtr<AnimationClip>.Read(reader);
        PPtr<AnimationClip>[] _m_Animations = BuiltInArray<PPtr<AnimationClip>>.Read(reader);
        reader.AlignTo(4); /* m_WrapMode */
        int _m_WrapMode = reader.ReadS32();
        bool _m_PlayAutomatically = reader.ReadBool();
        bool _m_AnimatePhysics = reader.ReadBool();
        reader.AlignTo(4); /* m_CullingType */
        int _m_CullingType = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Animation,
            _m_Animations,
            _m_WrapMode,
            _m_PlayAutomatically,
            _m_AnimatePhysics,
            _m_CullingType);
    }
}

