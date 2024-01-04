namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Transform (6 fields) 0859EF55586068C69197937FE65096F5 */
public record class Transform(
    PPtr<GameObject> m_GameObject /* None */,
    Quaternionf m_LocalRotation /* None */,
    Vector3f m_LocalPosition /* None */,
    Vector3f m_LocalScale /* None */,
    PPtr<Transform>[] m_Children /* NeedsAlign */,
    PPtr<Transform> m_Father /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(140111701, 1482713286, 2442630015, 3864041205);
    public static Transform Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        Quaternionf _m_LocalRotation = Quaternionf.Read(reader);
        Vector3f _m_LocalPosition = Vector3f.Read(reader);
        Vector3f _m_LocalScale = Vector3f.Read(reader);
        reader.AlignTo(4); /* m_Children */
        PPtr<Transform>[] _m_Children = BuiltInArray<PPtr<Transform>>.Read(reader);
        reader.AlignTo(4); /* m_Father */
        PPtr<Transform> _m_Father = PPtr<Transform>.Read(reader);
        
        return new(_m_GameObject,
            _m_LocalRotation,
            _m_LocalPosition,
            _m_LocalScale,
            _m_Children,
            _m_Father);
    }
}

