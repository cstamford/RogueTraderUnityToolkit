namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $LODGroup (8 fields) LODGroup 222071680371689287B490B6347897EB */
public record class LODGroup (
    PPtr<GameObject> m_GameObject,
    Vector3f m_LocalReferencePoint,
    float m_Size,
    int m_FadeMode,
    bool m_AnimateCrossFading,
    bool m_LastLODIsBillboard,
    LOD[] m_LODs,
    bool m_Enabled) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.LODGroup;
    public static Hash128 Hash => new("222071680371689287B490B6347897EB");
    public static LODGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        Vector3f m_LocalReferencePoint_ = Vector3f.Read(reader);
        float m_Size_ = reader.ReadF32();
        int m_FadeMode_ = reader.ReadS32();
        bool m_AnimateCrossFading_ = reader.ReadBool();
        bool m_LastLODIsBillboard_ = reader.ReadBool();
        reader.AlignTo(4); /* m_LastLODIsBillboard */
        LOD[] m_LODs_ = BuiltInArray<LOD>.Read(reader);
        reader.AlignTo(4); /* m_LODs */
        bool m_Enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Enabled */
        
        return new(m_GameObject_,
            m_LocalReferencePoint_,
            m_Size_,
            m_FadeMode_,
            m_AnimateCrossFading_,
            m_LastLODIsBillboard_,
            m_LODs_,
            m_Enabled_);
    }

    public override string ToString() => $"LODGroup\n{ToString(4)}";

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

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GameObject: {m_GameObject}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LocalReferencePoint: {{ x: {m_LocalReferencePoint.x}, y: {m_LocalReferencePoint.y}, z: {m_LocalReferencePoint.z} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Size: {m_Size}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FadeMode: {m_FadeMode}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AnimateCrossFading: {m_AnimateCrossFading}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LastLODIsBillboard: {m_LastLODIsBillboard}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LODs[{m_LODs.Length}] = {{");
        if (m_LODs.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (LOD _4 in m_LODs)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_LODs.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }
}

