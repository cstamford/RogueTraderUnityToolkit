namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $Animator (13 fields) (IsEngineType) */
public record class Animator(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    PPtr<Avatar> m_Avatar,
    PPtr<RuntimeAnimatorController> m_Controller,
    int m_CullingMode,
    int m_UpdateMode,
    bool m_ApplyRootMotion,
    bool m_LinearVelocityBlending,
    bool m_StabilizeFeet,
    bool m_HasTransformHierarchy,
    bool m_AllowConstantClipSamplingOptimization,
    bool m_KeepAnimatorStateOnDisable,
    bool m_WriteDefaultValuesOnDisable)
{
    public static Animator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        PPtr<Avatar> m_Avatar = PPtr<Avatar>.Read(reader);
        PPtr<RuntimeAnimatorController> m_Controller = PPtr<RuntimeAnimatorController>.Read(reader);
        int m_CullingMode = reader.ReadS32();
        int m_UpdateMode = reader.ReadS32();
        bool m_ApplyRootMotion = reader.ReadBool();
        bool m_LinearVelocityBlending = reader.ReadBool();
        bool m_StabilizeFeet = reader.ReadBool();
        bool m_HasTransformHierarchy = reader.ReadBool();
        bool m_AllowConstantClipSamplingOptimization = reader.ReadBool();
        bool m_KeepAnimatorStateOnDisable = reader.ReadBool();
        bool m_WriteDefaultValuesOnDisable = reader.ReadBool();
        
        return new(m_GameObject,
            m_Enabled,
            m_Avatar,
            m_Controller,
            m_CullingMode,
            m_UpdateMode,
            m_ApplyRootMotion,
            m_LinearVelocityBlending,
            m_StabilizeFeet,
            m_HasTransformHierarchy,
            m_AllowConstantClipSamplingOptimization,
            m_KeepAnimatorStateOnDisable,
            m_WriteDefaultValuesOnDisable);
    }
}

