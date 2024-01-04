namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $LODGroup (8 fields) 222071680371689287B490B6347897EB */
public record class LODGroup(
    PPtr<GameObject> m_GameObject /* None */,
    Vector3f m_LocalReferencePoint /* None */,
    float m_Size /* None */,
    int m_FadeMode /* None */,
    bool m_AnimateCrossFading /* None */,
    bool m_LastLODIsBillboard /* None */,
    LOD[] m_LODs /* NeedsAlign */,
    bool m_Enabled /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(572551528, 57763986, 2276757686, 880318443);
    public static LODGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        Vector3f _m_LocalReferencePoint = Vector3f.Read(reader);
        float _m_Size = reader.ReadF32();
        int _m_FadeMode = reader.ReadS32();
        bool _m_AnimateCrossFading = reader.ReadBool();
        bool _m_LastLODIsBillboard = reader.ReadBool();
        reader.AlignTo(4); /* m_LODs */
        LOD[] _m_LODs = BuiltInArray<LOD>.Read(reader);
        reader.AlignTo(4); /* m_Enabled */
        bool _m_Enabled = reader.ReadBool();
        
        return new(_m_GameObject,
            _m_LocalReferencePoint,
            _m_Size,
            _m_FadeMode,
            _m_AnimateCrossFading,
            _m_LastLODIsBillboard,
            _m_LODs,
            _m_Enabled);
    }
}

