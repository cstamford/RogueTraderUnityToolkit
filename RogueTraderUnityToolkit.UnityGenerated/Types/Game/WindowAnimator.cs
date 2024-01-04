namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WindowAnimator (9 fields) 02116827148B05DB288596E5A5BCF814/FB5D49DBF808843862A4CFB58338771C */
public record class WindowAnimator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int Angle /* NeedsAlign */,
    float m_AppearTime /* None */,
    int m_AppearAnimCurve /* None */,
    float m_DisappearTime /* None */,
    int m_DisappearAnimCurve /* None */)
{
    public static WindowAnimator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Angle */
        int _Angle = reader.ReadS32();
        float _m_AppearTime = reader.ReadF32();
        int _m_AppearAnimCurve = reader.ReadS32();
        float _m_DisappearTime = reader.ReadF32();
        int _m_DisappearAnimCurve = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Angle,
            _m_AppearTime,
            _m_AppearAnimCurve,
            _m_DisappearTime,
            _m_DisappearAnimCurve);
    }
}

