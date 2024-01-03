namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $Transform (6 fields) (IsEngineType) */
public record class Transform(
    PPtr<GameObject> m_GameObject,
    Quaternionf m_LocalRotation,
    Vector3f m_LocalPosition,
    Vector3f m_LocalScale,
    PPtr<Transform>[] m_Children,
    PPtr<Transform> m_Father)
{
    public static Transform Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        Quaternionf m_LocalRotation = Quaternionf.Read(reader);
        Vector3f m_LocalPosition = Vector3f.Read(reader);
        Vector3f m_LocalScale = Vector3f.Read(reader);
        PPtr<Transform>[] m_Children = Array<PPtr<Transform>>.Read(reader);
        PPtr<Transform> m_Father = PPtr<Transform>.Read(reader);
        
        return new(m_GameObject,
            m_LocalRotation,
            m_LocalPosition,
            m_LocalScale,
            m_Children,
            m_Father);
    }
}

