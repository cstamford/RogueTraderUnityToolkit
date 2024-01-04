namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WarpMoveEffect (15 fields) 56567D05B9E12C4F978904622D9B4DB7/B0A8EB69A7DEC2932C0347B3ED96D816 */
public record class WarpMoveEffect(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColorRGBA WarpEffectColorAndTransparent /* NeedsAlign */,
    Vector2f WarpEffectSpeed /* None */,
    float WarpEffectFadeOutSpeed /* None */,
    PPtr<GameObject> WarpPortalIn /* None */,
    PPtr<GameObject> WarpPortalOut /* None */,
    float ShakeAmplitude /* None */,
    float ShakeSpeed /* None */,
    PPtr<GameObject> LightPrefab1 /* None */,
    float RotateSpeed1 /* None */,
    PPtr<GameObject> LightPrefab2 /* None */,
    float RotateSpeed2 /* None */)
{
    public static WarpMoveEffect Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* WarpEffectColorAndTransparent */
        ColorRGBA _WarpEffectColorAndTransparent = ColorRGBA.Read(reader);
        Vector2f _WarpEffectSpeed = Vector2f.Read(reader);
        float _WarpEffectFadeOutSpeed = reader.ReadF32();
        PPtr<GameObject> _WarpPortalIn = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _WarpPortalOut = PPtr<GameObject>.Read(reader);
        float _ShakeAmplitude = reader.ReadF32();
        float _ShakeSpeed = reader.ReadF32();
        PPtr<GameObject> _LightPrefab1 = PPtr<GameObject>.Read(reader);
        float _RotateSpeed1 = reader.ReadF32();
        PPtr<GameObject> _LightPrefab2 = PPtr<GameObject>.Read(reader);
        float _RotateSpeed2 = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _WarpEffectColorAndTransparent,
            _WarpEffectSpeed,
            _WarpEffectFadeOutSpeed,
            _WarpPortalIn,
            _WarpPortalOut,
            _ShakeAmplitude,
            _ShakeSpeed,
            _LightPrefab1,
            _RotateSpeed1,
            _LightPrefab2,
            _RotateSpeed2);
    }
}

