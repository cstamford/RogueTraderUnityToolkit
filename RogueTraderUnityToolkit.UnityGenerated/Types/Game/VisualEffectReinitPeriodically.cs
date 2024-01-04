namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VisualEffectReinitPeriodically (5 fields) 043969A82826DDED6B130F59D8715F42/7864BA6EDB7A3230CC05C2445A9EE37A */
public record class VisualEffectReinitPeriodically(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float m_TimeIntervalInSeconds /* NeedsAlign */)
{
    public static VisualEffectReinitPeriodically Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TimeIntervalInSeconds */
        float _m_TimeIntervalInSeconds = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TimeIntervalInSeconds);
    }
}

