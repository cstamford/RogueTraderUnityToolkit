namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $PlayableDirector (9 fields) PlayableDirector D200DB4E6F5FC6A9C3CDF5258063B81B */
public record class PlayableDirector (
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    PPtr<Object> m_PlayableAsset,
    int m_InitialState,
    int m_WrapMode,
    int m_DirectorUpdateMode,
    double m_InitialTime,
    DirectorGenericBinding[] m_SceneBindings,
    ExposedReferenceTable m_ExposedReferences) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.PlayableDirector;
    public static Hash128 Hash => new("D200DB4E6F5FC6A9C3CDF5258063B81B");
    public static PlayableDirector Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<Object> m_PlayableAsset_ = PPtr<Object>.Read(reader);
        int m_InitialState_ = reader.ReadS32();
        int m_WrapMode_ = reader.ReadS32();
        int m_DirectorUpdateMode_ = reader.ReadS32();
        double m_InitialTime_ = reader.ReadF64();
        DirectorGenericBinding[] m_SceneBindings_ = BuiltInArray<DirectorGenericBinding>.Read(reader);
        reader.AlignTo(4); /* m_SceneBindings */
        ExposedReferenceTable m_ExposedReferences_ = ExposedReferenceTable.Read(reader);
        reader.AlignTo(4); /* m_ExposedReferences */
        
        return new(m_GameObject_,
            m_Enabled_,
            m_PlayableAsset_,
            m_InitialState_,
            m_WrapMode_,
            m_DirectorUpdateMode_,
            m_InitialTime_,
            m_SceneBindings_,
            m_ExposedReferences_);
    }

    public override string ToString() => $"PlayableDirector\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_PlayableAsset: {m_PlayableAsset}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_InitialState: {m_InitialState}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WrapMode: {m_WrapMode}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DirectorUpdateMode: {m_DirectorUpdateMode}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_InitialTime: {m_InitialTime}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SceneBindings[{m_SceneBindings.Length}] = {{");
        if (m_SceneBindings.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (DirectorGenericBinding _4 in m_SceneBindings)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_SceneBindings.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ExposedReferences: {{ \n{m_ExposedReferences.ToString(indent+4)}{indent_}}}\n");
    }
}

