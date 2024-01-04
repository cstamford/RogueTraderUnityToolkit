namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipDecalConfig (10 fields) BA350AD9D76FE72BE63C0EA3E7A0C7C7/8C733EADBD093128852D38E1E9AA0CF7 */
public record class ShipDecalConfig(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ShieldDecalColorSet DefaultShieldColor /* NeedsAlign */,
    ShieldDecalColorSet HighlightHitShieldColor /* None */,
    ColorRGBA ReinforcedShieldColor /* None */,
    float MediumShieldCapacityThreshold /* None */,
    float LowShieldCapacityThreshold /* None */,
    float HitHighlightBlinkAlpha /* None */)
{
    public static ShipDecalConfig Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* DefaultShieldColor */
        ShieldDecalColorSet _DefaultShieldColor = ShieldDecalColorSet.Read(reader);
        ShieldDecalColorSet _HighlightHitShieldColor = ShieldDecalColorSet.Read(reader);
        ColorRGBA _ReinforcedShieldColor = ColorRGBA.Read(reader);
        float _MediumShieldCapacityThreshold = reader.ReadF32();
        float _LowShieldCapacityThreshold = reader.ReadF32();
        float _HitHighlightBlinkAlpha = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _DefaultShieldColor,
            _HighlightHitShieldColor,
            _ReinforcedShieldColor,
            _MediumShieldCapacityThreshold,
            _LowShieldCapacityThreshold,
            _HitHighlightBlinkAlpha);
    }
}

