namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $Animation (8 fields) (IsEngineType) */
public record class Animation(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    PPtr<AnimationClip> m_Animation,
    PPtr<AnimationClip>[] m_Animations,
    int m_WrapMode,
    bool m_PlayAutomatically,
    bool m_AnimatePhysics,
    int m_CullingType)
{
    public static Animation Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        PPtr<AnimationClip> m_Animation = PPtr<AnimationClip>.Read(reader);
        PPtr<AnimationClip>[] m_Animations = Array<PPtr<AnimationClip>>.Read(reader);
        int m_WrapMode = reader.ReadS32();
        bool m_PlayAutomatically = reader.ReadBool();
        bool m_AnimatePhysics = reader.ReadBool();
        int m_CullingType = reader.ReadS32();
        
        return new(m_GameObject,
            m_Enabled,
            m_Animation,
            m_Animations,
            m_WrapMode,
            m_PlayAutomatically,
            m_AnimatePhysics,
            m_CullingType);
    }
}

