namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Canvas (16 fields) Canvas 3FC45685A60F896CA8544543DEE25120 */
public record class Canvas (
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    int m_RenderMode,
    PPtr<Camera> m_Camera,
    float m_PlaneDistance,
    bool m_PixelPerfect,
    bool m_ReceivesEvents,
    bool m_OverrideSorting,
    bool m_OverridePixelPerfect,
    float m_SortingBucketNormalizedSize,
    bool m_VertexColorAlwaysGammaSpace,
    int m_AdditionalShaderChannelsFlag,
    int m_UpdateRectTransformForStandalone,
    int m_SortingLayerID,
    short m_SortingOrder,
    sbyte m_TargetDisplay) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.Canvas;
    public static Hash128 Hash => new("3FC45685A60F896CA8544543DEE25120");
    public static Canvas Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        int m_RenderMode_ = reader.ReadS32();
        PPtr<Camera> m_Camera_ = PPtr<Camera>.Read(reader);
        float m_PlaneDistance_ = reader.ReadF32();
        bool m_PixelPerfect_ = reader.ReadBool();
        bool m_ReceivesEvents_ = reader.ReadBool();
        bool m_OverrideSorting_ = reader.ReadBool();
        bool m_OverridePixelPerfect_ = reader.ReadBool();
        float m_SortingBucketNormalizedSize_ = reader.ReadF32();
        bool m_VertexColorAlwaysGammaSpace_ = reader.ReadBool();
        reader.AlignTo(4); /* m_VertexColorAlwaysGammaSpace */
        int m_AdditionalShaderChannelsFlag_ = reader.ReadS32();
        int m_UpdateRectTransformForStandalone_ = reader.ReadS32();
        reader.AlignTo(4); /* m_UpdateRectTransformForStandalone */
        int m_SortingLayerID_ = reader.ReadS32();
        short m_SortingOrder_ = reader.ReadS16();
        sbyte m_TargetDisplay_ = reader.ReadS8();
        
        return new(m_GameObject_,
            m_Enabled_,
            m_RenderMode_,
            m_Camera_,
            m_PlaneDistance_,
            m_PixelPerfect_,
            m_ReceivesEvents_,
            m_OverrideSorting_,
            m_OverridePixelPerfect_,
            m_SortingBucketNormalizedSize_,
            m_VertexColorAlwaysGammaSpace_,
            m_AdditionalShaderChannelsFlag_,
            m_UpdateRectTransformForStandalone_,
            m_SortingLayerID_,
            m_SortingOrder_,
            m_TargetDisplay_);
    }

    public override string ToString() => $"Canvas\n{ToString(4)}";

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
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);

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
        sb.AppendLine($"{indent_}m_RenderMode: {m_RenderMode}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Camera: {m_Camera}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PlaneDistance: {m_PlaneDistance}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PixelPerfect: {m_PixelPerfect}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ReceivesEvents: {m_ReceivesEvents}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_OverrideSorting: {m_OverrideSorting}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_OverridePixelPerfect: {m_OverridePixelPerfect}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SortingBucketNormalizedSize: {m_SortingBucketNormalizedSize}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_VertexColorAlwaysGammaSpace: {m_VertexColorAlwaysGammaSpace}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AdditionalShaderChannelsFlag: {m_AdditionalShaderChannelsFlag}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UpdateRectTransformForStandalone: {m_UpdateRectTransformForStandalone}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SortingLayerID: {m_SortingLayerID}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SortingOrder: {m_SortingOrder}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TargetDisplay: {m_TargetDisplay}");
    }
}

