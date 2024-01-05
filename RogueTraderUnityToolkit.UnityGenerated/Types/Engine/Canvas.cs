namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Canvas (16 fields) 3FC45685A60F896CA8544543DEE25120 */
public record class Canvas(
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
    public static Hash128 Hash => new(1069831813, 2786036076, 2824095043, 3739373856);

    public static Canvas Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        int _m_RenderMode = reader.ReadS32();
        PPtr<Camera> _m_Camera = PPtr<Camera>.Read(reader);
        float _m_PlaneDistance = reader.ReadF32();
        bool _m_PixelPerfect = reader.ReadBool();
        bool _m_ReceivesEvents = reader.ReadBool();
        bool _m_OverrideSorting = reader.ReadBool();
        bool _m_OverridePixelPerfect = reader.ReadBool();
        float _m_SortingBucketNormalizedSize = reader.ReadF32();
        bool _m_VertexColorAlwaysGammaSpace = reader.ReadBool();
        reader.AlignTo(4); /* m_VertexColorAlwaysGammaSpace */
        int _m_AdditionalShaderChannelsFlag = reader.ReadS32();
        int _m_UpdateRectTransformForStandalone = reader.ReadS32();
        reader.AlignTo(4); /* m_UpdateRectTransformForStandalone */
        int _m_SortingLayerID = reader.ReadS32();
        short _m_SortingOrder = reader.ReadS16();
        sbyte _m_TargetDisplay = reader.ReadS8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_RenderMode,
            _m_Camera,
            _m_PlaneDistance,
            _m_PixelPerfect,
            _m_ReceivesEvents,
            _m_OverrideSorting,
            _m_OverridePixelPerfect,
            _m_SortingBucketNormalizedSize,
            _m_VertexColorAlwaysGammaSpace,
            _m_AdditionalShaderChannelsFlag,
            _m_UpdateRectTransformForStandalone,
            _m_SortingLayerID,
            _m_SortingOrder,
            _m_TargetDisplay);
    }

    public override string ToString() => $"Canvas\n{ToString(4)}";

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
        sb.Append("m_RenderMode: ");
        sb.AppendLine(m_RenderMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Camera: ");
        sb.AppendLine(m_Camera.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PlaneDistance: ");
        sb.AppendLine(m_PlaneDistance.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PixelPerfect: ");
        sb.AppendLine(m_PixelPerfect.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ReceivesEvents: ");
        sb.AppendLine(m_ReceivesEvents.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_OverrideSorting: ");
        sb.AppendLine(m_OverrideSorting.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_OverridePixelPerfect: ");
        sb.AppendLine(m_OverridePixelPerfect.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SortingBucketNormalizedSize: ");
        sb.AppendLine(m_SortingBucketNormalizedSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_VertexColorAlwaysGammaSpace: ");
        sb.AppendLine(m_VertexColorAlwaysGammaSpace.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AdditionalShaderChannelsFlag: ");
        sb.AppendLine(m_AdditionalShaderChannelsFlag.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UpdateRectTransformForStandalone: ");
        sb.AppendLine(m_UpdateRectTransformForStandalone.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SortingLayerID: ");
        sb.AppendLine(m_SortingLayerID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SortingOrder: ");
        sb.AppendLine(m_SortingOrder.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TargetDisplay: ");
        sb.AppendLine(m_TargetDisplay.ToString());

        return sb.ToString();
    }
}

