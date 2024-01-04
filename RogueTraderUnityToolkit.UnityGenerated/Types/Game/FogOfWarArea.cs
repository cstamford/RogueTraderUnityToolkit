namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FogOfWarArea (12 fields) 2D7385ED186218E65380B4A6AE78BD58/11E683191508AD0EFA87D3CA186A35BF */
public record class FogOfWarArea(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AABB m_Bounds /* NeedsAlign */,
    float m_ShadowFalloff /* None */,
    byte m_IsBlurEnabled /* None */,
    BorderSettings m_BorderSettings /* NeedsAlign */,
    PPtr<Texture2D> m_StaticMask /* NeedsAlign */,
    byte m_RevealOnStart /* None */,
    byte m_SetActiveOnEnable /* NeedsAlign */,
    byte m_ApplyShaderManually /* NeedsAlign */)
{
    public static FogOfWarArea Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Bounds */
        AABB _m_Bounds = AABB.Read(reader);
        float _m_ShadowFalloff = reader.ReadF32();
        byte _m_IsBlurEnabled = reader.ReadU8();
        reader.AlignTo(4); /* m_BorderSettings */
        BorderSettings _m_BorderSettings = BorderSettings.Read(reader);
        reader.AlignTo(4); /* m_StaticMask */
        PPtr<Texture2D> _m_StaticMask = PPtr<Texture2D>.Read(reader);
        byte _m_RevealOnStart = reader.ReadU8();
        reader.AlignTo(4); /* m_SetActiveOnEnable */
        byte _m_SetActiveOnEnable = reader.ReadU8();
        reader.AlignTo(4); /* m_ApplyShaderManually */
        byte _m_ApplyShaderManually = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Bounds,
            _m_ShadowFalloff,
            _m_IsBlurEnabled,
            _m_BorderSettings,
            _m_StaticMask,
            _m_RevealOnStart,
            _m_SetActiveOnEnable,
            _m_ApplyShaderManually);
    }
}

