namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Animator (13 fields) 63C77A158D0E4404365B94D21CD949B0 */
public record class Animator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<Avatar> m_Avatar /* NeedsAlign */,
    PPtr<RuntimeAnimatorController> m_Controller /* None */,
    int m_CullingMode /* None */,
    int m_UpdateMode /* None */,
    bool m_ApplyRootMotion /* None */,
    bool m_LinearVelocityBlending /* None */,
    bool m_StabilizeFeet /* None */,
    bool m_HasTransformHierarchy /* NeedsAlign */,
    bool m_AllowConstantClipSamplingOptimization /* None */,
    bool m_KeepAnimatorStateOnDisable /* None */,
    bool m_WriteDefaultValuesOnDisable /* None */) : IUnityObject
{
    public static Hash128 Hash => new(1674017301, 2366522372, 911971538, 484002224);
    public static Animator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Avatar */
        PPtr<Avatar> _m_Avatar = PPtr<Avatar>.Read(reader);
        PPtr<RuntimeAnimatorController> _m_Controller = PPtr<RuntimeAnimatorController>.Read(reader);
        int _m_CullingMode = reader.ReadS32();
        int _m_UpdateMode = reader.ReadS32();
        bool _m_ApplyRootMotion = reader.ReadBool();
        bool _m_LinearVelocityBlending = reader.ReadBool();
        bool _m_StabilizeFeet = reader.ReadBool();
        reader.AlignTo(4); /* m_HasTransformHierarchy */
        bool _m_HasTransformHierarchy = reader.ReadBool();
        bool _m_AllowConstantClipSamplingOptimization = reader.ReadBool();
        bool _m_KeepAnimatorStateOnDisable = reader.ReadBool();
        bool _m_WriteDefaultValuesOnDisable = reader.ReadBool();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Avatar,
            _m_Controller,
            _m_CullingMode,
            _m_UpdateMode,
            _m_ApplyRootMotion,
            _m_LinearVelocityBlending,
            _m_StabilizeFeet,
            _m_HasTransformHierarchy,
            _m_AllowConstantClipSamplingOptimization,
            _m_KeepAnimatorStateOnDisable,
            _m_WriteDefaultValuesOnDisable);
    }
}

