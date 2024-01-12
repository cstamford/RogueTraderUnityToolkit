namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Animator (13 fields) Animator 63C77A158D0E4404365B94D21CD949B0 */
public record class Animator (
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
    public static UnityObjectType ObjectType => UnityObjectType.Animator;
    public static Hash128 Hash => new("63C77A158D0E4404365B94D21CD949B0");
    public static Animator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<Avatar> m_Avatar_ = PPtr<Avatar>.Read(reader);
        PPtr<RuntimeAnimatorController> m_Controller_ = PPtr<RuntimeAnimatorController>.Read(reader);
        int m_CullingMode_ = reader.ReadS32();
        int m_UpdateMode_ = reader.ReadS32();
        bool m_ApplyRootMotion_ = reader.ReadBool();
        bool m_LinearVelocityBlending_ = reader.ReadBool();
        bool m_StabilizeFeet_ = reader.ReadBool();
        reader.AlignTo(4); /* m_StabilizeFeet */
        bool m_HasTransformHierarchy_ = reader.ReadBool();
        bool m_AllowConstantClipSamplingOptimization_ = reader.ReadBool();
        bool m_KeepAnimatorStateOnDisable_ = reader.ReadBool();
        bool m_WriteDefaultValuesOnDisable_ = reader.ReadBool();
        reader.AlignTo(4); /* m_WriteDefaultValuesOnDisable */
        
        return new(m_GameObject_,
            m_Enabled_,
            m_Avatar_,
            m_Controller_,
            m_CullingMode_,
            m_UpdateMode_,
            m_ApplyRootMotion_,
            m_LinearVelocityBlending_,
            m_StabilizeFeet_,
            m_HasTransformHierarchy_,
            m_AllowConstantClipSamplingOptimization_,
            m_KeepAnimatorStateOnDisable_,
            m_WriteDefaultValuesOnDisable_);
    }

    public override string ToString() => $"Animator\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GameObject: {m_GameObject}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Avatar: {m_Avatar}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Controller: {m_Controller}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CullingMode: {m_CullingMode}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UpdateMode: {m_UpdateMode}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ApplyRootMotion: {m_ApplyRootMotion}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LinearVelocityBlending: {m_LinearVelocityBlending}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StabilizeFeet: {m_StabilizeFeet}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HasTransformHierarchy: {m_HasTransformHierarchy}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AllowConstantClipSamplingOptimization: {m_AllowConstantClipSamplingOptimization}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_KeepAnimatorStateOnDisable: {m_KeepAnimatorStateOnDisable}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WriteDefaultValuesOnDisable: {m_WriteDefaultValuesOnDisable}");
    }
}

