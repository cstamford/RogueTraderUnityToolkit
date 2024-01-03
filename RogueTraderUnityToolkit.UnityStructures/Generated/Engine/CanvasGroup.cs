namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $CanvasGroup (6 fields) (IsEngineType) */
public record class CanvasGroup(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    float m_Alpha,
    bool m_Interactable,
    bool m_BlocksRaycasts,
    bool m_IgnoreParentGroups)
{
    public static CanvasGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        float m_Alpha = reader.ReadF32();
        bool m_Interactable = reader.ReadBool();
        bool m_BlocksRaycasts = reader.ReadBool();
        bool m_IgnoreParentGroups = reader.ReadBool();
        
        return new(m_GameObject,
            m_Enabled,
            m_Alpha,
            m_Interactable,
            m_BlocksRaycasts,
            m_IgnoreParentGroups);
    }
}

