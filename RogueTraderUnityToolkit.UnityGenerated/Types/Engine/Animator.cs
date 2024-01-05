namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Animator (13 fields) 63C77A158D0E4404365B94D21CD949B0 */
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
    bool m_WriteDefaultValuesOnDisable) : IUnityEngineStructure
{
    public static Hash128 Hash => new(1674017301, 2366522372, 911971538, 484002224);

    public static Animator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<Avatar> _m_Avatar = PPtr<Avatar>.Read(reader);
        PPtr<RuntimeAnimatorController> _m_Controller = PPtr<RuntimeAnimatorController>.Read(reader);
        int _m_CullingMode = reader.ReadS32();
        int _m_UpdateMode = reader.ReadS32();
        bool _m_ApplyRootMotion = reader.ReadBool();
        bool _m_LinearVelocityBlending = reader.ReadBool();
        bool _m_StabilizeFeet = reader.ReadBool();
        reader.AlignTo(4); /* m_StabilizeFeet */
        bool _m_HasTransformHierarchy = reader.ReadBool();
        bool _m_AllowConstantClipSamplingOptimization = reader.ReadBool();
        bool _m_KeepAnimatorStateOnDisable = reader.ReadBool();
        bool _m_WriteDefaultValuesOnDisable = reader.ReadBool();
        reader.AlignTo(4); /* m_WriteDefaultValuesOnDisable */
        
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

    public override string ToString() => $"Animator\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Enabled: ");
        sb.AppendLine(m_Enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Avatar: ");
        sb.AppendLine(m_Avatar.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Controller: ");
        sb.AppendLine(m_Controller.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CullingMode: ");
        sb.AppendLine(m_CullingMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UpdateMode: ");
        sb.AppendLine(m_UpdateMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ApplyRootMotion: ");
        sb.AppendLine(m_ApplyRootMotion.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LinearVelocityBlending: ");
        sb.AppendLine(m_LinearVelocityBlending.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StabilizeFeet: ");
        sb.AppendLine(m_StabilizeFeet.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HasTransformHierarchy: ");
        sb.AppendLine(m_HasTransformHierarchy.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AllowConstantClipSamplingOptimization: ");
        sb.AppendLine(m_AllowConstantClipSamplingOptimization.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_KeepAnimatorStateOnDisable: ");
        sb.AppendLine(m_KeepAnimatorStateOnDisable.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_WriteDefaultValuesOnDisable: ");
        sb.AppendLine(m_WriteDefaultValuesOnDisable.ToString());

        return sb.ToString();
    }
}

