namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Canvas (16 fields) 3FC45685A60F896CA8544543DEE25120 */
public record class Canvas(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    int m_RenderMode /* NeedsAlign */,
    PPtr<Camera> m_Camera /* None */,
    float m_PlaneDistance /* None */,
    bool m_PixelPerfect /* None */,
    bool m_ReceivesEvents /* None */,
    bool m_OverrideSorting /* None */,
    bool m_OverridePixelPerfect /* None */,
    float m_SortingBucketNormalizedSize /* None */,
    bool m_VertexColorAlwaysGammaSpace /* None */,
    int m_AdditionalShaderChannelsFlag /* NeedsAlign */,
    int m_UpdateRectTransformForStandalone /* None */,
    int m_SortingLayerID /* NeedsAlign */,
    short m_SortingOrder /* None */,
    sbyte m_TargetDisplay /* None */) : IUnityObject
{
    public static Hash128 Hash => new(1069831813, 2786036076, 2824095043, 3739373856);
    public static Canvas Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_RenderMode */
        int _m_RenderMode = reader.ReadS32();
        PPtr<Camera> _m_Camera = PPtr<Camera>.Read(reader);
        float _m_PlaneDistance = reader.ReadF32();
        bool _m_PixelPerfect = reader.ReadBool();
        bool _m_ReceivesEvents = reader.ReadBool();
        bool _m_OverrideSorting = reader.ReadBool();
        bool _m_OverridePixelPerfect = reader.ReadBool();
        float _m_SortingBucketNormalizedSize = reader.ReadF32();
        bool _m_VertexColorAlwaysGammaSpace = reader.ReadBool();
        reader.AlignTo(4); /* m_AdditionalShaderChannelsFlag */
        int _m_AdditionalShaderChannelsFlag = reader.ReadS32();
        int _m_UpdateRectTransformForStandalone = reader.ReadS32();
        reader.AlignTo(4); /* m_SortingLayerID */
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
}

