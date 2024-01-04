namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $LightingSettings (9 fields) 7C075EB768E56392C216AAFEF21A9FC1 */
public record class LightingSettings(
    AsciiString m_Name /* None */,
    int m_GIWorkflowMode /* NeedsAlign */,
    bool m_EnableBakedLightmaps /* None */,
    bool m_EnableRealtimeLightmaps /* None */,
    bool m_RealtimeEnvironmentLighting /* None */,
    float m_BounceScale /* NeedsAlign */,
    float m_AlbedoBoost /* None */,
    float m_IndirectOutputScale /* None */,
    bool m_UsingShadowmask /* None */) : IUnityObject
{
    public static Hash128 Hash => new(2080857783, 1759863698, 3256265470, 4061831105);
    public static LightingSettings Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_GIWorkflowMode */
        int _m_GIWorkflowMode = reader.ReadS32();
        bool _m_EnableBakedLightmaps = reader.ReadBool();
        bool _m_EnableRealtimeLightmaps = reader.ReadBool();
        bool _m_RealtimeEnvironmentLighting = reader.ReadBool();
        reader.AlignTo(4); /* m_BounceScale */
        float _m_BounceScale = reader.ReadF32();
        float _m_AlbedoBoost = reader.ReadF32();
        float _m_IndirectOutputScale = reader.ReadF32();
        bool _m_UsingShadowmask = reader.ReadBool();
        
        return new(_m_Name,
            _m_GIWorkflowMode,
            _m_EnableBakedLightmaps,
            _m_EnableRealtimeLightmaps,
            _m_RealtimeEnvironmentLighting,
            _m_BounceScale,
            _m_AlbedoBoost,
            _m_IndirectOutputScale,
            _m_UsingShadowmask);
    }
}

