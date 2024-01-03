namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $Canvas (16 fields) (IsEngineType) */
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
    sbyte m_TargetDisplay)
{
    public static Canvas Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        int m_RenderMode = reader.ReadS32();
        PPtr<Camera> m_Camera = PPtr<Camera>.Read(reader);
        float m_PlaneDistance = reader.ReadF32();
        bool m_PixelPerfect = reader.ReadBool();
        bool m_ReceivesEvents = reader.ReadBool();
        bool m_OverrideSorting = reader.ReadBool();
        bool m_OverridePixelPerfect = reader.ReadBool();
        float m_SortingBucketNormalizedSize = reader.ReadF32();
        bool m_VertexColorAlwaysGammaSpace = reader.ReadBool();
        int m_AdditionalShaderChannelsFlag = reader.ReadS32();
        int m_UpdateRectTransformForStandalone = reader.ReadS32();
        int m_SortingLayerID = reader.ReadS32();
        short m_SortingOrder = reader.ReadS16();
        sbyte m_TargetDisplay = reader.ReadS8();
        
        return new(m_GameObject,
            m_Enabled,
            m_RenderMode,
            m_Camera,
            m_PlaneDistance,
            m_PixelPerfect,
            m_ReceivesEvents,
            m_OverrideSorting,
            m_OverridePixelPerfect,
            m_SortingBucketNormalizedSize,
            m_VertexColorAlwaysGammaSpace,
            m_AdditionalShaderChannelsFlag,
            m_UpdateRectTransformForStandalone,
            m_SortingLayerID,
            m_SortingOrder,
            m_TargetDisplay);
    }
}

