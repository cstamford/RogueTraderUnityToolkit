namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $RectTransform (11 fields) FA41C0F096F995631A4D8B0C878F41B9 */
public record class RectTransform(
    PPtr<GameObject> m_GameObject /* None */,
    Quaternionf m_LocalRotation /* None */,
    Vector3f m_LocalPosition /* None */,
    Vector3f m_LocalScale /* None */,
    PPtr<Transform>[] m_Children /* NeedsAlign */,
    PPtr<Transform> m_Father /* NeedsAlign */,
    Vector2f m_AnchorMin /* None */,
    Vector2f m_AnchorMax /* None */,
    Vector2f m_AnchoredPosition /* None */,
    Vector2f m_SizeDelta /* None */,
    Vector2f m_Pivot /* None */) : IUnityObject
{
    public static Hash128 Hash => new(4198613232, 2532939107, 441289484, 2274312633);
    public static RectTransform Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        Quaternionf _m_LocalRotation = Quaternionf.Read(reader);
        Vector3f _m_LocalPosition = Vector3f.Read(reader);
        Vector3f _m_LocalScale = Vector3f.Read(reader);
        reader.AlignTo(4); /* m_Children */
        PPtr<Transform>[] _m_Children = BuiltInArray<PPtr<Transform>>.Read(reader);
        reader.AlignTo(4); /* m_Father */
        PPtr<Transform> _m_Father = PPtr<Transform>.Read(reader);
        Vector2f _m_AnchorMin = Vector2f.Read(reader);
        Vector2f _m_AnchorMax = Vector2f.Read(reader);
        Vector2f _m_AnchoredPosition = Vector2f.Read(reader);
        Vector2f _m_SizeDelta = Vector2f.Read(reader);
        Vector2f _m_Pivot = Vector2f.Read(reader);
        
        return new(_m_GameObject,
            _m_LocalRotation,
            _m_LocalPosition,
            _m_LocalScale,
            _m_Children,
            _m_Father,
            _m_AnchorMin,
            _m_AnchorMax,
            _m_AnchoredPosition,
            _m_SizeDelta,
            _m_Pivot);
    }
}

