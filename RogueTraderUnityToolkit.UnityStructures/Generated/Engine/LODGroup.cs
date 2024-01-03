namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $LODGroup (8 fields) (IsEngineType) */
public record class LODGroup(
    PPtr<GameObject> m_GameObject,
    Vector3f m_LocalReferencePoint,
    float m_Size,
    int m_FadeMode,
    bool m_AnimateCrossFading,
    bool m_LastLODIsBillboard,
    LOD[] m_LODs,
    bool m_Enabled)
{
    public static LODGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        Vector3f m_LocalReferencePoint = Vector3f.Read(reader);
        float m_Size = reader.ReadF32();
        int m_FadeMode = reader.ReadS32();
        bool m_AnimateCrossFading = reader.ReadBool();
        bool m_LastLODIsBillboard = reader.ReadBool();
        LOD[] m_LODs = Array<LOD>.Read(reader);
        bool m_Enabled = reader.ReadBool();
        
        return new(m_GameObject,
            m_LocalReferencePoint,
            m_Size,
            m_FadeMode,
            m_AnimateCrossFading,
            m_LastLODIsBillboard,
            m_LODs,
            m_Enabled);
    }
}

