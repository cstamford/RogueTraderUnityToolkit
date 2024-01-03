namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $PlayableDirector (9 fields) (IsEngineType) */
public record class PlayableDirector(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    PPtr<Object> m_PlayableAsset,
    int m_InitialState,
    int m_WrapMode,
    int m_DirectorUpdateMode,
    double m_InitialTime,
    DirectorGenericBinding[] m_SceneBindings,
    ExposedReferenceTable m_ExposedReferences)
{
    public static PlayableDirector Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        PPtr<Object> m_PlayableAsset = PPtr<Object>.Read(reader);
        int m_InitialState = reader.ReadS32();
        int m_WrapMode = reader.ReadS32();
        int m_DirectorUpdateMode = reader.ReadS32();
        double m_InitialTime = reader.ReadF64();
        DirectorGenericBinding[] m_SceneBindings = Array<DirectorGenericBinding>.Read(reader);
        ExposedReferenceTable m_ExposedReferences = ExposedReferenceTable.Read(reader);
        
        return new(m_GameObject,
            m_Enabled,
            m_PlayableAsset,
            m_InitialState,
            m_WrapMode,
            m_DirectorUpdateMode,
            m_InitialTime,
            m_SceneBindings,
            m_ExposedReferences);
    }
}

