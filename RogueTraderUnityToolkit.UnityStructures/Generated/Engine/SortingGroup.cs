namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $SortingGroup (6 fields) (IsEngineType) */
public record class SortingGroup(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    int m_SortingLayerID,
    short m_SortingLayer,
    short m_SortingOrder,
    bool m_SortAtRoot)
{
    public static SortingGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        int m_SortingLayerID = reader.ReadS32();
        short m_SortingLayer = reader.ReadS16();
        short m_SortingOrder = reader.ReadS16();
        bool m_SortAtRoot = reader.ReadBool();
        
        return new(m_GameObject,
            m_Enabled,
            m_SortingLayerID,
            m_SortingLayer,
            m_SortingOrder,
            m_SortAtRoot);
    }
}

