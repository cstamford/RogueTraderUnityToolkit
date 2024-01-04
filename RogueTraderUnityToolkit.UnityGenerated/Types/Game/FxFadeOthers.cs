namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FxFadeOthers (7 fields) 5AD701EDDD1B04DE497DBDFFACB55613/F74EE396C7B65662E10F64E6166D7C25 */
public record class FxFadeOthers(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float m_OpacityDelay /* NeedsAlign */,
    float m_OpacityDuration /* None */,
    AnimationCurve m_OpacityCurve /* None */)
{
    public static FxFadeOthers Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_OpacityDelay */
        float _m_OpacityDelay = reader.ReadF32();
        float _m_OpacityDuration = reader.ReadF32();
        AnimationCurve _m_OpacityCurve = AnimationCurve.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_OpacityDelay,
            _m_OpacityDuration,
            _m_OpacityCurve);
    }
}

