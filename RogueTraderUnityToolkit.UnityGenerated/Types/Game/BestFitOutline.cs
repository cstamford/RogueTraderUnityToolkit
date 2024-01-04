namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BestFitOutline (7 fields) 416915EA4857803DDCF2CEB7852C62B4/C60C07D895C84E11E166484A7C0F8740 */
public record class BestFitOutline(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColorRGBA m_EffectColor /* NeedsAlign */,
    Vector2f m_EffectDistance /* None */,
    byte m_UseGraphicAlpha /* None */)
{
    public static BestFitOutline Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_EffectColor */
        ColorRGBA _m_EffectColor = ColorRGBA.Read(reader);
        Vector2f _m_EffectDistance = Vector2f.Read(reader);
        byte _m_UseGraphicAlpha = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_EffectColor,
            _m_EffectDistance,
            _m_UseGraphicAlpha);
    }
}

