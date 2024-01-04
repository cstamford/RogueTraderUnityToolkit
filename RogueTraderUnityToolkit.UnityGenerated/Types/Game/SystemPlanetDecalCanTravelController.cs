namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemPlanetDecalCanTravelController (12 fields) 76CB069E4A9E1227A0BA1C0CDB0A7569/1D281929B378F398749C7B1C82EC1706 */
public record class SystemPlanetDecalCanTravelController(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SpriteRenderer> m_Decal /* NeedsAlign */,
    ColorRGBA m_SafePassageColor /* None */,
    ColorRGBA m_UnsafePassageColor /* None */,
    ColorRGBA m_DangerousPassageColor /* None */,
    ColorRGBA m_DeadlyPassageColor /* None */,
    float m_DurationRotate /* None */,
    float m_ScaleEndValue /* None */,
    float m_DurationScale /* None */)
{
    public static SystemPlanetDecalCanTravelController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Decal */
        PPtr<SpriteRenderer> _m_Decal = PPtr<SpriteRenderer>.Read(reader);
        ColorRGBA _m_SafePassageColor = ColorRGBA.Read(reader);
        ColorRGBA _m_UnsafePassageColor = ColorRGBA.Read(reader);
        ColorRGBA _m_DangerousPassageColor = ColorRGBA.Read(reader);
        ColorRGBA _m_DeadlyPassageColor = ColorRGBA.Read(reader);
        float _m_DurationRotate = reader.ReadF32();
        float _m_ScaleEndValue = reader.ReadF32();
        float _m_DurationScale = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Decal,
            _m_SafePassageColor,
            _m_UnsafePassageColor,
            _m_DangerousPassageColor,
            _m_DeadlyPassageColor,
            _m_DurationRotate,
            _m_ScaleEndValue,
            _m_DurationScale);
    }
}

