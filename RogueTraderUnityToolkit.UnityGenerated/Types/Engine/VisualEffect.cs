namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $VisualEffect (9 fields) VisualEffect 511CF571F43A5F0DAF0E3962651E58EB */
public record class VisualEffect (
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    PPtr<VisualEffectAsset> m_Asset,
    AsciiString m_InitialEventName,
    byte m_InitialEventNameOverriden,
    uint m_StartSeed,
    byte m_ResetSeedOnPlay,
    byte m_AllowInstancing,
    VFXPropertySheetSerializedBase m_PropertySheet) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.VisualEffect;
    public static Hash128 Hash => new("511CF571F43A5F0DAF0E3962651E58EB");
    public static VisualEffect Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<VisualEffectAsset> m_Asset_ = PPtr<VisualEffectAsset>.Read(reader);
        AsciiString m_InitialEventName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InitialEventName */
        byte m_InitialEventNameOverriden_ = reader.ReadU8();
        reader.AlignTo(4); /* m_InitialEventNameOverriden */
        uint m_StartSeed_ = reader.ReadU32();
        byte m_ResetSeedOnPlay_ = reader.ReadU8();
        byte m_AllowInstancing_ = reader.ReadU8();
        reader.AlignTo(4); /* m_AllowInstancing */
        VFXPropertySheetSerializedBase m_PropertySheet_ = VFXPropertySheetSerializedBase.Read(reader);
        reader.AlignTo(4); /* m_PropertySheet */
        
        return new(m_GameObject_,
            m_Enabled_,
            m_Asset_,
            m_InitialEventName_,
            m_InitialEventNameOverriden_,
            m_StartSeed_,
            m_ResetSeedOnPlay_,
            m_AllowInstancing_,
            m_PropertySheet_);
    }

    public override string ToString() => $"VisualEffect\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_Asset: {m_Asset}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_InitialEventName: \"{m_InitialEventName}\"");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_InitialEventNameOverriden: {m_InitialEventNameOverriden}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StartSeed: {m_StartSeed}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ResetSeedOnPlay: {m_ResetSeedOnPlay}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AllowInstancing: {m_AllowInstancing}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PropertySheet: {{ \n{m_PropertySheet.ToString(indent+4)}{indent_}}}\n");
    }
}

