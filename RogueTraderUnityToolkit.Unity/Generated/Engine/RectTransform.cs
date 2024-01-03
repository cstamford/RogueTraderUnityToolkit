namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $RectTransform (11 fields) (IsEngineType) */
public record class RectTransform(
    PPtr<GameObject> m_GameObject,
    Quaternionf m_LocalRotation,
    Vector3f m_LocalPosition,
    Vector3f m_LocalScale,
    PPtr<Transform>[] m_Children,
    PPtr<Transform> m_Father,
    Vector2f m_AnchorMin,
    Vector2f m_AnchorMax,
    Vector2f m_AnchoredPosition,
    Vector2f m_SizeDelta,
    Vector2f m_Pivot)
{
    public static RectTransform Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        Quaternionf m_LocalRotation = Quaternionf.Read(reader);
        Vector3f m_LocalPosition = Vector3f.Read(reader);
        Vector3f m_LocalScale = Vector3f.Read(reader);
        PPtr<Transform>[] m_Children = Array<PPtr<Transform>>.Read(reader);
        PPtr<Transform> m_Father = PPtr<Transform>.Read(reader);
        Vector2f m_AnchorMin = Vector2f.Read(reader);
        Vector2f m_AnchorMax = Vector2f.Read(reader);
        Vector2f m_AnchoredPosition = Vector2f.Read(reader);
        Vector2f m_SizeDelta = Vector2f.Read(reader);
        Vector2f m_Pivot = Vector2f.Read(reader);
        
        return new(m_GameObject,
            m_LocalRotation,
            m_LocalPosition,
            m_LocalScale,
            m_Children,
            m_Father,
            m_AnchorMin,
            m_AnchorMax,
            m_AnchoredPosition,
            m_SizeDelta,
            m_Pivot);
    }
}

