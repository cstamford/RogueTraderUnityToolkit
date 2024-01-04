namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FxProjectileLauncher (9 fields) C4F03A9DB89177772B2C867EA955B816/6CB2633D8FECCB989E8B1D4983665B58 */
public record class FxProjectileLauncher(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    BlueprintProjectileReference Blueprint /* NeedsAlign */,
    byte m_InvertUpDirectionForTrajectories /* NeedsAlign */,
    PPtr<Transform> m_Start /* NeedsAlign */,
    PPtr<Transform> m_End /* None */,
    float m_Delay /* None */)
{
    public static FxProjectileLauncher Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Blueprint */
        BlueprintProjectileReference _Blueprint = BlueprintProjectileReference.Read(reader);
        reader.AlignTo(4); /* m_InvertUpDirectionForTrajectories */
        byte _m_InvertUpDirectionForTrajectories = reader.ReadU8();
        reader.AlignTo(4); /* m_Start */
        PPtr<Transform> _m_Start = PPtr<Transform>.Read(reader);
        PPtr<Transform> _m_End = PPtr<Transform>.Read(reader);
        float _m_Delay = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Blueprint,
            _m_InvertUpDirectionForTrajectories,
            _m_Start,
            _m_End,
            _m_Delay);
    }
}

