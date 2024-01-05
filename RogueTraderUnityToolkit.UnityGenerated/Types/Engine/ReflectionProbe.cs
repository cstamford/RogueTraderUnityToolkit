namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $ReflectionProbe (25 fields) 63E8651709EB2F3D976DBC38841BB4DC */
public record class ReflectionProbe(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    int m_Type,
    int m_Mode,
    int m_RefreshMode,
    int m_TimeSlicingMode,
    int m_Resolution,
    int m_UpdateFrequency,
    Vector3f m_BoxSize,
    Vector3f m_BoxOffset,
    float m_NearClip,
    float m_FarClip,
    float m_ShadowDistance,
    uint m_ClearFlags,
    ColorRGBA_0 m_BackGroundColor,
    BitField m_CullingMask,
    float m_IntensityMultiplier,
    float m_BlendDistance,
    bool m_HDR,
    bool m_BoxProjection,
    bool m_RenderDynamicObjects,
    bool m_UseOcclusionCulling,
    short m_Importance,
    PPtr<Texture> m_CustomBakedTexture,
    PPtr<Texture> m_BakedTexture) : IUnityEngineStructure
{
    public static Hash128 Hash => new(1676174615, 166407997, 2540551224, 2216408284);

    public static ReflectionProbe Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        int _m_Type = reader.ReadS32();
        int _m_Mode = reader.ReadS32();
        int _m_RefreshMode = reader.ReadS32();
        int _m_TimeSlicingMode = reader.ReadS32();
        int _m_Resolution = reader.ReadS32();
        int _m_UpdateFrequency = reader.ReadS32();
        Vector3f _m_BoxSize = Vector3f.Read(reader);
        Vector3f _m_BoxOffset = Vector3f.Read(reader);
        float _m_NearClip = reader.ReadF32();
        float _m_FarClip = reader.ReadF32();
        float _m_ShadowDistance = reader.ReadF32();
        uint _m_ClearFlags = reader.ReadU32();
        ColorRGBA_0 _m_BackGroundColor = ColorRGBA_0.Read(reader);
        BitField _m_CullingMask = BitField.Read(reader);
        float _m_IntensityMultiplier = reader.ReadF32();
        float _m_BlendDistance = reader.ReadF32();
        bool _m_HDR = reader.ReadBool();
        bool _m_BoxProjection = reader.ReadBool();
        bool _m_RenderDynamicObjects = reader.ReadBool();
        bool _m_UseOcclusionCulling = reader.ReadBool();
        short _m_Importance = reader.ReadS16();
        reader.AlignTo(4); /* m_Importance */
        PPtr<Texture> _m_CustomBakedTexture = PPtr<Texture>.Read(reader);
        PPtr<Texture> _m_BakedTexture = PPtr<Texture>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Type,
            _m_Mode,
            _m_RefreshMode,
            _m_TimeSlicingMode,
            _m_Resolution,
            _m_UpdateFrequency,
            _m_BoxSize,
            _m_BoxOffset,
            _m_NearClip,
            _m_FarClip,
            _m_ShadowDistance,
            _m_ClearFlags,
            _m_BackGroundColor,
            _m_CullingMask,
            _m_IntensityMultiplier,
            _m_BlendDistance,
            _m_HDR,
            _m_BoxProjection,
            _m_RenderDynamicObjects,
            _m_UseOcclusionCulling,
            _m_Importance,
            _m_CustomBakedTexture,
            _m_BakedTexture);
    }

    public override string ToString() => $"ReflectionProbe\n{ToString(4)}";

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
        sb.Append("m_Type: ");
        sb.AppendLine(m_Type.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mode: ");
        sb.AppendLine(m_Mode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RefreshMode: ");
        sb.AppendLine(m_RefreshMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TimeSlicingMode: ");
        sb.AppendLine(m_TimeSlicingMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Resolution: ");
        sb.AppendLine(m_Resolution.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UpdateFrequency: ");
        sb.AppendLine(m_UpdateFrequency.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BoxSize: ");
        sb.AppendLine();
        sb.Append(m_BoxSize.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BoxOffset: ");
        sb.AppendLine();
        sb.Append(m_BoxOffset.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NearClip: ");
        sb.AppendLine(m_NearClip.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FarClip: ");
        sb.AppendLine(m_FarClip.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ShadowDistance: ");
        sb.AppendLine(m_ShadowDistance.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ClearFlags: ");
        sb.AppendLine(m_ClearFlags.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BackGroundColor: ");
        sb.AppendLine();
        sb.Append(m_BackGroundColor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CullingMask: ");
        sb.AppendLine();
        sb.Append(m_CullingMask.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IntensityMultiplier: ");
        sb.AppendLine(m_IntensityMultiplier.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BlendDistance: ");
        sb.AppendLine(m_BlendDistance.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HDR: ");
        sb.AppendLine(m_HDR.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BoxProjection: ");
        sb.AppendLine(m_BoxProjection.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RenderDynamicObjects: ");
        sb.AppendLine(m_RenderDynamicObjects.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UseOcclusionCulling: ");
        sb.AppendLine(m_UseOcclusionCulling.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Importance: ");
        sb.AppendLine(m_Importance.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CustomBakedTexture: ");
        sb.AppendLine(m_CustomBakedTexture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BakedTexture: ");
        sb.AppendLine(m_BakedTexture.ToString());

        return sb.ToString();
    }
}

