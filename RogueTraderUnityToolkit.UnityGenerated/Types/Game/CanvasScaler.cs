namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CanvasScaler (15 fields) 046B356AB00B5CC24BB2C10896F9B0F8/0F485B55C2A65BE76AB9372E3E42DFB0 */
public record class CanvasScaler(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int m_UiScaleMode /* NeedsAlign */,
    float m_ReferencePixelsPerUnit /* None */,
    float m_ScaleFactor /* None */,
    Vector2f m_ReferenceResolution /* None */,
    int m_ScreenMatchMode /* None */,
    float m_MatchWidthOrHeight /* None */,
    int m_PhysicalUnit /* None */,
    float m_FallbackScreenDPI /* None */,
    float m_DefaultSpriteDPI /* None */,
    float m_DynamicPixelsPerUnit /* None */,
    byte m_PresetInfoIsWorld /* None */)
{
    public static CanvasScaler Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UiScaleMode */
        int _m_UiScaleMode = reader.ReadS32();
        float _m_ReferencePixelsPerUnit = reader.ReadF32();
        float _m_ScaleFactor = reader.ReadF32();
        Vector2f _m_ReferenceResolution = Vector2f.Read(reader);
        int _m_ScreenMatchMode = reader.ReadS32();
        float _m_MatchWidthOrHeight = reader.ReadF32();
        int _m_PhysicalUnit = reader.ReadS32();
        float _m_FallbackScreenDPI = reader.ReadF32();
        float _m_DefaultSpriteDPI = reader.ReadF32();
        float _m_DynamicPixelsPerUnit = reader.ReadF32();
        byte _m_PresetInfoIsWorld = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UiScaleMode,
            _m_ReferencePixelsPerUnit,
            _m_ScaleFactor,
            _m_ReferenceResolution,
            _m_ScreenMatchMode,
            _m_MatchWidthOrHeight,
            _m_PhysicalUnit,
            _m_FallbackScreenDPI,
            _m_DefaultSpriteDPI,
            _m_DynamicPixelsPerUnit,
            _m_PresetInfoIsWorld);
    }
}

